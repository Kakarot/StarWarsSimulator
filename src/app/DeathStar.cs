using System;
using static System.Console;
using static Newtonsoft.Json.JsonConvert;

namespace BattleSimulator
{
    public static class DeathStar
    {
        public static void Main(string[] args)
        {
            int kyloRenPower = RememberTheName(new Random(Guid.NewGuid().GetHashCode()).Next(1,201), 70, 10, 100);
            int pikachuPower = RememberTheName(new Random(Guid.NewGuid().GetHashCode()).Next(1,201), 30, 40, 0);

            WriteLine($"Pikachu's power is: {pikachuPower} units.");
            WriteLine($"Kylo's power is: {kyloRenPower} units.");
            WriteLine($"Kylo Ren obliterated Pikachu into {kyloRenPower-pikachuPower} space particles.");
        }

        private static int RememberTheName(int luck, int skill, int pleasure, int pain) =>
            DeserializeObject<int>($"{luck + skill + pleasure + pain}");
    }
}