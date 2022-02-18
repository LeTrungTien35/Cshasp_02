using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LibDictionary
{
    public class DicEnVi
    {
        public Dictionary<string, string> dic;
        private string pathDicTextFile;

        public Dictionary<string, string>.KeyCollection En
        {
            get
            {
                return dic.Keys;
            }
        }

        public int Count
        {
            get
            {
                return dic.Count;
            }
        }

        public List<string> AllWord()
        {
            List<string> listAll = new List<string>();
            foreach (var item in dic)
                listAll.Add(string.Format("{0}: {1}", item.Key, item.Value));
            return listAll;
        }

        /// <summary>
        /// hàm tạo
        /// </summary>
        /// <param name="pathDicTextFile"></param>
        public DicEnVi(string pathDicTextFile = "tudien.txt")
        {
            dic = new Dictionary<string, string>();
            this.pathDicTextFile = pathDicTextFile;
        }
        public void LoadDic()
        {

            string allText = File.ReadAllText(pathDicTextFile);
            char[] sep1 = { '\r', '\n' };
            char[] sep2 = { ':' };
            string[] lines = allText.Split(sep1, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in lines)
            {
                string[] w = item.Split(sep2, StringSplitOptions.RemoveEmptyEntries);
                if (w.Length == 2)
                {
                    string en = w[0];
                    string vi = w[1];
                    AddDic(en, vi);
                }
            }
        }
        public bool SaveDic()
        {
            string contents = "";
            foreach (var item in dic)
            {
                contents += string.Format("{0}:{1}\r\n", item.Key, item.Value);
            }
            File.WriteAllText(pathDicTextFile, contents);
            return true;
        }
        public bool AddDic(string en, string vi)
        {
            if (!dic.ContainsKey(en))
            {
                dic.Add(en, vi);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateDic(string oldEn, string newEn, string newVi)
        {
            if (dic.ContainsKey(oldEn) && !dic.ContainsKey(newEn))
            {
                dic.Remove(oldEn);
                dic.Add(newEn, newVi);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateDic(string oldEn, string newVi)
        {
            if (dic.ContainsKey(oldEn))
            {
                dic[oldEn] = newVi;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteDic(string en)
        {
            if (dic.ContainsKey(en))
            {
                dic.Remove(en);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Search(string en)
        {
            if (dic.ContainsKey(en))
                return dic[en];
            else
                return null;
        }
        public Dictionary<string, string> FindStartEn(string en)
        {
            Dictionary<string, string> kq = new Dictionary<string, string>();
            foreach (var item in dic)
            {
                if (item.Key.StartsWith(en))
                {
                    kq.Add(item.Key, item.Value);
                }
            }
            return kq;
        }
        public Dictionary<string, string> FindContainVi(string vi)
        {
            Dictionary<string, string> kq = new Dictionary<string, string>();
            foreach (var item in dic)
            {
                if (item.Value.Contains(vi))
                {
                    kq.Add(item.Key, item.Value);
                }
            }
            return kq;
        }
    }
}
