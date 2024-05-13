namespace VestaboardPackage
{
    public class Color : Enumeration
    {
        public static readonly Color Red = new Color(63, "Red");
        public static readonly Color Orange = new Color(64, "Orange");
        public static readonly Color Yellow = new Color(65, "Yellow");
        public static readonly Color Green = new Color(66, "Green");
        public static readonly Color Blue = new Color(67, "Blue");
        public static readonly Color Purple = new Color(68, "Purple");
        public static readonly Color White = new Color(69, "White");
        public static readonly Color Black = new Color(70, "Black");
        public static readonly Color Filled = new Color(71, "Filled");

        private Color(int id, string name) : base(id, name)
        {
        }
    }
}