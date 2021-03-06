﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary1;
using Chain_Build;
using Check_Grammar;
using ErrorHandler;

namespace GeneratorForm
{
    public partial class GeneratorForm : Form
    {
        Help_Form f;
        private Grammatic gramm;
        private List<string> degradated_grammatic;
        private int gramm_type = 0, gramm_rules_count = 0, gramm_rule_lenght = 0, gramm_nonterms_count = 0;
        private bool gramm_left_or_right = false;
        private Builder chain = new Builder();
        private Checker asys = new Checker();
        private Handler errHand = new Handler();

        //часть с окном генерации грамматик
        public GeneratorForm()
        {
            InitializeComponent();
            Random rand = new Random();
            grammatic_auto_type.Hide();
            if (rand.Next(1, 10) > 5)
                auto_left.Checked = true;
            else
                auto_right.Checked = true;
            buttonSave.Hide();
            type_contextFree.Checked = true;
            nonterms_count_edit.Text = Convert.ToString(rand.Next(2, 26));
            rules_fromcount_edit.Text = Convert.ToString(rand.Next(1, 10));
            rules_tocount_edit.Text = Convert.ToString(Convert.ToInt32(rules_fromcount_edit.Text) + 2);
            rules_fromlength_edit.Text = Convert.ToString(rand.Next(3, 6));
            rule_tolength_edit.Text = Convert.ToString(Convert.ToInt32(rules_fromlength_edit.Text) + 2);
            set_rules_static.Checked = true;
            
        }

