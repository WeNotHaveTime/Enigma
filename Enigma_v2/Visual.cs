using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Enigma
{
    public static class Visual
    {
        public static void VisualLoad(double Opacity)
        {
            Opacity = 0;
            while (Opacity < 1)
            {
                Thread.Sleep(1);
                Opacity += 0.025;
            }
            


        } // Плавне появлення форми
        public static void VisualClose(double Opacity)
        {
            Opacity = 1;
            while (Opacity > 0)
            {
                Thread.Sleep(1);
                Opacity += 0.025;
            }
        }
    }
}
