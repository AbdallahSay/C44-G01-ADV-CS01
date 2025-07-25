namespace Demo.EX1
{
    internal struct Point
    {
        #region Prop
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Ctor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        } 
        #endregion
        #region Override ToString
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        } 
        #endregion



    }
}
