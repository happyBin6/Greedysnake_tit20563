
namespace EatSnake
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btEnter = new System.Windows.Forms.Button();
            this.label_welcome1 = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.label_welcome2 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btSign = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_Select = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("宋体", 20F);
            this.btEnter.Location = new System.Drawing.Point(386, 330);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(170, 60);
            this.btEnter.TabIndex = 0;
            this.btEnter.Text = "登录";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // label_welcome1
            // 
            this.label_welcome1.AutoSize = true;
            this.label_welcome1.Font = new System.Drawing.Font("华文行楷", 35F);
            this.label_welcome1.Location = new System.Drawing.Point(341, 110);
            this.label_welcome1.Name = "label_welcome1";
            this.label_welcome1.Size = new System.Drawing.Size(288, 62);
            this.label_welcome1.TabIndex = 1;
            this.label_welcome1.Text = "贪  吃  蛇  ";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Font = new System.Drawing.Font("宋体", 20F);
            this.label_level.Location = new System.Drawing.Point(158, 43);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(134, 34);
            this.label_level.TabIndex = 2;
            this.label_level.Text = "等级：8";
            this.label_level.Visible = false;
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("宋体", 20F);
            this.label_money.Location = new System.Drawing.Point(616, 43);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(168, 34);
            this.label_money.TabIndex = 3;
            this.label_money.Text = "金币：666";
            this.label_money.Visible = false;
            // 
            // label_welcome2
            // 
            this.label_welcome2.AutoSize = true;
            this.label_welcome2.Font = new System.Drawing.Font("华文行楷", 45F);
            this.label_welcome2.Location = new System.Drawing.Point(263, 187);
            this.label_welcome2.Name = "label_welcome2";
            this.label_welcome2.Size = new System.Drawing.Size(442, 79);
            this.label_welcome2.TabIndex = 4;
            this.label_welcome2.Text = "称  霸  世  界";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("宋体", 20F);
            this.btStart.Location = new System.Drawing.Point(371, 315);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(196, 53);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "开始游戏";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Visible = false;
            // 
            // btSign
            // 
            this.btSign.Font = new System.Drawing.Font("宋体", 20F);
            this.btSign.Location = new System.Drawing.Point(791, 386);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(118, 41);
            this.btSign.TabIndex = 6;
            this.btSign.Text = "签到";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 20F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "简单",
            "中等",
            "困难"});
            this.comboBox1.Location = new System.Drawing.Point(195, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 41);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "简单";
            this.comboBox1.Visible = false;
            // 
            // label_Select
            // 
            this.label_Select.AutoSize = true;
            this.label_Select.Font = new System.Drawing.Font("宋体", 20F);
            this.label_Select.Location = new System.Drawing.Point(12, 393);
            this.label_Select.Name = "label_Select";
            this.label_Select.Size = new System.Drawing.Size(168, 34);
            this.label_Select.TabIndex = 8;
            this.label_Select.Text = "难度选择:";
            this.label_Select.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 481);
            this.Controls.Add(this.label_Select);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btSign);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label_welcome2);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label_welcome1);
            this.Controls.Add(this.btEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Label label_welcome1;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Label label_welcome2;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_Select;
    }
}

