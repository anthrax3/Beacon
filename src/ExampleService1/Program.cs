﻿using System;
using Nancy;
using Beacon;

namespace ExampleService1
{
    class Program
    {
        static void Main(string[] args)
        {
            BeaconService.Start("MyService" + DateTime.Now);
        }
    }

    public class MyModule : NancyModule
    {
        public MyModule ()
        {
            Get["/"] = _ =>
            {
                return "hello";
            };
        }
    }
}