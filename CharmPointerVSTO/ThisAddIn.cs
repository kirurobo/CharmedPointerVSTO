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
        PointerForm pointerForm;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            pointerForm = new PointerForm();
            pointerForm.Show();

            Globals.ThisAddIn.Application.SlideShowBegin += Application_SlideShowBegin;
            Globals.ThisAddIn.Application.SlideShowEnd += Application_SlideShowEnd;

            Globals.ThisAddIn.Application.WindowActivate += Application_WindowActivate;
            Globals.ThisAddIn.Application.WindowDeactivate += Application_WindowActivate;
        }

        private void Application_WindowActivate(PowerPoint.Presentation Pres, PowerPoint.DocumentWindow Wn)
        {
            UpdatePointer();
        }

        private void Application_SlideShowBegin(PowerPoint.SlideShowWindow Wn)
        {
            pointerForm.SlideWindowRectangle = new System.Drawing.Rectangle(
               (int)Wn.Left, (int)Wn.Top, (int)Wn.Width, (int)Wn.Height
               );
            //pointerForm.Show();
        }

        private void Application_SlideShowEnd(PowerPoint.Presentation Pres)
        {
            //pointerForm.Hide();
        }

        private void UpdatePointer()
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
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
