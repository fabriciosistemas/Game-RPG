using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.src.Entities
{
    class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base()
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = this.Level * 100;
        }
    }
}
