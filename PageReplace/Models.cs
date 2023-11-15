using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageReplace
{
    public enum BtnType
    {
        FIFO,
        
        OPT,

        LRU,

        LFU,

        ALL

    }
    public struct OPTEntity
    {
        /// <summary>
        /// 值
        /// </summary>
        public int Value;
        /// <summary>
        /// 在页号引用串中最近出现的下标，若没有出现，赋值为int.max
        /// </summary>
        public int LatestFindIndex;
    }

    public struct LRUEntity
    {
        /// <summary>
        /// 值
        /// </summary>
        public int Value;
        /// <summary>
        /// 自上次访问后经过的时间
        /// </summary>
        public int Time;
    }

    public struct LFUEntity
    {
        /// <summary>
        /// 值
        /// </summary>
        public int Value;
        /// <summary>
        /// 使用次数计数
        /// </summary>
        public int UseCount;
    }
}
