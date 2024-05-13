using System;

namespace VestaboardPackage;

public class Symbol : Enumeration
{
    public static Symbol ExclamationMark = new Symbol(37, "Exclamation Mark", "!");
    public static Symbol At = new Symbol(38, "At", "@");
    public static Symbol Pound = new Symbol(39, "Pound", "#");
    public static Symbol Dollar = new Symbol(40, "Dollar", "$");
    public static Symbol LeftParenthesis = new Symbol(41, "Left Parenthesis", "(");
    public static Symbol RightParenthesis = new Symbol(42, "Right Parenthesis", ")");
    public static Symbol Hyphen = new Symbol(44, "Hyphen", "-");
    public static Symbol Plus = new Symbol(46, "Plus", "+");
    public static Symbol Ampersand = new Symbol(47, "Ampersand", "&");
    public static Symbol Equal = new Symbol(48, "Equal", "=");
    public static Symbol Semicolon = new Symbol(49, "Semicolon", ";");
    public static Symbol Colon = new Symbol(50, "Colon", ":");
    public static Symbol SingleQuote = new Symbol(52, "Single Quote", "'");
    public static Symbol DoubleQuote = new Symbol(53, "Double Quote", "\"");
    public static Symbol Percent = new Symbol(54, "Percent", "%");
    public static Symbol Comma = new Symbol(55, "Comma", ",");
    public static Symbol Period = new Symbol(56, "Period", ".");
    public static Symbol Slash = new Symbol(59, "Slash", "/");
    public static Symbol QuestionMark = new Symbol(60, "Question Mark", "?");
    public static Symbol Degree = new Symbol(62, "Degree", "\u00b0");


    private Symbol(int id, string name, string symbol) : base(id, name, symbol)
    {
    }
}