using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EatSnake
{
    class Food:Block
    {
        // 初始化食物，设置食物的大小
        public Food(int foodSize) { Size = foodSize; }

        // 对绘画方法进行重写
        public override void Draw(Graphics g, Color c)
        {
            SolidBrush brush = new SolidBrush(c);
            g.FillRectangle(brush, X * Size + 2, Y * Size + 2, Size - 3, Size - 3);
        }

        // 设置 Food 的位置
        public Food NewFood()
        {
            Random r = new Random();
            Food food = new Food(Size);
            food.X = r.Next(1, 19);
            food.Y = r.Next(1, 19);
            return food;
        }


    }
}
