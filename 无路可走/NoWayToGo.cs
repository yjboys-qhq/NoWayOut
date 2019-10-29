using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 无路可走
{
    /// <summary>
    /// 主类
    /// </summary>
    public partial class NoWayToGo : Form
    {
        /// <summary>
        /// 现有营地集合
        /// </summary>
        List<E_Campsite> campsiteList = new List<E_Campsite>();
        /// <summary>
        /// 现有球集合
        /// </summary>
        List<E_Globe> globeList = new List<E_Globe>();
        /// <summary>
        /// 球
        /// </summary>
        E_Globe globe;
        /// <summary>
        /// 存储鼠标点击之后的X坐标
        /// </summary>
        int mouseDownX;
        /// <summary>
        /// 存储鼠标点击之后的Y坐标
        /// </summary>
        int mouseDownY;
        /// <summary>
        /// 存储鼠标点击之后的X坐标
        /// </summary>
        int mouseDownGlobeX;
        int mouseDownGlobeY;
        /// <summary>
        /// 边距
        /// </summary>
        static int backGauge = 20;
        /// <summary>
        /// 主类的构造方法
        /// </summary>
        public NoWayToGo()
        {
            InitializeComponent();
            this.BTStart.Location = new Point(10000, 10000);
            this.BTClose.Location = new Point(10000, 10000);
            this.Width = this.Height;
            LBRestart.Location = new Point(this.Width / 2 - LBRestart.Width / 2, this.Height / 2 - 20);
            LBClose.Location = new Point(this.Width / 2 - LBClose.Width / 2, this.Height / 2 + 20);
            this.DoubleBuffered = true;
            ElementInit();
        }
        /// <summary>
        /// 初始化营地，球
        /// </summary>
        public void ElementInit()
        {
            //初始化营地
            E_Campsite camp1 = new E_Campsite();
            camp1.p1 = new Point(backGauge, backGauge);

            E_Campsite camp2 = new E_Campsite();
            camp2.p1 = new Point((this.Width - backGauge * 2 - camp2.radius) / 2 + backGauge, backGauge);

            E_Campsite camp3 = new E_Campsite();
            camp3.p1 = new Point(this.Width - backGauge - camp3.radius, backGauge);

            E_Campsite camp4 = new E_Campsite();
            camp4.p1 = new Point(backGauge, (this.Width - backGauge * 2 - camp4.radius) / 2 + backGauge);

            E_Campsite camp5 = new E_Campsite();
            camp5.p1 = new Point(this.Width - backGauge - camp5.radius, (this.Width - backGauge * 2 - camp5.radius) / 2 + backGauge);

            E_Campsite camp6 = new E_Campsite();
            camp6.p1 = new Point(backGauge, this.Width - backGauge - camp6.radius);

            E_Campsite camp7 = new E_Campsite();
            camp7.p1 = new Point((this.Width - backGauge * 2 - camp7.radius) / 2 + backGauge, this.Width - backGauge - camp7.radius);

            E_Campsite camp8 = new E_Campsite();
            camp8.p1 = new Point(this.Width - backGauge - camp8.radius, this.Width - backGauge - camp8.radius);

            //添加与之相连营地
            camp1.another.Add(camp2);
            camp1.another.Add(camp4);

            camp2.another.Add(camp1);
            camp2.another.Add(camp3);
            camp2.another.Add(camp4);
            camp2.another.Add(camp5);

            camp3.another.Add(camp2);
            camp3.another.Add(camp5);

            camp4.another.Add(camp1);
            camp4.another.Add(camp2);
            camp4.another.Add(camp6);
            camp4.another.Add(camp7);

            camp5.another.Add(camp2);
            camp5.another.Add(camp3);
            camp5.another.Add(camp7);
            camp5.another.Add(camp8);

            camp6.another.Add(camp4);
            camp6.another.Add(camp7);

            camp7.another.Add(camp4);
            camp7.another.Add(camp5);
            camp7.another.Add(camp6);
            camp7.another.Add(camp8);

            camp8.another.Add(camp5);
            camp8.another.Add(camp7);

            //向营地集合中添加各个营地
            campsiteList.Add(camp1);
            campsiteList.Add(camp2);
            campsiteList.Add(camp3);
            campsiteList.Add(camp4);
            campsiteList.Add(camp5);
            campsiteList.Add(camp6);
            campsiteList.Add(camp7);
            campsiteList.Add(camp8);

            //初始化球
            E_Globe g1 = new E_Globe();
            E_Globe g2 = new E_Globe();
            E_Globe g3 = new E_Globe();
            E_Globe g4 = new E_Globe();
            E_Globe g5 = new E_Globe();
            E_Globe g6 = new E_Globe();

            //向营地中相应位置添加球
            camp1.Add(g1);
            camp2.Add(g2);
            camp3.Add(g3);
            camp6.Add(g4);
            camp7.Add(g5);
            camp8.Add(g6);

            //分类球
            g1.color = Color.Red;
            g2.color = Color.Red;
            g3.color = Color.Red;
            g4.color = Color.Blue;
            g5.color = Color.Blue;
            g6.color = Color.Blue;

            //向球集合中添加各个球体
            globeList.Add(g1);
            globeList.Add(g2);
            globeList.Add(g3);
            globeList.Add(g4);
            globeList.Add(g5);
            globeList.Add(g6);
        }
        /// <summary>
        /// 主界面绘图方法
        /// </summary>
        /// <param name="sender">主界面</param>
        /// <param name="e">绘图工具</param>
        private void NoWayToGo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Black);
            //按照相连接关系绘制图线
            foreach (Element c in campsiteList)
            {
                foreach (E_Campsite cam in ((E_Campsite)c).another)
                {
                    g.DrawLine(pen, ((E_Campsite)c).p1.X + 25, ((E_Campsite)c).p1.Y + 25, cam.p1.X + 25, cam.p1.Y + 25);
                }
            }
            //绘制营地
            foreach (Element c in campsiteList)
            {
                c.draw(g);
            }
            //绘制球
            if (globe != null)
            {
                ((Element)globe).draw(g);
            }

        }
        /// <summary>
        /// 主界面鼠标点击方法
        /// </summary>
        /// <param name="sender">主界面</param>
        /// <param name="e">点击之后的鼠标</param>
        private void NoWayToGo_MouseDown(object sender, MouseEventArgs e)
        {
            //设定球的初始值为空
            globe = null;
            //循环球集合
            foreach (E_Globe c in globeList)
            {
                //如果点击到了球
                if (e.X >= c.p1.X && e.Y >= c.p1.Y && e.X <= c.p1.X + c.radius && e.Y <= c.p1.Y + c.radius)
                {
                    //将点击的球赋值给本界面的球
                    globe = c;
                    //将此营地的球移除
                    globe.campsite.Remove();
                    foreach (E_Campsite cs in campsiteList)
                    {
                        if (cs.globe == c)
                        {
                            cs.globe = null;
                        }
                    }
                    //存储鼠标相对于球的坐标
                    mouseDownGlobeX = e.X - c.p1.X;
                    mouseDownGlobeY = e.Y - c.p1.Y;
                    break;
                }
            }
            //存储鼠标相对于界面的坐标
            mouseDownX = e.X;
            mouseDownY = e.Y;
        }
        /// <summary>
        /// 主界面中鼠标移动方法
        /// </summary>
        /// <param name="sender">主界面</param>
        /// <param name="e">鼠标</param>
        private void NoWayToGo_MouseMove(object sender, MouseEventArgs e)
        {
            if (globe != null)
            {
                globe.p1 = new Point(e.X - 25, e.Y - 25);
                this.Invalidate();
            }
        }
        /// <summary>
        /// 主界面鼠标放开方法
        /// </summary>
        /// <param name="sender">主界面</param>
        /// <param name="e">鼠标</param>
        private void NoWayToGo_MouseUp(object sender, MouseEventArgs e)
        {
            //当球不为空的时候
            if (globe != null)
            {
                //将营地赋值为空
                E_Campsite cs = null;
                //定义bool变量isRelation
                bool isRelation = false;
                //循环所有营地
                foreach (E_Campsite c in campsiteList)
                {
                    //当鼠标到达营地的时候
                    if (e.X >= c.p1.X - 20 && e.Y >= c.p1.Y - 20 && e.X <= c.p1.X + c.radius + 20 && e.Y <= c.p1.Y + c.radius + 20)
                    {
                        //将营地赋值给当前界面的营地
                        cs = c;
                        break;
                    }
                }
                //当营地不为空的时候
                if (cs != null)
                {
                    //循环与之相连的营地
                    foreach (E_Campsite cam in globe.campsite.another)
                    {
                        //当鼠标所在营地是其相连营地的时候
                        if (cam == cs)
                        {
                            //IDRelation赋值为true（两个营地有关系）
                            isRelation = true;
                        }
                    }
                }
                //当两个营地没有关系时，此界面的营地赋值为空
                if (!isRelation)
                {
                    cs = null;
                }
                //当营地和球都不为空的时候
                if (cs != null && cs.globe == null)
                {
                    //将球赋值为此营地的球
                    globe.p1 = cs.p1;
                    //将球的营地更改为鼠标当前的营地
                    globe.campsite = cs;
                }
                else
                {
                    //球归位
                    globe.p1 = new Point(e.X - mouseDownGlobeX, e.Y - mouseDownGlobeY);

                }
                //球的坐标为所在营地的坐标
                globe.p1 = globe.campsite.p1;
                //营地的球是当前球
                globe.campsite.globe = globe;
            }
            this.Invalidate();
            globe = null;
        }

        private void NoWayToGo_Resize(object sender, System.EventArgs e)
        {
            this.Width = this.Height;
            this.Height = this.Width;
        }

        private void BTStart_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }

        private void BTClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}