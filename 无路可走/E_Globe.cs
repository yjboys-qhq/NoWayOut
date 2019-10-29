using System.Drawing;

namespace 无路可走
{
    /// <summary>
    /// 元素球类
    /// </summary>
    class E_Globe : Element
    {
        /// <summary>
        /// 球类的左上角坐标点
        /// </summary>
        public Point p1;
        /// <summary>
        /// 球类半径
        /// </summary>
        public int radius = 48;
        /// <summary>
        /// 球类颜色
        /// </summary>
        public Color color;
        /// <summary>
        /// 此球的所在的营地
        /// </summary>
        public E_Campsite campsite;
        /// <summary>
        /// 实现的元素类的绘画方法
        /// </summary>
        /// <param name="g">绘画工具参数</param>
        void Element.draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Pen pen = new Pen(brush);
            g.DrawEllipse(pen, p1.X + 1, p1.Y + 1, radius, radius);
            g.FillEllipse(brush, p1.X + 1, p1.Y + 1, radius, radius);
        }
    }
}
