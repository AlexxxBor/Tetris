using System.Text;
using Tetris.Figures;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(0, 0);
            sq.Draw();

            Console.ReadLine();
        }
    }
}
