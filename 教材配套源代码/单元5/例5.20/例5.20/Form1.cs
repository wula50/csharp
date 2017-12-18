using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void btnBold_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "你点击了加粗按钮";
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "你点击了斜体按钮";
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "你点击了下划线按钮";
        }
    }
}
