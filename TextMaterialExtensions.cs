using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A9;



namespace A10
{
    public static class TextMaterialExtensions
    {
        public static TextMaterial Clone(this TextMaterial entity)
        {
            return new TextMaterial
            {
                Id = entity.Id,
                Description = entity.Description,
                Text = entity.Text
            };
        }
    }

}
