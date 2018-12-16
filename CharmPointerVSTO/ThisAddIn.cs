using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.ComponentModel;
using System.Windows.Forms;

namespace CharmPointerVSTO
{
    public partial class ThisAddIn
    {
        BackgroundWorker mainLoopWorker;
        PowerPoint.SlideShowWindow window = null;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

            Globals.ThisAddIn.Application.SlideShowBegin += Application_SlideShowBegin;
            Globals.ThisAddIn.Application.SlideShowEnd += Application_SlideShowEnd;

        }

        private void Application_SlideShowBegin(PowerPoint.SlideShowWindow Wn)
        {
            mainLoopWorker = new BackgroundWorker();
            mainLoopWorker.DoWork += MainLoopWorker_DoWork;
            mainLoopWorker.WorkerSupportsCancellation = true;

            window = Wn;
            mainLoopWorker.RunWorkerAsync();
        }

        private void Application_SlideShowEnd(PowerPoint.Presentation Pres)
        {
            mainLoopWorker.CancelAsync();
            mainLoopWorker = null;
            window = null;
        }


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            if (mainLoopWorker != null)
            {
                mainLoopWorker.CancelAsync();
            }
        }

        private void MainLoopWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            PointerForm pointerForm;
            pointerForm = new PointerForm();
            pointerForm.Show();

            Console.WriteLine("Slideshow started!");

            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending && (window != null))
            {
                int wx = 0;
                int wy = 0;

                // タイミングにより途中で window が無くなることもあるため try{} を利用
                try
                {
                    wx = (int)window.Left;
                    wy = (int)window.Top;
                }
                catch
                {
                    wx = 0;
                    wy = 0;
                }

                var pos = Control.MousePosition;
                pointerForm.SetPosition(pos);
            }

            e.Cancel = true;
            pointerForm.Close();
        }


        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
