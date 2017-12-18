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
    public partial class SetSizeForm : Form
    {
        public SetSizeForm()
        {
            InitializeComponent();
        }

        public int WidthValue
        {
            get { return Convert.ToInt32(numWidth.Value); }
            set { numWidth.Value = value; }
        }

        public int HeightValue
        {
            get { return Convert.ToInt32(numHeight.Value); }
            set { numHeight.Value = value; }
        }
    }
}
