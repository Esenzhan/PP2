﻿using System;
using System.IO;

namespace FarMan
{
    class Far_man
    {
        public int kursor;
        public int sz;
        bool ok;
        public Far_man()
        {
            kursor = 0;

        }
        public void Color(FileSystemInfo fs, int index)
        {
            if (kursor == index)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void show(string path)
        {
            int index = 0;

            DirectoryInfo dir = new DirectoryInfo(path);
            FileSystemInfo[] filesystem = dir.GetFileSystemInfos();
            sz = filesystem.Length;
            foreach (FileSystemInfo fs in filesystem)
            {
                if (ok && fs.Name.StartsWith("."))
                {
                    sz--;
                    continue;
                }
                Color(fs, index);
                Console.WriteLine(fs.Name);
                index++;
            }
        }
        public void up()
        {
            if (kursor == 0)
                kursor = sz - 1;
            else
                kursor--;
        }
        public void down()
        {
            if (kursor == sz - 1)
                kursor = 0;
            else
                kursor++;
        }

        public void Start(string path)
        {
            DirectoryInfo director = new DirectoryInfo(path);

            ConsoleKeyInfo consolekey = Console.ReadKey();
            FileSystemInfo fs = null;
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                show(path);
                consolekey = Console.ReadKey();
                if (consolekey.Key == ConsoleKey.Escape)
                {
                    kursor = 0;
                    director = director.Parent;
                    path = director.FullName;
                }
                else if (consolekey.Key == ConsoleKey.UpArrow)
                {
                    up();
                }
                else if (consolekey.Key == ConsoleKey.DownArrow)
                {
                    down();
                }
                else if (consolekey.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    kursor = 0;
                }
                else if (consolekey.Key == ConsoleKey.LeftArrow)
                {
                    ok = true;
                    kursor = 0;
                }
                else if (consolekey.Key == ConsoleKey.Enter)
                {
                    int k = 0;
                    for (int i = 0; i < director.GetFileSystemInfos().Length; i++)
                    {
                        if (ok && director.GetFileSystemInfos()[i].Name.StartsWith("."))
                            continue;
                        if (kursor == k)
                        {
                            fs = director.GetFileSystemInfos()[i];
                            break;
                        }
                        k++;
                    }
                    if (fs.GetType() == typeof(DirectoryInfo))
                    {
                        kursor = 0;
                        director = new DirectoryInfo(fs.FullName);
                        path = fs.FullName;
                    }
                    
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Far_man farmanager = new Far_man();
                farmanager.Start(@"C:\Users\123\Desktop\PP2");
            }
        }
    }
}