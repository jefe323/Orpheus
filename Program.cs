using System;
using System.IO;

namespace Orpheus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Orpheus, by jefe323";

            Console.Write("Enter the name of the text file you would like to play: ");
            string file = Console.ReadLine();
            
            Console.WriteLine("                                          ()");
            Console.WriteLine("                           () |");
            Console.WriteLine("                    _      |  |");
            Console.WriteLine("                   |       |.'");
            Console.WriteLine("                   |       '");
            Console.WriteLine("      __          ()   \\");
            Console.WriteLine("    ('__`>           .  \\  | /");
            Console.WriteLine("    // -(         ,   `. \\ |");
            Console.WriteLine("    /:_ /        /   ___________");
            Console.WriteLine("   / /_;\\       /____\\__________)____________");
            Console.WriteLine("  **/ ) \\,-_  /                       \\  \\ `.");
            Console.WriteLine("    | |  \\(\\J                        \\  \\  |");
            Console.WriteLine("    |  \\_J,)|~                         \\  \\  ;");
            Console.WriteLine("     \\._/' `|_______________,------------+-+-'");
            Console.WriteLine("      `.___.  \\     ||| /                | |");
            Console.WriteLine("     |_..__.'. \\ \\   |||/                 | |");
            Console.WriteLine("       ||  || \\_\\__ |||                  `.|");
            Console.WriteLine("       ||  ||  \\_-'=|||                   ||");
            Console.WriteLine("  -----++--++-------++--------------------++--------");
            Console.WriteLine("Let me play you the song of my people...");
            
            //Open file using readalllines
            string currentPath = Directory.GetCurrentDirectory();
            string[] output = File.ReadAllLines(file);
            foreach (string s in output)
            {                
                //loop through and then get char array from string
                char[] letters = s.ToLower().ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    //send chars to play class
                    try
                    {
                        Play(letters[i]);
                    }
                    catch { }
                }
            }
        }

        static private void Play(char input)
        {
            Random R = new Random();
            int next = R.Next(5);
            int Duration = 0;
            switch (next)
            {
                case 0:
                    Duration = 800;
                    break;
                case 1:
                    Duration = 400;
                    break;
                case 2:
                    Duration = 400;
                    break;
                case 3:
                    Duration = 200;
                    break;
                case 4:
                    Duration = 100;
                    break;
                default:
                    break;
            }
            //frequencies from: http://coba.belmont.edu/fac/tappant/piano.htm
            switch (input)
            {
                case 'a':
                    Console.Beep((int)174.614, Duration);
                    break;
                case 'b':
                    Console.Beep((int)184.997, Duration);
                    break;
                case 'c':
                    Console.Beep((int)195.998, Duration);
                    break;
                case 'd':
                    Console.Beep((int)207.652, Duration);
                    break;
                case 'e':
                    Console.Beep((int)220.000, Duration);
                    break;
                case 'f':
                    Console.Beep((int)233.082, Duration);
                    break;
                case 'g':
                    Console.Beep((int)246.942, Duration);
                    break;
                case 'h':
                    Console.Beep((int)261.626, Duration);
                    break;
                case 'i':
                    Console.Beep((int)277.183, Duration);
                    break;
                case 'j':
                    Console.Beep((int)293.665, Duration);
                    break;
                case 'k':
                    Console.Beep((int)311.127, Duration);
                    break;
                case 'l':
                    Console.Beep((int)329.629, Duration);
                    break;
                case 'm':
                    Console.Beep((int)349.228, Duration);
                    break;
                case 'n':
                    Console.Beep((int)369.994, Duration);
                    break;
                case 'o':
                    Console.Beep((int)391.995, Duration);
                    break;
                case 'p':
                    Console.Beep((int)415.305, Duration);
                    break;
                case 'q':
                    Console.Beep((int)440.000, Duration);
                    break;
                case 'r':
                    Console.Beep((int)466.164, Duration);
                    break;
                case 's':
                    Console.Beep((int)493.883, Duration);
                    break;
                case 't':
                    Console.Beep((int)523.251, Duration);
                    break;
                case 'u':
                    Console.Beep((int)554.365, Duration);
                    break;
                case 'v':
                    Console.Beep((int)587.330, Duration);
                    break;
                case 'w':
                    Console.Beep((int)622.254, Duration);
                    break;
                case 'x':
                    Console.Beep((int)659.255, Duration);
                    break;
                case 'y':
                    Console.Beep((int)698.456, Duration);
                    break;
                case 'z':
                    Console.Beep((int)739.989, Duration);
                    break;
                case '0':
                    Console.Beep((int)783.991, Duration);
                    break;
                case '1':
                    Console.Beep((int)830.609, Duration);
                    break;
                case '2':
                    Console.Beep((int)880.000, Duration);
                    break;
                case '3':
                    Console.Beep((int)932.328, Duration);
                    break;
                case '4':
                    Console.Beep((int)987.767, Duration);
                    break;
                case '5':
                    Console.Beep((int)1046.502, Duration);
                    break;
                case '6':
                    Console.Beep((int)1108.731, Duration);
                    break;
                case '7':
                    Console.Beep((int)1174.659, Duration);
                    break;
                case '8':
                    Console.Beep((int)1244.598, Duration);
                    break;
                case '9':
                    Console.Beep((int)1318.520, Duration);
                    break;
                case '!':
                    Console.Beep((int)1396.913, Duration);
                    break;
                case '@':
                    Console.Beep((int)1479.978, Duration);
                    break;
                case '#':
                    Console.Beep((int)1567.982, Duration);
                    break;
                case '$':
                    Console.Beep((int)1661.219, Duration);
                    break;
                case '%':
                    Console.Beep((int)1760.000, Duration);
                    break;
                case '^':
                    Console.Beep((int)1864.655, Duration);
                    break;
                case '&':
                    Console.Beep((int)1975.533, Duration);
                    break;
                case '*':
                    Console.Beep((int)2093.004, Duration);
                    break;
                case '(':
                    Console.Beep((int)2217.461, Duration);
                    break;
                case ')':
                    Console.Beep((int)2349.318, Duration);
                    break;
                case '[':
                    Console.Beep((int)2489.016, Duration);
                    break;
                case '{':
                    Console.Beep((int)2637.020, Duration);
                    break;
                case ']':
                    Console.Beep((int)2793.826, Duration);
                    break;
                case '}':
                    Console.Beep((int)2959.955, Duration);
                    break;
                case '\\':
                    Console.Beep((int)3135.437, Duration);
                    break;
                case '|':
                    Console.Beep((int)3322.437, Duration);
                    break;
                case ';':
                    Console.Beep((int)3520.000, Duration);
                    break;
                case ':':
                    Console.Beep((int)3729.310, Duration);
                    break;
                case '\'':
                    Console.Beep((int)3951.066, Duration);
                    break;
                case '"':
                    Console.Beep((int)4186.009, Duration);
                    break;
                case ',':
                    Console.Beep((int)38.891, Duration);
                    break;
                case '<':
                    Console.Beep((int)41.203, Duration);
                    break;
                case '.':
                    Console.Beep((int)43.654, Duration);
                    break;
                case '>':
                    Console.Beep((int)46.249, Duration);
                    break;
                case '/':
                    Console.Beep((int)48.999, Duration);
                    break;
                case '?':
                    Console.Beep((int)51.913, Duration);
                    break;
                default:
                    break;
            }
        }
    }
}
