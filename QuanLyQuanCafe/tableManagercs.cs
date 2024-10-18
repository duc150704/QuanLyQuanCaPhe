using QuanLyQuanCAFE.DAO;
using QuanLyQuanCAFE.DTO;
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
    public partial class tableManagercs : Form
    {
        public tableManagercs()
        {
            InitializeComponent();
            LoadTable();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        #region Events
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
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddFood_Click(object sender, EventArgs e)
        {

        }

        #region

        void LoadTable()
        {
            List<Table> tableList =  TableDAO.Instance.LoadTableList();

            foreach (Table t in tableList) {
                Button btn = new Button() 
                {   
                    Width = TableDAO.TableWidth,
                    Height = TableDAO.TableHeight 
                };
                btn.Text = t.Name + Environment.NewLine + t.Status;

                if (t.Status.Equals("Trống"))
                {
                    btn.BackColor = Color.Gray;
                }
                else
                {
                    btn.BackColor = Color.Green;
                }

                flpTable.Controls.Add(btn);
            }
        }

        #endregion
    }
}
