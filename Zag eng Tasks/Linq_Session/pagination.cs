using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ3
{
    public static class Extensions
    {
        public static IEnumerable<T> Paginate<T>(
            this IEnumerable<T> source,
            int page = 1,
            int size = 10)
        {
            if (page <= 0)
                page = 1;

            if (size <= 0)
                size = 10;

            var totalItems = source.Count(); // 46 size = 10 {10, 10, 10, 10, 6}

            var totalPages = (int)Math.Ceiling((decimal)totalItems / size); // 

            var data = source // 2 - {11-20}
                .Skip((page - 1) * size)
                .Take(size)
                .ToList();

            return data;
        }
    }

}