﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MBlog.Forms;

namespace MBlog
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