        private void Grammar_Type_Set(object sender, EventArgs e)
        {
            rule_tolength_edit.Visible = (sender == type_automatic) ? false : true;
            rule_length_label.Visible = (sender == type_automatic) ? false : true;
            grammatic_auto_type.Visible = (sender == type_automatic) ? true : false;
            set_rules_dinamic.Visible = (sender == type_automatic) ? false : true;
            rules_fromcount_edit.Visible = (set_rules_dinamic.Checked && set_rules_dinamic.Visible) ? true : false;
            rules_fromlength_edit.Visible = (set_rules_dinamic.Checked && set_rules_dinamic.Visible) ? true : false;
            to_label1.Visible = (set_rules_dinamic.Checked && set_rules_dinamic.Visible) ? true : false;
            to_label2.Visible = (set_rules_dinamic.Checked && set_rules_dinamic.Visible) ? true : false;
            from_label1.Visible = (set_rules_dinamic.Checked && set_rules_dinamic.Visible) ? true : false;
            from_label2.Visible = (set_rules_dinamic.Checked && set_rules_dinamic.Visible) ? true : false;
            if (sender == type_automatic)
                gramm_type = 1;
            else
                if (sender == type_contextFree)
                gramm_type = 2;
            else
                if (sender == type_contextDepend)
                gramm_type = 3;
            else
                gramm_type = 4;
            if (gramm_type == 1)
                set_rules_static.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grammatic_textBox.Clear();
            nonterms_count_edit.BackColor = Color.White;
            rules_tocount_edit.BackColor = Color.White;
            rule_tolength_edit.BackColor = Color.White;
            rules_fromcount_edit.BackColor = Color.White;
            rules_fromlength_edit.BackColor = Color.White;
            grammatic_nonterms.Text = "Нетерминалы";
            grammatic_rules.Text = "Правила";
            bool error = false;
            if (!int.TryParse(nonterms_count_edit.Text, out gramm_nonterms_count) || gramm_nonterms_count < 1)
            {
                grammatic_textBox.AppendText("\tНеправильно введено количество нетерминалов. Введите натуральное число\n");
                grammatic_nonterms.Text = "ВОЗНИКЛА ОШИБКА";
                nonterms_count_edit.BackColor = Color.Red;
                error = true; ;
            }
            if (!set_rules_dinamic.Checked)
            {
                if(!int.TryParse(rules_tocount_edit.Text, out gramm_rules_count)||gramm_rules_count<1)
                {
                    grammatic_textBox.AppendText("\tНеверно введено количество замен. Введите натуральное число\n");
                    grammatic_rules.Text = "ВОЗНИКЛА ОШИБКА";
                    rules_tocount_edit.BackColor = Color.Red;
                    error = true;
                }
                if (!int.TryParse(rule_tolength_edit.Text, out gramm_rule_lenght) || gramm_rule_lenght < 1)
                {
                    grammatic_textBox.AppendText("\tНеверно введена длинна замен. Введите натуральное число\n");
                    grammatic_rules.Text = "ВОЗНИКЛА ОШИБКА";
                    rule_tolength_edit.BackColor = Color.Red;
                    error = true;
                }
            }
            else
            {
                Random rand = new Random();
                int i, j;
                if (!int.TryParse(rules_fromcount_edit.Text, out i) || i < 1)
                {
                    grammatic_textBox.AppendText("\tНеверно введена левая граница возмножного количества замен. Введите натуральное число\n");
                    grammatic_rules.Text = "ВОЗНИКЛА ОШИБКА";
                    rules_fromcount_edit.BackColor = Color.Red;
                    error = true;
                }
                if(!int.TryParse(rules_tocount_edit.Text, out j)||j<1||j<i)
                {
                    grammatic_textBox.AppendText("\tНеверно введена правая граница возможного количества замен. Введите натуральное число, большее, либо равное левой границе\n");
                    grammatic_rules.Text = "ВОЗНИКЛА ОШИБКА";
                    rules_tocount_edit.BackColor = Color.Red;
                    error = true;
                }
                if(!error)
                    gramm_rules_count = rand.Next(i, j);
                if(!int.TryParse(rules_fromlength_edit.Text, out i)||i<1)
                {
                    grammatic_textBox.AppendText("\tНеверно введена левая гранца возмножной длинны замены. Введите натуральное число\n");
                    grammatic_rules.Text = "ВОЗНИКЛА ОШИБКА";
                    rules_fromlength_edit.BackColor = Color.Red;
                    error = true;
                }
                if(!int.TryParse(rule_tolength_edit.Text, out j)||j<1||j<i)
                {
                    grammatic_textBox.AppendText("\tНеверно введена правая граница возмножной длинны замен. Введите натуральное число, большее, либо равное левой границе\n");
                    grammatic_rules.Text = "ВОЗНИКЛА ОШИБКА";
                    rule_tolength_edit.BackColor = Color.Red;
                    error = true;
                }
                if(!error)
                    gramm_rule_lenght = rand.Next(i, j);
            }
            if (error)
                return;
            gramm_left_or_right = auto_left.Checked;
            gramm = new Grammatic(gramm_nonterms_count, gramm_rules_count, gramm_rule_lenght, gramm_left_or_right);
            if (!gramm.GenerateGrammatic(gramm_type, out degradated_grammatic))
            {
                grammatic_textBox.AppendText("Во время генерации возникла ошибка. Попробуйте снова или с другими параметрами");
                nonterms_count_edit.BackColor = Color.Red;
                rules_tocount_edit.BackColor = Color.Red;
                rule_tolength_edit.BackColor = Color.Red;
                rules_fromcount_edit.BackColor = Color.Red;
                rules_fromlength_edit.BackColor = Color.Red;
            }
            else
            {
                foreach (string s in degradated_grammatic)
                    grammatic_textBox.AppendText(s + "\n");
                buttonSave.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dial = new SaveFileDialog
            {
                DefaultExt = "txt",
                AddExtension = true,
                FileName = "*.txt",
                Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*"
            };
            if (dial.ShowDialog() == DialogResult.OK)
            {
                Stream file = dial.OpenFile();
                StreamWriter sw = new StreamWriter(file);
                foreach (string s in degradated_grammatic)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
                file.Close();
                Chain_Builder_RichBox_Folder.Text = dial.FileName;
                Chain_Builder_from_Folder_in_TextBox();
                Chain_Builder_Check_EnterManual.Visible = false;
                Chain_Builder_Button_Clear.Visible = true;
                Chain_Builder_Button_Compile.Visible = true;

                Check_Grammar_RichBox_Folder.Text = dial.FileName;
                Check_Grammar_from_Folder_in_TextBox();
                Check_Grammar_Check_EnterManual.Visible = false;
                Check_Grammar_Button_Clear.Visible = true;
                Check_Grammar_Button_Check.Visible = true;
            }
        }

        private void Set_Rules_Type(object sender, EventArgs e)
        {
            if(sender == set_rules_default)
            {
                rules_fromcount_edit.Hide();
                rules_fromlength_edit.Hide();
                to_label1.Hide();
                to_label2.Hide();
                from_label1.Hide();
                from_label2.Hide();
                rules_tocount_edit.Text = "5";
                rules_fromcount_edit.Text = "5";
                rule_tolength_edit.Text = "4";
                rules_fromlength_edit.Text = "4";
                rules_tocount_edit.BackColor = SystemColors.Control;
                rule_tolength_edit.BackColor = SystemColors.Control;
                rule_tolength_edit.ReadOnly = true;
                rules_tocount_edit.ReadOnly = true;
            }
            else
            {
                rule_tolength_edit.ReadOnly = false;
                rules_tocount_edit.ReadOnly = false;
                rules_tocount_edit.BackColor = SystemColors.Window;
                rule_tolength_edit.BackColor = SystemColors.Window;
                rules_fromcount_edit.Visible = (sender == set_rules_dinamic) ? true : false;
                rules_fromlength_edit.Visible = (sender == set_rules_dinamic) ? true : false;
                to_label1.Visible = (sender == set_rules_dinamic) ? true : false;
                to_label2.Visible = (sender == set_rules_dinamic) ? true : false;
                from_label1.Visible = (sender == set_rules_dinamic) ? true : false;
                from_label2.Visible = (sender == set_rules_dinamic) ? true : false; 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (setDefaultNonterms.Checked)
            {
                nonterms_count_edit.ReadOnly = true;
                nonterms_count_edit.Text = "26";
                nonterms_count_edit.BackColor = SystemColors.Control;
            }
            else
            {
                nonterms_count_edit.ReadOnly = false;
                nonterms_count_edit.BackColor = SystemColors.Window;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new Help_Form();
            }
            string TextName = "../../Text1.txt";
            f.Help_Form_Changed(TextName);
            f.Show();
        }

        //Все функции для страницы с составителем цепочек

        SaveFileDialog SaveFile = new SaveFileDialog
        {
            DefaultExt = "txt",
            AddExtension = true,
            FileName = "*.txt",
            Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*"
        };

        private void Chain_Builder_Button_SaveFile_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                Stream file = SaveFile.OpenFile();
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(Chain_Builder_RichBox_Result.Text);
                sw.Close();
                file.Close();
                
            }
        }

