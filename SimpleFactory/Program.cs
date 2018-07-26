using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂 案例：计算器
            var oper = OperationFactory.CreateOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            var result = oper.GetResult();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
