using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A7;


namespace A9
{
    public class TextMaterial : Material
    {
        public string Text
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}