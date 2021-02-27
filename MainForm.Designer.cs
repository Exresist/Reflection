namespace Lab2_Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.усилениеРезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкиеКраяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутьВлевоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутьВправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отразитьПоГоризонталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отразитьПоВертикалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьРазмерХолстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnStar = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.эффектыToolStripMenuItem,
            this.windowsMenu,
            this.изменитьРазмерХолстаToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1260, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(69, 29);
            this.fileMenu.Text = "&Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newToolStripMenuItem.Text = "&Создать";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.openToolStripMenuItem.Text = "&Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.saveToolStripMenuItem.Text = "&Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.saveAsToolStripMenuItem.Text = "Сохранить &как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(258, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.exitToolStripMenuItem.Text = "В&ыход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // эффектыToolStripMenuItem
            // 
            this.эффектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контурToolStripMenuItem,
            this.усилениеРезкостиToolStripMenuItem,
            this.размытиеToolStripMenuItem,
            this.резкиеКраяToolStripMenuItem,
            this.повернутьВлевоToolStripMenuItem,
            this.повернутьВправоToolStripMenuItem,
            this.отразитьПоГоризонталиToolStripMenuItem,
            this.отразитьПоВертикалиToolStripMenuItem});
            this.эффектыToolStripMenuItem.Name = "эффектыToolStripMenuItem";
            this.эффектыToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.эффектыToolStripMenuItem.Text = "Рисунок";
            // 
            // контурToolStripMenuItem
            // 
            this.контурToolStripMenuItem.Name = "контурToolStripMenuItem";
            this.контурToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.контурToolStripMenuItem.Text = "Контур";
            this.контурToolStripMenuItem.Click += new System.EventHandler(this.контурToolStripMenuItem_Click);
            // 
            // усилениеРезкостиToolStripMenuItem
            // 
            this.усилениеРезкостиToolStripMenuItem.Name = "усилениеРезкостиToolStripMenuItem";
            this.усилениеРезкостиToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.усилениеРезкостиToolStripMenuItem.Text = "Усиление резкости";
            this.усилениеРезкостиToolStripMenuItem.Click += new System.EventHandler(this.усилениеРезкостиToolStripMenuItem_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // резкиеКраяToolStripMenuItem
            // 
            this.резкиеКраяToolStripMenuItem.Name = "резкиеКраяToolStripMenuItem";
            this.резкиеКраяToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.резкиеКраяToolStripMenuItem.Text = "Резкие края";
            this.резкиеКраяToolStripMenuItem.Click += new System.EventHandler(this.резкиеКраяToolStripMenuItem_Click);
            // 
            // повернутьВлевоToolStripMenuItem
            // 
            this.повернутьВлевоToolStripMenuItem.Name = "повернутьВлевоToolStripMenuItem";
            this.повернутьВлевоToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.повернутьВлевоToolStripMenuItem.Text = "Повернуть влево";
            this.повернутьВлевоToolStripMenuItem.Click += new System.EventHandler(this.повернутьВлевоToolStripMenuItem_Click);
            // 
            // повернутьВправоToolStripMenuItem
            // 
            this.повернутьВправоToolStripMenuItem.Name = "повернутьВправоToolStripMenuItem";
            this.повернутьВправоToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.повернутьВправоToolStripMenuItem.Text = "Повернуть вправо";
            this.повернутьВправоToolStripMenuItem.Click += new System.EventHandler(this.повернутьВправоToolStripMenuItem_Click);
            // 
            // отразитьПоГоризонталиToolStripMenuItem
            // 
            this.отразитьПоГоризонталиToolStripMenuItem.Name = "отразитьПоГоризонталиToolStripMenuItem";
            this.отразитьПоГоризонталиToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.отразитьПоГоризонталиToolStripMenuItem.Text = "Отразить по горизонтали";
            this.отразитьПоГоризонталиToolStripMenuItem.Click += new System.EventHandler(this.отразитьПоГоризонталиToolStripMenuItem_Click);
            // 
            // отразитьПоВертикалиToolStripMenuItem
            // 
            this.отразитьПоВертикалиToolStripMenuItem.Name = "отразитьПоВертикалиToolStripMenuItem";
            this.отразитьПоВертикалиToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.отразитьПоВертикалиToolStripMenuItem.Text = "Отразить по вертикали";
            this.отразитьПоВертикалиToolStripMenuItem.Click += new System.EventHandler(this.отразитьПоВертикалиToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(70, 29);
            this.windowsMenu.Text = "&Окна";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.newWindowToolStripMenuItem.Text = "&Новое окно";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.cascadeToolStripMenuItem.Text = "&Каскадом";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.tileVerticalToolStripMenuItem.Text = "С&лева направо";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.tileHorizontalToolStripMenuItem.Text = "С&верху вниз";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.closeAllToolStripMenuItem.Text = "&Закрыть все";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.arrangeIconsToolStripMenuItem.Text = "&Упорядочить значки";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // изменитьРазмерХолстаToolStripMenuItem
            // 
            this.изменитьРазмерХолстаToolStripMenuItem.Name = "изменитьРазмерХолстаToolStripMenuItem";
            this.изменитьРазмерХолстаToolStripMenuItem.Size = new System.Drawing.Size(230, 29);
            this.изменитьРазмерХолстаToolStripMenuItem.Text = "Изменить размер холста";
            this.изменитьРазмерХолстаToolStripMenuItem.Click += new System.EventHandler(this.изменитьРазмерХолстаToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 636);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1260, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(98, 25);
            this.toolStripStatusLabel.Text = "Состояние";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnZoomOut, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnZoomIn, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnColor, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnEraser, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnStar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLine, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEllipse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPencil, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07763F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.689467F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(112, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomOut.Location = new System.Drawing.Point(3, 509);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(106, 40);
            this.btnZoomOut.TabIndex = 8;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomIn.Location = new System.Drawing.Point(3, 463);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(106, 40);
            this.btnZoomIn.TabIndex = 7;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnColor
            // 
            this.btnColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColor.Location = new System.Drawing.Point(3, 233);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(106, 40);
            this.btnColor.TabIndex = 5;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEraser.Location = new System.Drawing.Point(3, 187);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(106, 40);
            this.btnEraser.TabIndex = 4;
            this.btnEraser.Text = "Ластик";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnStar
            // 
            this.btnStar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStar.Location = new System.Drawing.Point(3, 141);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(106, 40);
            this.btnStar.TabIndex = 3;
            this.btnStar.Text = "Звезда";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnLine
            // 
            this.btnLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLine.Location = new System.Drawing.Point(3, 95);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(106, 40);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEllipse.Location = new System.Drawing.Point(3, 49);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(106, 40);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPencil.Location = new System.Drawing.Point(3, 3);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(106, 40);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.Text = "Карандаш";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(3, 325);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(106, 132);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            this.фильтрыToolStripMenuItem.Click += new System.EventHandler(this.фильтрыToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 668);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Китайский пейнт";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem эффектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem усилениеРезкостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкиеКраяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьВлевоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьВправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отразитьПоГоризонталиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отразитьПоВертикалиToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        public System.Windows.Forms.Button btnColor;
        public System.Windows.Forms.Button btnPencil;
        public System.Windows.Forms.Button btnEllipse;
        public System.Windows.Forms.Button btnLine;
        public System.Windows.Forms.Button btnEraser;
        public System.Windows.Forms.Button btnStar;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem изменитьРазмерХолстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
    }
}



