using System;

public class SonicHarvester : Harvester
{
    private int sonicFactor;
   

    public int SonicFactor
    {
        get { return this.sonicFactor; }
        protected set
        {
            this.sonicFactor = value;
        }
    }

    public SonicHarvester(string id, float oreOutput, float energyRequirement, int sonicFactor)
        :base(id, oreOutput, energyRequirement)
    {
        this.EnergyRequirement = base.EnergyRequirement / sonicFactor;
        this.SonicFactor = sonicFactor;
        this.Type = "Sonic";
    }
}

