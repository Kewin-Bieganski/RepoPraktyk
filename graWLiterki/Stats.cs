﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graWLiterki
{
    internal class Stats
    {
        public int total = 0;
        public int missed = 0;
        public int correct = 0;
        public int accuracy = 0;

        public void Update(bool correctKey)
        {
            total++;

            if (!correctKey)
            {
                missed++;
            }
            else
            {
                correct++;
            }

            accuracy = 100 * correct / total;
        }
    }
}
