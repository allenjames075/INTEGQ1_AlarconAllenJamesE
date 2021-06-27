using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Exercise
    {
        static int numberofTraining;

        public Exercise()
        {

        }
        public string TraineeID { get; set; }
        public string TraineeNumber { get; set; }
        public string Category { get; set; }

        public TrainingUnitType UnitType { get; set; }
    }
}
