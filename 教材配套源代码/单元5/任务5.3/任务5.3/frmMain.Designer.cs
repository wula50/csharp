namespace MyNotepad
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSavaAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNew = new System.Windows.Forms.ToolStripButton();
            this.toolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCopy = new System.Windows.Forms.ToolStripButton();
            this.toolCut = new System.Windows.Forms.ToolStripButton();
            this.toolPaste = new System.Windows.Forms.ToolStripButton();
            this.toolUndo = new System.Windows.Forms.ToolStripButton();
            this.toolRedo = new System.Windows.Forms.ToolStripButton();
            this.toolSlecletAll = new System.Windows.Forms.ToolStripButton();
            this.cbxFontName = new System.Windows.Forms.ToolStripComboBox();
            this.cbxFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolboldface = new System.Windows.Forms.ToolStripButton();
            this.toolItalic = new System.Windows.Forms.ToolStripButton();
            this.toolUnderline = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.msg1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dfToolStripMenuItem
            // 
            this.dfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNew,
            this.MenuItemOpen,
            this.toolStripMenuItem1,
            this.MenuItemSave,
            this.MenuItemSavaAs,
            this.toolStripMenuItem4,
            this.MenuItemExit});
            this.dfToolStripMenuItem.Name = "dfToolStripMenuItem";
            this.dfToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.dfToolStripMenuItem.Text = "文件(&F)";
            // 
            // MenuItemNew
            // 
            this.MenuItemNew.Image = global::MyNotepad.Properties.Resources.filenew;
            this.MenuItemNew.Name = "MenuItemNew";
            this.MenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemNew.Size = new System.Drawing.Size(165, 22);
            this.MenuItemNew.Text = "新建(&N)";
            this.MenuItemNew.Click += new System.EventHandler(this.MenuItemNew_Click);
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Image = global::MyNotepad.Properties.Resources.fileopen;
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemOpen.Size = new System.Drawing.Size(165, 22);
            this.MenuItemOpen.Text = "打开(&O)";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Image = global::MyNotepad.Properties.Resources.filesave;
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemSave.Size = new System.Drawing.Size(165, 22);
            this.MenuItemSave.Text = "保存(&S)";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // MenuItemSavaAs
            // 
            this.MenuItemSavaAs.Image = global::MyNotepad.Properties.Resources.filesaveas;
            this.MenuItemSavaAs.Name = "MenuItemSavaAs";
            this.MenuItemSavaAs.Size = new System.Drawing.Size(165, 22);
            this.MenuItemSavaAs.Text = "另存为(&A)";
            this.MenuItemSavaAs.Click += new System.EventHandler(this.MenuItemSaveAs_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(162, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(165, 22);
            this.MenuItemExit.Text = "退出(&X)";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUndo,
            this.MenuItemRedo,
            this.toolStripMenuItem6,
            this.MenuItemCut,
            this.MenuItemCopy,
            this.MenuItemPaste,
            this.toolStripMenuItem7,
            this.MenuItemSelectAll,
            this.toolStripMenuItem8,
            this.MenuItemFind,
            this.MenuItemReplace});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // MenuItemUndo
            // 
            this.MenuItemUndo.Image = global::MyNotepad.Properties.Resources.undo;
            this.MenuItemUndo.Name = "MenuItemUndo";
            this.MenuItemUndo.Size = new System.Drawing.Size(177, 22);
            this.MenuItemUndo.Text = "撤消(&U)　　Ctrl+Z";
            this.MenuItemUndo.Click += new System.EventHandler(this.MenuItemUndo_Click);
            // 
            // MenuItemRedo
            // 
            this.MenuItemRedo.Image = global::MyNotepad.Properties.Resources.redo;
            this.MenuItemRedo.Name = "MenuItemRedo";
            this.MenuItemRedo.Size = new System.Drawing.Size(177, 22);
            this.MenuItemRedo.Text = "重复(&R)　　Ctrl+Y";
            this.MenuItemRedo.Click += new System.EventHandler(this.MenuItemRedo_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(174, 6);
            // 
            // MenuItemCut
            // 
            this.MenuItemCut.Image = global::MyNotepad.Properties.Resources.editcut;
            this.MenuItemCut.Name = "MenuItemCut";
            this.MenuItemCut.Size = new System.Drawing.Size(177, 22);
            this.MenuItemCut.Text = "剪切(&T)　　Ctrl+X";
            this.MenuItemCut.Click += new System.EventHandler(this.MenuItemCut_Click);
            // 
            // MenuItemCopy
            // 
            this.MenuItemCopy.Image = global::MyNotepad.Properties.Resources.editcopy;
            this.MenuItemCopy.Name = "MenuItemCopy";
            this.MenuItemCopy.Size = new System.Drawing.Size(177, 22);
            this.MenuItemCopy.Text = "复制(&C)　　Ctrl+C";
            this.MenuItemCopy.Click += new System.EventHandler(this.MenuItemCopy_Click);
            // 
            // MenuItemPaste
            // 
            this.MenuItemPaste.Image = global::MyNotepad.Properties.Resources.editpaste;
            this.MenuItemPaste.Name = "MenuItemPaste";
            this.MenuItemPaste.Size = new System.Drawing.Size(177, 22);
            this.MenuItemPaste.Text = "粘贴(&P)　　Ctrl+V";
            this.MenuItemPaste.Click += new System.EventHandler(this.MenuItemPaste_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(174, 6);
            // 
            // MenuItemSelectAll
            // 
            this.MenuItemSelectAll.Name = "MenuItemSelectAll";
            this.MenuItemSelectAll.Size = new System.Drawing.Size(177, 22);
            this.MenuItemSelectAll.Text = "全选(&A)　　Ctrl+A";
            this.MenuItemSelectAll.Click += new System.EventHandler(this.MenuItemSelectAll_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(174, 6);
            // 
            // MenuItemFind
            // 
            this.MenuItemFind.Image = global::MyNotepad.Properties.Resources.find;
            this.MenuItemFind.Name = "MenuItemFind";
            this.MenuItemFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MenuItemFind.Size = new System.Drawing.Size(177, 22);
            this.MenuItemFind.Text = "查找(&F)";
            this.MenuItemFind.Click += new System.EventHandler(this.MenuItemFind_Click);
            // 
            // MenuItemReplace
            // 
            this.MenuItemReplace.Name = "MenuItemReplace";
            this.MenuItemReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.MenuItemReplace.Size = new System.Drawing.Size(177, 22);
            this.MenuItemReplace.Text = "替换(&H)";
            this.MenuItemReplace.Click += new System.EventHandler(this.MenuItemReplace_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemWordWrap,
            this.toolStripMenuItem9,
            this.MenuItemFont,
            this.MenuItemBackColor});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.格式ToolStripMenuItem.Text = "格式(&O)";
            // 
            // MenuItemWordWrap
            // 
            this.MenuItemWordWrap.CheckOnClick = true;
            this.MenuItemWordWrap.Name = "MenuItemWordWrap";
            this.MenuItemWordWrap.Size = new System.Drawing.Size(152, 22);
            this.MenuItemWordWrap.Text = "自动换行(&W)";
            this.MenuItemWordWrap.Click += new System.EventHandler(this.MenuItemWordWrap_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItemFont
            // 
            this.MenuItemFont.Image = global::MyNotepad.Properties.Resources.fonts;
            this.MenuItemFont.Name = "MenuItemFont";
            this.MenuItemFont.Size = new System.Drawing.Size(152, 22);
            this.MenuItemFont.Text = "字体(&F)";
            this.MenuItemFont.Click += new System.EventHandler(this.MenuItemFont_Click);
            // 
            // MenuItemBackColor
            // 
            this.MenuItemBackColor.Image = global::MyNotepad.Properties.Resources.colorize;
            this.MenuItemBackColor.Name = "MenuItemBackColor";
            this.MenuItemBackColor.Size = new System.Drawing.Size(152, 22);
            this.MenuItemBackColor.Text = "背景颜色(&C)";
            this.MenuItemBackColor.Click += new System.EventHandler(this.MenuItemBackColor_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Checked = true;
            this.MenuItemAbout.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.MenuItemAbout.Image = global::MyNotepad.Properties.Resources.help;
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(152, 22);
            this.MenuItemAbout.Text = "关于(&A)...";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNew,
            this.toolOpen,
            this.toolSave,
            this.toolCopy,
            this.toolCut,
            this.toolPaste,
            this.toolUndo,
            this.toolRedo,
            this.toolSlecletAll,
            this.cbxFontName,
            this.cbxFontSize,
            this.toolboldface,
            this.toolItalic,
            this.toolUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(612, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolNew
            // 
            this.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNew.Image = global::MyNotepad.Properties.Resources.filenew;
            this.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNew.Name = "toolNew";
            this.toolNew.Size = new System.Drawing.Size(23, 22);
            this.toolNew.Text = "新建";
            this.toolNew.Click += new System.EventHandler(this.toolNew_Click);
            // 
            // toolOpen
            // 
            this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpen.Image = global::MyNotepad.Properties.Resources.fileopen;
            this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(23, 22);
            this.toolOpen.Text = "打开";
            this.toolOpen.Click += new System.EventHandler(this.toolOpen_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = global::MyNotepad.Properties.Resources.filesave;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(23, 22);
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCopy
            // 
            this.toolCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCopy.Image = global::MyNotepad.Properties.Resources.editcopy;
            this.toolCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCopy.Name = "toolCopy";
            this.toolCopy.Size = new System.Drawing.Size(23, 22);
            this.toolCopy.Text = "复制";
            this.toolCopy.Click += new System.EventHandler(this.toolCopy_Click);
            // 
            // toolCut
            // 
            this.toolCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCut.Image = global::MyNotepad.Properties.Resources.editcut;
            this.toolCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCut.Name = "toolCut";
            this.toolCut.Size = new System.Drawing.Size(23, 22);
            this.toolCut.Text = "剪切";
            this.toolCut.Click += new System.EventHandler(this.toolCut_Click);
            // 
            // toolPaste
            // 
            this.toolPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPaste.Image = global::MyNotepad.Properties.Resources.editpaste;
            this.toolPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPaste.Name = "toolPaste";
            this.toolPaste.Size = new System.Drawing.Size(23, 22);
            this.toolPaste.Text = "粘贴";
            this.toolPaste.Click += new System.EventHandler(this.toolPaste_Click);
            // 
            // toolUndo
            // 
            this.toolUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUndo.Image = global::MyNotepad.Properties.Resources.undo;
            this.toolUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUndo.Name = "toolUndo";
            this.toolUndo.Size = new System.Drawing.Size(23, 22);
            this.toolUndo.Text = "撤销";
            this.toolUndo.Click += new System.EventHandler(this.toolUndo_Click);
            // 
            // toolRedo
            // 
            this.toolRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRedo.Image = global::MyNotepad.Properties.Resources.redo;
            this.toolRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRedo.Name = "toolRedo";
            this.toolRedo.Size = new System.Drawing.Size(23, 22);
            this.toolRedo.Text = "重做";
            this.toolRedo.Click += new System.EventHandler(this.toolRedo_Click);
            // 
            // toolSlecletAll
            // 
            this.toolSlecletAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSlecletAll.Image = ((System.Drawing.Image)(resources.GetObject("toolSlecletAll.Image")));
            this.toolSlecletAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSlecletAll.Name = "toolSlecletAll";
            this.toolSlecletAll.Size = new System.Drawing.Size(36, 22);
            this.toolSlecletAll.Text = "全选";
            this.toolSlecletAll.Click += new System.EventHandler(this.toolSlecletAll_Click);
            // 
            // cbxFontName
            // 
            this.cbxFontName.Items.AddRange(new object[] {
            "宋体",
            "楷体",
            "仿宋",
            "黑体",
            "行楷"});
            this.cbxFontName.Name = "cbxFontName";
            this.cbxFontName.Size = new System.Drawing.Size(121, 25);
            this.cbxFontName.SelectedIndexChanged += new System.EventHandler(this.cbxFontName_SelectedIndexChanged);
            // 
            // cbxFontSize
            // 
            this.cbxFontSize.Name = "cbxFontSize";
            this.cbxFontSize.Size = new System.Drawing.Size(121, 25);
            this.cbxFontSize.SelectedIndexChanged += new System.EventHandler(this.cbxFontSize_SelectedIndexChanged);
            // 
            // toolboldface
            // 
            this.toolboldface.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolboldface.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolboldface.Image = ((System.Drawing.Image)(resources.GetObject("toolboldface.Image")));
            this.toolboldface.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolboldface.Name = "toolboldface";
            this.toolboldface.Size = new System.Drawing.Size(23, 22);
            this.toolboldface.Text = "B";
            this.toolboldface.Click += new System.EventHandler(this.toolboldface_Click);
            // 
            // toolItalic
            // 
            this.toolItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolItalic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolItalic.Image")));
            this.toolItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolItalic.Name = "toolItalic";
            this.toolItalic.Size = new System.Drawing.Size(23, 22);
            this.toolItalic.Text = "I";
            this.toolItalic.Click += new System.EventHandler(this.toolItalic_Click);
            // 
            // toolUnderline
            // 
            this.toolUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolUnderline.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolUnderline.Image")));
            this.toolUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUnderline.Name = "toolUnderline";
            this.toolUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolUnderline.Text = "U";
            this.toolUnderline.Click += new System.EventHandler(this.toolUnderline_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msg1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(612, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // msg1
            // 
            this.msg1.Name = "msg1";
            this.msg1.Size = new System.Drawing.Size(71, 17);
            this.msg1.Text = "制作人:XXX";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuItemCopy,
            this.ContextMenuItemCut,
            this.ContextMenuItemPaste,
            this.toolStripMenuItem2,
            this.ContextMenuItemSelectAll,
            this.toolStripMenuItem3,
            this.ContextMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 126);
            // 
            // ContextMenuItemCopy
            // 
            this.ContextMenuItemCopy.Name = "ContextMenuItemCopy";
            this.ContextMenuItemCopy.Size = new System.Drawing.Size(100, 22);
            this.ContextMenuItemCopy.Text = "复制";
            // 
            // ContextMenuItemCut
            // 
            this.ContextMenuItemCut.Name = "ContextMenuItemCut";
            this.ContextMenuItemCut.Size = new System.Drawing.Size(100, 22);
            this.ContextMenuItemCut.Text = "剪切";
            // 
            // ContextMenuItemPaste
            // 
            this.ContextMenuItemPaste.Name = "ContextMenuItemPaste";
            this.ContextMenuItemPaste.Size = new System.Drawing.Size(100, 22);
            this.ContextMenuItemPaste.Text = "粘贴";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 6);
            // 
            // ContextMenuItemSelectAll
            // 
            this.ContextMenuItemSelectAll.Name = "ContextMenuItemSelectAll";
            this.ContextMenuItemSelectAll.Size = new System.Drawing.Size(100, 22);
            this.ContextMenuItemSelectAll.Text = "全选";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(97, 6);
            // 
            // ContextMenuItemExit
            // 
            this.ContextMenuItemExit.Name = "ContextMenuItemExit";
            this.ContextMenuItemExit.Size = new System.Drawing.Size(100, 22);
            this.ContextMenuItemExit.Text = "退出";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtb1
            // 
            this.rtb1.ContextMenuStrip = this.contextMenuStrip1;
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.Location = new System.Drawing.Point(0, 50);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(612, 366);
            this.rtb1.TabIndex = 5;
            this.rtb1.Text = "";
            this.rtb1.WordWrap = false;
            this.rtb1.SelectionChanged += new System.EventHandler(this.rtb1_SelectionChanged);
            this.rtb1.TextChanged += new System.EventHandler(this.rtb1_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 438);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简易记事本";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
      
        

       
        public System.Windows.Forms.ToolStrip toolStrip1;
       
        private System.Windows.Forms.StatusStrip statusStrip1;
      
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemPaste;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        
        private System.Windows.Forms.ToolStripMenuItem dfToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolNew;
        private System.Windows.Forms.ToolStripButton toolOpen;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCopy;
        private System.Windows.Forms.ToolStripButton toolCut;
        private System.Windows.Forms.ToolStripButton toolPaste;
        private System.Windows.Forms.ToolStripButton toolUndo;
        private System.Windows.Forms.ToolStripButton toolRedo;
        private System.Windows.Forms.ToolStripButton toolSlecletAll;
        private System.Windows.Forms.ToolStripComboBox cbxFontName;
        private System.Windows.Forms.ToolStripComboBox cbxFontSize;
        private System.Windows.Forms.ToolStripButton toolboldface;
        private System.Windows.Forms.ToolStripButton toolItalic;
        private System.Windows.Forms.ToolStripButton toolUnderline;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNew;
        private System.Windows.Forms.ToolStripStatusLabel msg1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSavaAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFind;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReplace;
        private System.Windows.Forms.ToolStripMenuItem MenuItemWordWrap;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFont;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBackColor;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemExit;
        public System.Windows.Forms.RichTextBox rtb1;
    }
}

