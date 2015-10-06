using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class SlicingFile
{
    static void Main()
    {
        string source = @"D:\video.mp4";
        string destination;
        int n = int.Parse(Console.ReadLine());

        List<string> collectedDestinations = new List<string>(n);

        for (int i = 0; i < n; i++)
        {
            destination = "Part-" + i + ".mp4";
            collectedDestinations.Add(destination);
            Slice(source, destination, n);
        }


        string newSource = "../../assembled.mp4";
        Assemble(collectedDestinations, newSource);
    }

    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            for (int i = 0; i < parts; i++)
            {
                using (var destination = new FileStream(destinationDirectory, FileMode.Create))
                {
                    double fileLength = source.Length;
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
    static void Assemble(List<string> files, string destinationDirectory)
    {
        var create = new FileStream(destinationDirectory, FileMode.Create);
        using (create)
        {
            for (int i = 0; i < files.Count; i++)
            {
                var opener = new FileStream(files[i], FileMode.Open);
                byte[] bytes = Encoding.ASCII.GetBytes(files[i]);
                create.Write(bytes, 0, bytes.Length);
            }

        }

    }
}