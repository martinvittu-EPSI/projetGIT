﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GestionEtudiants.Forms;

namespace GestionEtudiants
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() // ceci est un test
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListeEtudiantsForm());
        }
    }
}
