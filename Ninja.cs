using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Ninja
    {
        //Ninja
        public Ninja(int defLife, int defAttack, int defEnergy)
        {
            Lifepoints = LifepointsMax = defLife; //Ninja LIfe
            Attack = AttackMax = defAttack; //Ninja Main Attack
            Energy = EnergyMax = defEnergy;  //Ninja Main Energy
        }
        // Basic Attack
        public void Slash(ref Ninja target)
        {
            target.Lifepoints -= this.Attack;
        }

        //Special
        public void Backslash(ref Ninja target)
        {
            if (this.Energy >= 60)
            {
                this.Energy -= 60;
                target.Lifepoints -= 80;

            }
        }

        //Special
        public void Amaterasu (ref Ninja target)
        {
            if (this.Energy >= 80)
            {
                this.Energy -= 80;
                target.Lifepoints -= 110;
                target.Attack -= 10;
            }
        }

        //Spcial
        public void Kamui (ref Ninja target)
        {
            if (this.Energy >= 70)
            {
                this.Energy -= 60;
                target.Lifepoints -= 20;
                target.Attack -= 10;
            }
        }

        //Special
        public void Yamimahou (ref Ninja target)
        {
            if (this.Energy >= 50)
            {
                this.Energy -= 50;
                target.Lifepoints -= 30;
                target.Attack -= 20;
            }
        }

        //Add energy per turn
        public void EnergyRestore(ref Ninja target)
        {
            Energy += 10;
        }

        //Rest
        public void Heal(ref Ninja target)
        {
            Lifepoints += 20;
            Energy += 20;
        }
        //Energize
        public void PowerUp(ref Ninja target)
        {
            Attack += 10;
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
