using System;
using System.Windows.Forms;

namespace CSLab06_Array
{
    public partial class frmNhapLieu : Form
    {
        public frmNhapLieu()
        {
            InitializeComponent();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int soDong = 1;
            int soCot = 1;

            if (int.TryParse(txtSoDong.Text, out int dong) && dong > 0)
            {
                soDong = dong;
            }

            if (int.TryParse(txtSoCot.Text, out int cot) && cot > 0)
            {
                soCot = cot;
            }

            frmXuat formXuat = new frmXuat(soDong, soCot);
            formXuat.StartPosition = FormStartPosition.CenterScreen;
            formXuat.Show();
        }
    }
}