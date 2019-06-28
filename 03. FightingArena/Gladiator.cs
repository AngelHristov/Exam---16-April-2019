using System.Text;

namespace FightingArena
{
    public class Gladiator
    {

        //        •	Name: string
        //•	Stat: Stat
        //•	Weapon: Weapon
        //•	GetTotalPower() : int – return the sum of the stat properties plus the sum of the weapon properties.
        //•	GetWeaponPower() : int - return the sum of the weapon properties.
        // •	GetStatPower(): int - return the sum of the stat properties.

        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }
        public int GetWeaponPower()
        {
            int weaponPower = Weapon.Sharpness + Weapon.Size + Weapon.Solidity;

            return weaponPower;
        }

        public int GetStatPower()
        {
            int statPower = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            return statPower;
        }

        public int GetTotalPower()
        {
            int TotalPower = GetStatPower() + GetWeaponPower();

            return TotalPower;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} - {GetTotalPower()}");
            sb.AppendLine($"  Weapon Power: {GetWeaponPower()}");
            sb.AppendLine($"  Stat Power: {GetStatPower()}");

            return sb.ToString();
        }
    }
}
