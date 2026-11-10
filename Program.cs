using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach(DriveInfo drive in drives)
        {

            Console.WriteLine("Name of the drive: {0}", drive.Name);
            Console.WriteLine("Type of the drive: {0}", drive.DriveType);

            if (drive.IsReady)
            {
                Console.WriteLine("Volume: {0}", drive.TotalSize);
                Console.WriteLine("Free space {0}", drive.TotalFreeSpace);
                Console.WriteLine("Label: {0}", drive.VolumeLabel);

            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
