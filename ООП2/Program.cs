using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    class TV
    {
        public bool Tvkl = true;
        public int ChanMax = 11;
        public int ChanNow = 1;
        public string Num = "";

        public void SwitchChan()
        {
            ConsoleKeyInfo vvod = Console.ReadKey();
            if (vvod.Key == ConsoleKey.Enter) 
            {
                if(Num!="")
                if (Convert.ToInt32(Num) > 0 && Convert.ToInt32(Num) < ChanMax) ChanNow = Convert.ToInt32(Num);
                else Console.WriteLine(" | \tКанала " + Num + " нет");
                Num = ""; Console.WriteLine(" | \tтекущий канал-" + ChanNow); 
            }
            switch(vvod.KeyChar)
            {
                case '*':
                    Tvkl = false; Num = "";
                    break;
                case '-':
                    ChanPlus(-1); Num = "";
                    break;
                case '+':
                    ChanPlus(1); Num = "";
                    break;
                       case '0':
                    Num += 0; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
                        case '1':
                    Num += 1; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
                        case '2':
                    Num += 2; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
                        case '3':
                    Num += 3; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
                        case '4':
                    Num += 4; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
                        case '5':
                    Num += 5; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
                        case '6':
                    Num += 6; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
                        case '7':
                    Num += 7; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
                        case '8':
                    Num += 8; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
                        case '9':
                    Num += 9; Console.WriteLine(" | \t" + "введённый номер-->" + Num);
                    break;
            }
            
        }
        public void ChanPlus(int n)
        {
            ChanNow += n;
            if (ChanNow <= 0) ChanNow = ChanMax;
            if (ChanNow > ChanMax) ChanNow = 1;
            Console.WriteLine(" | \t" + "текущий канал-" + ChanNow);
        }
    }
    


    class Program
    {
        static void Main(string[] args)
        {
            TV TV1 = new TV();
            Console.WriteLine("Вы включили телевизор, для выключения нажмите *");
            Console.WriteLine();
            Console.WriteLine("Переключить канал на следующий или предыдущий: - или +\n " +
            "Также вы можете вести номер нужного вам канала и нажать enter\n"+
            "Доступные каналы от 1 до "+TV1.ChanMax);
             Console.WriteLine("------------------------------------------------------------");

    link:
                Console.WriteLine(" | \tтекущий канал-" + TV1.ChanNow);
                while (TV1.Tvkl==true)
                {
                    TV1.SwitchChan();
                }
                Console.WriteLine(" | \tТелевизор выключен");

            if(Console.ReadKey().KeyChar == '*')
            {
                Console.WriteLine(" | \tТелевизор включен");
                TV1.Tvkl = true;
                goto link;
            }

            Console.ReadKey();
        }
    }
}
