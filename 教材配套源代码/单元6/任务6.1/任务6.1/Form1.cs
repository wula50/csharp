using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 任务6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //刷新ListView以显示更新后的联系人列表
        void RefreshListView()
        {
            listView1.Items.Clear();
            foreach (Person p in ContactsBook.Contacts)
            {
                ListViewItem item = new ListViewItem(p.Name);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, p.DayOfBirth.ToLongDateString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, p.Phone));
                listView1.Items.Add(item);
            }
        }

        //在点击“新建”按钮时设置各个控件的状态
        private void ControlsStateOnCreatPerson()
        {
            btnCreate.Enabled = false;
            btnSave.Enabled = true;
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            dtpDayOfBirth.Enabled = true;
        }

        //在点击“保存”按钮时设置各个控件的状态
        private void ControlsStateOnSavePerson()
        {
            btnCreate.Enabled = true;
            btnSave.Enabled = false;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            dtpDayOfBirth.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhone.Text = "";
            ControlsStateOnCreatPerson();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //创建联系人
            ContactsBook.Add(txtName.Text, dtpDayOfBirth.Value, txtPhone.Text);

            ControlsStateOnSavePerson();
            RefreshListView();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                ContactsBook.Remove(listView1.SelectedIndices[0]);
                RefreshListView();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            ContactsBook.RemoveAll();
            RefreshListView();
        }        
    }
}
