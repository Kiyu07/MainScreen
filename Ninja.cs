using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Ninja
    {
        public Ninja(int defLife, int defAttack, int defEnergy)
        {
            Lifepoints = LifepointsMax = defLife;
            Attack = AttackMax = defAttack;
            Energy = EnergyMax = defEnergy;
        }
        public void Slash(ref Ninja target)
        {
            target.Lifepoints -= this.Attack;
        }
        public void Backslash(ref Ninja target)
        {
            if (this.Energy >= 60)
            {
                this.Energy -= 60;
                target.Lifepoints -= 80;

            }
        }
        public void EnergyRestore(ref Ninja target)
        {
            Energy += 10;
        }
        public void Heal(ref Ninja target)
        {
            Lifepoints += 20;
            Energy += 20;
        }
        public void PowerUp(ref Ninja target)
        {
            Attack += 20;
            Energy += 10;
        }
        public int Lifepoints { get; set; }
        public int LifepointsMax { get; set; }
        public int Attack { get; set; }
        public int AttackMax { get; set; }
        public int Energy { get; set; }
        public int EnergyMax { get; set; }
    }
}
