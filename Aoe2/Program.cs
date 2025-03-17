using Aoe2.Hero;
using System;

namespace Aoe2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              
                Ihero player = CHero.CreateCRT();

            
                Ihero opponent = CHero.CreateRandomOpponent();

               
                CHero.Fight(player, opponent);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}