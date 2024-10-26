using QuanLyQuanCAFE.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCAFE
{
    public partial class fAmin : Form
    {
        BindingSource accountList = new BindingSource();


        public fAmin()
        {
            InitializeComponent();
            Load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Load()
        {
            dtgvAccount.DataSource = accountList;
            AddAccountBinding();
            LoadAccount();
        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            cbAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        private void butViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
