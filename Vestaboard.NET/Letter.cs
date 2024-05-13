namespace VestaboardPackage
{
    public class Letter : Enumeration
    {
        public static Letter A = new Letter(1, "A");
        public static Letter B = new Letter(2, "B");
        public static Letter C = new Letter(3, "C");
        public static Letter D = new Letter(4, "D");
        public static Letter E = new Letter(5, "E");
        public static Letter F = new Letter(6, "F");
        public static Letter G = new Letter(7, "G");
        public static Letter H = new Letter(8, "H");
        public static Letter I = new Letter(9, "I");
        public static Letter J = new Letter(10, "J");
        public static Letter K = new Letter(11, "K");
        public static Letter L = new Letter(12, "L");
        public static Letter M = new Letter(13, "M");
        public static Letter N = new Letter(14, "N");
        public static Letter O = new Letter(15, "O");
        public static Letter P = new Letter(16, "P");
        public static Letter Q = new Letter(17, "Q");
        public static Letter R = new Letter(18, "R");
        public static Letter S = new Letter(19, "S");
        public static Letter T = new Letter(20, "T");
        public static Letter U = new Letter(21, "U");
        public static Letter V = new Letter(22, "V");
        public static Letter W = new Letter(23, "W");
        public static Letter X = new Letter(24, "X");
        public static Letter Y = new Letter(25, "Y");
        public static Letter Z = new Letter(26, "Z");

        private Letter(int id, string name) : base(id, name)
        {
        }
    }
}