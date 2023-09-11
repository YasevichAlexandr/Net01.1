using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A7;


namespace A8
{
    public static class MaterialExtensions
    {
        public static void GenerateId(this Material entity)
        {
            entity.Id = Guid.NewGuid().ToString();
        }
    }
}