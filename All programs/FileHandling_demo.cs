//// File handling in c#


//using System;
//using System.IO;

//namespace ConsoleApp_Hexaware
//{
//    class FileHandling_demo
//    {
//        static void Main(string[] args)
//        {
//            // FileInfo class example
//            FileInfo f1 = new FileInfo(@"c:\demo\testdata.txt");
//            Console.WriteLine(f1.FullName);
//            Console.WriteLine(f1.Name);
//            Console.WriteLine(f1.Exists ? "File exists." : "File does not exist.");
//            Console.WriteLine(f1.Length > 0 ? "File is not empty." : "File is empty.");
//            Console.WriteLine(f1.LastWriteTime);
//            Console.WriteLine(f1.CreationTime);
//            Console.WriteLine(f1.DirectoryName);
//            Console.WriteLine(f1.CreationTime.ToString("MM/dd/yyyy HH:mm:ss"));

//            //==============================================================================

//            // DirectoryInfo class example
//            DirectoryInfo d1 = new DirectoryInfo(@"c:\demo");
//            Console.WriteLine(d1.FullName);
//            Console.WriteLine(d1.Name);
//            Console.WriteLine(d1.Exists ? "Directory exists." : "Directory does not exist.");
            
//            Console.WriteLine(d1.LastWriteTime);
//            Console.WriteLine(d1.CreationTime);

//            DirectoryInfo parentDir = d1.Parent;
//            if (parentDir != null)
//            {
//                Console.WriteLine("Parent Directory: " + parentDir.FullName);
//            }
//            else
//            {
//                Console.WriteLine("This directory has no parent.");
//            }
//            //=====================================================================

//            // DriveInfo class example

//            // Note: Ensure you have the necessary permissions to access drive information.

//            //DriveInfo di = new DriveInfo("c:\\");
//            //Console.WriteLine(di.Name);
//            //Console.WriteLine(di.AvailableFreeSpace);
//            //Console.WriteLine(di.TotalSize);


//            //DriveInfo[] drives = DriveInfo.GetDrives();
//            //Console.WriteLine(drives.Length);

//            //foreach (DriveInfo d in drives)
//            //{
//            //    Console.WriteLine("Drive Name: " + d.Name);
//            //    Console.WriteLine("Drive Type: " + d.DriveType);
//            //    if (d.IsReady)
//            //    {
//            //        Console.WriteLine("Total Size: " + d.TotalSize);
//            //        Console.WriteLine("Available Free Space: " + d.AvailableFreeSpace);
//            //        Console.WriteLine("Volume Label: " + d.VolumeLabel);
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Drive is not ready.");
//            //    }
//            //}

//            //=====================================================================

//            string filePath = "c:\\demo\\testdata.txt";

//            // Writing to a file
//            using (StreamWriter w = new StreamWriter(filePath))
//            {
//                w.WriteLine("Hello, World!");
//                w.WriteLine("This is a file handling demo.");
//            }
            
//            // Reading from a file
//            using (StreamReader reader = new StreamReader(filePath))
//            {
//                string line;
//                while ((line = reader.ReadLine()) != null)
//                {
//                    Console.WriteLine(line);
//                }
//            }
//            // Deleting the file
//            if (File.Exists(filePath))
//            {
//                File.Delete(filePath);
//                Console.WriteLine("File deleted successfully.");
//            }
//        }
//    }
//}
