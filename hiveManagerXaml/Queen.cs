using System;

namespace hiveManager
{
    internal class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssingWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, numberOfShifts))
                {
                    return true;
                }
            }
            return false;
        }
        
        public string WorkTheNextShift()
        {
            double honeyConsumed = HoneyConsumptionRate();
            shiftNumber++;
            string report = $"Raport zmiany numer {shiftNumber}\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumed += workers[i].HoneyConsumptionRate();
                if (workers[i].DidYouFinish())
                {
                    report += $"Robotnica numer {(i + 1)} zakończyła swoje zadanie \r\n";
                }
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    report += $"Robotnica numer {(i + 1)} nie pracuje \r\n";
                } else
                {
                    if (workers[i].ShiftsLeft > 0)
                    {
                        report += $"Robotnica numer {(i + 1)} robi '{workers[i].CurrentJob}' po tej zmiamie\r\n";
                    }
                }
            }
            report += $"Całkowite spożycie miodu: {honeyConsumed} jednostek\r\n";
            return report;
        }
    }
}
