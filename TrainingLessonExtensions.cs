using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A11;


namespace A12
{
    public static class TrainingLessonExtensions
    {
        public static void GenerateId(this TrainingLesson entity)
        {
            entity.Id = Guid.NewGuid().ToString();
        }
    }
}