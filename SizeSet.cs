using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Paint
{
    public partial class SizeSet : Form
    {
        public SizeSet()
        {
            InitializeComponent();
        }

        public int width1 = 300;

        public int height = 200;

        private void SizeSet_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

                width1 = Convert.ToInt32(length.Value);
                height = Convert.ToInt32(width.Value);
            ActiveForm.Close();
        }
    }
}
