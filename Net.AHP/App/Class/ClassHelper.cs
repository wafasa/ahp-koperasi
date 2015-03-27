using System;
using System.Globalization;
using System.Windows.Forms;

namespace helper.Class
{
    static class ClassHelper
    {

        public static bool AlmostEquals(this double double1, double double2, double precision)
        {
            return (Math.Abs(double1 - double2) <= precision);
        }

        public static void ClearTextBox(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                var textBox = c as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }
                if (c.HasChildren)
                {
                    ClearTextBox(c);
                }
            }
        }

        public static void SetReadOnlyOnTextBox(Control ctrl, bool readOnly)
        {
            if (ctrl is TextBoxBase)
                ((TextBoxBase)ctrl).ReadOnly = readOnly;
            foreach (Control control in ctrl.Controls)
                SetReadOnlyOnTextBox(control, readOnly);
        }

        public static string[] ToStringArray(this int[] intArray)
        {
            return Array.ConvertAll<int ,string>(intArray, intParameter => intParameter.ToString(CultureInfo.InvariantCulture));
        }

        public static int[] ToIntArray(this string[] strArray)
        {
            return Array.ConvertAll<string, int>(strArray, intParameter => int.Parse(intParameter.ToString(CultureInfo.InvariantCulture)));
        }
    }
}
