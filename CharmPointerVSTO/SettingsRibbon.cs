using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace CharmPointerVSTO
{
    public partial class SettingsRibbon
    {
        private void SettingsRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            var pointerForm = Globals.ThisAddIn.pointerForm;
            toggleButtonEnabled.Checked = pointerForm.IsEnabled;
            editBoxDuration.Text = pointerForm.ShowDuration.ToString("F2");
            editBoxShowVelocityThreshold.Text = pointerForm.showVelocityThreshold.ToString("F1");
            editBoxHideVelocityThreshold.Text = pointerForm.hideVelocityThreshold.ToString("F1");
        }

        private void toggleButtonEnabled_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.pointerForm.IsEnabled = toggleButtonEnabled.Checked;
        }

        private void editBoxDuration_TextChanged(object sender, RibbonControlEventArgs e)
        {
            double value;
            if (double.TryParse(((RibbonEditBox)sender).Text, out value))
            {
                Globals.ThisAddIn.pointerForm.ShowDuration = value;
            }
            else
            {
                ((RibbonEditBox)sender).Text = Globals.ThisAddIn.pointerForm.ShowDuration.ToString("F2");
            }
        }

        private void editBoxShowVelocityThreshold_TextChanged(object sender, RibbonControlEventArgs e)
        {
            double value;
            if (double.TryParse(((RibbonEditBox)sender).Text, out value))
            {
                Globals.ThisAddIn.pointerForm.showVelocityThreshold = value;
            }
            else
            {
                ((RibbonEditBox)sender).Text = Globals.ThisAddIn.pointerForm.showVelocityThreshold.ToString("F1");
            }

        }

        private void editBoxHideVelocityThreshold_TextChanged(object sender, RibbonControlEventArgs e)
        {
            double value;
            if (double.TryParse(((RibbonEditBox)sender).Text, out value))
            {
                Globals.ThisAddIn.pointerForm.hideVelocityThreshold = value;
            }
            else
            {
                ((RibbonEditBox)sender).Text = Globals.ThisAddIn.pointerForm.hideVelocityThreshold.ToString("F1");
            }

        }
    }
}
