using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch10CardLib;

namespace Flush_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newflush = new Deck();
            newflush.Shuffle();
            Card[] tempCards = new Card[5];
            bool flush_justify = false;
            for(int j = 0; j < 50; j++)
            {
                switch (j % 5)
                {
                    case 0:
                        tempCards[0] = newflush.GetCard(j);
                        break;
                    case 1:
                        tempCards[1] = newflush.GetCard(j);
                        break;
                    case 2:
                        tempCards[2] = newflush.GetCard(j);
                        break;
                    case 3:
                        tempCards[3] = newflush.GetCard(j);
                        break;
                    case 4:
                        tempCards[4] = newflush.GetCard(j);
                        flush_justify = true;
                        break;
                    default:
                        throw (new System.ArgumentOutOfRangeException("j", j, "value must be between 0 and 4"));
                        break;
                }
                while (flush_justify == true)
                {
                    for(int k = 0; k < 5; k++)
                    {
                        Console.Write(tempCards[k].ToString()+", ");
                        if (k == 4)
                            Console.WriteLine();
                    }
                        bool justify_1 = tempCards[0].suit == tempCards[1].suit;
                        bool justify_2 = tempCards[1].suit == tempCards[2].suit;
                        bool justify_3 = tempCards[2].suit == tempCards[3].suit;
                        bool justify_4 = tempCards[3].suit == tempCards[4].suit;
                    if (justify_1 && justify_2 && justify_3 && justify_4)
                    //if (justify_1 && justify_2 && justify_3)
                    {
                        Console.WriteLine("\n\nFlash!");
                        Console.ReadKey();
                        return;
                    }
                    else
                        flush_justify = false;
                }
            }
            Console.WriteLine("\nNo flash.");
            Console.ReadKey();
        }
    }
}
