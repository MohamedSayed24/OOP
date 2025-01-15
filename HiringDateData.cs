using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_
{
    public class HiringDateData
    {
        int day;
        int month;
        int year;

        public HiringDateData(int d , int m , int y)
        {
            if (d <= 0 || d > 24)
            {
                throw new ArgumentOutOfRangeException("Day must be between 1 and 24");
            }
            else if (m <= 0 || m > 12)
            {
                throw new ArgumentOutOfRangeException("Month must be between 1 and 12");
            }
            else if (y <= 1950 || y > 2025)
            {
                throw new ArgumentOutOfRangeException("Year must be between 1950 and 2025 ");
            }
            day = d;
            month = m;
            year = y;
        }

        public override string ToString()
        {
            return $"Day: {day}\n Month: {month}\n Year: {year}";
        }

    }
}
