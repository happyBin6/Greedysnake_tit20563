using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatSnake
{
    public partial class FrmPwdCheck : Form
    {
        //总共次数
        int MAXPWDCOUNT = 3;
        //已输次数
        int pwdcount = 1;
        public FrmPwdCheck()
        {
            InitializeComponent();
        }
        //在输入密码时，设置textBox_pwd的PasswordChar的值为 * ，可保证每一次输入的值都为 *
        private void btOK_Click(object sender, EventArgs e)
        {
            if (textBox_pwd.Text == "123456")
            {
                //密码正确，验证成功
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //密码错误
                pwdcount++;
                if (pwdcount > MAXPWDCOUNT)
                {
                    //验证失败
                    MessageBox.Show("您登录过于频繁，请休息一下吧");
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    //还剩MAXPWDCOUNT-pwdcount次机会
                    MessageBox.Show("密码错误，请重新输入", "提示", MessageBoxButtons.OK);
                    //将密码框置空
                    textBox_pwd.Text = "";
                    //重新将光标聚集到输入框
                    textBox_pwd.Focus();
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("退出成功！");
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
