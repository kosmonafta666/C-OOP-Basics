﻿using System;

class SonicHarvester : Harvester
{
    private int sonicFactor;

    public int SonicFactor
    {
        get { return this.sonicFactor; }
        private set { this.sonicFactor = value; }
    }

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        :base (id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement /= this.SonicFactor;
    }
}

