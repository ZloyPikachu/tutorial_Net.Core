﻿using System;
using Newtonsoft.Json;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonConvert.SerializeObject(args));
            Console.WriteLine("Hello World!");
        }
    }
}
