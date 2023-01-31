using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojeFinanse
{
    class MenuWForms
    {
        public static void NumericValuesOnly(object sender, KeyPressEventArgs Event)
        {
            var FreightTextBox = (sender as TextBox);
            Event.Handled = true;
            bool FalseInput = !char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar) && !char.IsControl(Event.KeyChar) && Event.KeyChar != 8 && Event.KeyChar != '.';
            if (!FalseInput)
            {
                Event.Handled = false;
                if (Regex.IsMatch(FreightTextBox.Text, @"^\d+\.\d*$") && Event.KeyChar != 8)
                {
                    bool ContainDot = FreightTextBox.Text.Contains(".");
                    Event.Handled = true;
                    if (ContainDot && Event.KeyChar != 8 && Event.KeyChar != '.')
                    {
                        Event.Handled = Regex.IsMatch(FreightTextBox.Text, @"\.\d\d");
                    }
                }
            }
        }
    }
}
