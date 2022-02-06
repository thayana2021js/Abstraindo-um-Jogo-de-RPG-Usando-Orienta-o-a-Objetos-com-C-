//PROGRAMA ORIENTAÇÃO A OBJETO- PROJETO_DIO_
using System;
using DOTNET__POO.src.Entities;

namespace Dotnet_POO
{
    class Program
    {
       static void Main(string[] args)
        {

            //Programa orientado a objeto.Paramentros.

            Knight arus = new Knight("Arus", 23, "Knigth");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            

            Console.WriteLine(arus.Attack()); 
            Console.WriteLine(wizard.Attack(1));

        }

    }
}

 