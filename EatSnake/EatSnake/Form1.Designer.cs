
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
            this.components = new System.ComponentModel.Container();
            this.btEnter = new System.Windows.Forms.Button();
            this.label_welcome1 = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.label_welcome2 = new System.Windows.Forms.Label();
            this.btEnterGame = new System.Windows.Forms.Button();
            this.btSign = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_Select = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_difficulty = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_over = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.label_EndScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("宋体", 30F);
            this.btEnter.Location = new System.Drawing.Point(399, 521);
            this.btEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(191, 60);
            this.btEnter.TabIndex = 0;
            this.btEnter.Text = "登录";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // label_welcome1
            // 
            this.label_welcome1.AutoSize = true;
            this.label_welcome1.Font = new System.Drawing.Font("华文行楷", 45F);
            this.label_welcome1.Location = new System.Drawing.Point(320, 191);
            this.label_welcome1.Name = "label_welcome1";
            this.label_welcome1.Size = new System.Drawing.Size(367, 79);
            this.label_welcome1.TabIndex = 1;
            this.label_welcome1.Text = "贪  吃  蛇  ";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Font = new System.Drawing.Font("宋体", 30F);
            this.label_level.Location = new System.Drawing.Point(77, 74);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(197, 50);
            this.label_level.TabIndex = 2;
            this.label_level.Text = "等级：8";
            this.label_level.Visible = false;
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("宋体", 30F);
            this.label_money.Location = new System.Drawing.Point(612, 74);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(247, 50);
            this.label_money.TabIndex = 3;
            this.label_money.Text = "金币：666";
            this.label_money.Visible = false;
            // 
            // label_welcome2
            // 
            this.label_welcome2.AutoSize = true;
            this.label_welcome2.Font = new System.Drawing.Font("华文行楷", 55F);
            this.label_welcome2.Location = new System.Drawing.Point(211, 316);
            this.label_welcome2.Name = "label_welcome2";
            this.label_welcome2.Size = new System.Drawing.Size(542, 97);
            this.label_welcome2.TabIndex = 4;
            this.label_welcome2.Text = "称  霸  世  界";
            // 
            // btEnterGame
            // 
            this.btEnterGame.Font = new System.Drawing.Font("宋体", 30F);
            this.btEnterGame.Location = new System.Drawing.Point(359, 479);
            this.btEnterGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEnterGame.Name = "btEnterGame";
            this.btEnterGame.Size = new System.Drawing.Size(276, 69);
            this.btEnterGame.TabIndex = 5;
            this.btEnterGame.Text = "进入游戏";
            this.btEnterGame.UseVisualStyleBackColor = true;
            this.btEnterGame.Visible = false;
            this.btEnterGame.Click += new System.EventHandler(this.btEnterGame_Click);
            // 
            // btSign
            // 
            this.btSign.Font = new System.Drawing.Font("宋体", 30F);
            this.btSign.Location = new System.Drawing.Point(748, 622);
            this.btSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(191, 64);
            this.btSign.TabIndex = 6;
            this.btSign.Text = "签到";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Visible = false;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 30F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "简单",
            "中等",
            "困难"});
            this.comboBox1.Location = new System.Drawing.Point(283, 632);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 58);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "简单";
            this.comboBox1.Visible = false;
            // 
            // label_Select
            // 
            this.label_Select.AutoSize = true;
            this.label_Select.Font = new System.Drawing.Font("宋体", 30F);
            this.label_Select.Location = new System.Drawing.Point(15, 636);
            this.label_Select.Name = "label_Select";
            this.label_Select.Size = new System.Drawing.Size(247, 50);
            this.label_Select.TabIndex = 8;
            this.label_Select.Text = "难度选择:";
            this.label_Select.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_difficulty
            // 
            this.label_difficulty.AutoSize = true;
            this.label_difficulty.Font = new System.Drawing.Font("宋体", 18F);
            this.label_difficulty.Location = new System.Drawing.Point(784, 94);
            this.label_difficulty.Name = "label_difficulty";
            this.label_difficulty.Size = new System.Drawing.Size(103, 30);
            this.label_difficulty.TabIndex = 10;
            this.label_difficulty.Text = "难度：";
            this.label_difficulty.Visible = false;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("宋体", 18F);
            this.label_score.Location = new System.Drawing.Point(784, 200);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(103, 30);
            this.label_score.TabIndex = 11;
            this.label_score.Text = "分数：";
            this.label_score.Visible = false;
            // 
            // label_over
            // 
            this.label_over.AutoSize = true;
            this.label_over.BackColor = System.Drawing.Color.White;
            this.label_over.Font = new System.Drawing.Font("华光综艺_CNKI", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_over.Location = new System.Drawing.Point(179, 270);
            this.label_over.Name = "label_over";
            this.label_over.Size = new System.Drawing.Size(559, 78);
            this.label_over.TabIndex = 13;
            this.label_over.Text = "游   戏   结   束   !";
            this.label_over.Visible = false;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("宋体", 18F);
            this.btStart.Location = new System.Drawing.Point(789, 497);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(177, 46);
            this.btStart.TabIndex = 12;
            this.btStart.Text = "开始游戏";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label_EndScore
            // 
            this.label_EndScore.AutoSize = true;
            this.label_EndScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_EndScore.Font = new System.Drawing.Font("华光综艺_CNKI", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_EndScore.Location = new System.Drawing.Point(284, 384);
            this.label_EndScore.Name = "label_EndScore";
            this.label_EndScore.Size = new System.Drawing.Size(203, 67);
            this.label_EndScore.TabIndex = 14;
            this.label_EndScore.Text = "分数：";
            this.label_EndScore.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 752);
            this.Controls.Add(this.label_EndScore);
            this.Controls.Add(this.label_over);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_difficulty);
            this.Controls.Add(this.label_Select);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btSign);
            this.Controls.Add(this.btEnterGame);
            this.Controls.Add(this.label_welcome2);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label_welcome1);
            this.Controls.Add(this.btEnter);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Label label_welcome1;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Label label_welcome2;
        private System.Windows.Forms.Button btEnterGame;
        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_Select;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_difficulty;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_over;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label_EndScore;
    }
}

