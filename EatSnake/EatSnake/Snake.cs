using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//游戏中的主角，玩家通过上下左右四个键来控制蛇的运动。

namespace EatSnake
{
    class Snake:Block
    {
        //用于存放蛇的集合
        public List<Block> snakeList = new List<Block>();
        // 蛇头
        public Point Head = new Point();
        //方向，1蛇上 2蛇下 3蛇左 4蛇右，也可以用来认知下一个蛇方块的位置
        private int forld;
        // 方向字段封装
        public int Forld { get => forld; set => forld = value; }

        // public Snake() { }
        public Snake(int snake_size, int snakeX, int snakeY, int[][] mapGrid)
        {
            // 蛇块大小
            Size = snake_size;
            //初始化蛇 集合
            Head = new Point(snakeX, snakeY);  //蛇头位置
            snakeList.Add(new Block(Head.X - 2, Head.Y, Size));  // 蛇尾
            snakeList.Add(new Block(Head.X - 1, Head.Y, Size));
            snakeList.Add(new Block(Head.X, Head.Y, Size));   //蛇头
            //蛇的初始方向，赋值代表朝向
            //二维数组snakeBody[1][2]代表1行二列 即先纵向再横向=>二维数组snakeBody[Y][X]
            mapGrid[snakeList[0].Y][snakeList[0].X] = 4;
            mapGrid[snakeList[1].Y][snakeList[1].X] = 4;
            mapGrid[snakeList[2].Y][snakeList[2].X] = 4;
            Forld = 4;
        }
        // 画蛇
        public override void Draw(Graphics g, Color c)
        {
            foreach (Block item in snakeList)
            {
                item.Draw(g, c);
            }
        }

        // 清除蛇
        public void Clear(Graphics g, Color c, int[][] mapGrid)
        {
            foreach (Block item in snakeList)
            {
                mapGrid[item.Y][item.X] = 0;
                item.clear(g, c);
            }
        }

        // 清除蛇尾
        public void MoveTail(Graphics g, Color c, int[][] mapGrid)
        {
            mapGrid[snakeList[0].Y][snakeList[0].X] = 0;
            snakeList[0].clear(g, c);
            snakeList.RemoveAt(0);
        }

        // 新生蛇头，保证蛇不断移动
        public void MoveHead(Graphics g, Color c)
        {
            Block B = new Block(Head.X, Head.Y, Size);
            snakeList.Add(B);
            B.Draw(g, c);
        }

        // 检查是否咬到自己
        public bool IsTouchMyself(int x, int y)
        {
            for (int i = 0; i < snakeList.Count; i++)
            {
                if ((x == snakeList[i].X) && y == snakeList[i].Y)
                {
                    return true;
                }
            }
            return false;
        }

        // 移动方向
        public void moveUp() { Head.Y--; Forld = 1; }
        public void moveDown() { Head.Y++; Forld = 2; }
        public void moveLeft() { Head.X--; Forld = 3; }
        public void moveRight() { Head.X++; Forld = 4; }


    }
}
