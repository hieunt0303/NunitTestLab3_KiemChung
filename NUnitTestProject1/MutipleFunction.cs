using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class MutipleFunction
    {

        public bool checkNamNhuan(int year)
        {
            return ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) ? true : false;
        }
        public int DayInMonth(int year, int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        return 31;
                    }
                case 2:
                    {
                        if (checkNamNhuan(year))
                            return 29;
                        else
                            return 28;
                    }
                default:
                    return 30;
            }
        }
        public bool CheckDate(int day, int month, int year)
        {
            if (month >= 1 && month <= 12)
            {
                if (day >= 1)
                {
                    if (day <= DayInMonth(year, month))
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