        private void Chain_Builder_Button_Compile_Click(object sender, EventArgs e)
        {
            while (Chain_Builder_RichBox_EnterManual.Text.IndexOf("\n\n") > -1)
                Chain_Builder_RichBox_EnterManual.Text = Chain_Builder_RichBox_EnterManual.Text.Replace("\n\n", "\n");
            Chain_Builder_RichBox_EnterManual.Text = Chain_Builder_RichBox_EnterManual.Text.Replace(" ", "");
            string[] str = Chain_Builder_RichBox_EnterManual.Text.Split('\n');
            bool f = errHand.CheckGramm(str);
            if (f)
                Chain_Builder_RichBox_Result.Text = chain.GenerateChain(str);
            else
                Chain_Builder_RichBox_Result.Text = "Неправильный ввод грамматики";
            Chain_Builder_Button_SaveFile.Visible=true;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        OpenFileDialog OpenFile = new OpenFileDialog();

        private void Chain_Builder_Button_Folder_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Chain_Builder_RichBox_Folder.Text = OpenFile.FileName;
                string FileName = Chain_Builder_RichBox_Folder.Text;
                Chain_Builder_RichBox_EnterManual.Visible = true;
                Chain_Builder_Button_Clear.Visible = true;
                FileStream f = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(f);
                Chain_Builder_RichBox_EnterManual.Text = reader.ReadToEnd();
                Chain_Builder_Check_EnterManual.Visible = false;
                Chain_Builder_Button_Compile.Visible = true;
            }
        }

