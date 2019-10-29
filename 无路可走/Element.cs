using System.Drawing;

namespace 无路可走
{
    /// <summary>
    /// 接口元素
    /// </summary>
    interface Element
    {
        /// <summary>
        /// 接口元素类的绘画方法
        /// </summary>
        /// <param name="g">绘画工具</param>
        void draw(Graphics g);
    }
}
