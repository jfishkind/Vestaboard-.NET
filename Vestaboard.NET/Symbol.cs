using System;

namespace VestaboardPackage;

public class Symbol : Enumeration
{
    public static readonly Symbol ExclamationMark = new Symbol(37, "Exclamation Mark", "!");
    public static readonly Symbol At = new Symbol(38, "At", "@");
    public static readonly Symbol Pound = new Symbol(39, "Pound", "#");
    public static readonly Symbol Dollar = new Symbol(40, "Dollar", "$");
    public static readonly Symbol LeftParenthesis = new Symbol(41, "Left Parenthesis", "(");
    public static readonly Symbol RightParenthesis = new Symbol(42, "Right Parenthesis", ")");
    public static readonly Symbol Hyphen = new Symbol(44, "Hyphen", "-");
    public static readonly Symbol Plus = new Symbol(46, "Plus", "+");
    public static readonly Symbol Ampersand = new Symbol(47, "Ampersand", "&");
    public static readonly Symbol Equal = new Symbol(48, "Equal", "=");
    public static readonly Symbol Semicolon = new Symbol(49, "Semicolon", ";");
    public static readonly Symbol Colon = new Symbol(50, "Colon", ":");
    public static readonly Symbol SingleQuote = new Symbol(52, "Single Quote", "'");
    public static readonly Symbol DoubleQuote = new Symbol(53, "Double Quote", "\"");
    public static readonly Symbol Percent = new Symbol(54, "Percent", "%");
    public static readonly Symbol Comma = new Symbol(55, "Comma", ",");
    public static readonly Symbol Period = new Symbol(56, "Period", ".");
    public static readonly Symbol Slash = new Symbol(59, "Slash", "/");
    public static readonly Symbol QuestionMark = new Symbol(60, "Question Mark", "?");
    public static readonly Symbol Degree = new Symbol(62, "Degree", "\u00b0");


    private Symbol(int id, string name, string symbol) : base(id, name, symbol)
    {
    }
}