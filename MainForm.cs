using Reflection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Paint
{
    public partial class MainForm : Form
    {
        int i = 1;
        Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();
        public MainForm()
        {
            InitializeComponent();
            FindPlugins();
            CreateMenu();

            btnColor.BackColor = Color.Black;
        }

        #region Работа с файлами

        void FindPlugins()
        {
            // папка с плагинами
            string folder = System.AppDomain.CurrentDomain.BaseDirectory;

            // dll-файлы в этой папке
            string[] files = Directory.GetFiles(folder, "*.dll");

            foreach (string file in files)
                try
                {
                    Assembly assembly = Assembly.LoadFile(file);
                    foreach (Type type in assembly.GetTypes())
                    {
                        Type iface = type.GetInterface("PluginInterface.IPlugin");

                        if (iface != null)
                        {
                            IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                            plugins.Add(plugin.Name, plugin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки плагина\n" + ex.Message);
                }
        }

        void CreateMenu()
        {
            foreach (IPlugin plugin in plugins.Values)
            {
                var menuItem = new ToolStripMenuItem(plugin.Name);
                menuItem.Click += OnPluginClick;
                VersionAttribute MyAttribute = (VersionAttribute)Attribute.GetCustomAttribute(plugin.GetType(), typeof(VersionAttribute));
                menuItem.ToolTipText = $"Автор: {plugin.Author}\nВерсия: {MyAttribute.Major}.{MyAttribute.Minor}";
                фильтрыToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }

        private void OnPluginClick(object sender, EventArgs args)
        {
            IPlugin plugin = plugins[((ToolStripMenuItem)sender).Text];
            plugin.Transform((Bitmap)((ChildForm)ActiveMdiChild).Snapshot();
            ((ChildForm)ActiveMdiChild).drawPanel.Refresh();
        }
        private void ShowNewForm(object sender, EventArgs e) //Создание нового файла
        {
            var childForm = new ChildForm
            {
                MdiParent = this,
                Text = "Безымянный" + i,
                MaximizeBox = true
            };

            childForm.Show();
            childForm.SetColor(Color.Black);
            childForm.SetWidth(trackBar1.Value);
            i++;
        }

        private void OpenFile(object sender, EventArgs e) //Открытие файла
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Title = "Открытие файл",
                Filter = "Bitmap (*.bmp)|*bmp| JPEG (*.jpeg)|*jpeg| Все файлы (*.*)|(*.*)",
                AddExtension = true
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                var childForm = new ChildForm
                {
                    MdiParent = this,
                    Path = ofd.FileName,
                    Text = ofd.FileName,
                    MaximizeBox = true
                };

                childForm.Show();
                childForm.TempDraw = new Bitmap(Image.FromFile(ofd.FileName));
                childForm.Snapshot = childForm.TempDraw;
                childForm.SetColor(btnColor.BackColor);
                childForm.SetWidth(trackBar1.Value);

                childForm.drawPanel.Invalidate();
                childForm.drawPanel.Refresh();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка сохранить
        {
            if (!(ActiveMdiChild is ChildForm child))
                return;

            if (child.Path != null)
                child.SaveImage(child.Path);
            else
                SaveAsToolStripMenuItem_Click(sender, e);
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка сохранить как
        {
            if (!(ActiveMdiChild is ChildForm child))
                return;

            var sfd = new SaveFileDialog
            {
                Title = "Сохранение изображения",
                Filter = "Bitmap (*.bmp)|*bmp",
                AddExtension = true,
                DefaultExt = ".bmp"
            };

            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                child.Path = sfd.FileName;
                child.SaveImage(child.Path);
                child.Text = sfd.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) //Кнопка выхода
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) //Каскад
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) //По вертикали
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) //По горизонтали
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) //Упорядочить
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) //Закрытие формы
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #endregion

        #region Эффекты

        private void контурToolStripMenuItem_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetEffects.Circuit();

        private void усилениеРезкостиToolStripMenuItem_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetEffects.Sharpness();

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetEffects.Blur();

        private void резкиеКраяToolStripMenuItem_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetEffects.SharpEdges();

        private void повернутьВлевоToolStripMenuItem_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetEffects.RotateLeft();

        private void повернутьВправоToolStripMenuItem_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetEffects.RotateRight();

        private void отразитьПоГоризонталиToolStripMenuItem_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetEffects.MirrorX();

        private void отразитьПоВертикалиToolStripMenuItem_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetEffects.MirrorY();

        #endregion

        #region Элементы рисования

        private void btnPencil_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetTool(ChildForm.Tool.Pencil);

        private void btnEllipse_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetTool(ChildForm.Tool.Ellipse);

        private void btnLine_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetTool(ChildForm.Tool.Line);

        private void btnStar_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetTool(ChildForm.Tool.Star);

        private void btnEraser_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetTool(ChildForm.Tool.Eraser);

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                (ActiveMdiChild as ChildForm)?.SetColor(colorDialog.Color);
                btnColor.BackColor = colorDialog.Color;
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.drawPanel_MouseWheel(this, new MouseEventArgs(MouseButtons.None, 0, 0, 0, 1));

        private void btnZoomOut_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.drawPanel_MouseWheel(this, new MouseEventArgs(MouseButtons.None, 0, 0, 0, -1));

        private void trackBar1_Scroll(object sender, EventArgs e) =>
            (ActiveMdiChild as ChildForm)?.SetWidth(trackBar1.Value);

        #endregion

        private void изменитьРазмерХолстаToolStripMenuItem_Click(object sender, EventArgs e)
        {

                SizeSet ss = new SizeSet();

                

                if (ss.ShowDialog() == DialogResult.OK)

                {

                     ActiveMdiChild.Width = ss.width1;

                     ActiveMdiChild.Height = ss.height;

                }

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void фильтрыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
