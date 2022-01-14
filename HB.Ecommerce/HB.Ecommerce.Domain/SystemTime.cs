using System;
using System.Collections.Generic;
using System.Text;

namespace HB.Ecommerce.Domain.SeedWork
{
    public static class SystemTime
    {
        private static int systemHour = 0;

        public static DateTime Now = new DateTime(2022, 01, 14, systemHour, 0, 0);

        public static void IncreaseTime(int hour)
        {
            systemHour += hour;
        }
        public static void SystemTimeReset()
        {
            systemHour = 0;
        }


    }
}
