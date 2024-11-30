using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Utils
{
    public class Utilities
    {
        public static void Mensaje(string msg, bool IsError = false) {
            if (IsError)
            {
                MessageBox.Show(msg, "Tienda.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show(msg, "Tienda.", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        
        }
    }
}
