using System;
using System.Collections.Generic;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harversters;
    private Dictionary<string, Provider> providers;

    public DraftManager()
    {
        this.harversters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];

        var sb = new StringBuilder();

        try
        {
            switch (type)
            {
                case "Hammer":
                    var id = arguments[1];
                    var oreOutput = float.Parse(arguments[2]);
                    var energyRequirement = float.Parse(arguments[3]);
                    harversters.Add(id, new HammerHarvester(id, oreOutput, energyRequirement));
                    break;
                case "Sonic":
                    id = arguments[1];
                    oreOutput = float.Parse(arguments[2]);
                    energyRequirement = float.Parse(arguments[3]);
                    var sonicFactor = int.Parse(arguments[4]);
                    harversters.Add(id, new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor));
                    break;
            }

            var harvester = harversters[arguments[1]];
           
            sb.AppendLine($"Successfully registered {type} Harvester – {harvester.Id}");
        }
        catch (ArgumentException er)
        {
            sb.AppendLine(er.Message);
        }
        
        return sb.ToString().Trim();
    }

    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];

        var sb = new StringBuilder();

        try
        {
            switch (type)
            {
                case "Solar":
                    var id = arguments[1];
                    var energyOutput = float.Parse(arguments[2]);
                    providers.Add(id, new SolarProvider(id, energyOutput));
                    break;
                case "Pressure":
                    id = arguments[1];
                    energyOutput = float.Parse(arguments[2]);
                    providers.Add(id, new PressureProvider(id, energyOutput));
                    break;
            }

            var provider = providers[arguments[1]];

            sb.AppendLine($"Successfully registered {type} Provider – {provider.Id}");
        }
        catch(ArgumentException er)
        {
            sb.AppendLine(er.Message);
        }

        return sb.ToString().Trim();
    }

    public string Day()
    {
        return "";
    }

    public string Mode(List<string> arguments)
    {
        return "";
    }

    public string Check(List<string> arguments)
    {
        var sb = new StringBuilder();

        var id = arguments[0];

        if (harversters.ContainsKey(id))
        {
            var harvester = harversters[id];

            sb.AppendLine($"{harvester.Type} Harvester – {harvester.Id}");
            sb.AppendLine($"Ore Output: {harvester.OreOutput}");
            sb.AppendLine($"Energy Requirement: {harvester.EnergyRequirement}");
        }
        else if (providers.ContainsKey(id))
        {
            var provider = providers[id];

            sb.AppendLine($"{provider.GetType().Name} Provider – {provider.Id}");
            sb.AppendLine($"Energy Output: {provider.EnergyOutput}");
        }
        else
        {
            sb.AppendLine($"No element found with id – {id}.");
        }

        return sb.ToString().Trim();
    }

    public string ShutDown()
    {
        return "";
    }

}

