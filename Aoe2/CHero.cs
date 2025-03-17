using Aoe2.Hero;
using System;

namespace Aoe2
{
    public class CHero
    {
        private static readonly Random random = new Random();

       
        public static Ihero CreateCRT()
        {
            Console.WriteLine("Nhập loại anh hùng (1: Cung thủ, 2: Chiến binh, 3: Phù thủy):");
            string type = Console.ReadLine().ToLower();

            Console.WriteLine("Nhập tên cho anh hùng:");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Tên anh hùng không được để trống!");
            }

            switch (type)
            {
                case "1":
                    return new CungThu(name);
                case "2":
                    return new ChienBinh(name);
                case "3":
                    return new PhuThuy(name);
                default:
                    throw new ArgumentException("Loại anh hùng không hợp lệ!");
            }
        }

        public static Ihero CreateRandomOpponent()
        {
            int type = random.Next(1, 4); 
            string[] randomNames = { "Dark Archer", "Iron Warrior", "Mystic Mage" };
            string name = randomNames[type - 1];

            switch (type)
            {
                case 1:
                    return new CungThu(name);
                case 2:
                    return new ChienBinh(name);
                case 3:
                    return new PhuThuy(name);
                default:
                    throw new Exception("Lỗi hệ thống khi tạo đối thủ!");
            }
        }


        public static void Fight(Ihero player, Ihero opponent)
        {
            Console.WriteLine($"\nTrận đấu bắt đầu: {player} ({player.GetType().Name}) vs {opponent} ({opponent.GetType().Name})");

           
            if (player.GetType() == opponent.GetType())
            {
                Console.WriteLine("Hòa! Cả hai anh hùng cùng loại.");
            }
            else if ((player is CungThu && opponent is PhuThuy) ||
                     (player is PhuThuy && opponent is ChienBinh) ||
                     (player is ChienBinh && opponent is CungThu))
            {
                player.AttackWin(opponent);
            }
            else
            {
                player.AttackLoss(opponent);
            }
        }
    }
}