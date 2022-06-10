using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Moq
{
    public static class MoqDatas
    {
        /// <summary>
        /// Возвращает список тестовых данных
        /// </summary>
        /// <returns></returns>
        public static List<int> GetListInt() 
        {
            List<int> result = new List<int>
            {
                1,2,3,4,5,6,7,8,9
            };

            return result;
        }

    }
}
