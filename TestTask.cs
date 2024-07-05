using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode
{
    // public class TestTask
    // {


    //     public async Task<string> T1()
    //     {
    //         for (var i = 0; i < 5; i++)
    //         {
    //             Console.ForegroundColor = ConsoleColor.Red;
    //             Console.WriteLine($"T1 - {i}");
    //             Console.ResetColor();
    //             Thread.Sleep(1000);
    //         }
    //         await Task.CompletedTask;
    //         return "hoan thanh T1";
    //     }
    //     public async Task<string> T2()
    //     {
    //         for (var i = 0; i < 5; i++)
    //         {
    //             Console.ForegroundColor = ConsoleColor.Yellow;
    //             Console.WriteLine($"T2 - {i}");
    //             Console.ResetColor();
    //             Thread.Sleep(1000);
    //         }

    //         await Task.CompletedTask;
    //         return "hoan thanh T2";
    //     }
    // }
    public class TestTask
    {
        public async Task T1()
        {
            Task task = new Task(() =>
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"T1 - {i}");
                    Console.ResetColor();
                    //await Task.Delay(1000);
                    Thread.Sleep(1000);

                }
            });
            task.Start();
            await task;
            Console.WriteLine("hoan thanh T1");
        }

        public async Task T2()
        {
            Task task = new Task(() =>
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"T2 - {i}");
                    Console.ResetColor();
                    Thread.Sleep(1000);

                    //await Task.Delay(1000);
                }
            });
            task.Start();
            await task;

            Console.WriteLine("hoan thanh T1");
        }
    }

    public class TestTask1
    {
        public Task<string> T1()
        {
            return Task.Run(async () =>
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"T1 - {i}");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
                return "hoan thanh T1";
            });
        }

        public Task<string> T2()
        {
            return Task.Run(async () =>
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"T2 - {i}");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
                return "hoan thanh T2";
            });
        }
    }
}