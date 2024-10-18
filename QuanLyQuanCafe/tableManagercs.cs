using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
        public partial class tableManagercs : Form
    {
        public tableManagercs()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Method
        void LoadTable()
        {
            List<Table> TableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in TableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightBlue;
                        break;
                    default : 
                        btn.BackColor = Color.LightPink; 
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }
        #endregion

        #region Events
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAmin f = new fAmin();
            f.ShowDialog();

        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AcountProfile f = new AcountProfile();
            f.ShowDialog();
        }
        #endregion
    }
}
