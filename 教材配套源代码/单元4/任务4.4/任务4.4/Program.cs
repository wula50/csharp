using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 任务4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Poem po = new Poem();
            Console.WriteLine("重新排版后的诗词：");
            Console.WriteLine(po.ChangePoem());
            Console.ReadKey();
        }
    }

    class Poem
    {
        string poem = "怒发冲冠,凭阑处,潇潇雨歇.抬望眼,仰天长啸,壮同激烈.三十功名尘与土,八千里路云和月.莫等闲,白了少年头,空悲切.靖康耻,犹未雪;臣子憾,何时灭.驾长车踏破,贺兰山缺.壮志饥餐胡虏肉,笑谈渴饮匈奴血.待从头,收拾旧山河,朝天阙.";

        public StringBuilder ChangePoem()
        {
            StringBuilder sb = new StringBuilder(poem);
            string s = sb.ToString();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '.' || s[i] == ';')
                    sb.Insert(i + 1, "\n");
            }
            sb.Insert(0, "满江红\n");
            sb.Replace(',', '，');
            sb.Replace('.', '。');

            return sb;
        }

    }

}
