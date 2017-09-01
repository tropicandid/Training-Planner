using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlanner.Components
{
  public class Tags
  {
    public ExerciseTagTypes ExerciseTags { get; set; }
  }
  public enum ExerciseTagTypes
  {
    // Different types of workouts EX: plyometric, cardio, yoga, etc.
  }
}
