﻿using BenchmarkDotNet.Running;

namespace ThreadCalculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}