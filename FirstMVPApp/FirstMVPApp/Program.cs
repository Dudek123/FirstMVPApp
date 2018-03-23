using FirstMVPApp.Models;
using FirstMVPApp.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstMVPApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Models.FirstMVPAppModel model = new Models.FirstMVPAppModel();
            FirstMVPAppView view = new FirstMVPAppView();
            FirstMVPAppPresenter presenter = new FirstMVPAppPresenter(model, view);

            Application.Run(view);
        }
    }
}
