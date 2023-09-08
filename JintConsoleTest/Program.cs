using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jint;
using Jint.Runtime.Interop;

namespace JintConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 读取JavaScript脚本文件
            string inputPath = @"C:\Users\45486\Desktop\test.js";
            string script = System.IO.File.ReadAllText(inputPath);

            string inputPath2 = @"C:\Users\45486\Desktop\test2.js";
            string script2 = System.IO.File.ReadAllText(inputPath2);
            // 实例化JINT解释器并执行JavaScript脚本
            var engine = new Engine();
            //var engine = new Engine(options =>
            //{
            //    options.SetTypeResolver(new TypeResolver
            //    {
            //        MemberNameComparer = StringComparer.Ordinal
            //    });
            //});
            engine.Execute(script2);
            engine.SetValue("cm", new TestClass());

            // 调用JavaScript中的函数
            //var result = engine.Invoke("add", 1, 2);
            //Console.WriteLine($"调用了JavaScript中的add(1, 2)函数，结果为：{result}");
            engine.Invoke("test");
            var c = engine.GetValue("c");
            Console.WriteLine($"获取了JavaScript中的c变量，值为：{c}");
            Console.ReadKey();
        }
    }

    public class TestClass
    {
        public void Test()
        {
            Console.WriteLine("js to C# test start!");
        }

        public void Test2()
        {
            Console.WriteLine("js to C# test2 start!");
        }

        public Player getPlayer()
        {
            return new Player();
        }
    }

    public class Player
    {
        public void test()
        {
            Console.WriteLine("js to C# Player start!");
        }
    }
}
