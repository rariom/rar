﻿using rar;
using System;
using System.Windows.Forms;

namespace rar
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Запуск с формы логина
        }
    }
}
