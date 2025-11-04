using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class FormHelper
    {
        public static void ResetForm(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (ctrl is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
                else if (ctrl is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (ctrl is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (ctrl is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (ctrl is GroupBox || ctrl is Panel || ctrl is TabPage)
                {
                    // Nếu Control là GroupBox, Panel, hoặc TabPage, duyệt tiếp các control con
                    ResetForm(ctrl);
                }
            }
        }
    }
}
