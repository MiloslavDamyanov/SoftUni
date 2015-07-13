using System;

class DeclareVariables
{
    static void Main()
    {
        sbyte sbyteVAlue = -115;    // -128 to 127
        byte byteValue = 97;        // 0 to 255
        ushort ushortValue = 52130; // 0 to 65535
        uint unitValue = 4825932;   // 0 to 4,294,967,295

        Console.WriteLine("sbyte {0}", sbyteVAlue);
        Console.WriteLine("byte {0}", byteValue);
        Console.WriteLine("ushort {0}", ushortValue);
        Console.WriteLine("uint {0}", unitValue);
    }
}