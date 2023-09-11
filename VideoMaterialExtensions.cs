using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A14;

namespace A15
{
    public static class VideoMaterialExtensions
    {
        public static VideoMaterial Clone(this VideoMaterial entity)
        {
            return new VideoMaterial
            {
                Id = entity.Id,
                Description = entity.Description,
                VideoUri = entity.VideoUri,
                ThumbnailUri = entity.ThumbnailUri,
                Format = entity.Format,
                Version = (byte[])entity.Version.Clone()
            };
        }
    }
}
