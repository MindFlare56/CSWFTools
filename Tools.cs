using System;
using System.Windows.Forms;

namespace CSWFTools
{

    static class Tools
    {        
    
        public static void AddListToComboBox<T>(ComboBox comboBox, List<T> list)
        {
            foreach (T element in list)
            {
                comboBox.Items.Add(element);
            }
        }
    }
}
