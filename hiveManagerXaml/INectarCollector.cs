using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiveManager
{
    internal interface INectarCollector
    {
        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }
}
