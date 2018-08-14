using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skylum_com
{
    class Gallery
    {
        public string ImagePath { get; set; }

        public Gallery(string img)
        {
            ImagePath = img;
        }
        public Gallery(){}
    }
}
