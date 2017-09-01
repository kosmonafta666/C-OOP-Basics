namespace Wild_farm.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Felime : Mamal
    {
        protected Felime(string animalType, string animalName, double animalWeight, string livingRegion)
            :base (animalType, animalName, animalWeight, livingRegion)
        {
        }
    }
}
