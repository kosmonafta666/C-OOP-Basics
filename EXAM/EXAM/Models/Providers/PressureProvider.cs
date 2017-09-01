using System;

public class PressureProvider : Provider
{
    public PressureProvider(string id, float energyOutput)
        :base(id, energyOutput)
    {
        this.EnergyOutput += (base.EnergyOutput / 100) * 50;
    }
}

