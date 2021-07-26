using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyMessAppWin.Backend_Services
{
    public class ImageProcessor
    {
        public static Bitmap StringToBitmap(string imageData)
        {
            byte[] a = Convert.FromBase64String(imageData);

            MemoryStream ms = new MemoryStream();
            ms.Write(a, 0, Convert.ToInt32(a.Length));

            Bitmap imageBitmap =  new Bitmap(ms, false);
            ms.Dispose();

            return imageBitmap;
        }
    }
}
