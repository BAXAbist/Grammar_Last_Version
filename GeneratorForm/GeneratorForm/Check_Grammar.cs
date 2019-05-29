using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Grammar
{
    public class Checker
    {
        public Checker()
            {

            }

        public string Analysis (string[] str)
        {
            Dictionary<string, string[]> map = new Dictionary<string, string[]>();
            string[] words;
            string[] changes;
            char[] dumb = { '|', '-' };
            for (int i = 0; i < str.Length; i++)
            {
                words = str[i].Split(dumb);
                changes = new string[words.Length - 1];
                for (int j = 0; j < words.Length - 1; j++)
                    changes[j] = words[j + 1];
                map.Add(words[0], changes);
            }

            bool isAuto = true;
            bool isCF = false;
            bool isCS = false;

            foreach (var k in map.Keys)
            {
                if (isAuto)
                {
                    isAuto = Check_Auto(k, map[k]);
                    if (!isAuto)
                        isCF = true;
                }
                if (isCF)
                {
                    isCF = Check_Context_Free(k);
                    if (!isCF)
                        isCS = true;
                }
                if (isCS)
                {
                    isCS = Check_Context_Sensitive(k, map[k]);
                    if (!isCS)
                        isCS = false;
                }
            }

            if (isAuto)
            {
                return "Автоматная грамматика";
            }
            if (isCF)
            {
                return "Контекстно-свободная грамматика";
            }
            if (isCS)
            {
                return "Контекстно-зависимая грамматика";
            }
            return "Естественный язык";
        }

        static bool Check_Auto(string key, string[] value)
        {
            bool check = true;
            bool L;
            bool R;
            bool L_check = false;
            bool R_check = false;
            if (key.Length > 1)
                return false;
            for (int i = 0; i < value.Length; i++)
                if (value[i].Length > 3)
                    return false;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].Length == 2)
                {
                    if (check)
                    {
                        L_check = char.IsUpper(value[i][0]);
                        R_check = char.IsUpper(value[i][1]);
                        check = false;
                    }
                    L = char.IsUpper(value[i][0]);                  //true если заглавная false строчная
                    R = char.IsUpper(value[i][1]);
                    if ((L != L_check) || (R != R_check))
                    {
                        return false;
                    }
                }
                else if (value[i].Length > 2)
                    return false;
                else
                if (char.IsUpper(value[i][0]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool Check_Context_Free(string key)
        {
            if (key.Length > 1)
                return false;
            return true;
        }

        static bool Check_Context_Sensitive(string key, string[] value)
        {
            int j = 0;
            int l = 0;
            if (key.Length > 1)
                for (int i = 0; i < value.Length; i++)
                {
                    while (key[j] == value[i][j])
                        j++;
                    while ((key[key.Length - l - 1] == value[i][value[i].Length - l - 1]) && (j != key.Length - l - 1))
                        l++;
                    if (j != key.Length - l - 1)
                    {
                        return false;
                    }
                    j = 0;
                    l = 0;
                }
            return true;
        }
    }
}
