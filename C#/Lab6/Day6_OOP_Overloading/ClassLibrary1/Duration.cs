using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        int total;
        public Duration()
        {
            
        }
        public Duration(int TotalSecs)
        {
            total = TotalSecs;
            Hours = TotalSecs / 3600;
            Minutes = (TotalSecs / 60) % 60;
            Seconds = TotalSecs % 60;
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else if (Minutes > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            else
                return $"Seconds: {Seconds}";
        }
        public static Duration operator +( Duration D1, Duration D2 )
        {
            Duration res = new Duration();
            res.Hours = D1.Hours + D2.Hours;
            res.Minutes = D1.Minutes + D2.Minutes;  
            res.Seconds = D1.Seconds + D2.Seconds;      
            return res;
        }
        public static Duration operator +( Duration D1, int secs )
        {
            Duration tmp = new Duration(secs);
            Duration res = new Duration();
            res.Hours = D1.Hours + tmp.Hours;
            res.Minutes = D1.Minutes + tmp.Minutes;  
            res.Seconds = D1.Seconds + tmp.Seconds;      
            return res;
        }  
        public static Duration operator +( int secs, Duration D2 )
        {
            Duration tmp = new Duration(secs);
            Duration res = new Duration();
            res.Hours = D2.Hours + tmp.Hours;
            res.Minutes = D2.Minutes + tmp.Minutes;  
            res.Seconds = D2.Seconds + tmp.Seconds;      
            return res;
        } 
        public static Duration operator ++( Duration D )
        {
            if (D.Minutes == 60)
            {
                D.Hours++;
                D.Minutes = 0;
            }
            else
                D.Minutes++;
            return D;
        }  
        public static Duration operator --( Duration D )
        {
            if (D.Minutes == 0)
            {
                D.Hours--;
                D.Minutes = 59;
            }
            else
                D.Minutes--;
            return D;
        } 
        public static bool operator >( Duration D1, Duration D2 )
        {
            return D1.total > D2.total; 
        }  
        public static bool operator <( Duration D1, Duration D2 )
        {
            return D1.total < D2.total;
        }
        public static bool operator >=( Duration D1, Duration D2 )
        {
            return D1.total >= D2.total;
        }
        public static bool operator <=( Duration D1, Duration D2 )
        {
            return D1.total <= D2.total;
        }
        public static explicit operator DateTime( Duration D )
        {
            return new DateTime(2024, 7, 16, D.Hours, D.Minutes, D.Seconds);
        }
    }
}
