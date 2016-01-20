using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeathStar
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeathStar deathStar = new DeathStar();

            deathStar.FloatOminously();
            deathStar.PlayTheMusic();
            deathStar.SendEmail("dzanfox@gmail.com");
            Console.ReadLine();
        }
    }
}
