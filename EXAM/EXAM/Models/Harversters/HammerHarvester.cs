using System;

public class HammerHarvester : Harvester
{
    public string Type = "Harvester";

    public HammerHarvester(string id, float oreOutput, float energyRequirement)
        :base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += (base.OreOutput / 100) * 200;
        this.EnergyRequirement += (base.EnergyRequirement / 100) * 100;
        this.Type = "Hammer";
    }
}

