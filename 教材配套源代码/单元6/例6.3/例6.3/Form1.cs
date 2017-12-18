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

namespace 例6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //使用构造函数创建BinaryWriter对象
            FileStream fs = new FileStream("temp.dat", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(2012);
            bw.Write("程序设计");

            bw.Close();//关闭bw对象和基础流fs对象。   

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
            BinaryReader br = new BinaryReader(File.OpenRead("temp.dat"));

            textBox1.AppendText(br.ReadInt32().ToString());//读取整数
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(br.ReadString());//字符串
            textBox1.AppendText(Environment.NewLine);

            textBox1.AppendText("文件共有" + br.BaseStream.Length + "个字节");

            br.Close();
        }
    }
}
