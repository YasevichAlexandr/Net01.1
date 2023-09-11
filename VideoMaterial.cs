using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A2;
using A7;
using A13;


namespace A14
{
    public class VideoMaterial : Material, IVersionable
    {
        public string VideoUri { get; set; }
        public string ThumbnailUri { get; set; }
        public VideoFormat Format { get; set; }
        public byte[] Version { get; set; }

        public override string ToString()
        {
            return VideoUri;
        }

        public byte[] GetVersion()
        {
            return (byte[])Version.Clone();
        }

        public void SetVersion(byte[] version)
        {
            Version = (byte[])version.Clone();
        }
    }
}