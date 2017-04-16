using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Task6
{
    class PushEx
    {
        public static void Run()
        {
            var source = new Subject<Hamburger>();

            source
                .Sample(TimeSpan.FromSeconds(1.0))
                .Subscribe(x => Console.WriteLine($"received {x}"))
                ;

            var t = new Thread(() =>
            {
                int i = 0;
                Hamburger myBurger = new Hamburger(i);
                while (true)
                {
                    Thread.Sleep(250);
                    source.OnNext(myBurger);
                    Console.WriteLine($"sent {myBurger}");
                    i++;
                }
            });
            t.Start();
        }
    }
}
