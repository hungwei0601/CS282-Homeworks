using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student someone = new Student();
            someone.name = "盧弘偉";
            Console.WriteLine("學生姓名:{0}", someone.name);
            someone.birthday = "1979年6月1日";
            Console.WriteLine("生日:{0}", someone.birthday);
            someone.email = "hungwei0601@gmail.com";
            Console.WriteLine("電子信箱:{0}", someone.email);
            someone.phone = "0912345678";
            Console.WriteLine("連絡電話:{0}", someone.phone);
            someone.phone = "38";
            Console.WriteLine("年齡:{0}", someone.phone);
        }
    }
}