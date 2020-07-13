using System;
using System.Linq.Expressions;

namespace PokemonDemo
{
    class Pokemon {
        private string name;
        private double Height;
        private double AttackMax;
        private double BlockMax;
        private Random rnd = new Random();

        public Pokemon()
        {
        }

        public Pokemon(string n,double H,double A, double B)
        {
            this.name = n;
            this.Height = H;
            this.AttackMax = A;
            this.BlockMax = B;
        }
        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }


        public override string ToString()
        {
            return " Name " + name + " Height " + Height + " AttackMAX " + AttackMax + " BlockMAX " + BlockMax + " Attack " + Attack() + " Block " + Block();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon ace = new Pokemon("Cường", 18, 20, 25);
            
             Console.WriteLine(ace.ToString());
            


        }
    }
}
