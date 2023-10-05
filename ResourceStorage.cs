﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment
{
    public class ResourceStorage
    {
        private static ResourceStorage? instance;
        public int CoalStorage = 0;
        public int UraniumStorage = 0;
        public int HeliumStorage = 0;
        public int AntimatterStorage = 0;
        public int EnergyStorage = 0;

        public ResourceStorage() { }

        public static ResourceStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResourceStorage();
                }
                return instance;
            }
        }

    }
}
