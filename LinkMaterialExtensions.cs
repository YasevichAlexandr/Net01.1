using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using A4;


namespace A5
{
    public static class LinkMaterialExtensions
    {
        public static LinkMaterial Clone(this LinkMaterial entity)
        {
            return new LinkMaterial
            {
                Id = entity.Id,
                Description = entity.Description,
                ContentUri = entity.ContentUri,
                Type = entity.Type
            };
        }
    }
}
