using static System.Console;

WriteLine("--------------------------------------------------------------------------");
WriteLine("Type    Byte(s) of memory               Min                            Max");
WriteLine("--------------------------------------------------------------------------");
WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
WriteLine("--------------------------------------------------------------------------");

Writeline("Hello, Teacher Mark. I am a beginner studying your book. Do you think the following code is too complicated? ^L^！");
string[] MaxValueS = { sbyte.MaxValue.ToString(), byte.MaxValue.ToString(),
                     short.MaxValue.ToString(), ushort.MaxValue.ToString(),
                     int.MaxValue.ToString(),   uint.MaxValue.ToString(),
                     long.MaxValue.ToString(),  ulong.MaxValue.ToString(),
                     float.MaxValue.ToString(), double.MaxValue.ToString(),
                     decimal.MaxValue.ToString()};
for (int i = 0; i < MaxValueS.Length-1; i++)
{
    if (MaxValueS[i].Length > MaxValueS[i+1].Length)
    { var temp = MaxValueS[i];
        MaxValueS[i] = MaxValueS[i + 1];
        MaxValueS[i + 1] = temp; }
}

string[] MinValueS = { sbyte.MinValue.ToString(), byte.MinValue.ToString(),
                     short.MinValue.ToString(), ushort.MinValue.ToString(),
                     int.MinValue.ToString(),   uint.MinValue.ToString(),
                     long.MinValue.ToString(),  ulong.MinValue.ToString(),
                     float.MinValue.ToString(), double.MinValue.ToString(),
                     decimal.MinValue.ToString()};
for (int i = 0; i < MinValueS.Length - 1; i++)
{
    if (MinValueS[i].Length > MinValueS[i + 1].Length)
    {
        var temp = MinValueS[i];
        MinValueS[i] = MinValueS[i + 1];
        MinValueS[i + 1] = temp;
    }
}
string[] stringS = { "sbyte", "byte", "short", "ushort", 
                    "int", "uint", "long", "ulong", 
                        "float", "double", "decimal" };

for (int i = 0; i < stringS.Length-1; i++) 
    {
    if (stringS[i].Length > stringS[i+1].Length)
    {   var temp = stringS[i];
        stringS[i] = stringS[i + 1];
        stringS[i + 1] = temp;
    }
} 

string[] bytes = { sizeof(sbyte).ToString(), sizeof(byte).ToString(),
                   sizeof(short).ToString(), sizeof(ushort).ToString(),
                   sizeof(int).ToString(),   sizeof(uint).ToString(),
                   sizeof(long).ToString(),  sizeof(ulong).ToString(),
                   sizeof(float).ToString(),sizeof(double).ToString(),
                   sizeof(decimal).ToString() };
for (int i = 0; i < bytes.Length-1 ; i++)
{
    if (bytes[i].Length > bytes[i + 1].Length)
    {
        var temp = bytes[i];
        bytes[i] = bytes[i + 1];
        bytes[i + 1] = temp;
    }
}
   
    int LengthM = MaxValueS[MaxValueS.Length-1].Length;
    int LengthN = MinValueS[MinValueS.Length - 1].Length;
    int LengthS = stringS[stringS.Length - 1].Length;
    int LengthB = bytes[bytes.Length - 1].Length;
    int b = "Byte(s) of memory".Length;
    int LengthA = "Byte(s) of memory".Length - LengthB;
    int Length = (LengthM +2)+ (LengthN+ 2) + (LengthS+2)+ (LengthB + 2);

WriteLine(new string('-', Length));
WriteLine("{0,-" + (LengthS+2)+"}{1,-"+ "Byte(s) of memory".Length + "}{2,"+(LengthN-(b-LengthB-4)) + "}{3,"+(LengthM+2) + "}","Type","Byte(s) of memory","Min","Max");
WriteLine(new string('-', Length));


for (int i = 0; i < stringS.Length; i++)
{
   
    WriteLine("{0,-" + (LengthS + 2) + "}{1,-" + (LengthB + 2) + "}{2," + (LengthN + 2) + "}{3," + (LengthM + 2) + "}",  stringS[i], bytes[i], MinValueS[i], MaxValueS[i]);
}
