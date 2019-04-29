namespace GeneratorForm
{
    partial class GeneratorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grammatic_type = new System.Windows.Forms.GroupBox();
            this.type_natural = new System.Windows.Forms.RadioButton();
            this.type_contextDepend = new System.Windows.Forms.RadioButton();
            this.type_contextFree = new System.Windows.Forms.RadioButton();
            this.type_automatic = new System.Windows.Forms.RadioButton();
            this.grammatic_nonterms = new System.Windows.Forms.GroupBox();
            this.setDefaultNonterms = new System.Windows.Forms.CheckBox();
            this.nonterms_count_label = new System.Windows.Forms.Label();
            this.nonterms_count_edit = new System.Windows.Forms.TextBox();
            this.grammatic_rules = new System.Windows.Forms.GroupBox();
            this.to_label2 = new System.Windows.Forms.Label();
            this.to_label1 = new System.Windows.Forms.Label();
            this.from_label2 = new System.Windows.Forms.Label();
            this.from_label1 = new System.Windows.Forms.Label();
            this.set_rules_dinamic = new System.Windows.Forms.RadioButton();
            this.set_rules_static = new System.Windows.Forms.RadioButton();
            this.set_rules_default = new System.Windows.Forms.RadioButton();
            this.rule_length_label = new System.Windows.Forms.Label();
            this.rules_count_label = new System.Windows.Forms.Label();
            this.rule_tolength_edit = new System.Windows.Forms.TextBox();
            this.rules_tocount_edit = new System.Windows.Forms.TextBox();
            this.rules_fromlength_edit = new System.Windows.Forms.TextBox();
            this.rules_fromcount_edit = new System.Windows.Forms.TextBox();
            this.grammatic_auto_type = new System.Windows.Forms.GroupBox();
            this.auto_right = new System.Windows.Forms.RadioButton();
            this.auto_left = new System.Windows.Forms.RadioButton();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.grammatic_textBox = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Chain_Builder_RichBox_EnterManual = new System.Windows.Forms.RichTextBox();
            this.Chain_Builder_RichBox_Result = new System.Windows.Forms.RichTextBox();
            this.Chain_Builder_RichBox_Folder = new System.Windows.Forms.RichTextBox();
            this.Chain_Builder_Check_EnterManual = new System.Windows.Forms.CheckBox();
            this.Chain_Builder_Button_Compile = new System.Windows.Forms.Button();
            this.Chain_Builder_Button_SaveFile = new System.Windows.Forms.Button();
            this.Chain_Builder_Button_Help = new System.Windows.Forms.Button();
            this.Chain_Builder_Button_Folder = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Check_Grammar_Check_EnterManual = new System.Windows.Forms.CheckBox();
            this.Check_Grammar_RichBox_EnterManual = new System.Windows.Forms.RichTextBox();
            this.Check_Grammar_RichBox_Result = new System.Windows.Forms.RichTextBox();
            this.Check_Grammar_RichBox_Folder = new System.Windows.Forms.RichTextBox();
            this.Check_Grammar_Button_Folder = new System.Windows.Forms.Button();
            this.CheckBox_Button_Help = new System.Windows.Forms.Button();
            this.Check_Grammar_Button_Check = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grammatic_type.SuspendLayout();
            this.grammatic_nonterms.SuspendLayout();
            this.grammatic_rules.SuspendLayout();
            this.grammatic_auto_type.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grammatic_type
            // 
            this.grammatic_type.Controls.Add(this.type_natural);
            this.grammatic_type.Controls.Add(this.type_contextDepend);
            this.grammatic_type.Controls.Add(this.type_contextFree);
            this.grammatic_type.Controls.Add(this.type_automatic);
            this.grammatic_type.Location = new System.Drawing.Point(6, 6);
            this.grammatic_type.Name = "grammatic_type";
            this.grammatic_type.Size = new System.Drawing.Size(148, 114);
            this.grammatic_type.TabIndex = 0;
            this.grammatic_type.TabStop = false;
            this.grammatic_type.Text = "Тип грамматики";
            // 
            // type_natural
            // 
            this.type_natural.AutoSize = true;
            this.type_natural.Location = new System.Drawing.Point(6, 89);
            this.type_natural.Name = "type_natural";
            this.type_natural.Size = new System.Drawing.Size(127, 17);
            this.type_natural.TabIndex = 1;
            this.type_natural.TabStop = true;
            this.type_natural.Text = "Естественный язык";
            this.type_natural.UseVisualStyleBackColor = true;
            this.type_natural.CheckedChanged += new System.EventHandler(this.type_natural_CheckedChanged);
            // 
            // type_contextDepend
            // 
            this.type_contextDepend.AutoSize = true;
            this.type_contextDepend.Location = new System.Drawing.Point(6, 66);
            this.type_contextDepend.Name = "type_contextDepend";
            this.type_contextDepend.Size = new System.Drawing.Size(143, 17);
            this.type_contextDepend.TabIndex = 0;
            this.type_contextDepend.TabStop = true;
            this.type_contextDepend.Text = "Контекстно-зависимая";
            this.type_contextDepend.UseVisualStyleBackColor = true;
            this.type_contextDepend.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // type_contextFree
            // 
            this.type_contextFree.AutoSize = true;
            this.type_contextFree.Location = new System.Drawing.Point(6, 43);
            this.type_contextFree.Name = "type_contextFree";
            this.type_contextFree.Size = new System.Drawing.Size(141, 17);
            this.type_contextFree.TabIndex = 0;
            this.type_contextFree.TabStop = true;
            this.type_contextFree.Text = "Контекстно-свободная";
            this.type_contextFree.UseVisualStyleBackColor = true;
            this.type_contextFree.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // type_automatic
            // 
            this.type_automatic.AutoSize = true;
            this.type_automatic.Location = new System.Drawing.Point(7, 20);
            this.type_automatic.Name = "type_automatic";
            this.type_automatic.Size = new System.Drawing.Size(86, 17);
            this.type_automatic.TabIndex = 0;
            this.type_automatic.TabStop = true;
            this.type_automatic.Text = "Автоматная";
            this.type_automatic.UseVisualStyleBackColor = true;
            this.type_automatic.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grammatic_nonterms
            // 
            this.grammatic_nonterms.Controls.Add(this.setDefaultNonterms);
            this.grammatic_nonterms.Controls.Add(this.nonterms_count_label);
            this.grammatic_nonterms.Controls.Add(this.nonterms_count_edit);
            this.grammatic_nonterms.Location = new System.Drawing.Point(161, 6);
            this.grammatic_nonterms.Name = "grammatic_nonterms";
            this.grammatic_nonterms.Size = new System.Drawing.Size(213, 65);
            this.grammatic_nonterms.TabIndex = 1;
            this.grammatic_nonterms.TabStop = false;
            this.grammatic_nonterms.Text = "Нетерминалы";
            // 
            // setDefaultNonterms
            // 
            this.setDefaultNonterms.AutoSize = true;
            this.setDefaultNonterms.Location = new System.Drawing.Point(7, 42);
            this.setDefaultNonterms.Name = "setDefaultNonterms";
            this.setDefaultNonterms.Size = new System.Drawing.Size(160, 17);
            this.setDefaultNonterms.TabIndex = 2;
            this.setDefaultNonterms.Text = "Установить по умолчанию";
            this.setDefaultNonterms.UseVisualStyleBackColor = true;
            this.setDefaultNonterms.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nonterms_count_label
            // 
            this.nonterms_count_label.AutoSize = true;
            this.nonterms_count_label.BackColor = System.Drawing.Color.Transparent;
            this.nonterms_count_label.Location = new System.Drawing.Point(60, 23);
            this.nonterms_count_label.Name = "nonterms_count_label";
            this.nonterms_count_label.Size = new System.Drawing.Size(117, 13);
            this.nonterms_count_label.TabIndex = 1;
            this.nonterms_count_label.Text = "Кол-во нетерминалов";
            this.nonterms_count_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // nonterms_count_edit
            // 
            this.nonterms_count_edit.BackColor = System.Drawing.SystemColors.Window;
            this.nonterms_count_edit.Location = new System.Drawing.Point(7, 20);
            this.nonterms_count_edit.Name = "nonterms_count_edit";
            this.nonterms_count_edit.Size = new System.Drawing.Size(47, 20);
            this.nonterms_count_edit.TabIndex = 0;
            this.nonterms_count_edit.Text = "10";
            // 
            // grammatic_rules
            // 
            this.grammatic_rules.Controls.Add(this.to_label2);
            this.grammatic_rules.Controls.Add(this.to_label1);
            this.grammatic_rules.Controls.Add(this.from_label2);
            this.grammatic_rules.Controls.Add(this.from_label1);
            this.grammatic_rules.Controls.Add(this.set_rules_dinamic);
            this.grammatic_rules.Controls.Add(this.set_rules_static);
            this.grammatic_rules.Controls.Add(this.set_rules_default);
            this.grammatic_rules.Controls.Add(this.rule_length_label);
            this.grammatic_rules.Controls.Add(this.rules_count_label);
            this.grammatic_rules.Controls.Add(this.rule_tolength_edit);
            this.grammatic_rules.Controls.Add(this.rules_tocount_edit);
            this.grammatic_rules.Controls.Add(this.rules_fromlength_edit);
            this.grammatic_rules.Controls.Add(this.rules_fromcount_edit);
            this.grammatic_rules.Location = new System.Drawing.Point(161, 77);
            this.grammatic_rules.Name = "grammatic_rules";
            this.grammatic_rules.Size = new System.Drawing.Size(310, 140);
            this.grammatic_rules.TabIndex = 2;
            this.grammatic_rules.TabStop = false;
            this.grammatic_rules.Text = "Правила";
            // 
            // to_label2
            // 
            this.to_label2.AutoSize = true;
            this.to_label2.Location = new System.Drawing.Point(44, 46);
            this.to_label2.Name = "to_label2";
            this.to_label2.Size = new System.Drawing.Size(19, 13);
            this.to_label2.TabIndex = 7;
            this.to_label2.Text = "до";
            // 
            // to_label1
            // 
            this.to_label1.AutoSize = true;
            this.to_label1.Location = new System.Drawing.Point(44, 23);
            this.to_label1.Name = "to_label1";
            this.to_label1.Size = new System.Drawing.Size(19, 13);
            this.to_label1.TabIndex = 7;
            this.to_label1.Text = "до";
            // 
            // from_label2
            // 
            this.from_label2.AutoSize = true;
            this.from_label2.Location = new System.Drawing.Point(3, 46);
            this.from_label2.Name = "from_label2";
            this.from_label2.Size = new System.Drawing.Size(18, 13);
            this.from_label2.TabIndex = 6;
            this.from_label2.Text = "от";
            // 
            // from_label1
            // 
            this.from_label1.AutoSize = true;
            this.from_label1.Location = new System.Drawing.Point(3, 23);
            this.from_label1.Name = "from_label1";
            this.from_label1.Size = new System.Drawing.Size(18, 13);
            this.from_label1.TabIndex = 6;
            this.from_label1.Text = "от";
            // 
            // set_rules_dinamic
            // 
            this.set_rules_dinamic.AutoSize = true;
            this.set_rules_dinamic.Location = new System.Drawing.Point(6, 121);
            this.set_rules_dinamic.Name = "set_rules_dinamic";
            this.set_rules_dinamic.Size = new System.Drawing.Size(126, 17);
            this.set_rules_dinamic.TabIndex = 5;
            this.set_rules_dinamic.TabStop = true;
            this.set_rules_dinamic.Text = "Диапазон значений";
            this.set_rules_dinamic.UseVisualStyleBackColor = true;
            this.set_rules_dinamic.CheckedChanged += new System.EventHandler(this.set_rules_dinamic_CheckedChanged);
            // 
            // set_rules_static
            // 
            this.set_rules_static.AutoSize = true;
            this.set_rules_static.Location = new System.Drawing.Point(6, 97);
            this.set_rules_static.Name = "set_rules_static";
            this.set_rules_static.Size = new System.Drawing.Size(135, 17);
            this.set_rules_static.TabIndex = 4;
            this.set_rules_static.TabStop = true;
            this.set_rules_static.Text = "Конкретное значение";
            this.set_rules_static.UseVisualStyleBackColor = true;
            this.set_rules_static.CheckedChanged += new System.EventHandler(this.set_rules_static_CheckedChanged);
            // 
            // set_rules_default
            // 
            this.set_rules_default.AutoSize = true;
            this.set_rules_default.Location = new System.Drawing.Point(7, 73);
            this.set_rules_default.Name = "set_rules_default";
            this.set_rules_default.Size = new System.Drawing.Size(159, 17);
            this.set_rules_default.TabIndex = 3;
            this.set_rules_default.TabStop = true;
            this.set_rules_default.Text = "Установить по умолчанию";
            this.set_rules_default.UseVisualStyleBackColor = true;
            this.set_rules_default.CheckedChanged += new System.EventHandler(this.set_rules_default_CheckedChanged);
            // 
            // rule_length_label
            // 
            this.rule_length_label.AutoSize = true;
            this.rule_length_label.Location = new System.Drawing.Point(89, 46);
            this.rule_length_label.Name = "rule_length_label";
            this.rule_length_label.Size = new System.Drawing.Size(137, 13);
            this.rule_length_label.TabIndex = 2;
            this.rule_length_label.Text = "Длинна каждого правила";
            // 
            // rules_count_label
            // 
            this.rules_count_label.AutoSize = true;
            this.rules_count_label.Location = new System.Drawing.Point(89, 23);
            this.rules_count_label.Name = "rules_count_label";
            this.rules_count_label.Size = new System.Drawing.Size(217, 13);
            this.rules_count_label.TabIndex = 2;
            this.rules_count_label.Text = "Кол-во правил для каждого нетерминала";
            // 
            // rule_tolength_edit
            // 
            this.rule_tolength_edit.Location = new System.Drawing.Point(69, 43);
            this.rule_tolength_edit.Name = "rule_tolength_edit";
            this.rule_tolength_edit.Size = new System.Drawing.Size(16, 20);
            this.rule_tolength_edit.TabIndex = 1;
            this.rule_tolength_edit.Text = "4";
            // 
            // rules_tocount_edit
            // 
            this.rules_tocount_edit.Location = new System.Drawing.Point(69, 20);
            this.rules_tocount_edit.Name = "rules_tocount_edit";
            this.rules_tocount_edit.Size = new System.Drawing.Size(16, 20);
            this.rules_tocount_edit.TabIndex = 0;
            this.rules_tocount_edit.Text = "5";
            // 
            // rules_fromlength_edit
            // 
            this.rules_fromlength_edit.Location = new System.Drawing.Point(24, 43);
            this.rules_fromlength_edit.Name = "rules_fromlength_edit";
            this.rules_fromlength_edit.Size = new System.Drawing.Size(16, 20);
            this.rules_fromlength_edit.TabIndex = 0;
            this.rules_fromlength_edit.Text = "5";
            // 
            // rules_fromcount_edit
            // 
            this.rules_fromcount_edit.Location = new System.Drawing.Point(24, 20);
            this.rules_fromcount_edit.Name = "rules_fromcount_edit";
            this.rules_fromcount_edit.Size = new System.Drawing.Size(16, 20);
            this.rules_fromcount_edit.TabIndex = 0;
            this.rules_fromcount_edit.Text = "5";
            // 
            // grammatic_auto_type
            // 
            this.grammatic_auto_type.Controls.Add(this.auto_right);
            this.grammatic_auto_type.Controls.Add(this.auto_left);
            this.grammatic_auto_type.Location = new System.Drawing.Point(6, 126);
            this.grammatic_auto_type.Name = "grammatic_auto_type";
            this.grammatic_auto_type.Size = new System.Drawing.Size(147, 91);
            this.grammatic_auto_type.TabIndex = 3;
            this.grammatic_auto_type.TabStop = false;
            this.grammatic_auto_type.Text = "Тип автоматной грамматики";
            // 
            // auto_right
            // 
            this.auto_right.AutoSize = true;
            this.auto_right.Location = new System.Drawing.Point(7, 62);
            this.auto_right.Name = "auto_right";
            this.auto_right.Size = new System.Drawing.Size(63, 17);
            this.auto_right.TabIndex = 1;
            this.auto_right.TabStop = true;
            this.auto_right.Text = "Правая";
            this.auto_right.UseVisualStyleBackColor = true;
            // 
            // auto_left
            // 
            this.auto_left.AutoSize = true;
            this.auto_left.Location = new System.Drawing.Point(7, 38);
            this.auto_left.Name = "auto_left";
            this.auto_left.Size = new System.Drawing.Size(57, 17);
            this.auto_left.TabIndex = 0;
            this.auto_left.TabStop = true;
            this.auto_left.Text = "Левая";
            this.auto_left.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(564, 25);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(182, 46);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // grammatic_textBox
            // 
            this.grammatic_textBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grammatic_textBox.Location = new System.Drawing.Point(477, 78);
            this.grammatic_textBox.Name = "grammatic_textBox";
            this.grammatic_textBox.Size = new System.Drawing.Size(327, 139);
            this.grammatic_textBox.TabIndex = 5;
            this.grammatic_textBox.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(477, 219);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(162, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(6, 223);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(93, 20);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "Помощь/Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 274);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grammatic_type);
            this.tabPage1.Controls.Add(this.buttonHelp);
            this.tabPage1.Controls.Add(this.grammatic_auto_type);
            this.tabPage1.Controls.Add(this.buttonGenerate);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.grammatic_nonterms);
            this.tabPage1.Controls.Add(this.grammatic_textBox);
            this.tabPage1.Controls.Add(this.grammatic_rules);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Генератор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Chain_Builder_RichBox_EnterManual);
            this.tabPage2.Controls.Add(this.Chain_Builder_RichBox_Result);
            this.tabPage2.Controls.Add(this.Chain_Builder_RichBox_Folder);
            this.tabPage2.Controls.Add(this.Chain_Builder_Check_EnterManual);
            this.tabPage2.Controls.Add(this.Chain_Builder_Button_Compile);
            this.tabPage2.Controls.Add(this.Chain_Builder_Button_SaveFile);
            this.tabPage2.Controls.Add(this.Chain_Builder_Button_Help);
            this.tabPage2.Controls.Add(this.Chain_Builder_Button_Folder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Составитель";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Chain_Builder_RichBox_EnterManual
            // 
            this.Chain_Builder_RichBox_EnterManual.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.Chain_Builder_RichBox_EnterManual.Location = new System.Drawing.Point(477, 78);
            this.Chain_Builder_RichBox_EnterManual.Name = "Chain_Builder_RichBox_EnterManual";
            this.Chain_Builder_RichBox_EnterManual.Size = new System.Drawing.Size(327, 139);
            this.Chain_Builder_RichBox_EnterManual.TabIndex = 7;
            this.Chain_Builder_RichBox_EnterManual.Text = "";
            this.Chain_Builder_RichBox_EnterManual.Visible = false;
            // 
            // Chain_Builder_RichBox_Result
            // 
            this.Chain_Builder_RichBox_Result.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.Chain_Builder_RichBox_Result.Location = new System.Drawing.Point(6, 171);
            this.Chain_Builder_RichBox_Result.Name = "Chain_Builder_RichBox_Result";
            this.Chain_Builder_RichBox_Result.ReadOnly = true;
            this.Chain_Builder_RichBox_Result.Size = new System.Drawing.Size(458, 46);
            this.Chain_Builder_RichBox_Result.TabIndex = 6;
            this.Chain_Builder_RichBox_Result.Text = "";
            // 
            // Chain_Builder_RichBox_Folder
            // 
            this.Chain_Builder_RichBox_Folder.Location = new System.Drawing.Point(7, 78);
            this.Chain_Builder_RichBox_Folder.Name = "Chain_Builder_RichBox_Folder";
            this.Chain_Builder_RichBox_Folder.Size = new System.Drawing.Size(464, 33);
            this.Chain_Builder_RichBox_Folder.TabIndex = 5;
            this.Chain_Builder_RichBox_Folder.Text = "";
            // 
            // Chain_Builder_Check_EnterManual
            // 
            this.Chain_Builder_Check_EnterManual.AutoSize = true;
            this.Chain_Builder_Check_EnterManual.Location = new System.Drawing.Point(7, 117);
            this.Chain_Builder_Check_EnterManual.Name = "Chain_Builder_Check_EnterManual";
            this.Chain_Builder_Check_EnterManual.Size = new System.Drawing.Size(106, 17);
            this.Chain_Builder_Check_EnterManual.TabIndex = 4;
            this.Chain_Builder_Check_EnterManual.Text = "Ввести вручную";
            this.Chain_Builder_Check_EnterManual.UseVisualStyleBackColor = true;
            this.Chain_Builder_Check_EnterManual.CheckedChanged += new System.EventHandler(this.Chain_Builder_Check_EnterManual_CheckedChanged);
            // 
            // Chain_Builder_Button_Compile
            // 
            this.Chain_Builder_Button_Compile.Location = new System.Drawing.Point(564, 25);
            this.Chain_Builder_Button_Compile.Name = "Chain_Builder_Button_Compile";
            this.Chain_Builder_Button_Compile.Size = new System.Drawing.Size(182, 46);
            this.Chain_Builder_Button_Compile.TabIndex = 3;
            this.Chain_Builder_Button_Compile.Text = "Составить";
            this.Chain_Builder_Button_Compile.UseVisualStyleBackColor = true;
            this.Chain_Builder_Button_Compile.Click += new System.EventHandler(this.Chain_Builder_Button_Compile_Click);
            // 
            // Chain_Builder_Button_SaveFile
            // 
            this.Chain_Builder_Button_SaveFile.Location = new System.Drawing.Point(477, 219);
            this.Chain_Builder_Button_SaveFile.Name = "Chain_Builder_Button_SaveFile";
            this.Chain_Builder_Button_SaveFile.Size = new System.Drawing.Size(162, 23);
            this.Chain_Builder_Button_SaveFile.TabIndex = 2;
            this.Chain_Builder_Button_SaveFile.Text = "Сохранить в файл";
            this.Chain_Builder_Button_SaveFile.UseVisualStyleBackColor = true;
            this.Chain_Builder_Button_SaveFile.Visible = false;
            this.Chain_Builder_Button_SaveFile.Click += new System.EventHandler(this.Chain_Builder_Button_SaveFile_Click);
            // 
            // Chain_Builder_Button_Help
            // 
            this.Chain_Builder_Button_Help.Location = new System.Drawing.Point(6, 223);
            this.Chain_Builder_Button_Help.Name = "Chain_Builder_Button_Help";
            this.Chain_Builder_Button_Help.Size = new System.Drawing.Size(93, 20);
            this.Chain_Builder_Button_Help.TabIndex = 1;
            this.Chain_Builder_Button_Help.Text = "Помощь/Help";
            this.Chain_Builder_Button_Help.UseVisualStyleBackColor = true;
            this.Chain_Builder_Button_Help.Click += new System.EventHandler(this.Chain_Builder_Button_Help_Click);
            // 
            // Chain_Builder_Button_Folder
            // 
            this.Chain_Builder_Button_Folder.Location = new System.Drawing.Point(309, 117);
            this.Chain_Builder_Button_Folder.Name = "Chain_Builder_Button_Folder";
            this.Chain_Builder_Button_Folder.Size = new System.Drawing.Size(162, 23);
            this.Chain_Builder_Button_Folder.TabIndex = 0;
            this.Chain_Builder_Button_Folder.Text = "Выберите файл";
            this.Chain_Builder_Button_Folder.UseVisualStyleBackColor = true;
            this.Chain_Builder_Button_Folder.Click += new System.EventHandler(this.Chain_Builder_Button_Folder_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Check_Grammar_Check_EnterManual);
            this.tabPage3.Controls.Add(this.Check_Grammar_RichBox_EnterManual);
            this.tabPage3.Controls.Add(this.Check_Grammar_RichBox_Result);
            this.tabPage3.Controls.Add(this.Check_Grammar_RichBox_Folder);
            this.tabPage3.Controls.Add(this.Check_Grammar_Button_Folder);
            this.tabPage3.Controls.Add(this.CheckBox_Button_Help);
            this.tabPage3.Controls.Add(this.Check_Grammar_Button_Check);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(836, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Анализатор";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Check_Grammar_Check_EnterManual
            // 
            this.Check_Grammar_Check_EnterManual.AutoSize = true;
            this.Check_Grammar_Check_EnterManual.Location = new System.Drawing.Point(7, 117);
            this.Check_Grammar_Check_EnterManual.Name = "Check_Grammar_Check_EnterManual";
            this.Check_Grammar_Check_EnterManual.Size = new System.Drawing.Size(106, 17);
            this.Check_Grammar_Check_EnterManual.TabIndex = 6;
            this.Check_Grammar_Check_EnterManual.Text = "Ввести вручную";
            this.Check_Grammar_Check_EnterManual.UseVisualStyleBackColor = true;
            this.Check_Grammar_Check_EnterManual.CheckedChanged += new System.EventHandler(this.Check_Grammar_Check_EnterManual_CheckedChanged);
            // 
            // Check_Grammar_RichBox_EnterManual
            // 
            this.Check_Grammar_RichBox_EnterManual.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.Check_Grammar_RichBox_EnterManual.Location = new System.Drawing.Point(477, 78);
            this.Check_Grammar_RichBox_EnterManual.Name = "Check_Grammar_RichBox_EnterManual";
            this.Check_Grammar_RichBox_EnterManual.Size = new System.Drawing.Size(327, 139);
            this.Check_Grammar_RichBox_EnterManual.TabIndex = 5;
            this.Check_Grammar_RichBox_EnterManual.Text = "";
            this.Check_Grammar_RichBox_EnterManual.Visible = false;
            // 
            // Check_Grammar_RichBox_Result
            // 
            this.Check_Grammar_RichBox_Result.Location = new System.Drawing.Point(6, 171);
            this.Check_Grammar_RichBox_Result.Name = "Check_Grammar_RichBox_Result";
            this.Check_Grammar_RichBox_Result.ReadOnly = true;
            this.Check_Grammar_RichBox_Result.Size = new System.Drawing.Size(458, 46);
            this.Check_Grammar_RichBox_Result.TabIndex = 4;
            this.Check_Grammar_RichBox_Result.Text = "";
            // 
            // Check_Grammar_RichBox_Folder
            // 
            this.Check_Grammar_RichBox_Folder.Location = new System.Drawing.Point(7, 78);
            this.Check_Grammar_RichBox_Folder.Name = "Check_Grammar_RichBox_Folder";
            this.Check_Grammar_RichBox_Folder.Size = new System.Drawing.Size(464, 33);
            this.Check_Grammar_RichBox_Folder.TabIndex = 3;
            this.Check_Grammar_RichBox_Folder.Text = "";
            // 
            // Check_Grammar_Button_Folder
            // 
            this.Check_Grammar_Button_Folder.Location = new System.Drawing.Point(309, 117);
            this.Check_Grammar_Button_Folder.Name = "Check_Grammar_Button_Folder";
            this.Check_Grammar_Button_Folder.Size = new System.Drawing.Size(162, 23);
            this.Check_Grammar_Button_Folder.TabIndex = 2;
            this.Check_Grammar_Button_Folder.Text = "Выберите файл";
            this.Check_Grammar_Button_Folder.UseVisualStyleBackColor = true;
            this.Check_Grammar_Button_Folder.Click += new System.EventHandler(this.Check_Grammar_Button_Folder_Click);
            // 
            // CheckBox_Button_Help
            // 
            this.CheckBox_Button_Help.Location = new System.Drawing.Point(6, 223);
            this.CheckBox_Button_Help.Name = "CheckBox_Button_Help";
            this.CheckBox_Button_Help.Size = new System.Drawing.Size(93, 20);
            this.CheckBox_Button_Help.TabIndex = 1;
            this.CheckBox_Button_Help.Text = "Помощь/Help";
            this.CheckBox_Button_Help.UseVisualStyleBackColor = true;
            this.CheckBox_Button_Help.Click += new System.EventHandler(this.CheckBox_Button_Help_Click);
            // 
            // Check_Grammar_Button_Check
            // 
            this.Check_Grammar_Button_Check.Location = new System.Drawing.Point(564, 25);
            this.Check_Grammar_Button_Check.Name = "Check_Grammar_Button_Check";
            this.Check_Grammar_Button_Check.Size = new System.Drawing.Size(182, 46);
            this.Check_Grammar_Button_Check.TabIndex = 0;
            this.Check_Grammar_Button_Check.Text = "Проверить";
            this.Check_Grammar_Button_Check.UseVisualStyleBackColor = true;
            this.Check_Grammar_Button_Check.Click += new System.EventHandler(this.Check_Grammar_Button_Check_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 282);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GeneratorForm";
            this.Text = "Генератор";
            this.grammatic_type.ResumeLayout(false);
            this.grammatic_type.PerformLayout();
            this.grammatic_nonterms.ResumeLayout(false);
            this.grammatic_nonterms.PerformLayout();
            this.grammatic_rules.ResumeLayout(false);
            this.grammatic_rules.PerformLayout();
            this.grammatic_auto_type.ResumeLayout(false);
            this.grammatic_auto_type.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grammatic_type;
        private System.Windows.Forms.RadioButton type_contextDepend;
        private System.Windows.Forms.RadioButton type_contextFree;
        private System.Windows.Forms.RadioButton type_automatic;
        private System.Windows.Forms.GroupBox grammatic_nonterms;
        private System.Windows.Forms.Label nonterms_count_label;
        private System.Windows.Forms.TextBox nonterms_count_edit;
        private System.Windows.Forms.CheckBox setDefaultNonterms;
        private System.Windows.Forms.GroupBox grammatic_rules;
        private System.Windows.Forms.Label rule_length_label;
        private System.Windows.Forms.Label rules_count_label;
        private System.Windows.Forms.TextBox rule_tolength_edit;
        private System.Windows.Forms.TextBox rules_fromcount_edit;
        private System.Windows.Forms.GroupBox grammatic_auto_type;
        private System.Windows.Forms.RadioButton auto_right;
        private System.Windows.Forms.RadioButton auto_left;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.RichTextBox grammatic_textBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RadioButton type_natural;
        private System.Windows.Forms.Label to_label2;
        private System.Windows.Forms.Label to_label1;
        private System.Windows.Forms.Label from_label2;
        private System.Windows.Forms.Label from_label1;
        private System.Windows.Forms.RadioButton set_rules_dinamic;
        private System.Windows.Forms.RadioButton set_rules_static;
        private System.Windows.Forms.RadioButton set_rules_default;
        private System.Windows.Forms.TextBox rules_tocount_edit;
        private System.Windows.Forms.TextBox rules_fromlength_edit;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox Chain_Builder_RichBox_EnterManual;
        private System.Windows.Forms.RichTextBox Chain_Builder_RichBox_Result;
        private System.Windows.Forms.RichTextBox Chain_Builder_RichBox_Folder;
        private System.Windows.Forms.CheckBox Chain_Builder_Check_EnterManual;
        private System.Windows.Forms.Button Chain_Builder_Button_Compile;
        private System.Windows.Forms.Button Chain_Builder_Button_SaveFile;
        private System.Windows.Forms.Button Chain_Builder_Button_Help;
        private System.Windows.Forms.Button Chain_Builder_Button_Folder;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox Check_Grammar_Check_EnterManual;
        private System.Windows.Forms.RichTextBox Check_Grammar_RichBox_EnterManual;
        private System.Windows.Forms.RichTextBox Check_Grammar_RichBox_Result;
        private System.Windows.Forms.RichTextBox Check_Grammar_RichBox_Folder;
        private System.Windows.Forms.Button Check_Grammar_Button_Folder;
        private System.Windows.Forms.Button CheckBox_Button_Help;
        private System.Windows.Forms.Button Check_Grammar_Button_Check;
    }
}

