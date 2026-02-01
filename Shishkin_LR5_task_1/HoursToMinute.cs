using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shishkin_LR5_task_1
{
    public class HoursToMinute
    {
        public void Read(out int hours, out int minutes)
        {
            Console.Write("Введите часы:");
            hours = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты:");
            minutes = int.Parse(Console.ReadLine());
        }
        public void Display(int hours, int minutes, int totalMinutes)
        {
            Console.WriteLine($"\nВремя:{hours} ч. {minutes} мин.");
            Console.WriteLine($"Всего минут {totalMinutes}");
        }
        public int Minutes(int hours, int minutes)
        {
            return hours * 60 + minutes;
        }
    }
}
