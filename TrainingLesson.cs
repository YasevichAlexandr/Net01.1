using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A1;
using A2;
using A3;
using A4;
using A5;
using A7;
using A9;
using A10;
using A14;
using A15;

namespace A11
{
    public class TrainingLesson : IVersionable, ICloneable<TrainingLesson>
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public LessonType LessonType { get; private set; }
        public Material[] Materials { get; set; }
        public byte[] Version { get; set; }

        public TrainingLesson()
        {
            LessonType = LessonType.TextLesson;
        }

        public LessonType GetLessonType()
        {
            foreach (var material in Materials)
            {
                if (material is VideoMaterial)
                {
                    LessonType = LessonType.VideoLesson;
                    break;
                }
            }

            return LessonType;
        }

        public override string ToString()
        {
            return Description;
        }

        public byte[] GetVersion()
        {
            return (byte[])Version.Clone();
        }

        public void SetVersion(byte[] version)
        {
            Version = (byte[])version.Clone();
        }

        public TrainingLesson Clone()
        {
            var clonedLesson = new TrainingLesson
            {
                Id = Id,
                Description = Description,
                LessonType = LessonType,
                Version = (byte[])Version.Clone()
            };

            clonedLesson.Materials = new Material[Materials.Length];
            for (int i = 0; i < Materials.Length; i++)
            {
                if (Materials[i] is TextMaterial)
                {
                    clonedLesson.Materials[i] = ((TextMaterial)Materials[i]).Clone();
                }
                else if (Materials[i] is VideoMaterial)
                {
                    clonedLesson.Materials[i] = ((VideoMaterial)Materials[i]).Clone();
                }
                else if (Materials[i] is LinkMaterial)
                {
                    clonedLesson.Materials[i] = ((LinkMaterial)Materials[i]).Clone();
                }
            }

            return clonedLesson;
        }
    }


}
