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

namespace 例6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //使用构造函数创建文件流对象
            FileStream fs = new FileStream("temp.dat", FileMode.Create);

            //将基本类型转换成字节数组
            byte[] a = BitConverter.GetBytes(2012);

            //按照Unicode编码规则将字符串转换成数组
            byte[] b = Encoding.Unicode.GetBytes("C#程序设计");

            fs.Write(a, 0, a.Length);  //将字节数组写入文件
            fs.Write(b, 0, b.Length);

            fs.Close();//关闭文件流

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
            //使用File.OpenRead方法创建文件流对象
            FileStream fs = File.OpenRead("temp.dat");
            byte[] a = new byte[10];
            byte[] b = new byte[50];
            byte[] buff = new byte[50];

            // 使用文件流的Read方法将文件流中的所有字节读取到buff数组中
            for (int i = 0, temp = 0; (temp = fs.ReadByte()) != -1; i++)
            {
                buff[i] = (byte)temp;
            }

            //在文本框中显示读到的字节数据
            textBox1.AppendText(String.Format("文件包含{0}个字节的数据：\r\n", fs.Length));

            for (int i = 0; i < fs.Length; i++)
            {
                textBox1.AppendText(buff[i].ToString("X2") + " ");
            }

            textBox1.AppendText("\r\n");

            //前面的读取动作使得fs.Position指向了文件的末尾，现在将流的当前位置重置为文件的开头
            fs.Seek(0, SeekOrigin.Begin);

            //读取4个字节放入数组a，然后将数组a转换成整数
            fs.Read(a, 0, 4);

            textBox1.AppendText("读取到的整数：" + BitConverter.ToInt32(a, 0).ToString() + "\r\n");

            //读取剩余的字节放入数组b，将数组b转换成字符串
            fs.Read(b, 0, (int)(fs.Length - 4));

            textBox1.AppendText("读取到的字符串：" + Encoding.Unicode.GetString(b));
            textBox1.AppendText(Environment.NewLine);

            //输出数组b的二进制数组
            textBox1.AppendText("该字符串的二进制内容是：\r\n");

            for (int i = 0; i < fs.Length - 4; i++)
            {
                textBox1.AppendText(b[i].ToString("X2") + " ");
            }

            fs.Close();//关闭文件流
            File.Delete("temp.dat");//删除文件

        }
    }
}
