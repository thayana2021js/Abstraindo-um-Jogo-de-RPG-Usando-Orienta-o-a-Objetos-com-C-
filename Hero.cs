using System;
using DOTNET__POO.src.Entities;

namespace DOTNET__POO.src.Entities
{
    public class  Hero
    {
        public Hero(string Name, int Level, string HeroType ){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
           
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){   //sobrescrita de método.
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }
    }    
}
