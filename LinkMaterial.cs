using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using A6;
using A7;


namespace A4
{
    public class LinkMaterial : Material
    {
        public string ContentUri { get; set; }
        public LinkType Type { get; set; }

        public override string ToString()
        {
            return ContentUri;
        }
    }
}