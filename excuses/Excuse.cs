﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace excuses
{
    [Serializable]
    internal class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }
        
        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            ExcusePath = excusePath;
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }
        
        private void OpenFile(string excusePath)
        {
            this.ExcusePath = excusePath;
            BinaryFormatter formatter = new BinaryFormatter();
            Excuse tempExcuse;
            using(Stream input = File.OpenRead(excusePath))
            {
                tempExcuse = (Excuse)formatter.Deserialize(input);
            }
            Description = tempExcuse.Description;
            Results = tempExcuse.Results;
            LastUsed = tempExcuse.LastUsed;
        }

        public void Save(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream output = File.OpenWrite(fileName))
            {
                formatter.Serialize(output, this);
            }
        }
    }
}
