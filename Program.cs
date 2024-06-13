using System.Text;
using static System.Console;
bool mono = false;
StringBuilder feed0 = new();
StringBuilder feed1 = new();
StringBuilder feed2 = new();
StringBuilder feed3 = new();
StringBuilder feed4 = new();
while (true)
{
    string? s = ReadLine();
    if (s is null || s.Length == 0)
        continue;
    if (s.StartsWith('\\'))
        switch (s)
        {
            case @"\mono" or @"\m":
                mono = true;
                continue;
            case @"\nomono" or @"\nm":
                mono = false;
                continue;
            case @"\clear" or @"\c":
                Clear();
                continue;
            case @"\exit" or @"\e" or @"\x":
                return;
            default:
                WriteLine("Invalid command.");
                continue;
        }
    foreach (char c in s)
    {
        Print(char.ToUpper(c));
        if (mono)
        {
            const int length = 8;
            Even(feed0, length);
            Even(feed1, length);
            Even(feed2, length);
            Even(feed3, length);
            Even(feed4, length);
        }
        else
            Space();
    }
    WriteLine(feed0.ToString(0, feed0.Length - 1));
    WriteLine(feed1.ToString(0, feed1.Length - 1));
    WriteLine(feed2.ToString(0, feed2.Length - 1));
    WriteLine(feed3.ToString(0, feed3.Length - 1));
    WriteLine(feed4.ToString(0, feed4.Length - 1));
    feed0.Clear();
    feed1.Clear();
    feed2.Clear();
    feed3.Clear();
    feed4.Clear();
}
static void Even(StringBuilder Builder, int Length)
{
    int mod = Builder.Length % Length;
    int add = mod == 0 ? 0 : Length - mod;
    _ = Builder.Append(new string(' ', add));
}
void Space()
{
    feed0.Append(' ');
    feed1.Append(' ');
    feed2.Append(' ');
    feed3.Append(' ');
    feed4.Append(' ');
}
void Print(char Character)
{
    switch (Character)
    {
        case ' ':
            PrintSpace();
            break;
        case 'A':
            PrintA();
            break;
        case 'B':
            PrintB();
            break;
        case 'C':
            PrintC();
            break;
        case 'D':
            PrintD();
            break;
        case 'E':
            PrintE();
            break;
        case 'F':
            PrintF();
            break;
        case 'G':
            PrintG();
            break;
        case 'H':
            PrintH();
            break;
        case 'I':
            PrintI();
            break;
        case 'J':
            PrintJ();
            break;
        case 'K':
            PrintK();
            break;
        case 'L':
            PrintL();
            break;
        case 'M':
            PrintM();
            break;
        case 'N':
            PrintN();
            break;
        case 'O':
            PrintO();
            break;
        case 'P':
            PrintP();
            break;
        case 'Q':
            PrintQ();
            break;
        case 'R':
            PrintR();
            break;
        case 'S':
            PrintS();
            break;
        case 'T':
            PrintT();
            break;
        case 'U':
            PrintU();
            break;
        case 'V':
            PrintV();
            break;
        case 'W':
            PrintW();
            break;
        case 'X':
            PrintX();
            break;
        case 'Y':
            PrintY();
            break;
        case 'Z':
            PrintZ();
            break;
        case '0':
            Print0();
            break;
        case '1':
            Print1();
            break;
        case '2':
            Print2();
            break;
        case '3':
            Print3();
            break;
        case '4':
            Print4();
            break;
        case '5':
            Print5();
            break;
        case '6':
            Print6();
            break;
        case '7':
            Print7();
            break;
        case '8':
            Print8();
            break;
        case '9':
            Print9();
            break;
        case ',':
            PrintComma();
            break;
        case '\'':
            PrintApostrophe();
            break;
        case '.':
            PrintPeriod();
            break;
        case '!':
            PrintExclamation();
            break;
        case '?':
            PrintQuestion();
            break;
        case ':':
            PrintColon();
            break;
        case ';':
            PrintSemicolon();
            break;
        case '(':
            PrintLeftParenthesis();
            break;
        case ')':
            PrintRightParenthesis();
            break;
        case '[':
            PrintLeftBracket();
            break;
        case ']':
            PrintRightBracket();
            break;
        case '{':
            PrintLeftCurly();
            break;
        case '}':
            PrintRightCurly();
            break;
        case '=':
            PrintEqual();
            break;
        case '>':
            PrintGreater();
            break;
        case '<':
            PrintLesser();
            break;
        case '"':
            PrintQuote();
            break;
        case '-':
            PrintDash();
            break;
        case '#':
            PrintHashtag();
            break;
        case '$':
            PrintDollar();
            break;
        case '%':
            PrintPercent();
            break;
        case '~':
            PrintSquiggle();
            break;
        case '|':
            PrintWall();
            break;
        case '+':
            PrintPlus();
            break;
        default:
            PrintQuestion();
            break;
    }
}
void PrintSpace()
{
    feed0.Append("     ");
    feed1.Append("     ");
    feed2.Append("     ");
    feed3.Append("     ");
    feed4.Append("     ");
}
void PrintA()
{
    feed0.Append(" ### ");
    feed1.Append("#   #");
    feed2.Append("#####");
    feed3.Append("#   #");
    feed4.Append("#   #");
}
void PrintB()
{
    feed0.Append("#### ");
    feed1.Append("#   #");
    feed2.Append("#### ");
    feed3.Append("#   #");
    feed4.Append("#### ");
}
void PrintC()
{
    feed0.Append(" ####");
    feed1.Append("#    ");
    feed2.Append("#    ");
    feed3.Append("#    ");
    feed4.Append(" ####");
}
void PrintD()
{
    feed0.Append("#### ");
    feed1.Append("#   #");
    feed2.Append("#   #");
    feed3.Append("#   #");
    feed4.Append("#### ");
}
void PrintE()
{
    feed0.Append("#####");
    feed1.Append("#    ");
    feed2.Append("#####");
    feed3.Append("#    ");
    feed4.Append("#####");
}
void PrintF()
{
    feed0.Append("#####");
    feed1.Append("#    ");
    feed2.Append("#####");
    feed3.Append("#    ");
    feed4.Append("#    ");
}
void PrintG()
{
    feed0.Append("#### ");
    feed1.Append("#    ");
    feed2.Append("# ###");
    feed3.Append("#   #");
    feed4.Append("#####");
}
void PrintH()
{
    feed0.Append("#   #");
    feed1.Append("#   #");
    feed2.Append("#####");
    feed3.Append("#   #");
    feed4.Append("#   #");
}
void PrintI()
{
    feed0.Append("#####");
    feed1.Append("  #  ");
    feed2.Append("  #  ");
    feed3.Append("  #  ");
    feed4.Append("#####");
}
void PrintJ()
{
    feed0.Append("#####");
    feed1.Append("  #  ");
    feed2.Append("  #  ");
    feed3.Append("# #  ");
    feed4.Append("###  ");
}
void PrintK()
{
    feed0.Append("#  #");
    feed1.Append("# # ");
    feed2.Append("##  ");
    feed3.Append("# # ");
    feed4.Append("#  #");
}
void PrintL()
{
    feed0.Append("#    ");
    feed1.Append("#    ");
    feed2.Append("#    ");
    feed3.Append("#    ");
    feed4.Append("#####");
}
void PrintM()
{
    feed0.Append("##   ##");
    feed1.Append("# # # #");
    feed2.Append("#  #  #");
    feed3.Append("#     #");
    feed4.Append("#     #");
}
void PrintN()
{
    feed0.Append("##    #");
    feed1.Append("# #   #");
    feed2.Append("#  #  #");
    feed3.Append("#   # #");
    feed4.Append("#    ##");
}
void PrintO()
{
    feed0.Append(" ### ");
    feed1.Append("#   #");
    feed2.Append("#   #");
    feed3.Append("#   #");
    feed4.Append(" ### ");
}
void PrintP()
{
    feed0.Append("#### ");
    feed1.Append("#   #");
    feed2.Append("#### ");
    feed3.Append("#    ");
    feed4.Append("#    ");
}
void PrintQ()
{
    feed0.Append("#####");
    feed1.Append("#   #");
    feed2.Append("# # #");
    feed3.Append("#  ##");
    feed4.Append("#####");
}
void PrintR()
{
    feed0.Append("#### ");
    feed1.Append("#   #");
    feed2.Append("#### ");
    feed3.Append("#   #");
    feed4.Append("#   #");
}
void PrintS()
{
    feed0.Append(" ### ");
    feed1.Append("#    ");
    feed2.Append(" ### ");
    feed3.Append("    #");
    feed4.Append(" ### ");
}
void PrintT()
{
    feed0.Append("#####");
    feed1.Append("  #  ");
    feed2.Append("  #  ");
    feed3.Append("  #  ");
    feed4.Append("  #  ");
}
void PrintU()
{
    feed0.Append("#   #");
    feed1.Append("#   #");
    feed2.Append("#   #");
    feed3.Append("#   #");
    feed4.Append(" ### ");
}
void PrintV()
{
    feed0.Append("#       #");
    feed1.Append(" #     # ");
    feed2.Append("  #   #  ");
    feed3.Append("   # #   ");
    feed4.Append("    #    ");
}
void PrintW()
{
    feed0.Append("#     #");
    feed1.Append("#     #");
    feed2.Append("#  #  #");
    feed3.Append("# # # #");
    feed4.Append("##   ##");
}
void PrintX()
{
    feed0.Append("#   #");
    feed1.Append(" # # ");
    feed2.Append("  #  ");
    feed3.Append(" # # ");
    feed4.Append("#   #");
}
void PrintY()
{
    feed0.Append("#   #");
    feed1.Append(" # # ");
    feed2.Append("  #  ");
    feed3.Append("  #  ");
    feed4.Append("  #  ");
}
void PrintZ()
{
    feed0.Append("#####");
    feed1.Append("   # ");
    feed2.Append("  #  ");
    feed3.Append(" #   ");
    feed4.Append("#####");
}
void Print0()
{
    feed0.Append(" ### ");
    feed1.Append("##  #");
    feed2.Append("# # #");
    feed3.Append("#  ##");
    feed4.Append(" ### ");
}
void Print1()
{
    feed0.Append("  #  ");
    feed1.Append(" ##  ");
    feed2.Append("# #  ");
    feed3.Append("  #  ");
    feed4.Append("#####");
}
void Print2()
{
    feed0.Append("#### ");
    feed1.Append("    #");
    feed2.Append(" ### ");
    feed3.Append("#    ");
    feed4.Append("#####");
}
void Print3()
{
    feed0.Append("#### ");
    feed1.Append("    #");
    feed2.Append("#### ");
    feed3.Append("    #");
    feed4.Append("#### ");
}
void Print4()
{
    feed0.Append("#   #");
    feed1.Append("#   #");
    feed2.Append("#####");
    feed3.Append("    #");
    feed4.Append("    #");
}
void Print5()
{
    feed0.Append("#####");
    feed1.Append("#    ");
    feed2.Append("#### ");
    feed3.Append("    #");
    feed4.Append("#### ");
}
void Print6()
{
    feed0.Append("#    ");
    feed1.Append("#    ");
    feed2.Append("#### ");
    feed3.Append("#   #");
    feed4.Append("#####");
}
void Print7()
{
    feed0.Append("#####");
    feed1.Append("   # ");
    feed2.Append("  #  ");
    feed3.Append(" #   ");
    feed4.Append("#    ");
}
void Print8()
{
    feed0.Append(" ### ");
    feed1.Append("#   #");
    feed2.Append(" ### ");
    feed3.Append("#   #");
    feed4.Append(" ### ");
}
void Print9()
{
    feed0.Append("#####");
    feed1.Append("#   #");
    feed2.Append("#####");
    feed3.Append("    #");
    feed4.Append("    #");
}
void PrintComma()
{
    feed0.Append("  ");
    feed1.Append("  ");
    feed2.Append("  ");
    feed3.Append(" #");
    feed4.Append("##");
}
void PrintApostrophe()
{
    feed0.Append("#");
    feed1.Append("#");
    feed2.Append(" ");
    feed3.Append(" ");
    feed4.Append(" ");
}
void PrintPeriod()
{
    feed0.Append(" ");
    feed1.Append(" ");
    feed2.Append(" ");
    feed3.Append(" ");
    feed4.Append("#");
}
void PrintQuestion()
{
    feed0.Append("#####");
    feed1.Append("    #");
    feed2.Append("  ###");
    feed3.Append("  #  ");
    feed4.Append("  #  ");
}
void PrintExclamation()
{
    feed0.Append("#");
    feed1.Append("#");
    feed2.Append("#");
    feed3.Append(" ");
    feed4.Append("#");
}
void PrintColon()
{
    feed0.Append(" ");
    feed1.Append("#");
    feed2.Append(" ");
    feed3.Append("#");
    feed4.Append(" ");
}
void PrintSemicolon()
{
    feed0.Append("  ");
    feed1.Append(" #");
    feed2.Append("  ");
    feed3.Append(" #");
    feed4.Append("##");
}
void PrintLeftParenthesis()
{
    feed0.Append(" #");
    feed1.Append("# ");
    feed2.Append("# ");
    feed3.Append("# ");
    feed4.Append(" #");
}
void PrintRightParenthesis()
{
    feed0.Append("# ");
    feed1.Append(" #");
    feed2.Append(" #");
    feed3.Append(" #");
    feed4.Append("# ");
}
void PrintLeftBracket()
{
    feed0.Append("##");
    feed1.Append("# ");
    feed2.Append("# ");
    feed3.Append("# ");
    feed4.Append("##");
}
void PrintRightBracket()
{
    feed0.Append("##");
    feed1.Append(" #");
    feed2.Append(" #");
    feed3.Append(" #");
    feed4.Append("##");
}
void PrintLeftCurly()
{
    feed0.Append(" ##");
    feed1.Append(" # ");
    feed2.Append("## ");
    feed3.Append(" # ");
    feed4.Append(" ##");
}
void PrintRightCurly()
{
    feed0.Append("## ");
    feed1.Append(" # ");
    feed2.Append(" ##");
    feed3.Append(" # ");
    feed4.Append("## ");
}
void PrintEqual()
{
    feed0.Append("     ");
    feed1.Append("#####");
    feed2.Append("     ");
    feed3.Append("#####");
    feed4.Append("     ");
}
void PrintGreater()
{
    feed0.Append("##    ");
    feed1.Append("  ##  ");
    feed2.Append("    ##");
    feed3.Append("  ##  ");
    feed4.Append("##    ");
}
void PrintLesser()
{
    feed0.Append("    ##");
    feed1.Append("  ##  ");
    feed2.Append("##    ");
    feed3.Append("  ##  ");
    feed4.Append("    ##");
}
void PrintQuote()
{
    feed0.Append("# #");
    feed1.Append("# #");
    feed2.Append("   ");
    feed3.Append("   ");
    feed4.Append("   ");
}
void PrintDash()
{
    feed0.Append("   ");
    feed1.Append("   ");
    feed2.Append("###");
    feed3.Append("   ");
    feed4.Append("   ");
}
void PrintHashtag()
{
    feed0.Append(" # # ");
    feed1.Append("#####");
    feed2.Append(" # # ");
    feed3.Append("#####");
    feed4.Append(" # # ");
}
void PrintDollar()
{
    feed0.Append(" ### ");
    feed1.Append("# #  ");
    feed2.Append(" ### ");
    feed3.Append("  # #");
    feed4.Append(" ### ");
}
void PrintPercent()
{
    feed0.Append("##  #");
    feed1.Append("## # ");
    feed2.Append("  #  ");
    feed3.Append(" # ##");
    feed4.Append("#  ##");
}
void PrintSquiggle()
{
    feed0.Append("     ");
    feed1.Append(" #   ");
    feed2.Append("# # #");
    feed3.Append("   # ");
    feed4.Append("     ");
}
void PrintWall()
{
    feed0.Append("#");
    feed1.Append("#");
    feed2.Append("#");
    feed3.Append("#");
    feed4.Append("#");
}
void PrintPlus()
{
    feed0.Append("   ");
    feed1.Append(" # ");
    feed2.Append("###");
    feed3.Append(" # ");
    feed4.Append("   ");
}