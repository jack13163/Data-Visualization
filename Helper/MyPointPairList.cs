using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;

namespace Drilling
{
    /// <summary>
    /// 自定义的PointPairList
    /// 实现数据的后移
    /// x始终为1，2，3，...
    /// y随机变化
    /// </summary>
    public class MyPointPairList : PointPairList
    {
        //动态变化的x轴，当增大到199时，不能增大了，只能在最后即索引为199的位置进行插入数据
        public static int sx = 0;

        public MyPointPairList()
        {
            
        }

        /// <summary>
        /// 插入元素
        /// </summary>
        /// <param name="index">索引值（<200）</param>
        /// <param name="value"></param>
        protected override void OnInsert(int index, object value)
        {
            //插入之前需要判断当前队列是否已经满了
            //获取要插入的位置
            if (index >= 200) 
            {
                throw new Exception("点列表索引越界!");
            }
            //获取当前列表中的元素个数
            int num = index % 200;
            //若当前的列表已满
            if (num >= 199)
            {
                //除去首个元素
                this.RemoveAt(0);
                //修改队列中的值
                for (int i = 0; i < 198; i++)
                {
                    //数字循环左移
                    this[i] = this[i + 1];
                    //修改队列中的点的横轴坐标值X,纵坐标的值Y不变化
                    this[i] = new PointPair(this[i].X - 1, this[i].Y);
                }
            }
            //调用父类的方法，执行插入操作
            base.OnInsert(index, value);
        }

        /// <summary>
        /// 根据输入的参数i产生一个坐标上的点
        /// </summary>
        /// <returns>一个点</returns>
        public PointPair create()
        {
            //产生一个点
            double x = sx;
            double y = new Random().Next(200);
            //索引自增,当索引增加到199时，停止增加
            if (sx < 199)
            {
                sx++;
            }
            return new PointPair(x, y);
        }

    }
}
