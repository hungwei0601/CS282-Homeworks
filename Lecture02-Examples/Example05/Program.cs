using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "盧弘偉",
                Birthday = "0601",
                Email = "hungwei0601@gmail.com",
                Orientation = 0.0,
                Pos = Position.Generate()
            };
            Console.WriteLine("請指定方形邊長:");
            double width = 0.0;
            bool success = double.TryParse(Console.ReadLine(), out width);
            if (success)
                person.DrawSquare(width);
            else
                Console.WriteLine("輸入錯誤,請重新執行!");
        }
    }
}