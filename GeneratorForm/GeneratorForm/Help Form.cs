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

namespace GeneratorForm
{
    public partial class Help_Form : Form
    {
        FileStream f;

        public Help_Form()
        {
            InitializeComponent();
        }
        public void Help_Form_Changed(string TextName)
        {
            f = new FileStream(TextName, FileMode.Open, FileAccess.Read);
            StreamReader str = new StreamReader(f, System.Text.Encoding.Default);
            Help_RichTextBox.Text = str.ReadToEnd();
        }
    }
}
