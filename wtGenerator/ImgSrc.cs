using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wtGenerator
{
    class Url
    {
        private static string[] urlBasic = {
            "http://ac.tc.qq.com/store_file_download?buid=",
            "&uin=",
            "&dir_path=",
            "/&name=" };

        public string u1, u2, u3, u4;

        public Url ()
        {
            u1 = urlBasic[0];
            u2 = urlBasic[1];
            u3 = urlBasic[2];
            u4 = urlBasic[3];
        }
    }

    class Content
    {
        private string _v1, _v3, _v4;
        public int n2, n3, n4;

        public Content()
        {
            _v1 = _v3 = _v4 = "";
            n2 = n3 = n4 = 0;
        }

        public string v1
        {
            get { return _v1; }
            set { _v1 = value; }
        }

        public string v2
        {
            get { return n2.ToString(); }
        }

        public string v3
        {
            get { return _v3 + n3.ToString(); }
            set { _v3 = value; }
        }

        public string v4
        {
            get { return n4.ToString() + _v4; }
            set { _v4 = value; }
        }
    }

    class ImgSrc
    {
        public Url url = new Url();
        public Content content = new Content();

        public ImgSrc(string str)
        {
            Worker.StringToImgSrc(this, str);
        }

        public string FullPath
        {
            get { return url.u1 + content.v1 + url.u2 + content.v2 + url.u3 + content.v3 + url.u4 + content.v4; }
        }

        public void Next()
        {
            content.n2++;
            content.n4++;
        }
    }
}
