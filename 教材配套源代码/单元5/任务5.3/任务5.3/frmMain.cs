using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class frmMain : Form
    {
        #region 字段定义

        public string fname = "";//当前文档的存盘路径
        public bool modified = false;//文档内容是否已经更改
        string fileDialogFilter = "文本文件|*.txt;*.cs;*.htm;*.html;*.vb|所有文件|*.*";

        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        //打开文件
        private void Open()
        {
            openFileDialog1.Title = "打开";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = this.fileDialogFilter;
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fname = openFileDialog1.FileName;
                rtb1.LoadFile(fname, RichTextBoxStreamType.PlainText);
                modified = false;
            }
        }

        //检查文件是否需要保存
        private DialogResult NeedSave()
        {
            DialogResult result = DialogResult.None;

            if (modified)
            {
                result = MessageBox.Show("是否保存数据", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    Save();
                }
            }

            return result;
        }

        //保存文件
        private void Save()
        {
            if (fname == "")
            {
                SaveAs();
            }
            else
            {
                rtb1.SaveFile(fname, RichTextBoxStreamType.PlainText);          
                modified = false;
            }
        }

        //另存文件
        private void SaveAs()
        {
            saveFileDialog1.Title = "另存为";
            this.saveFileDialog1.Filter = "文本文件|*.txt;";

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    rtb1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    fname = saveFileDialog1.FileName;
                    modified = false;
                }
            }
        }


        #region -- 窗体事件 --

        private void FormMain_Load(object sender, EventArgs e)
        {
            //用系统字体填充字体组合框
            cbxFontName.Items.Clear();

            foreach (FontFamily ff in FontFamily.Families)
            {
                //检查字体是否支持相应字体样式
                if (ff.IsStyleAvailable(FontStyle.Regular & FontStyle.Underline & FontStyle.Bold & FontStyle.Italic & FontStyle.Strikeout))
                {
                    cbxFontName.Items.Add(ff.Name);
                }
            }

            cbxFontName.Text = rtb1.Font.Name;
            // 填充字体大小组合框
            for (int i = 5; i <= 20; i++)
                cbxFontSize.Items.Add(i);

            for (int i = 22; i < 72; i += 2)
                cbxFontSize.Items.Add(i);

            //设置字体组合框和字体大小组合框的初值
            cbxFontName.Text = rtb1.Font.Name;
            cbxFontSize.Text = ((int)(rtb1.Font.Size)).ToString();

            MenuItemNew.PerformClick();
        }

        //窗体退出事件
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NeedSave() == DialogResult.Cancel)
                e.Cancel = true;
        }


        #endregion


        #region -- 文件菜单 --

        //新建文件
        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            if (NeedSave() != DialogResult.Cancel)
            {
                rtb1.ResetText();
                modified = false;
                fname = "";
            }
        }

        //打开文件
        private void MenuItemOpen_Click(object sender, EventArgs e)
        { 
            Open();
        }

        //保存文件
        private void MenuItemSave_Click(object sender, EventArgs e)
        { 
            Save();
        }

        //文件另存为
        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        { 
            SaveAs();
        }

        //退出
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        #endregion

        
        #region -- 编辑菜单 --
        //撤销
        private void MenuItemUndo_Click(object sender, EventArgs e)
        {
            rtb1.Undo();
        }

        //恢复
        private void MenuItemRedo_Click(object sender, EventArgs e)
        {
            rtb1.Redo();
        }

        //剪贴
        private void MenuItemCut_Click(object sender, EventArgs e)
        {
            rtb1.Cut();
        }

        //复制
        private void MenuItemCopy_Click(object sender, EventArgs e)
        {
            rtb1.Copy();
        }

        //粘贴
        private void MenuItemPaste_Click(object sender, EventArgs e)
        {
            rtb1.Paste();
        }

        //全选
        private void MenuItemSelectAll_Click(object sender, EventArgs e)
        {
            rtb1.SelectAll();
        }

        #endregion


        #region -- 格式菜单 --
        //自动换行
        private void MenuItemWordWrap_Click(object sender, EventArgs e)
        { 
            rtb1.WordWrap = MenuItemWordWrap.Checked; 
        }

        //字体设置
        private void MenuItemFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            { 
                rtb1.SelectionFont = fontDialog1.Font; 
            }
        }

        //背景颜色设置
        private void MenuItemBackColor_Click(object sender, EventArgs e)
        {
            //使用自定义颜色
            colorDialog1.AllowFullOpen = true;
            //显示基本颜色集中的可用的所有颜色
            colorDialog1.AnyColor = true;
            //打开自定义颜色控件
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtb1.BackColor = colorDialog1.Color;
            }
        }
        #endregion


        #region -- 帮助菜单 --


        #endregion


        #region -- 工具栏 --
        //“新建”按钮
        private void toolNew_Click(object sender, EventArgs e)
        {
            MenuItemNew_Click(null, null); 
        }

        //“打开”按钮
        private void toolOpen_Click(object sender, EventArgs e)
        { 
            MenuItemOpen.PerformClick(); 
        }

        //“保存”按钮
        private void toolSave_Click(object sender, EventArgs e)
        { 
            MenuItemSave_Click(sender, e);
        }
        
        private void toolCopy_Click(object sender, EventArgs e)
        {
            MenuItemCopy.PerformClick();
        }

        private void toolCut_Click(object sender, EventArgs e)
        {
            MenuItemCut.PerformClick();
        }

        private void toolPaste_Click(object sender, EventArgs e)
        {
            MenuItemPaste.PerformClick();
        }

        private void toolUndo_Click(object sender, EventArgs e)
        {
            MenuItemUndo.PerformClick();
        }

        private void toolRedo_Click(object sender, EventArgs e)
        {
            MenuItemRedo.PerformClick();
        }

        private void toolSlecletAll_Click(object sender, EventArgs e)
        {
            MenuItemSelectAll.PerformClick();
        }

        //“字形”设置
        private void cbxFontName_SelectedIndexChanged(object sender, EventArgs e)
            //字体样式选择
        {
            this.SetSelectionTextFont(cbxFontName.Text.Trim());
        }

        //“字号”设置
        private void cbxFontSize_SelectedIndexChanged(object sender, EventArgs e)
            //字体大小选择float.Parse(cbxFontSize.Text)
        {
            float size;

            if (float.TryParse(cbxFontSize.Text, out size))
            {
                if (size >= 5.0)
                    this.SetSelectionTextFont(size);
            }
        }

        //“粗体”按钮
        private void toolboldface_Click(object sender, EventArgs e)
        { 
            this.SetSelectionTextFont(FontStyle.Bold); 
        }

        //“斜体”按钮
        private void toolItalic_Click(object sender, EventArgs e)
        {
            this.SetSelectionTextFont(FontStyle.Italic); 
        }

        //“下划线”按钮
        private void toolUnderline_Click(object sender, EventArgs e)
        { 
            this.SetSelectionTextFont(FontStyle.Underline);
        }

        #endregion


        #region -- 文字格式处理相关方法 --       

        //重载SetSelectionTextFont()：设置RichTextBox的被选中文本的字体、大小和样式
        private void SetSelectionTextFont(RichTextBox rtb, string fontname, float fontsize, FontStyle fontstyle)
        {
            int currentPosition = rtb.SelectionStart;
            int length = rtb.SelectionLength;
            RichTextBox temp = new RichTextBox();

            temp.Rtf = rtb.SelectedRtf;

            for (int i = 0; i < length; i++)
            {
                temp.Select(i, 1);
                temp.SelectionFont = new Font(fontname == null || fontname == "" ? temp.SelectionFont.Name : fontname,
                    fontsize < 5 ? temp.SelectionFont.Size : fontsize, temp.SelectionFont.Style ^ fontstyle);
            }

            temp.Select(0, length);
            rtb.SelectedRtf = temp.SelectedRtf;

            rtb.SelectionStart = currentPosition;
            rtb.Select(currentPosition, length);
            rtb.Focus();
        }

        // 重载SetSelectionTextFont()：设置选中文本字体
        private void SetSelectionTextFont(string fontname)
        { 
            this.SetSelectionTextFont(rtb1, fontname, 0, FontStyle.Regular); 
        }

        //重载SetSelectionTextFont()：设置选中文本大小
        private void SetSelectionTextFont(float fontsize)
        {
            this.SetSelectionTextFont(rtb1, "", fontsize, FontStyle.Regular); 
        }

        //重载SetSelectionTextFont()：设置选中文本样式
        private void SetSelectionTextFont(FontStyle fontstyle)
        {
            this.SetSelectionTextFont(rtb1, "", 0, fontstyle);
        }


        #endregion


        #region -- 其它控件事件处理 --
        // rtb1文本改变事件处理
        private void rtb1_TextChanged(object sender, EventArgs e)
        {
            modified = true;
        }

        // rtb1的文本选择改变事件 
        private void rtb1_SelectionChanged(object sender, EventArgs e)
        {
            int lineNum = rtb1.GetLineFromCharIndex(rtb1.SelectionStart);
            int colNum = rtb1.SelectionStart - rtb1.GetFirstCharIndexFromLine(lineNum);

            try
            {
                msg1.Text = String.Format("行:{0},列:{1}", lineNum, colNum);
            }
            catch (Exception x)
            { 
                msg1.Text = x.Message;
            }

            if (rtb1.SelectionType == RichTextBoxSelectionTypes.Text)
            {
                cbxFontName.Text = rtb1.SelectionFont.Name;
                cbxFontSize.Text = rtb1.SelectionFont.Size.ToString();
            }
        }
        #endregion

        // 此属性让“查找”、“替换”等窗口类访问本窗口中富文本框中的文本
        public string TextContent
        {
            get { return rtb1.Text; }
            set { rtb1.Text = value; }
        }

        private void MenuItemFind_Click(object sender, EventArgs e)
        {
            frmFind f = new frmFind();
            f.Owner = this;
            f.Show();
        }

        private void MenuItemReplace_Click(object sender, EventArgs e)
        {
            frmReplace f = new frmReplace();
            f.Owner = this;
            f.Show();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().Show();
        }

        

    }//end of class Form1


}