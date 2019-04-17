using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OP_LAB11
{
    class Search
    {       
       
        static public void FindFileWithoutReg(string StartDirectory, string FileToFind, bool Register, List<string> PathToFile)
        {
            var Files = Directory.EnumerateFiles(StartDirectory);
            string nameOfFile = null;

            string nameOfFileToFind;

            foreach (var file in Files)
            {
                nameOfFile = file.Substring(file.LastIndexOf("\\") + 1, file.Length - file.LastIndexOf("\\") - 1);
                if (Register)
                {
                    if (nameOfFile.Contains(FileToFind)) PathToFile.Add(file);
                }
                else
                {
                    if (nameOfFile.ToLower().Contains(FileToFind.ToLower())) PathToFile.Add(file);
                }

            }

            foreach (var directory in Directory.EnumerateDirectories(StartDirectory))
            {
                FindFile(directory, FileToFind, Register, PathToFile);
            }


        }

        static public void FindFileWithStar(string StartDirectory, string FileToFind, bool Register, List<string> PathToFile)
        {
            var Files = Directory.EnumerateFiles(StartDirectory);
            string nameOfFile = null;

            Regex fileWithStar = new Regex(FileToFind.Substring(0, FileToFind.IndexOf("*")) + @"\w+" + FileToFind.Substring(FileToFind.IndexOf("*") + 1, FileToFind.Length - FileToFind.IndexOf("*") - 1));

            Regex fileWithStarNoReg = new Regex(FileToFind.Substring(0, FileToFind.IndexOf("*")) + @"\w+" + FileToFind.Substring(FileToFind.IndexOf("*") + 1, FileToFind.Length - FileToFind.IndexOf("*") - 1), RegexOptions.IgnoreCase);

            foreach (var file in Files)
            {
                nameOfFile = file.Substring(file.LastIndexOf("\\") + 1, file.Length - file.LastIndexOf("\\") - 1);

                if (Register)
                {
                    if (fileWithStar.Matches(nameOfFile).Count > 0) PathToFile.Add(file);
                }
                else
                {
                    if (fileWithStarNoReg.Matches(nameOfFile).Count > 0) PathToFile.Add(file);
                }

            }

            foreach (var directory in Directory.EnumerateDirectories(StartDirectory))
            {
                FindFile(directory, FileToFind, Register, PathToFile);
            }


        }

        static public void FindFileWithQuestionMark(string StartDirectory, string FileToFind, bool Register, List<string> PathToFile)
        {
            var Files = Directory.EnumerateFiles(StartDirectory);
            string nameOfFile = null;

            Regex fileWithQuestion = new Regex(FileToFind.Substring(0, FileToFind.IndexOf("?")) + @"\w" + FileToFind.Substring(FileToFind.IndexOf("?")+1, FileToFind.Length - FileToFind.IndexOf("?")-1));

            Regex fileWithQuestionNoReg = new Regex(FileToFind.Substring(0, FileToFind.IndexOf("?")) + @"\w" + FileToFind.Substring(FileToFind.IndexOf("?") + 1, FileToFind.Length - FileToFind.IndexOf("?") - 1),RegexOptions.IgnoreCase);

            foreach (var file in Files)
            {
                nameOfFile = file.Substring(file.LastIndexOf("\\") + 1, file.Length - file.LastIndexOf("\\") - 1);

                if (Register)
                {
                    if (fileWithQuestion.Matches(nameOfFile).Count > 0) PathToFile.Add(file);
                }
                else
                {                   
                    if (fileWithQuestionNoReg.Matches(nameOfFile).Count > 0) PathToFile.Add(file);
                }

            }

            foreach (var directory in Directory.EnumerateDirectories(StartDirectory))
            {
                FindFile(directory, FileToFind, Register, PathToFile);
            }


        }



        static public void FindFile(string StartDirectory,string FileToFind,bool Register,List<string> PathToFile)
        {
            var Files = Directory.EnumerateFiles(StartDirectory);

            string nameOfFileToFind;

            if (FileToFind.Contains("*"))
            {
                FindFileWithStar(StartDirectory, FileToFind, Register, PathToFile);
            }
            else if (FileToFind.Contains("?"))
            {
                FindFileWithQuestionMark(StartDirectory, FileToFind, Register, PathToFile);
            }
            else
            {
                FindFileWithoutReg(StartDirectory, FileToFind, Register, PathToFile);
            }

        }
    }
}
