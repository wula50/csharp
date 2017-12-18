using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSizeForm f = new SetSizeForm();
            if (f.ShowDialog() == DialogResult.OK)
            { 
                textBox1.Text = "宽度：" + f.WidthValue + ",高度：" + f.HeightValue; 
            }
            f.Dispose();//释放窗体所占资源
        }
    }
}
