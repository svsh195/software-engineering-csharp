using System;
using System.Collections.Generic;
using System.IO;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\svsh195\Desktop\Lab11";
            //Sort(path);

            string root = @"C:\\Users\svsh195\Desktop";
            Tree(root, 3);
        }

        static void Sort(string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                Dictionary<string, string> extensions = new Dictionary<string, string>();

                foreach (string file in files)
                {
                    FileInfo f = new FileInfo(file);
                    DirectoryInfo d = new DirectoryInfo(path);

                    try
                    {
                        extensions.Add(f.Extension.ToString(), f.Extension.ToString().Remove(0, 1));
                    }
                    catch (Exception e)
                    {
                        // do nothing
                    }

                    string newPath = path + @"\" + extensions[f.Extension.ToString()] + @"\";

                    if (Directory.Exists(newPath))
                    {
                        f.MoveTo(newPath + f.Name);
                    }
                    else
                    {
                        try
                        {
                            d.CreateSubdirectory(extensions[f.Extension.ToString()]);
                        }
                        catch (Exception e)
                        {
                            // do nothing
                        }

                        f.MoveTo(newPath + f.Name);
                    }
                }
            }
        }

        static void Tree(string root, int nesting)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(root);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                    if (nesting > 1)
                        Tree(s, nesting - 1);
                }
            }
            catch (Exception e)
            {
                // do nothing
            }
            
        }
    }
}
