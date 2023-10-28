using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileOperation
    {

        public void CreateFile()
        {
            FileInfo fi = new
                FileInfo("D:\\FileHandling\\Sample.txt");
            using StreamWriter str = fi.CreateText();
            str.WriteLine("hello india");
            str.WriteLine(" How are u");
        }
        public void WriteData()
        {
            FileStream fs = new FileStream("D:\\FileHandling\\sample2.txt", FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(fs);
            Console.WriteLine("Enter the text which" + "you want to write to the file");
            string? str = Console.ReadLine();
            SW.WriteLine(str);
            SW.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("D:\\FileHandling\\sample2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        public void CopyMoveFile()
        {
            FileInfo fi = new FileInfo("D:\\FileHandling\\sample.txt");
            FileInfo fi2 = new FileInfo("D:\\FileHandling\\sample2.txt");
            fi.CopyTo("D:\\FileHandling\\Tenm\\copy.txt");
            fi2.MoveTo("D:\\FileHandling\\Tenm\\sample2.txt");
        }
        public void DeleteFile()
        {
            FileInfo fi = new FileInfo("D:\\FileHandling\\Tenm\\copy.txt");
            fi.Delete();

        }
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("D:\\FileHandling\\sample.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.Extension);
        }
    }
}
