using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTrangChuCQ : Form
    {
        public frmTrangChuCQ()
        {
            InitializeComponent();
        }
        private void OpenFormInPanel(object Formhijo)
        {
            if (this.panel_workarea.Controls.Count > 0)
            {
                this.panel_workarea.Controls.RemoveAt(0);
            }
            Form fm = Formhijo as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.WindowState = FormWindowState.Normal;
            this.panel_workarea.Controls.Add(fm);
            this.panel_workarea.Tag = fm;
            fm.Show();
        }
        private void frmTrangChuCQ_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChuyenGiaoDien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu frm = new frmTrangChu();
            frm.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmQuanLyNhanVien());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHome());
        }
    }
}
