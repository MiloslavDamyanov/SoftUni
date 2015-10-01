using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class CopyBinaryFile
{
    static void Main()
    {
        string source = @"../../pic.png";
        string destination = @"D:\newpic.png";
        using (FileStream stream = File.OpenRead(source))
        using (FileStream writeStream = File.OpenWrite(destination))
        {
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(writeStream);
            
            byte[] buffer = new Byte[1024];
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, 1024)) > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
            }
        }       
    }   
}
