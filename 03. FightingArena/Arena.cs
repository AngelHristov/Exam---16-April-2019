namespace FightingArena
{
    using System.Collections.Generic;
    using System.Linq;

    public class Arena
    {
        private List<Gladiator> gladiators;
        public string Name { get; set; }

        public Arena(string name)
        {
            Name = name;
            gladiators = new List<Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            gladiators.Remove(gladiators.FirstOrDefault(x => x.Name == name));
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return gladiators.OrderByDescending(x => x.GetStatPower()).FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return gladiators.OrderByDescending(x => x.GetWeaponPower()).FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return gladiators.OrderByDescending(x => x.GetTotalPower()).FirstOrDefault();
        }

        public int Count { get => gladiators.Count();} 

        public override string ToString()
        {
            return $"{Name} - {Count} gladiators are participating.";
        }
    }
}
