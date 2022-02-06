using System;
namespace DOTNET__POO.src.Entities
{
    public class Arus : Hero
    {
         public Arus(string Name, int Level, string HeroType ){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

            public override string Attack(){
            return this.Name + "  Atacou com a sua espada";

        }    

        
    }
}





// arus guerreiro