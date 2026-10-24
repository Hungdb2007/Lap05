using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSLab06_Array
{
    public partial class frmXuat : Form
    {
        public int SoDong { get; set; }
        public int SoCot { get; set; }

        int h = 35;
        int margin = 5;

        public frmXuat(int dong = 1, int cot = 1)
        {
            InitializeComponent();

            this.SoDong = dong;
            this.SoCot = cot;

            Button btn = null;
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    btn = new Button();
                    btn.Width = h;
                    btn.Height = h;
                    btn.Text = (i * SoCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;

                    btn.Click += btn_Click;
                    btn.MouseHover += HoChuotLenButton;
                    btn.Tag = string.Format("Dòng {0} cột {1}", i + 1, j + 1);

                    this.Controls.Add(btn);
                }
            }

            this.ClientSize = new Size(SoCot * (h + margin) + margin, SoDong * (h + margin) + margin);
        }

        private void HoChuotLenButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                this.Text = btn.Tag.ToString();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                MessageBox.Show("Bạn vừa bấm vào nút số: " + btn.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}