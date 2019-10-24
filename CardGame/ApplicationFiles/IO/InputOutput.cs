using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ApplicationFiles.IO
{
    class InputOutput
    {
        string filePath = "";
        public InputOutput(string filePath, string fileName)
        {
            this.filePath = filePath + "\\" + fileName;

        }
        public int Read(ref string text)
        {
            if (!File.Exists(filePath))
            {
                return -1;
            }
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();


            sw.Close();
            fs.Close();
            text = yazi;
            return 1;
        }
        public int ReadAll(ref List<string> OutputText)
        {
            //Böyle Bir Dosya Yok
            if (!File.Exists(filePath))
            {
                return -1;
            }
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                OutputText.Add(yazi);
                yazi = sw.ReadLine();

            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
            return 1;
        }
        public int Write(string WritingText)
        {
            using (System.IO.StreamWriter sw =
           new System.IO.StreamWriter(filePath, true))
            {
                sw.WriteLine(WritingText);
            }

            return 1;
        }
        public int WriteAll(List<string> Writetexts)
        {
            FileStream fs;
            fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var text in Writetexts)
            {
                sw.WriteLine(text);
            }
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Flush();
            sw.Close();
            fs.Close();
            return 1;
        }





    }
}

