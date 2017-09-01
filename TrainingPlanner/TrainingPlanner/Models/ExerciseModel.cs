using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPlanner.Components;

namespace TrainingPlanner.Models
{
  public class ExerciseModel
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Image> Photos { get; set; }
    public Tags Tags { get; set; }

  }
}
