using System;
using System.Windows.Forms;
namespace 任务6._3
{
    public partial class Form1 : Form
    {
        bool isCreate = false;//指示是在创建新记录还是在编辑原有记录

        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindToListView();
            groupBoxPerson.Enabled = false;
        }

        //读取所有联系人记录填充ListView
        void BindToListView()
        {
            listView1.Items.Clear();
            foreach (Person p in ContactsBook.GetAll())
            {
                ListViewItem item = new ListViewItem(p.Name);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, p.DayOfBirth.ToLongDateString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, p.Phone));
                item.Tag = p;//将联系人对象的引用缓存在Tag中
                listView1.Items.Add(item);
            }
        }

        //新建按钮
        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhone.Text = "";
            isCreate = true;
            OnBtnCreateClick();
        }

        //保存按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isCreate)
            {
                //创建联系人
                Person person = new Person()
                {
                    Name = txtName.Text.Trim(),
                    DayOfBirth = dtpDayOfBirth.Value,
                    Phone = txtPhone.Text.Trim()
                };

                ContactsBook.Add(person);
                isCreate = false;
            }
            else//保存编辑后的信息
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    Person person = new Person()//创建联系人
                    {
                        ID = (listView1.SelectedItems[0].Tag as Person).ID,
                        Name = txtName.Text.Trim(),
                        DayOfBirth = dtpDayOfBirth.Value,
                        Phone = txtPhone.Text.Trim()
                    };
                    ContactsBook.Save(person);
                }
            }
            BindToListView();
            OnBtnSaveClick();
        }

        //删除按钮
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                ContactsBook.Remove((Person)(listView1.SelectedItems[0].Tag));
                BindToListView();
            }
            else
                MessageBox.Show("请先选中一条记录再删除");
        }

        // 清空按钮
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你真的要清空通讯录？", "清空？", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ContactsBook.RemoveAll();
                BindToListView();
            }
        }

        //ListView选项改变时
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = (listView1.SelectedItems.Count == 0) ? false : true;
            btnRemove.Enabled = (listView1.SelectedItems.Count == 0) ? false : true;
            if (listView1.SelectedItems.Count > 0)
            {
                Person person = (Person)listView1.SelectedItems[0].Tag;
                txtName.Text = person.Name;
                txtPhone.Text = person.Phone;
                dtpDayOfBirth.Value = person.DayOfBirth;
            }
        }

        // 编辑按钮
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选中一条记录再编辑");
                return;
            }
            OnBtnEditClick();
        }

        //在点击“新建”按钮时设置各个控件的状态
        private void OnBtnCreateClick()
        {
            btnCreate.Enabled = false;
            btnSave.Enabled = true;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            btnRemoveAll.Enabled = false; ;
            groupBoxPerson.Enabled = true;
        }

        //在点击“保存”按钮时设置各个控件的状态
        private void OnBtnSaveClick()
        {
            btnCreate.Enabled = true;
            btnSave.Enabled = false;
            btnRemove.Enabled = true;
            btnEdit.Enabled = true;
            btnRemoveAll.Enabled = true; ;
            groupBoxPerson.Enabled = false;
        }

        //在点击“编辑”按钮时设置各个控件的状态
        private void OnBtnEditClick()
        {
            btnCreate.Enabled = false;
            btnSave.Enabled = true;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            btnRemoveAll.Enabled = false;
            groupBoxPerson.Enabled = true;
        }

    }
}
