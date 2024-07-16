namespace ClassLibrary1
{
    public struct HD
    {
        public int day;
        public int month;
        public int year;
        public HD(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
