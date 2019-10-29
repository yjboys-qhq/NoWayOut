using System.Collections.Generic;
using System.Drawing;

namespace 无路可走
{
    /// <summary>
    /// 元素营地
    /// </summary>
    class E_Campsite : Element
    {
        /// <summary>
        /// 营地左上角坐标
        /// </summary>
        public Point p1;
        /// <summary>
        /// 与此营地相连的其他营地集合
        /// </summary>
        public List<E_Campsite> another = new List<E_Campsite>();
        /// <summary>
        /// 此营地中的球
        /// </summary>
        public E_Globe globe;
        /// <summary>
        /// 营地的半径
        /// </summary>
        public int radius = 50;
        /// <summary>
        /// 实现的元素类的绘图方法
        /// </summary>
        /// <param name="g">绘图工具的参数</param>
        void Element.draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Gainsboro);
            Pen pen = new Pen(brush);
            g.DrawEllipse(pen, p1.X, p1.Y, radius, radius);
            g.FillEllipse(brush, p1.X, p1.Y, radius, radius);
            if (globe != null)
            {
                //globe.p1 = this.p1;
                ((Element)globe).draw(g);
            }
        }
        /// <summary>
        /// 将球添加到此营地
        /// </summary>
        /// <param name="g">要添加的球</param>
        public void Add(E_Globe g)
        {
            globe = g;
            g.p1 = this.p1;
            g.campsite = this;
        }
        /// <summary>
        /// 移除此营地中的球
        /// </summary>
        public void Remove()
        {
            globe = null;
        }
    }
}
