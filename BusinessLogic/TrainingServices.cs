using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace BusinessLogic
{
    public class TrainingServices
    {
        private List<Training> _trainings = new List<Training>();
        public void AddTrainingList(Training training)
        {
            if (training.Quantity > 0)
            {
                _trainings.Add(training);
            }
        }

        private List<Training> _training = new List<Training>();
        public void DeleteTrainingList(Training training)
        {
            if (training.Quantity > 0)
            {
                _training.Add(training);
            }
        }


    }
}
