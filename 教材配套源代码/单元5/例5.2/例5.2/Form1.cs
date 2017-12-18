using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblMousePosition.Text = "当前鼠标的位置为：( " + e.X + " , " + e.Y + ")";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                lblButton.Text = "鼠标按键是：左键！";
            else if (e.Button == MouseButtons.Right)
                lblButton.Text = "鼠标按键是：右键！";
            else if (e.Button == MouseButtons.Middle)
                lblButton.Text = "鼠标按键是：中键！";

            lblButton.Text += ", 鼠标按键次数：" + e.Clicks;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lblKey.Text = "您所按的键是：" + e.KeyCode + "，" + e.Modifiers;
        }
     
    }
}
