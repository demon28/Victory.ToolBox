using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victory.ToolBox.Helper
{
   public static class DateTimeHelper
    {
        /// <summary>
        /// 时间戳起始日期（东8区）
        /// </summary>
        public static DateTime TimestampStart = new DateTime(1970, 1, 1, 8, 0, 0, 0);

        /// <summary>
        /// 转换为时间戳
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="milliseconds">是否使用毫秒</param>
        /// <returns></returns>
        public static long ToTimestamp(this DateTime dateTime, bool milliseconds = false)
        {
            var timestamp = dateTime.ToUniversalTime() - TimestampStart;
            return (long)(milliseconds ? timestamp.TotalMilliseconds : timestamp.TotalSeconds);
        }

    }
}
