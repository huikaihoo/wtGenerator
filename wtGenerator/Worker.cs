using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wtGenerator
{
    class Worker
    {
        public static int IndexOfNth(string str, char c, int n=1)
        {
            int s = -1;
            for (int i = 0; i < n; i++)
            {
                s = str.IndexOf(c, s + 1);
                if (s == -1) break;
            }
            return s;
        }

        public static string Substring(string str, int startIndex, int endIndex)
        {
            try
            {
                return str.Substring(startIndex, endIndex - startIndex + 1);
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static bool StringToImgSrc(ImgSrc imgSrc, string str)
        {
            //                                                   2          3                                 4         5
            //                                             1         2               3                   *         4
            // http://ac.tc.qq.com/store_file_download?buid=15017&uin=538643&dir_path=/mif800/1/31/530131/141/&name=8371.mif2

            int s1 = 0;
            int s2 = IndexOfNth(str, '&', 1);
            int s3 = IndexOfNth(str, '&', 2);
            int s4 = IndexOfNth(str, '&', 3);
            int s5 = str.LastIndexOf('.');

            int e1 = IndexOfNth(str, '=', 1);
            int e2 = IndexOfNth(str, '=', 2);
            int e3 = IndexOfNth(str, '=', 3);
            int e4 = IndexOfNth(str, '=', 4);
            int e5 = str.Length;
            
            int sp = IndexOfNth(str, '/', 8);

            imgSrc.url.u1 = Substring(str, s1, e1);
            imgSrc.url.u2 = Substring(str, s2, e2);
            imgSrc.url.u3 = Substring(str, s3, e3);
            imgSrc.url.u4 = Substring(str, s4 - 1, e4);

            imgSrc.content.v1 = Substring(str, e1  +1, s2 - 1);
            Int32.TryParse(Substring(str, e2 + 1, s3 - 1), out imgSrc.content.n2);
            imgSrc.content.v3 = Substring(str, e3 + 1, sp);
            Int32.TryParse(Substring(str, sp + 1, s4 - 2), out imgSrc.content.n3);
            Int32.TryParse(Substring(str, e4 + 1, s5 - 1), out imgSrc.content.n4);
            imgSrc.content.v4 = Substring(str, s5, e5 - 1); 

            return true;
        }

        public static void DownloadImg(string folderName, ImgSrc imgSrc, int count)
        {
            folderName = new string('0', 3 - folderName.Length) + folderName;
            Directory.CreateDirectory(folderName);
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    for (int i = 1; i <= count; i++)
                    {
                        webClient.DownloadFile(imgSrc.FullPath, ".\\" + folderName + "\\" + i.ToString() + ".jpg");
                        imgSrc.Next();
                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public static void GenerateHtml(string fileName, ImgSrc imgSrc, int count)
        {
            fileName = new string('0', 3 - fileName.Length) + fileName;
            using (StreamWriter writer = new StreamWriter( fileName + ".html" ))
            {
                while (count-- > 0)
                {
                    writer.WriteLine("<img src=\""+ imgSrc.FullPath + "\">");
                    imgSrc.Next();
                }
            }
        }


        public static void SearchImg(string folderName, ImgSrc imgSrc, int count)
        {
            folderName = new string('0', 3 - folderName.Length) + folderName;
            Directory.CreateDirectory(folderName);
            using (WebClient webClient = new WebClient())
            {
                for (int i = 538724; i <= 540000; i++)
                {
                    //for (int j = 4251; j >= 4045; j--)
                    //{
                        try
                        {
                            imgSrc.content.n2 = i;
                            //imgSrc.content.n4 = j;
                            using (StreamWriter writer = new StreamWriter("find.html", true))
                            {
                                writer.WriteLine("<img src=\"" + imgSrc.FullPath + "\">");
                            }
                            //webClient.DownloadFile(imgSrc.FullPath, ".\\" + folderName + "\\" + i.ToString() + ".jpg");
                        }
                        catch (Exception e)
                        {
                            using (StreamWriter writer = new StreamWriter("find.txt", true))
                            {
                                writer.WriteLine();
                            }
                        }
                    //}
                }
                        
                        
                        

            }
        }
    }
}
