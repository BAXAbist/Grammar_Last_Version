using System;
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
            //setDefaultRules.Checked = false;
            nonterms_count_edit.Text = Convert.ToString(rand.Next(2, 26));
            rules_fromcount_edit.Text = Convert.ToString(rand.Next(1, 10));
            rules_tocount_edit.Text = Convert.ToString(Convert.ToInt32(rules_fromcount_edit.Text) + 2);
            rules_fromlength_edit.Text = Convert.ToString(rand.Next(3, 6));
            rule_tolength_edit.Text = Convert.ToString(Convert.ToInt32(rules_fromlength_edit.Text) + 2);
            set_rules_static.Checked = true;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.gramm_type = 2;
            rule_tolength_edit.Show();
            rule_length_label.Show();
            grammatic_auto_type.Hide();
            set_rules_dinamic.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.gramm_type = 3;
            rule_tolength_edit.Show();
            rule_length_label.Show();
            grammatic_auto_type.Hide();
            set_rules_dinamic.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (setDefaultRules.Checked)
        //    {
        //        rules_count_edit.ReadOnly = true;
        //        rule_length_edit.ReadOnly = true;
        //        rules_count_edit.BackColor = SystemColors.Control;
        //        rule_length_edit.BackColor = SystemColors.Control;
        //        rules_count_edit.Text = "5";
        //        rule_length_edit.Text = "4";
        //    }
        //    else
        //    {
        //        rules_count_edit.ReadOnly = false;
        //        rule_length_edit.ReadOnly = false;
        //        rules_count_edit.BackColor = SystemColors.Window;
        //        rule_length_edit.BackColor = SystemColors.Window;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            gramm_nonterms_count = Convert.ToInt32(nonterms_count_edit.Text);
            if (!set_rules_dinamic.Checked)
            {
                gramm_rules_count = Convert.ToInt32(rules_tocount_edit.Text);
                gramm_rule_lenght = Convert.ToInt32(rule_tolength_edit.Text);
            }
            else
            {
                Random rand = new Random();
                int i = Convert.ToInt32(rules_fromcount_edit.Text);
                int j = Convert.ToInt32(rules_tocount_edit.Text);
                if(i>j)
                {
                    int c = i;
                    i = j;
                    j = c;
                }
                gramm_rules_count = rand.Next(i, j);
                i = Convert.ToInt32(rules_fromlength_edit.Text);
                j = Convert.ToInt32(rule_tolength_edit.Text);
                if (i > j)
                {
                    int c = i;
                    i = j;
                    j = c;
                }
                gramm_rule_lenght = rand.Next(i,j);
            }
            gramm_left_or_right = auto_left.Checked;
            gramm = new Grammatic(gramm_nonterms_count, gramm_rules_count, gramm_rule_lenght, gramm_left_or_right);
            gramm.GenerateGrammatic(gramm_type, out degradated_grammatic);
            grammatic_textBox.Clear();
            foreach (string s in degradated_grammatic)
                grammatic_textBox.AppendText(s + "\n");
            buttonSave.Show();
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
                Check_Grammar_RichBox_Folder.Text = dial.FileName;
                Check_Grammar_from_Folder_in_TextBox();
            }
        }

        private void type_natural_CheckedChanged(object sender, EventArgs e)
        {
            if (type_natural.Checked)
            {
                gramm_type = 4;
                rule_tolength_edit.Show();
                rule_length_label.Show();
                grammatic_auto_type.Hide();
                set_rules_dinamic.Show();
            }
        }

        private void set_rules_default_CheckedChanged(object sender, EventArgs e)
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

        private void set_rules_static_CheckedChanged(object sender, EventArgs e)
        {
            rules_fromcount_edit.Hide();
            rules_fromlength_edit.Hide();
            to_label1.Hide();
            to_label2.Hide();
            from_label1.Hide();
            from_label2.Hide();
            rule_tolength_edit.ReadOnly = false;
            rules_tocount_edit.ReadOnly = false;
            rules_tocount_edit.BackColor = SystemColors.Window;
            rule_tolength_edit.BackColor = SystemColors.Window;
        }

        private void set_rules_dinamic_CheckedChanged(object sender, EventArgs e)
        {
            rules_fromcount_edit.Show();
            rules_fromlength_edit.Show();
            to_label1.Show();
            to_label2.Show();
            from_label1.Show();
            from_label2.Show();
            rule_tolength_edit.ReadOnly = false;
            rules_tocount_edit.ReadOnly = false;
            rules_tocount_edit.BackColor = SystemColors.Window;
            rule_tolength_edit.BackColor = SystemColors.Window;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.gramm_type = 1;
            rule_tolength_edit.Hide();
            rule_length_label.Hide();
            grammatic_auto_type.Show();
            rules_fromcount_edit.Hide();
            rules_fromlength_edit.Hide();
            to_label1.Hide();
            to_label2.Hide();
            from_label1.Hide();
            from_label2.Hide();
            set_rules_static.Checked = true;
            set_rules_dinamic.Hide();
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
            string[] str = Chain_Builder_RichBox_EnterManual.Text.Split('\n');
            string result;
            result = chain.GenerateChain(str);
            Chain_Builder_RichBox_Result.Text = result;
            Chain_Builder_Button_SaveFile.Visible=true;
        }

        OpenFileDialog OpenFile = new OpenFileDialog();

        private void Chain_Builder_Button_Folder_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Chain_Builder_RichBox_Folder.Text = OpenFile.FileName;
                string FileName = Chain_Builder_RichBox_Folder.Text;
                Chain_Builder_RichBox_EnterManual.Visible = true;
                FileStream f = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(f);
                Chain_Builder_RichBox_EnterManual.Text = reader.ReadToEnd();
            }
        }

        private void Chain_Builder_Check_EnterManual_CheckedChanged(object sender, EventArgs e)
        {
            Chain_Builder_RichBox_EnterManual.Visible = true;
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

        //Все функции для страницы с анализатором грамматик

        private void Check_Grammar_Button_Check_Click(object sender, EventArgs e)
        {
            string[] str = Check_Grammar_RichBox_EnterManual.Text.Split('\n');
            Check_Grammar_RichBox_Result.Text = asys.Analysis(str);
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

        

        private void Check_Grammar_Check_EnterManual_CheckedChanged(object sender, EventArgs e)
        {
            //Check_Grammar_RichBox_EnterManual.Clear();
            Check_Grammar_RichBox_EnterManual.Visible = Check_Grammar_Check_EnterManual.Checked;
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
