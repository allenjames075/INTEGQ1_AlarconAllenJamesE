using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Training
    {
        
            static int numberofTraining;
            public Training()  //constructor
            {
                numberofTraining++;
            }

            private List<Training> _trainings = new List<Training>();
            public DateTime Participate { get; set; }

            private string _trainingNumber;

            public string TrainingNumber
            {
                get
                {
                    return _trainingNumber;
                }
                set
                {
                    _trainingNumber = value;
                }

            }
            private string _trainingType;

            public string TrainingType
            {
                get
                {
                    return !string.IsNullOrEmpty(_trainingType) ? _trainingType : "Visual";
                }
                set
                {
                    _trainingType = !string.IsNullOrEmpty(value) ? value : "Visual";
                }
            }

            public TrainingType TrainingName { get; set; }
            public int Quantity { get; private set; }

            public DateTime ReceivedDate { get; set; }

            public void AddTrainingList(Training training)
            {
                if (training.Quantity > 0)
                {
                    _trainings.Add(training);
                }
            }

            public List<Training> GetTrainings()
            {
                return _trainings;
            }
        }
    }

