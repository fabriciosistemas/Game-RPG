using GameRPG.src.Entities;
using System;

namespace GameRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennifer", 23, "White Wizard");
            Console.WriteLine(hero.Attack(wizard));
            Console.WriteLine(wizard.Attack(1, hero));
            Console.WriteLine("\n------ Resultados após 2 turnos: ------\n");
            Console.WriteLine("Status de " + hero.Name + ": " + hero.RetornaHP() + " HP");
            Console.WriteLine("Status de " + wizard.Name + ": " + wizard.RetornaHP() + " HP");

        }
    }
}
