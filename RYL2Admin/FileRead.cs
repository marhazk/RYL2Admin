using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml;
using System.Text.RegularExpressions;
using System.Net;


namespace RYL2Admin
{
    class FileRead
    {
        public List<String> DB = new List<String>();
        String file;
        FileStream filestream;
        public FileRead(string _file)
        {
            Open(_file);
        }
        public void Open(string _file)
        {
            this.file = _file;
            try
            {
                filestream = File.Open(this.file, FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader r = new StreamReader(filestream);
                string t;
                while ((t = r.ReadLine()) != null)
                {
                    DB.Add(t);
                }
                filestream.Close();
            }
            catch { }
        }
        public String Read(int num)
        {
            String temp = "";
            int x = 0;
            foreach (String r in DB)
            {
                if (x == num)
                {
                    temp = r;
                    break;
                }
                x++;
            }
            return temp;
        }
        public void Replace(String find, string replacewith)
        {
            List<String> FindLDB = new List<String>();
            FindLDB.Add(find);
            Replace(FindLDB, replacewith);
        }
        public void Replace(String[] FindDB, string replacewith)
        {
            List<String> FindLDB = new List<String>();
            foreach (String find in FindDB)
            {
                FindLDB.Add(find);
            }
            Replace(FindLDB, replacewith);
        }
        public void Replace(List<String> FindDB, string replacewith)
        {
            List<String> NewDB = new List<String>();
            foreach (String r in DB)
            {
                String newstr = r;
                foreach (String find in FindDB)
                {
                    newstr = newstr.Replace(find, replacewith);
                }
                NewDB.Add(newstr);
            }
            this.DB = NewDB;
        }
        public static bool TryToDelete(string f)
        {
            try
            {
                // A.
                // Try to delete the file.
                File.Delete(f);
                return true;
            }
            catch (IOException)
            {
                // B.
                // We couldn't delete the file.
                return false;
            }
        }
        public void Update()
        {
            TryToDelete(file);
            StreamWriter wfile = new StreamWriter(file);
            foreach (String r in DB)
            {
                wfile.WriteLine(r);
            }
            wfile.Close();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
