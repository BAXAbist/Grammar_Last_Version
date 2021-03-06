﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Grammatic
    {
        //Поудалять ненужные переменные
        private int ruleCounts = 0, ruleLength = 0;
        private string nonterms = "QWERTYUIOPADFGHJKLZXCVBNM";
        private readonly string terms = "qwertyuiopasdfghjklzxcvbnm";
        private bool automatRuleType = false;
        private string[] contextes;
        private Random rand = new Random();

        public Grammatic(int nontermsCount, int rulesCount, int ruleLength, bool LeftOrRight)
        {
            string new_upper_alph = "S";
            HashSet<int> Indexes = new HashSet<int>();
            int j = 0;
            if(nontermsCount>1)
            do
            {
                if (Indexes.Add(rand.Next(0, nonterms.Length)))
                    j++;
            } while (j < nontermsCount - 1);
            foreach (int i in Indexes)
            {
                new_upper_alph += nonterms[i];
            }
            automatRuleType = LeftOrRight;
            this.ruleCounts = rulesCount;
            this.ruleLength = ruleLength;
            if (ruleCounts == 0)
                ruleCounts = rand.Next(2, 10);
            if (this.ruleLength == 0)
                this.ruleLength = rand.Next(3, 5);
            int contextCount = rand.Next(2, 4);
            j = 1;
            contextes = new string[contextCount];
            HashSet<string> AllContext = new HashSet<string>();
            do
            {
                if (AllContext.Add(GenerateString(nonterms + terms, rand.Next(0, 3))))
                    j++;
            } while (j <= contextCount);
            AllContext.CopyTo(contextes);
            if (new_upper_alph != "")
                nonterms = new_upper_alph;
        }

        private string GenerateString(string alphabet, int length)
        {
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += alphabet[rand.Next(0, alphabet.Length)];
            }
            return result;
        }

        public bool GenerateGrammatic(int type, out List<string> generated_grammatic)
        {
            bool success = false;
            try
            {
                switch (type)
                {
                    case 1:
                        do
                        {
                            success = Automatic(out generated_grammatic);
                        } while (!success);
                        break;
                    case 2:
                        do
                        {
                            success = ContextFree(out generated_grammatic);
                        } while (!success);
                        break;
                    case 3:
                        do
                        {
                            success = ContextDepend(out generated_grammatic);
                        } while (!success);
                        break;
                    case 4:
                        do
                        {
                            success = Natural(out generated_grammatic);
                        } while (!success);
                        break;
                    default:
                        {
                            generated_grammatic = new List<string>();
                            return false;
                        }
                }
                return success;
            }
            catch
            {
                generated_grammatic = new List<string>();
                return false;
            }
        }

        //Автоматная - разобратся с длинной и терминальными правилами
        private bool Automatic(out List<string> generated_grammatic)
        {
            string GenerateAutomaticValue(int length, bool left, bool terminal)
            {
                string result = "";
                if (!terminal)
                {
                    char term = terms[rand.Next(0, terms.Length)];
                    char nonterm = nonterms[rand.Next(1, nonterms.Length)];
                    if (left)
                        result += "" + nonterm + term;
                    else
                        result += "" + term + nonterm;
                }
                else
                {
                    for(int i=0;i<length;i++)
                    {
                        result += "" + terms[rand.Next(0, terms.Length)];
                    }
                }
                return result;
            }
            ruleLength = 2;
            generated_grammatic = new List<string>();
            string generated_rule = "";
            string value;
            int k;
            List<char> list_of_used;
            HashSet<char> avaliable_nonterms = new HashSet<char>();
            foreach (char c in nonterms)
                avaliable_nonterms.Add(c);
            HashSet<char> used_nonterms = new HashSet<char>();
            if (ruleCounts == 1)
            {
                if (avaliable_nonterms.Count == 1)
                {
                    generated_rule = nonterms[0] + "-" + GenerateAutomaticValue(1, automatRuleType, true);
                    generated_grammatic.Add(generated_rule);
                    return true;
                }
                else
                {
                    generated_rule = nonterms[0] + "-";
                    value = GenerateAutomaticValue(ruleLength, automatRuleType, false);
                    foreach (char c in value)
                        if (char.IsUpper(c))
                            used_nonterms.Add(c);
                    generated_rule += value;
                    generated_grammatic.Add(generated_rule);
                    list_of_used = new List<char>(used_nonterms);
                    k = 0;
                    while (k < list_of_used.Count)
                    {
                        generated_rule = list_of_used[k] + "-";
                        for (int i = 0; i < ruleCounts; i++)
                        {
                            value = GenerateAutomaticValue(ruleLength, automatRuleType, false);
                            for (int j = 0; j < value.Length; j++)
                                if (char.IsUpper(value[j]))
                                    used_nonterms.Add(value[j]);
                            generated_rule += value;
                        }
                        if (k == list_of_used.Count)
                        {
                            generated_rule += "|" + GenerateAutomaticValue(1, automatRuleType, true);
                        }
                        generated_grammatic.Add(generated_rule);
                        list_of_used = new List<char>(used_nonterms);
                        k++;
                    }
                    generated_grammatic[generated_grammatic.Count-1] += "|" + GenerateAutomaticValue(1, automatRuleType, true);
                    avaliable_nonterms.Remove(nonterms[0]);
                    if (!used_nonterms.SetEquals(avaliable_nonterms))
                    {
                        return false;
                    }
                    else
                        return true;
                }
            }
            else
            {
                generated_rule = nonterms[0] + "-";
                for (int i = 0; i < ruleCounts - 1; i++)
                {
                    value = GenerateAutomaticValue(ruleLength, automatRuleType, false);
                    foreach (char c in value)
                        if (char.IsUpper(c))
                            used_nonterms.Add(c);
                    generated_rule += value + "|";
                }
                generated_rule += GenerateAutomaticValue(1, automatRuleType, true);
                generated_rule.Remove(generated_rule.Length - 1);
                generated_grammatic.Add(generated_rule);
                list_of_used = new List<char>(used_nonterms);
                k = 0;
                while (k < list_of_used.Count)
                {
                    generated_rule = list_of_used[k] + "-";
                    for (int i = 0; i < ruleCounts - 1; i++)
                    {
                        value = GenerateAutomaticValue(ruleLength, automatRuleType, false);
                        for (int j = 0; j < value.Length; j++)
                            if (char.IsUpper(value[j]))
                                used_nonterms.Add(value[j]);
                        generated_rule += value + "|";
                    }
                    generated_rule += GenerateAutomaticValue(1, automatRuleType, true);
                    generated_rule.Remove(generated_rule.Length - 1);
                    generated_grammatic.Add(generated_rule);
                    list_of_used = new List<char>(used_nonterms);
                    k++;
                }
                avaliable_nonterms.Remove(nonterms[0]);
                if (!used_nonterms.SetEquals(avaliable_nonterms))
                {
                    return false;
                }
                else
                    return true;
            }
        }

        // КС - разобраться с полнотой
        private bool ContextFree(out List<string> generated_grammatic)
        {
            string GenerateValue(int length, bool terminal)
            {
                string result = "";
                if (!terminal)
                {
                    int nonterms_count = rand.Next(1, length);
                    HashSet<int> nonterm_Indexes = new HashSet<int>();
                    int i = 1;
                    do
                    {
                        if (nonterm_Indexes.Add(rand.Next(0, length - 1)))
                            i++;
                    } while (i < nonterms_count);
                    for (int j = 0; j < length; j++)
                    {
                        if (nonterm_Indexes.Contains(j))
                            result += nonterms[rand.Next(1, nonterms.Length)];
                        else
                            result += terms[rand.Next(0, terms.Length)];
                    }
                }
                else
                {
                    for (int j = 0; j < length; j++)
                        result += terms[rand.Next(0, terms.Length)];
                }
                return result;
            }
            generated_grammatic = new List<string>();
            HashSet<char> avaliable_nonterms = new HashSet<char>();
            foreach (char c in nonterms)
                avaliable_nonterms.Add(c);
            HashSet<char> used_nonterms = new HashSet<char>();
            string generated_rule = "";
            string value = "";
            List<char> list_of_used;
            int k = 0;
            //генерируем правило для стартового символa
            if (ruleCounts == 1)
            {
                if (avaliable_nonterms.Count == 1)
                {
                    generated_rule = nonterms[0] + "-" + GenerateValue(ruleLength, true);
                    generated_grammatic.Add(generated_rule);
                    return true;
                }
                else
                {
                    generated_rule = nonterms[0] + "-";
                    value = GenerateValue(ruleLength, false);
                    foreach (char c in value)
                        if (char.IsUpper(c))
                            used_nonterms.Add(c);
                    generated_rule += value;
                    generated_grammatic.Add(generated_rule);
                    list_of_used = new List<char>(used_nonterms);
                    k = 0;
                    while (k < list_of_used.Count)
                    {
                        generated_rule = list_of_used[k] + "-";
                        for (int i = 0; i < ruleCounts; i++)
                        {
                            value = GenerateValue(ruleLength, false);
                            for (int j = 0; j < value.Length; j++)
                                if (char.IsUpper(value[j]))
                                    used_nonterms.Add(value[j]);
                            generated_rule += value;
                        }
                        if (k == list_of_used.Count)
                        {
                            generated_rule += "|" + GenerateValue(ruleLength, true);
                        }
                        generated_grammatic.Add(generated_rule);
                        list_of_used = new List<char>(used_nonterms);
                        k++;
                    }
                    generated_grammatic[generated_grammatic.Count - 1] += "|" + GenerateValue(ruleLength, true);
                    avaliable_nonterms.Remove(nonterms[0]);
                    if (!used_nonterms.SetEquals(avaliable_nonterms))
                    {
                        return false;
                    }
                    else
                        return true;
                }

            }
            else
            {
                generated_rule = nonterms[0] + "-";
                for (int i = 0; i < ruleCounts - 1; i++)
                {
                    value = GenerateValue(ruleLength, false);
                    for (int j = 0; j < value.Length; j++)
                        if (char.IsUpper(value[j]))
                            used_nonterms.Add(value[j]);
                    generated_rule += value + "|";
                }
                generated_rule += GenerateValue(ruleLength, true);
                generated_rule.Remove(generated_rule.Length - 1);
                generated_grammatic.Add(generated_rule);
                //пытаемся сгенерировать правила для всех уже использованных символов
                list_of_used = new List<char>(used_nonterms);
                list_of_used.Remove(nonterms[0]);
                k = 0;
                while (k < list_of_used.Count)
                {
                    generated_rule = list_of_used[k] + "-";
                    for (int i = 0; i < ruleCounts - 1; i++)
                    {
                        value = GenerateValue(ruleLength, false);
                        for (int j = 0; j < value.Length; j++)
                            if (char.IsUpper(value[j]))
                                used_nonterms.Add(value[j]);
                        generated_rule += value + "|";
                    }
                    generated_rule += GenerateValue(ruleLength, true);
                    generated_rule.Remove(generated_rule.Length - 1);
                    generated_grammatic.Add(generated_rule);
                    list_of_used = new List<char>(used_nonterms);
                    k++;
                }
                avaliable_nonterms.Remove(nonterms[0]);
                if (!used_nonterms.SetEquals(avaliable_nonterms))
                {
                    return false;
                }
                else
                    return true;
            }
        }

        // КЗ - не лезь оно тебя сожрет
        private bool ContextDepend(out List<string> generated_grammatic)
        {
            string GenerateDependValue(int length, bool terminal)
            {
                string result = "";
                if (!terminal)
                {
                    if (nonterms.Length > 1)
                    {
                        int nonterms_count = rand.Next(2, length);
                        HashSet<int> nonterm_Indexes = new HashSet<int>();
                        int i = 1;
                        do
                        {
                            if (nonterm_Indexes.Add(rand.Next(0, length - 1)))
                                i++;
                        } while (i < nonterms_count);
                        for (int j = 0; j < length; j++)
                        {
                            if (nonterm_Indexes.Contains(j))
                                result += nonterms[rand.Next(1, nonterms.Length)];
                            else
                                result += terms[rand.Next(0, terms.Length)];
                        }
                    }
                    else
                        for(int i=0;i<ruleLength;i++)
                            result+= terms[rand.Next(0, terms.Length)];
                }
                else
                {
                    for (int j = 0; j < length; j++)
                        result += terms[rand.Next(0, terms.Length)];
                }
                return result;
            }
            generated_grammatic = new List<string>();
            List<string> avaliable_list = new List<string>();
            List<string> used_list = new List<string>();
            HashSet<string> used_nonterms = new HashSet<string>(used_list);
            HashSet<string> avaliable_nonterms = new HashSet<string>(avaliable_list);
            foreach (char c in nonterms)
                avaliable_list.Add(Convert.ToString(c));
            avaliable_list.Remove(avaliable_list[0]);
            List<string> contexted_list = new List<string>();
            for (int i = 0; i < avaliable_list.Count; i++)
            {
                int contxA, contxB;
                contxA = rand.Next(0, contextes.Length);
                contxB = rand.Next(0, contextes.Length);
                string key = contextes[contxA] + avaliable_list[i] + contextes[contxB];
                contexted_list.Add(key);
            }
            string generated_rule = nonterms[0] + "-";
            for(int i=0;i<ruleCounts-1;i++)
            {
                string value = GenerateDependValue(ruleLength, false);
                foreach (char k in value)
                    if (char.IsUpper(k))
                        used_nonterms.Add(Convert.ToString(k));
                generated_rule += value + "|";
            }
            generated_rule+=GenerateDependValue(ruleLength, true);
            generated_grammatic.Add(generated_rule);
            if (nonterms.Length > 1)
            {
                used_list = new List<string>(used_nonterms);
                int f = 0;
                while (f < used_list.Count)
                {
                    used_nonterms.Clear();
                    used_nonterms = new HashSet<string>(used_list);
                    int key_index = avaliable_list.IndexOf(used_list[f]);
                    generated_rule = contexted_list[key_index];
                    string[] contx = generated_rule.Split(Convert.ToChar(avaliable_list[key_index]));
                    generated_rule += "-";
                    for (int i = 0; i < ruleCounts; i++)
                    {
                        string value = GenerateDependValue(ruleLength, false);
                        foreach (char k in value)
                            if (char.IsUpper(k))
                                used_nonterms.Add(Convert.ToString(k));
                        generated_rule += contx[0] + value + contx[1] + "|";
                    }
                    generated_rule += contx[0] + GenerateDependValue(ruleLength, true) + contx[1];
                    generated_grammatic.Add(generated_rule);
                    used_list.Clear();
                    used_list = new List<string>(used_nonterms);
                    f++;
                }
                avaliable_nonterms = new HashSet<string>(avaliable_list);
            }
            if (used_nonterms.SetEquals(avaliable_nonterms))
                return true;
            else
                return false;
        }

        private bool Natural(out List<string> generated_grammatic)
        {
            string GenerateNaturalValue(int lenght, char key, bool terminal)
            {
                string result = "";
                string mem = nonterms;
                int index = rand.Next(0, lenght);
                result += GenerateString(mem + terms, index - 1);
                result += key;
                result += GenerateString(mem + terms, lenght - index);
                return result;
            }
            generated_grammatic = new List<string>();
            foreach (char key in nonterms)
            {
                string generated_rule = GenerateNaturalValue(ruleLength, key, false) + "-";
                for(int i=0;i<ruleCounts-1;i++)
                {
                    generated_rule += GenerateNaturalValue(ruleLength, nonterms[rand.Next(2, nonterms.Length)], false)+"|";
                }
                generated_rule += GenerateNaturalValue(ruleLength, terms[rand.Next(1, terms.Length)], true);
                generated_grammatic.Add(generated_rule);
            }
            return true;
        }
    }
}
//somebody once told me