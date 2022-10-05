﻿using System;
using System.Text.Json;
using System.Xml.Linq;
using ClassLibraryPart_2;


namespace TaskForSturtUp
{

    public partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonSerializer.Serialize(new Node<int>()));
            var testing = new Testing();
            Console.WriteLine("---TestAdd---");
            testing.TestAdd();
            Console.WriteLine("---TestDownload---");
            testing.TestDownload();
            Console.WriteLine("---TestFind---");
            testing.TestFind();
        }
    }
}