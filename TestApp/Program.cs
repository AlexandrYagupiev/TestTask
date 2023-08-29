using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Program
    {
        private static async Task<int> Main(string[] args)
        {
            var oneTask = Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Server.AddToCount(2);
                }
            });
            var twoTask = Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Server.AddToCount(2);
                }
            });
            var threeTask = Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Server.AddToCount(2);
                }
            });
            var fourTask = Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Server.AddToCount(2);
                }
            });
            await Task.WhenAll(oneTask, twoTask, threeTask, fourTask);
            Console.WriteLine(Server.GetCount());
            Console.ReadKey();
            return 0;
        }
    }
}
