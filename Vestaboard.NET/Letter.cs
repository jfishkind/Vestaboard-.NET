namespace VestaboardPackage
{
    public class Letter : Enumeration
    {
        public static readonly Letter A = new Letter(1, "A");
        public static readonly Letter B = new Letter(2, "B");
        public static readonly Letter C = new Letter(3, "C");
        public static readonly Letter D = new Letter(4, "D");
        public static readonly Letter E = new Letter(5, "E");
        public static readonly Letter F = new Letter(6, "F");
        public static readonly Letter G = new Letter(7, "G");
        public static readonly Letter H = new Letter(8, "H");
        public static readonly Letter I = new Letter(9, "I");
        public static readonly Letter J = new Letter(10, "J");
        public static readonly Letter K = new Letter(11, "K");
        public static readonly Letter L = new Letter(12, "L");
        public static readonly Letter M = new Letter(13, "M");
        public static readonly Letter N = new Letter(14, "N");
        public static readonly Letter O = new Letter(15, "O");
        public static readonly Letter P = new Letter(16, "P");
        public static readonly Letter Q = new Letter(17, "Q");
        public static readonly Letter R = new Letter(18, "R");
        public static readonly Letter S = new Letter(19, "S");
        public static readonly Letter T = new Letter(20, "T");
        public static readonly Letter U = new Letter(21, "U");
        public static readonly Letter V = new Letter(22, "V");
        public static readonly Letter W = new Letter(23, "W");
        public static readonly Letter X = new Letter(24, "X");
        public static readonly Letter Y = new Letter(25, "Y");
        public static readonly Letter Z = new Letter(26, "Z");

        private Letter(int id, string name) : base(id, name)
        {
        }
    }
}