using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestorFuentes
    {
        public static string GetTimes()
        {
            string fontName = "times";
            if (!FontFactory.IsRegistered(fontName))
            {
                var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\Fonts\\times.ttf";
                FontFactory.Register(fontPath, fontName);
            }
            return fontName;
        }
    }
}
