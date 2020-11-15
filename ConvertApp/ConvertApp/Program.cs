using System;
using ConvertApp.controller;

namespace ConvertApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertingController controller = new ConvertingController();
            controller.execution();
        }
    }
}
