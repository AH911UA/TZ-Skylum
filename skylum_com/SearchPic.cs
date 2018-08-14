using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skylum_com
{
    class SearchPic
    {
        public static List<Gallery> GetPic()
        {
            List<Gallery> tmp = new List<Gallery>();

            foreach (var item in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\img\"))
                if (IsPicture(item))
                    tmp.Add(new Gallery(item));
            return tmp;
        }

        public static bool IsPicture(string file) =>
            file.EndsWith(".jpg") || file.EndsWith(".JPG") || file.EndsWith(".png")
            || file.EndsWith(".ico") || file.EndsWith(".bmp") ? true : false;
    }
}
