using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base()
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = Level * 100;
        }
        public override string Attack(Hero hero)
        {
            return this.Name + " lançou magia.";
        }

        public string Attack(int Bonus, Hero hero)
        {
            hero.HP -= this.Level + Bonus;
            if (Bonus > 6)
                return this.Name + " lançou magia super efetiva com bônus de " + Bonus + " e dano de " + (Bonus + this.Level);

            return this.Name + " lançou magia fraca com bônus de " + Bonus + " e dano de " + (Bonus + this.Level);
        }
    }
}
