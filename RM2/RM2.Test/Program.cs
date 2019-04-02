﻿using RM2.Framework.IceAop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RM2.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("控制台测试程序");
            IAopBehavior aopBehavior = AopExtend.Container().Resolve<IAopBehavior>();
            aopBehavior.Show();
            Console.Read();
        }
    }
}