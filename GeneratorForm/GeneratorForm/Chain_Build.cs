using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Build
{
    public class Builder
    {
        public Builder()
        {

        }

        public string GenerateChain(string[] str)
        {
            Dictionary<string, string[]> keyValues = new Dictionary<string, string[]>();
            string[] words;
            string[] changes;
            char[] dumb = { '|', '-' };
            for (int i = 0; i < str.Length; i++)
            {
                words = str[i].Split(dumb);
                changes = new string[words.Length - 1];
                for (int j = 0; j < words.Length - 1; j++)
                    changes[j] = words[j + 1];
                keyValues.Add(words[0], changes);
            }

            Random rand = new Random();
            string res_in_step = "S";
            string s;
            string result = res_in_step;
            int count = 0;
            while (((s = KeyCheck(res_in_step, keyValues)) != "")&&(count < 145))
            {
                int index = rand.Next(keyValues[s].Length);
                string kek = keyValues[s][index];
                res_in_step = res_in_step.Replace(s, kek);
                try
                {
                    result += " — " + res_in_step;
                }
                catch
                {
                    result = "Fatal error";
                    break;
                }
                count++;
            }
            if (count == 145)
                result = "Fatal error1";
            return result;
        }

        string KeyCheck(string res, Dictionary<string, string[]> gramm)
        {
            foreach (string s in gramm.Keys)
            {
                if (res.Contains(s))
                    return s;
            }
            return "";
        }
    }
}
