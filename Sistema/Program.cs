﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmlogin frm = new frmlogin();
            frm.ShowDialog();

            if (frm.logado == true)
            {
                
            }

            Application.Run(new frm_menu());
        }
    }
}
