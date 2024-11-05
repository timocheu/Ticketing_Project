using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_Project
{
    public class Utilities
    {
        public void Change_Font(Form form)
        {
            // Create a font variable
            PrivateFontCollection pfc = new PrivateFontCollection();
            // Locate the path of the font.ttf
            pfc.AddFontFile("C:\\Users\\ACT-STUDENT\\Desktop\\Ticketing_Project\\Ticketing_Project\\Resources\\Poppins-Regular.ttf");
            // Loop through all the characters in the forms and change it to the corresponding font
            foreach (Control c in form.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);
            }
        }
    }
}
