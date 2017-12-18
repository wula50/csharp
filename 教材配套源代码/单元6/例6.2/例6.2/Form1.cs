using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //使用构造函数创建SteamWriter对象
            FileStream fs = new FileStream("temp.dat", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(2012);
            sw.WriteLine("程序设计");

            sw.Close();//关闭sw对象和基础流fs对象。   

            textBox1.AppendText("文件创建成功！\r\n\r\n");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //判断文件是否存在
            if (!File.Exists("temp.dat"))
            {
                MessageBox.Show("文件不存在，请先创建文件");
                return;
            }

            //使用File类创建StreamReader对象
            StreamReader sr = File.OpenText("temp.dat");
            string str = "";

            while ((str = sr.ReadLine()) != null)
            {
                textBox1.AppendText(str);//读取一行文本
                textBox1.AppendText(Environment.NewLine);
            }

            textBox1.AppendText("文件共有" + sr.BaseStream.Length + "个字节");//包括回车符和换行

            sr.Close();
        }
    }
}
