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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 登录
        // 创建 FrmPwdCheck 对象
        FrmPwdCheck frmPwdCheck = new FrmPwdCheck();
        private void btEnter_Click(object sender, EventArgs e)
        {
            DialogResult result = frmPwdCheck.ShowDialog();
            //密码验证成功
            if (result == DialogResult.OK)
            {
                MessageBox.Show("登录成功！祝您游戏愉快~");
                // 取消 登录按钮的显示
                btEnter.Visible = false;
                // 显示主页面
                label_level.Visible = true;
                label_money.Visible = true;
                label_Select.Visible = true;
                btSign.Visible = true;
                btStart.Visible = true;
                comboBox1.Visible = true;
            }
        }


        #endregion

    }
}
