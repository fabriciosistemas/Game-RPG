using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = this.Level * 100;
        }

        public Hero()
        {

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        public virtual string Attack(Hero hero)
        {
            hero.HP -= this.Level;
            return this.Name + " atacou com a sua espada e causou dano de " + this.Level;
        }

        public int RetornaHP()
        {
            return HP;
        }
    }
}
