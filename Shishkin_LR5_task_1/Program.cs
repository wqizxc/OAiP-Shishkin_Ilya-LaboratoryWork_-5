using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Shishkin_LR5_task_1
{
    class Program
    {
        static void Main()
        {
            HoursToMinute converter = new HoursToMinute();
            int h, m;
            converter.Read(out h, out m);
            int total = converter.Minutes(h, m);
            converter.Display(h, m, total);
        }
    }
}