        private void Chain_Builder_Check_EnterManual_CheckedChanged(object sender, EventArgs e)
        {
            Chain_Builder_Button_Clear.Visible = true;
            Chain_Builder_RichBox_EnterManual.Visible = true;
            Chain_Builder_Button_Compile.Visible = true;
            Chain_Builder_RichBox_Folder.Visible = !Chain_Builder_Check_EnterManual.Checked;
            Chain_Builder_Button_Folder.Visible = !Chain_Builder_Check_EnterManual.Checked;
        }

        private void Chain_Builder_Button_Help_Click(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new Help_Form();
            }
            string TextName = "../../Text2.txt";
            f.Help_Form_Changed(TextName);
            f.Show();
        }

        public void Chain_Builder_from_Folder_in_TextBox()
        {
            Chain_Builder_RichBox_EnterManual.Visible = true;
            FileStream f = new FileStream(Chain_Builder_RichBox_Folder.Text, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(f);
            Chain_Builder_RichBox_EnterManual.Text = reader.ReadToEnd();
        }

        private void Chain_Builder_Button_Clear_Click(object sender, EventArgs e)
        {
            Chain_Builder_RichBox_EnterManual.Clear();
            Chain_Builder_RichBox_Result.Clear();
            Chain_Builder_RichBox_Folder.Clear();
            Chain_Builder_Button_SaveFile.Visible = false;
        }

        //Все функции для страницы с анализатором грамматик

        private void Check_Grammar_Button_Check_Click(object sender, EventArgs e)
        {
            while (Check_Grammar_RichBox_EnterManual.Text.IndexOf("\n\n") < -1)
                Check_Grammar_RichBox_EnterManual.Text.Replace("\n\n", "\n");
            Check_Grammar_RichBox_EnterManual.Text = Check_Grammar_RichBox_EnterManual.Text.Replace(" ", "");
            string[] str = Check_Grammar_RichBox_EnterManual.Text.Split('\n');
            bool f = errHand.CheckGramm(str);
            if (f)
                Check_Grammar_RichBox_Result.Text = asys.Analysis(str);
            else
                Check_Grammar_RichBox_Result.Text = "Неправильный ввод грамматики";
        }

        private void CheckBox_Button_Help_Click(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new Help_Form();
            }
            string TextName = "../../Text3.txt";
            f.Help_Form_Changed(TextName);
            f.Show();
        }

        private void Check_Grammar_Button_Clear_Click(object sender, EventArgs e)
        {
            Check_Grammar_RichBox_EnterManual.Clear();
            Check_Grammar_RichBox_Result.Clear();
            Check_Grammar_RichBox_Folder.Clear();
        }

        private void Check_Grammar_Check_EnterManual_CheckedChanged(object sender, EventArgs e)
        {
            Check_Grammar_Button_Folder.Visible = !Check_Grammar_Check_EnterManual.Checked;
            Check_Grammar_RichBox_Folder.Visible = !Check_Grammar_Check_EnterManual.Checked;
            Check_Grammar_Button_Clear.Visible = true;
            Check_Grammar_RichBox_EnterManual.Visible = true;
            Check_Grammar_Button_Check.Visible = true;
        }

        private void Check_Grammar_Button_Folder_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Check_Grammar_RichBox_Folder.Text = OpenFile.FileName;
                string FileName = Check_Grammar_RichBox_Folder.Text;
                FileStream f = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(f);
                Check_Grammar_RichBox_EnterManual.Text = reader.ReadToEnd();
                Check_Grammar_RichBox_EnterManual.Visible = true;
                Check_Grammar_Button_Clear.Visible = true;
                Check_Grammar_Check_EnterManual.Visible = false;
                Check_Grammar_Button_Check.Visible = true;
            }
        }

        public void Check_Grammar_from_Folder_in_TextBox()
        {
            Check_Grammar_RichBox_EnterManual.Visible = true;
            FileStream f = new FileStream(Check_Grammar_RichBox_Folder.Text, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(f);
            Check_Grammar_RichBox_EnterManual.Text = reader.ReadToEnd();
        }
    }
}
