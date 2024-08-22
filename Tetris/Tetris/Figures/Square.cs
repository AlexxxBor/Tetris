namespace Tetris.Figures
{
    internal class Square
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; } = '*';

        private Point[] _points = new Point[4];

        public Square(int x, int y)
        {
            X = x;
            Y = y;

            _points[0] = new Point(X, Y, Symbol);
            _points[1] = new Point(X + 1, Y, Symbol);
            _points[2] = new Point(X, Y + 1, Symbol);
            _points[3] = new Point(X + 1, Y + 1, Symbol);
        }

        public void Draw()
        {
            foreach (Point figurePoint in _points)
            {
                figurePoint.Draw();
            }
        }
    }
}
