﻿using System;

namespace Desktop_First_Game
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new DesktopGame())
                game.Run();
        }
    }
}
