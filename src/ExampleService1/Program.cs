﻿using System;
using Nancy;
using Shared;

namespace ExampleService1
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.StartServices("ExampleService1");
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
