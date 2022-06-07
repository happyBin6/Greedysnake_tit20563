using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EatSnake
{
    class Block
    {
        // 每一个块的位置和大小
        private int x;
        private int y;
        private int size;
        // 每一个块的相关属性的封装
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Size { get => size; set => size = value; }

        // 构造方法
        public Block() { }
        public Block(int x, int y, int objSize)
        {
            X = x;
            Y = y;
            Size = objSize;
        }

        // 绘画
        public virtual void Draw(Graphics g, Color c)
        {
            SolidBrush brush = new SolidBrush(c);
            g.FillEllipse(brush, X * Size + 2, Y * Size + 2, Size - 3, Size - 3);//绘制 圆 形身体
        }

        // 清除
        public void clear(Graphics g, Color c)
        {
            SolidBrush Brush = new SolidBrush(c);
            g.FillRectangle(Brush, X * Size + 1, Y * Size + 1, Size - 1, Size - 1);// 填充矩形来清除
        }


    }
}