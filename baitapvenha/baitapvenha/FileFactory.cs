using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace baitapvenha
{
    class FileFactory
    {
        public static bool LuuFile(List<Access> dsAc, string Path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Path, true, Encoding.UTF8);
                foreach (Access ac in dsAc)
                {
                    string line = ac.datetime + "\t" + ac.TinhTrang;
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Access> DocFile(string path)
        {
            List<Access> dsAc = new List<Access>();

            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split('\t');
                    
                        Access ac = new Access();
                        ac.datetime = DateTime.Parse(arr[0]);
                        ac.TinhTrang = arr[1];
                        dsAc.Add(ac);
                    
                    line = sr.ReadLine();

                }
                sr.Close();
            }
            catch (Exception ex)
            {

                throw ex;

            }
            return dsAc;

        }

    }
}
