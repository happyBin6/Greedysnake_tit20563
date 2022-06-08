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
        public static int unit = 20;   //设定每一个网格的大小
        public int[][] mapGrid = new int[30][];   // 设定地图的网格
        public bool isGamePalying = false;  //标记游戏开始
        public bool isGameOver = false;  //标记游戏结束
        public int score;  // 定义游戏分数

        private Food food = new Food(unit);   //定义 食物 对象
        private Snake snake;  //定义 蛇 对象
        public enum Direction { Left, Right, Up, Down };  //定义上下左右方向
        public Direction snakeDirection = Direction.Right;  //设置蛇初始方向

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
                btEnterGame.Visible = true;
                comboBox1.Visible = true;
            }
        }


        #endregion

        #region 游戏初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            btStart.Visible = false;
            for (int i = 0; i < mapGrid.Length; i++)
            {
                mapGrid[i] = new int[30];   //初始化地图范围
            }
            snake = new Snake(unit, 10, 9, mapGrid);  //蛇的初始位置
            food = food.NewFood();  //食物随机出现的位置
            timer1.Enabled = true;  // 游戏能正常刷新
            timer1.Interval = 230;  //与上一事件间隔时间 => 蛇的速度，可根据combox进行修改
            score = 0;  //初始游戏分数
            button_return.Visible = false; 
        }
        #endregion

        #region 游戏运行
        void GamePlay()
        {
            Graphics g = this.CreateGraphics();
            // 游戏开始
            if (isGamePalying)
            {
                // 蛇移动
                if (snakeDirection == Direction.Right)
                {
                    snake.moveRight();
                }
                else if (snakeDirection == Direction.Down)
                {
                    snake.moveDown();
                }
                else if (snakeDirection == Direction.Left)
                {
                    snake.moveLeft();
                }
                else if (snakeDirection == Direction.Up)
                {
                    snake.moveUp();
                }
                // 检查是否挑战成功
                if (score == 150)
                {
                    isGamePalying = false;
                    isGameOver = true;
                    return;
                }

                // 检查蛇是否碰到墙
                if (snake.Head.X >= 29 || snake.Head.X <= 0 ||
                    snake.Head.Y >= 29 || snake.Head.Y <= 0)
                {
                    isGamePalying = false;
                    isGameOver = true;
                    return;
                }

                // 检查蛇是否咬到自己
                if (snake.IsTouchMyself(snake.Head.X, snake.Head.Y))
                {
                    isGamePalying = false;
                    isGameOver = true;
                    return;
                }

                // 检查蛇是否吃到食物
                if (snake.Head.X == food.X && snake.Head.Y == food.Y)
                {
                    food.clear(g, BackColor);   // 清除已有食物
                    food = food.NewFood();  // 初始化新食物
                    food.Draw(g, Color.Orange);// 重画食物
                    score += 10;  // 游戏加分
                }
                else
                {
                    snake.MoveTail(g, BackColor, mapGrid);  //清除蛇尾
                }
                snake.MoveHead(g, Color.Purple);  //蛇向前移动
            }
        }


        void GameOver()
        {
            Graphics g = CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 0, 0, 1000, 1000);
            snake.Clear(g, BackColor, mapGrid);   // 清除已有的蛇
            food.clear(g, BackColor);  // 清除食物
            label_over.Visible = true;
            btStart.Visible = true;
            btStart.Location = new Point(300, 400);
            btStart.Text = "重新开始";
            if (score == 150)
            {
                label_over.Text = "挑   战   成   功   ！";
            }
            label_EndScore.Visible = true;
            label_EndScore.Text = "分数：" + score.ToString();
            label_difficulty.Visible = false;
            label_score.Visible = false;
            button_return.Visible = true;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGameOver)
            {
                GameOver();
                timer1.Enabled = false;
            }
            if (isGamePalying)
            {
                // 游戏相关页面的准备
                // 绘画
                Bitmap bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
                Graphics g = Graphics.FromImage(bitmap);
                snake.Draw(g, Color.Purple);
                food.Draw(g, Color.Orange);
                // 画地图
                Graphics fg = this.CreateGraphics();
                fg.DrawImage(bitmap, this.ClientRectangle);
                Pen penMap = new Pen(Color.Black);
                fg.DrawRectangle(penMap, unit, unit, unit * (mapGrid.Length - 2), unit * (mapGrid.Length - 2));
                // 显示游戏相关标签
                label_score.Visible = true;
                label_score.Text= "分数：" + score.ToString();
                label_difficulty.Visible = true;
                // 默认显示简单
                if (label_difficulty.Text == "难度：")
                {
                    label_difficulty.Text = "难度：简单";
                }
                // 因为点击之后，焦点在button不在窗体，取消显示即可控制蛇的移动
                btStart.Visible = false;
                // 隐藏标签
                label_over.Visible = false;
                label_EndScore.Visible = false;
                // 游戏运行
                GamePlay();
            }

        }
        #endregion

        #region 开始游戏
        private void btStart_Click(object sender, EventArgs e)
        {
            isGamePalying = true;
            timer1.Enabled = true; //启动timer
            if (isGameOver)
            {
                // 重置 Snake
                //snake.Clear(this.CreateGraphics(), this.BackColor, mapGrid);   // 清除已有的蛇
                snake = new Snake(unit, 10, 9, mapGrid);  // 实例化新蛇新蛇
                snake.Draw(this.CreateGraphics(), Color.Purple); // 画 新蛇
                //重置food
                //food.clear(this.CreateGraphics(), this.BackColor);//食物所在矩形内部为背景色
                food = food.NewFood(); 
                food.Draw(this.CreateGraphics(), Color.Orange);//画食物
                //重置方向为right
                snakeDirection = Direction.Right;
                isGameOver = false;
                // 重置分数
                score = 0;
                // 取消显示返回大厅
                button_return.Visible = false;
            }

        }
        #endregion

        #region 方向按键设置
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // 不能在同一水平线进行更改方向
            if (e.KeyCode == Keys.Up && snakeDirection != Direction.Down)
            {
                snakeDirection = Direction.Up;
            }
            if (e.KeyCode == Keys.Down && snakeDirection != Direction.Up)
            {
                snakeDirection = Direction.Down;
            }
            if (e.KeyCode == Keys.Left && snakeDirection != Direction.Right)
            {
                snakeDirection = Direction.Left;
            }
            if (e.KeyCode == Keys.Right && snakeDirection != Direction.Left)
            {
                snakeDirection = Direction.Right;
            }
        }
        #endregion


        #region 取消游戏主页面
        private void btEnterGame_Click(object sender, EventArgs e)
        {
            //取消 游戏主页面的显示
            label_level.Visible = false;
            label_money.Visible = false;
            label_Select.Visible = false;
            btSign.Visible = false;
            btStart.Visible = false;
            comboBox1.Visible = false;
            label_welcome1.Visible = false;
            label_welcome2.Visible = false;
            btEnterGame.Visible = false;
            // 显示游戏页面
            btStart.Visible = true;
            btStart.Text = "开始游戏";
            btStart.Location = new Point(590, 450);
            label_score.Visible = true;
            label_difficulty.Visible = true;
            // 画地图
            Bitmap bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Graphics fg = this.CreateGraphics();
            fg.DrawImage(bitmap, this.ClientRectangle);
            Pen penMap = new Pen(Color.Black);
            fg.DrawRectangle(penMap, unit, unit, unit * (mapGrid.Length - 2), unit * (mapGrid.Length - 2));
        }
        #endregion

        #region 签到
        private void btSign_Click(object sender, EventArgs e)
        {
            MessageBox.Show("签到成功！恭喜您获得100个金币！");
            label_money.Text = "金币：766";
            btSign.Enabled = false;
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 根据combox的选项，然后更改timer.Interval，进而更改蛇的速度
            // timer 值越小，速度越快
            // 默认是230
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    timer1.Interval = 230;
                    label_difficulty.Text = "难度：简单";
                    break;
                case 1:
                    timer1.Interval = 150;
                    label_difficulty.Text = "难度：中等";
                    break;
                case 2:
                    timer1.Interval = 50;
                    label_difficulty.Text = "难度：困难";
                    break;
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 0, 0, 1000, 1000);
            // 显示主页面
            label_welcome1.Visible = true;
            label_welcome2.Visible = true;
            label_level.Visible = true;
            label_money.Visible = true;
            label_Select.Visible = true;
            btSign.Visible = true;
            btEnterGame.Visible = true;
            comboBox1.Visible = true;
            // 取消结算标签
            label_EndScore.Visible = false;
            label_over.Visible = false;
            btStart.Visible = false;
            button_return.Visible = false;

        }
    }
}
