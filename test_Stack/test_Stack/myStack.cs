using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private Clist m_List;                                   //调用链表类
        public CStack()
        {
            m_List = new Clist();                               //构造函数
        }
        /// <summary>
        /// 压入堆栈
        /// </summary>
        public void Push(int PushValue)
        {
            m_List.Append(PushValue);                            //参数：int PushValue压入堆栈的数据
        }
        /// <summary>
        /// 弹出堆栈数据,如果为空，则取得 2147483647 为 int 的最大值
        /// </summary>
        public int Pop()
        {
            int PopValue;                                   //功能：弹出堆栈数据
            if (!IsNullStack())                                 //不为空堆栈
            {
                MoveTop();                                   //移动到顶
                PopValue = GetCurrentValue();                       //取得弹出的数据
                Delete();                                    //删除
                return PopValue;
            }
            return 2147483647;                                  //空的时候为int类型的最大值
        }
        /// <summary>
        /// 判断是否为空的堆栈
        /// </summary>
        public bool IsNullStack()
        {
            if (m_List.IsNull())
                return true;
            return false;
        }
        /// <summary>
        /// 堆栈的个数
        /// </summary>
        public int StackListCount
        {
            get
            {
                return m_List.ListCount;
            }
        }
        /// <summary>
        /// 移动到堆栈的底部
        /// </summary>
        public void MoveBottom()
        {
            m_List.MoveFrist();
        }
        /// <summary>
        /// 移动到堆栈的顶部
        /// </summary>
        public void MoveTop()
        {
            m_List.MoveLast();
        }
        /// <summary>
        /// 向上移动
        /// </summary>
        public void MoveUp()
        {
            m_List.MoveNext();
        }
        /// <summary>
        /// 向上移动
        /// </summary>
        public void MoveDown()
        {
            m_List.MovePrevious();
        }
        /// <summary>
        /// 取得当前的值
        /// </summary>
        public int GetCurrentValue()
        {
            return m_List.GetCurrentValue();
        }
        /// <summary>
        /// 删除取得当前的结点
        /// </summary>
        public void Delete()
        {
            m_List.Delete();
        }
        /// <summary>
        /// 清空堆栈
        /// </summary>
        public void Clear()
        {
            m_List.Clear();
        }
    }
}
