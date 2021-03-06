﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandler
{
    class Handler
    {
        private string alphabet = "QWERTYUIOPADFGHJKLZXCVBNMSqwertyuiopasdfghjklzxcvbnms";

        public Handler()
        {

        }

        public bool CheckGramm(string[] masStr)
        {
            if (masStr[0] == "")
                return false;
            for (int i = 0; i < masStr.Length; i++)
            {
                    if (!CheckString(masStr[i]))
                        return false;
            }
            return true;
        }
        
        private bool CheckString(string str)
        {
            int j = 0;
            if (str == "")
                return true;
            while (str[j] != '-')
            {
                if (alphabet.Contains(str[j]))
                {
                    j++;
                    if (j == str.Length)
                        return false;
                }
                else
                    return false;
            }
            j++;

            do
            {
                while (str[j] != '|')
                    if (alphabet.Contains(str[j]))
                    {
                        j++;
                        if (j == str.Length)
                            return true;
                    }
                    else
                        return false;
                j++;
            } while (j < str.Length);

            return true;
        }
    }
}
