namespace VestaboardPackage
{
    public class Color : Enumeration
    {
        public static Color Red = new Color(63, "Red");
        public static Color Orange = new Color(64, "Orange");
        public static Color Yellow = new Color(65, "Yellow");
        public static Color Green = new Color(66, "Green");
        public static Color Blue = new Color(67, "Blue");
        public static Color Purple = new Color(68, "Purple");
        public static Color White = new Color(69, "White");
        public static Color Black = new Color(70, "Black");
        public static Color Filled = new Color(71, "Filled");

        private Color(int id, string name) : base(id, name)
        {
        }
    }
}