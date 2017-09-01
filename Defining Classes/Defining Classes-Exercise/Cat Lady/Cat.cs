namespace Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Cat
    {
        private string name;
        private string breed;
        private string personalData;

        public string Name
        {
            get { return this.name; }

            private set { this.name = value; }
        }

        public string Breed
        {
            get { return this.breed; }

            private set { this.breed = value; }
        }


        public string PersonalData
        {
            get { return this.personalData; }

            private set { this.personalData = value; }
        }

        public Cat(string name, string breed, string personalData)
        {
            this.Name = name;

            this.Breed = breed;

            this.PersonalData = personalData;
        }

        public override string ToString()
        {
            if (this.Breed == "Cymric")
            {
                var parsedData = double.Parse(this.PersonalData);

                return $"{this.Breed} {this.Name} {parsedData:f2}";
            }
            else
            {
                return $"{this.Breed} {this.Name} {this.PersonalData}";
            }           
        }
    }
}
