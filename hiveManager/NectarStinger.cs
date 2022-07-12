using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiveManager
{
    internal class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public int Nectar { get; set; }

        public NectarStinger(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg)
        {
        }

        public void FindFlowers()
        {
            throw new NotImplementedException();
        }

        public void GatherNectar()
        {
            throw new NotImplementedException();
        }

        public void ReturnToHive()
        {
            throw new NotImplementedException();
        }

        public bool LookForEnemies()
        {
            throw new NotImplementedException();
        }

        public int SharpenStinger(int Length)
        {
            throw new NotImplementedException();
        }
    }
}
