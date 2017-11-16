using System;

namespace ouch
{
    class Program
    {
        class Pos {
            public Pos(int startX, int startY)
            {
                x = startX;
                y = startY;
            }
            public int x;
            public int y;
        }

        static void Main(string[] args)
    {
      ConsoleKey key;
      var pos = new Pos(1, 13);
      Console.WriteLine("ouch! where are my glasses... what is this place..");
      Console.WriteLine("*use the arrow keys to try and find your glasses*");
      do
      {
        key = Console.ReadKey(false).Key;
        if (key == ConsoleKey.UpArrow) {
            if (map[pos.y - 1, pos.x] != 'x') {
                pos.y -= 1;
                Console.WriteLine("shuffle shuffle");
            } else {
                Console.WriteLine("ouch");
            }
        }
        else if (key == ConsoleKey.RightArrow) {
            if (map[pos.y, pos.x + 1] != 'x') {
                pos.x += 1;
                Console.WriteLine("shuffle shuffle");
            } else {
                Console.WriteLine("ouch");
            }
        }
        else if (key == ConsoleKey.LeftArrow) {
            if (map[pos.y, pos.x - 1] != 'x') {
                pos.x -= 1;
                Console.WriteLine("shuffle shuffle");
            } else {
                Console.WriteLine("ouch");
            }
        }
        else if (key == ConsoleKey.DownArrow) {
            if (map[pos.y + 1, pos.x] != 'x') {
                pos.y += 1;
                Console.WriteLine("shuffle shuffle");
            } else {
                Console.WriteLine("ouch");
            }
        }
        else if (key == ConsoleKey.Backspace)
            Console.WriteLine("exiting...");

        var mapcoord = map[pos.y, pos.x];
        if (mapcoord == '!')
            Console.WriteLine("you found your glasses... but not your way out!...!!!");

        // Console.WriteLine($"you are at x:{pos.x}, y:{pos.y}");
      } while (key != ConsoleKey.Backspace);

      Console.WriteLine("game over");
    }

    private static char[,] map => new char[15, 31] {
        {'x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
        {'x','!','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','x'},
        {'x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','-','x'},
        {'x','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','x'},
        {'x','-','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
        {'x','-','x','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','x','x','x','x','x','x','x','x','x','x'},
        {'x','-','x','x','x','x','-','x','x','x','x','x','x','x','x','-','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
        {'x','-','-','-','-','-','-','x','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','x'},
        {'x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','-','x','-','x','x','x','x','x','x','x','x','x','x','x'},
        {'x','x','x','-','-','-','-','-','x','x','x','x','x','x','x','x','x','-','x','-','-','-','-','-','-','-','-','-','-','-','x'},
        {'x','x','x','x','x','x','x','-','x','x','x','x','x','x','x','x','x','-','x','x','x','x','x','x','x','x','x','x','x','x','x'},
        {'x','x','x','x','x','x','-','-','x','x','x','x','x','x','x','x','-','-','x','x','x','x','x','x','x','x','x','x','x','x','x'},
        {'x','x','x','x','x','x','-','x','x','x','x','x','x','x','x','x','-','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
        {'x','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','x'},
        {'x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x','x'}
    };
  }
}
