using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05_login
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxbId.Text == "abcd" && TxbPw.Text == "1234")
            {
                LabLog.Text = string.Format("로그인 성공!");
                MessageBox.Show("로그인성공", "로그인", MessageBoxButtons.YesNo, icon: MessageBoxIcon.None);
            }
            else
            {
                LabLog.Text = string.Format("로그인 실패!");
                MessageBox.Show("로그인실패", "로그인", MessageBoxButtons.OK,icon: MessageBoxIcon.Error);
            }
        }
    }
}
