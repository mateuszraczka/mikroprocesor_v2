namespace mikroprocesor_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.al_textbox = new System.Windows.Forms.TextBox();
            this.AL = new System.Windows.Forms.Label();
            this.AH = new System.Windows.Forms.Label();
            this.ah_textbox = new System.Windows.Forms.TextBox();
            this.CL = new System.Windows.Forms.Label();
            this.cl_textbox = new System.Windows.Forms.TextBox();
            this.CH = new System.Windows.Forms.Label();
            this.ch_textbox = new System.Windows.Forms.TextBox();
            this.DL = new System.Windows.Forms.Label();
            this.dl_textbox = new System.Windows.Forms.TextBox();
            this.DH = new System.Windows.Forms.Label();
            this.dh_textbox = new System.Windows.Forms.TextBox();
            this.al_check = new System.Windows.Forms.CheckBox();
            this.ah_check = new System.Windows.Forms.CheckBox();
            this.cl_check = new System.Windows.Forms.CheckBox();
            this.ch_check = new System.Windows.Forms.CheckBox();
            this.dl_check = new System.Windows.Forms.CheckBox();
            this.dh_check = new System.Windows.Forms.CheckBox();
            this.al_value = new System.Windows.Forms.Label();
            this.ah_value = new System.Windows.Forms.Label();
            this.cl_value = new System.Windows.Forms.Label();
            this.ch_value = new System.Windows.Forms.Label();
            this.dl_value = new System.Windows.Forms.Label();
            this.dh_value = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.BL = new System.Windows.Forms.Label();
            this.BH = new System.Windows.Forms.Label();
            this.bh_textbox = new System.Windows.Forms.TextBox();
            this.bl_textbox = new System.Windows.Forms.TextBox();
            this.bl_value = new System.Windows.Forms.Label();
            this.bh_value = new System.Windows.Forms.Label();
            this.bl_check = new System.Windows.Forms.CheckBox();
            this.bh_check = new System.Windows.Forms.CheckBox();
            this.setregisters = new System.Windows.Forms.GroupBox();
            this.registers_progress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.functions = new System.Windows.Forms.GroupBox();
            this.choose_function = new System.Windows.Forms.ComboBox();
            this.setregisters.SuspendLayout();
            this.functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // al_textbox
            // 
            this.al_textbox.AccessibleDescription = "al_check";
            this.al_textbox.AccessibleName = "AL";
            this.al_textbox.BackColor = System.Drawing.Color.LightCoral;
            this.al_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.al_textbox.Location = new System.Drawing.Point(56, 63);
            this.al_textbox.MaxLength = 2;
            this.al_textbox.Name = "al_textbox";
            this.al_textbox.PlaceholderText = "FF";
            this.al_textbox.Size = new System.Drawing.Size(53, 27);
            this.al_textbox.TabIndex = 0;
            this.al_textbox.Tag = "0";
            this.al_textbox.TextChanged += new System.EventHandler(this.al_textbox_TextChanged);
            // 
            // AL
            // 
            this.AL.AutoSize = true;
            this.AL.Location = new System.Drawing.Point(20, 65);
            this.AL.Name = "AL";
            this.AL.Size = new System.Drawing.Size(26, 20);
            this.AL.TabIndex = 1;
            this.AL.Text = "AL";
            // 
            // AH
            // 
            this.AH.AutoSize = true;
            this.AH.Location = new System.Drawing.Point(20, 99);
            this.AH.Name = "AH";
            this.AH.Size = new System.Drawing.Size(30, 20);
            this.AH.TabIndex = 3;
            this.AH.Text = "AH";
            // 
            // ah_textbox
            // 
            this.ah_textbox.AccessibleName = "AH";
            this.ah_textbox.BackColor = System.Drawing.Color.LightCoral;
            this.ah_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ah_textbox.Location = new System.Drawing.Point(56, 96);
            this.ah_textbox.MaxLength = 2;
            this.ah_textbox.Name = "ah_textbox";
            this.ah_textbox.PlaceholderText = "FF";
            this.ah_textbox.Size = new System.Drawing.Size(53, 27);
            this.ah_textbox.TabIndex = 2;
            this.ah_textbox.Tag = "1";
            this.ah_textbox.TextChanged += new System.EventHandler(this.ah_textbox_TextChanged);
            // 
            // CL
            // 
            this.CL.AutoSize = true;
            this.CL.Location = new System.Drawing.Point(20, 199);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(25, 20);
            this.CL.TabIndex = 5;
            this.CL.Text = "CL";
            // 
            // cl_textbox
            // 
            this.cl_textbox.AccessibleName = "CL";
            this.cl_textbox.BackColor = System.Drawing.Color.LightCoral;
            this.cl_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cl_textbox.Location = new System.Drawing.Point(56, 196);
            this.cl_textbox.MaxLength = 2;
            this.cl_textbox.Name = "cl_textbox";
            this.cl_textbox.PlaceholderText = "FF";
            this.cl_textbox.Size = new System.Drawing.Size(53, 27);
            this.cl_textbox.TabIndex = 4;
            this.cl_textbox.Tag = "2";
            this.cl_textbox.TextChanged += new System.EventHandler(this.cl_textbox_TextChanged);
            // 
            // CH
            // 
            this.CH.AutoSize = true;
            this.CH.Location = new System.Drawing.Point(20, 232);
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(29, 20);
            this.CH.TabIndex = 7;
            this.CH.Text = "CH";
            // 
            // ch_textbox
            // 
            this.ch_textbox.AccessibleName = "CH";
            this.ch_textbox.BackColor = System.Drawing.Color.LightCoral;
            this.ch_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ch_textbox.Location = new System.Drawing.Point(56, 229);
            this.ch_textbox.MaxLength = 2;
            this.ch_textbox.Name = "ch_textbox";
            this.ch_textbox.PlaceholderText = "FF";
            this.ch_textbox.Size = new System.Drawing.Size(53, 27);
            this.ch_textbox.TabIndex = 6;
            this.ch_textbox.Tag = "3";
            this.ch_textbox.TextChanged += new System.EventHandler(this.ch_textbox_TextChanged);
            // 
            // DL
            // 
            this.DL.AutoSize = true;
            this.DL.Location = new System.Drawing.Point(20, 265);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(27, 20);
            this.DL.TabIndex = 9;
            this.DL.Text = "DL";
            // 
            // dl_textbox
            // 
            this.dl_textbox.AccessibleName = "DL";
            this.dl_textbox.BackColor = System.Drawing.Color.LightCoral;
            this.dl_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dl_textbox.Location = new System.Drawing.Point(56, 262);
            this.dl_textbox.MaxLength = 2;
            this.dl_textbox.Name = "dl_textbox";
            this.dl_textbox.PlaceholderText = "FF";
            this.dl_textbox.Size = new System.Drawing.Size(53, 27);
            this.dl_textbox.TabIndex = 8;
            this.dl_textbox.Tag = "4";
            this.dl_textbox.TextChanged += new System.EventHandler(this.dl_textbox_TextChanged);
            // 
            // DH
            // 
            this.DH.AutoSize = true;
            this.DH.Location = new System.Drawing.Point(20, 298);
            this.DH.Name = "DH";
            this.DH.Size = new System.Drawing.Size(31, 20);
            this.DH.TabIndex = 11;
            this.DH.Text = "DH";
            // 
            // dh_textbox
            // 
            this.dh_textbox.AccessibleName = "DH";
            this.dh_textbox.BackColor = System.Drawing.Color.LightCoral;
            this.dh_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dh_textbox.Location = new System.Drawing.Point(56, 295);
            this.dh_textbox.MaxLength = 2;
            this.dh_textbox.Name = "dh_textbox";
            this.dh_textbox.PlaceholderText = "FF";
            this.dh_textbox.Size = new System.Drawing.Size(53, 27);
            this.dh_textbox.TabIndex = 10;
            this.dh_textbox.Tag = "5";
            this.dh_textbox.TextChanged += new System.EventHandler(this.dh_textbox_TextChanged);
            // 
            // al_check
            // 
            this.al_check.AutoCheck = false;
            this.al_check.AutoSize = true;
            this.al_check.BackColor = System.Drawing.Color.Transparent;
            this.al_check.Location = new System.Drawing.Point(115, 68);
            this.al_check.Name = "al_check";
            this.al_check.Size = new System.Drawing.Size(18, 17);
            this.al_check.TabIndex = 12;
            this.al_check.UseVisualStyleBackColor = false;
            // 
            // ah_check
            // 
            this.ah_check.AutoCheck = false;
            this.ah_check.AutoSize = true;
            this.ah_check.BackColor = System.Drawing.Color.Transparent;
            this.ah_check.Location = new System.Drawing.Point(115, 102);
            this.ah_check.Name = "ah_check";
            this.ah_check.Size = new System.Drawing.Size(18, 17);
            this.ah_check.TabIndex = 13;
            this.ah_check.UseVisualStyleBackColor = false;
            // 
            // cl_check
            // 
            this.cl_check.AutoCheck = false;
            this.cl_check.AutoSize = true;
            this.cl_check.BackColor = System.Drawing.Color.Transparent;
            this.cl_check.Location = new System.Drawing.Point(115, 202);
            this.cl_check.Name = "cl_check";
            this.cl_check.Size = new System.Drawing.Size(18, 17);
            this.cl_check.TabIndex = 14;
            this.cl_check.UseVisualStyleBackColor = false;
            // 
            // ch_check
            // 
            this.ch_check.AutoCheck = false;
            this.ch_check.AutoSize = true;
            this.ch_check.BackColor = System.Drawing.Color.Transparent;
            this.ch_check.Location = new System.Drawing.Point(115, 235);
            this.ch_check.Name = "ch_check";
            this.ch_check.Size = new System.Drawing.Size(18, 17);
            this.ch_check.TabIndex = 15;
            this.ch_check.UseVisualStyleBackColor = false;
            // 
            // dl_check
            // 
            this.dl_check.AutoCheck = false;
            this.dl_check.AutoSize = true;
            this.dl_check.BackColor = System.Drawing.Color.Transparent;
            this.dl_check.Location = new System.Drawing.Point(115, 265);
            this.dl_check.Name = "dl_check";
            this.dl_check.Size = new System.Drawing.Size(18, 17);
            this.dl_check.TabIndex = 16;
            this.dl_check.UseVisualStyleBackColor = false;
            // 
            // dh_check
            // 
            this.dh_check.AutoCheck = false;
            this.dh_check.AutoSize = true;
            this.dh_check.BackColor = System.Drawing.Color.Transparent;
            this.dh_check.Location = new System.Drawing.Point(115, 301);
            this.dh_check.Name = "dh_check";
            this.dh_check.Size = new System.Drawing.Size(18, 17);
            this.dh_check.TabIndex = 17;
            this.dh_check.UseVisualStyleBackColor = false;
            // 
            // al_value
            // 
            this.al_value.AutoSize = true;
            this.al_value.BackColor = System.Drawing.Color.Lime;
            this.al_value.ForeColor = System.Drawing.Color.Black;
            this.al_value.Location = new System.Drawing.Point(155, 66);
            this.al_value.Name = "al_value";
            this.al_value.Size = new System.Drawing.Size(17, 20);
            this.al_value.TabIndex = 19;
            this.al_value.Text = "  ";
            this.al_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ah_value
            // 
            this.ah_value.AutoSize = true;
            this.ah_value.BackColor = System.Drawing.Color.Lime;
            this.ah_value.ForeColor = System.Drawing.Color.Black;
            this.ah_value.Location = new System.Drawing.Point(155, 99);
            this.ah_value.Name = "ah_value";
            this.ah_value.Size = new System.Drawing.Size(17, 20);
            this.ah_value.TabIndex = 20;
            this.ah_value.Text = "  ";
            this.ah_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cl_value
            // 
            this.cl_value.AutoSize = true;
            this.cl_value.BackColor = System.Drawing.Color.Lime;
            this.cl_value.ForeColor = System.Drawing.Color.Black;
            this.cl_value.Location = new System.Drawing.Point(155, 199);
            this.cl_value.Name = "cl_value";
            this.cl_value.Size = new System.Drawing.Size(17, 20);
            this.cl_value.TabIndex = 21;
            this.cl_value.Text = "  ";
            this.cl_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ch_value
            // 
            this.ch_value.AutoSize = true;
            this.ch_value.BackColor = System.Drawing.Color.Lime;
            this.ch_value.ForeColor = System.Drawing.Color.Black;
            this.ch_value.Location = new System.Drawing.Point(155, 232);
            this.ch_value.Name = "ch_value";
            this.ch_value.Size = new System.Drawing.Size(17, 20);
            this.ch_value.TabIndex = 22;
            this.ch_value.Text = "  ";
            this.ch_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dl_value
            // 
            this.dl_value.AutoSize = true;
            this.dl_value.BackColor = System.Drawing.Color.Lime;
            this.dl_value.ForeColor = System.Drawing.Color.Black;
            this.dl_value.Location = new System.Drawing.Point(155, 265);
            this.dl_value.Name = "dl_value";
            this.dl_value.Size = new System.Drawing.Size(17, 20);
            this.dl_value.TabIndex = 23;
            this.dl_value.Text = "  ";
            this.dl_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dh_value
            // 
            this.dh_value.AutoSize = true;
            this.dh_value.BackColor = System.Drawing.Color.Lime;
            this.dh_value.ForeColor = System.Drawing.Color.Black;
            this.dh_value.Location = new System.Drawing.Point(155, 298);
            this.dh_value.Name = "dh_value";
            this.dh_value.Size = new System.Drawing.Size(17, 20);
            this.dh_value.TabIndex = 24;
            this.dh_value.Text = "  ";
            this.dh_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(12, 394);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 29);
            this.Reset.TabIndex = 25;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // BL
            // 
            this.BL.AutoSize = true;
            this.BL.Location = new System.Drawing.Point(20, 132);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(25, 20);
            this.BL.TabIndex = 26;
            this.BL.Text = "BL";
            // 
            // BH
            // 
            this.BH.AutoSize = true;
            this.BH.Location = new System.Drawing.Point(20, 166);
            this.BH.Name = "BH";
            this.BH.Size = new System.Drawing.Size(29, 20);
            this.BH.TabIndex = 27;
            this.BH.Text = "BH";
            // 
            // bh_textbox
            // 
            this.bh_textbox.AccessibleName = "BH";
            this.bh_textbox.BackColor = System.Drawing.Color.LightCoral;
            this.bh_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bh_textbox.Location = new System.Drawing.Point(56, 163);
            this.bh_textbox.MaxLength = 2;
            this.bh_textbox.Name = "bh_textbox";
            this.bh_textbox.PlaceholderText = "FF";
            this.bh_textbox.Size = new System.Drawing.Size(53, 27);
            this.bh_textbox.TabIndex = 28;
            this.bh_textbox.TextChanged += new System.EventHandler(this.bh_textbox_TextChanged);
            // 
            // bl_textbox
            // 
            this.bl_textbox.AccessibleName = "BL";
            this.bl_textbox.BackColor = System.Drawing.Color.LightCoral;
            this.bl_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bl_textbox.Location = new System.Drawing.Point(56, 129);
            this.bl_textbox.MaxLength = 2;
            this.bl_textbox.Name = "bl_textbox";
            this.bl_textbox.PlaceholderText = "FF";
            this.bl_textbox.Size = new System.Drawing.Size(53, 27);
            this.bl_textbox.TabIndex = 29;
            this.bl_textbox.TextChanged += new System.EventHandler(this.bl_textbox_TextChanged);
            // 
            // bl_value
            // 
            this.bl_value.AutoSize = true;
            this.bl_value.BackColor = System.Drawing.Color.Lime;
            this.bl_value.ForeColor = System.Drawing.Color.Black;
            this.bl_value.Location = new System.Drawing.Point(155, 132);
            this.bl_value.Name = "bl_value";
            this.bl_value.Size = new System.Drawing.Size(17, 20);
            this.bl_value.TabIndex = 30;
            this.bl_value.Text = "  ";
            this.bl_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bh_value
            // 
            this.bh_value.AutoSize = true;
            this.bh_value.BackColor = System.Drawing.Color.Lime;
            this.bh_value.ForeColor = System.Drawing.Color.Black;
            this.bh_value.Location = new System.Drawing.Point(155, 166);
            this.bh_value.Name = "bh_value";
            this.bh_value.Size = new System.Drawing.Size(17, 20);
            this.bh_value.TabIndex = 31;
            this.bh_value.Text = "  ";
            this.bh_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bl_check
            // 
            this.bl_check.AutoCheck = false;
            this.bl_check.AutoSize = true;
            this.bl_check.BackColor = System.Drawing.Color.Transparent;
            this.bl_check.Location = new System.Drawing.Point(115, 135);
            this.bl_check.Name = "bl_check";
            this.bl_check.Size = new System.Drawing.Size(18, 17);
            this.bl_check.TabIndex = 32;
            this.bl_check.UseVisualStyleBackColor = false;
            // 
            // bh_check
            // 
            this.bh_check.AutoCheck = false;
            this.bh_check.AutoSize = true;
            this.bh_check.BackColor = System.Drawing.Color.Transparent;
            this.bh_check.Location = new System.Drawing.Point(115, 167);
            this.bh_check.Name = "bh_check";
            this.bh_check.Size = new System.Drawing.Size(18, 17);
            this.bh_check.TabIndex = 33;
            this.bh_check.UseVisualStyleBackColor = false;
            // 
            // setregisters
            // 
            this.setregisters.Controls.Add(this.registers_progress);
            this.setregisters.Controls.Add(this.label2);
            this.setregisters.Controls.Add(this.label1);
            this.setregisters.Controls.Add(this.al_textbox);
            this.setregisters.Controls.Add(this.BH);
            this.setregisters.Controls.Add(this.dh_value);
            this.setregisters.Controls.Add(this.DH);
            this.setregisters.Controls.Add(this.bh_value);
            this.setregisters.Controls.Add(this.dl_value);
            this.setregisters.Controls.Add(this.dh_check);
            this.setregisters.Controls.Add(this.bh_check);
            this.setregisters.Controls.Add(this.ch_value);
            this.setregisters.Controls.Add(this.dh_textbox);
            this.setregisters.Controls.Add(this.AL);
            this.setregisters.Controls.Add(this.DL);
            this.setregisters.Controls.Add(this.dl_check);
            this.setregisters.Controls.Add(this.cl_value);
            this.setregisters.Controls.Add(this.bl_check);
            this.setregisters.Controls.Add(this.bh_textbox);
            this.setregisters.Controls.Add(this.ch_check);
            this.setregisters.Controls.Add(this.dl_textbox);
            this.setregisters.Controls.Add(this.bl_value);
            this.setregisters.Controls.Add(this.CH);
            this.setregisters.Controls.Add(this.al_check);
            this.setregisters.Controls.Add(this.BL);
            this.setregisters.Controls.Add(this.cl_check);
            this.setregisters.Controls.Add(this.al_value);
            this.setregisters.Controls.Add(this.AH);
            this.setregisters.Controls.Add(this.ch_textbox);
            this.setregisters.Controls.Add(this.bl_textbox);
            this.setregisters.Controls.Add(this.CL);
            this.setregisters.Controls.Add(this.ah_textbox);
            this.setregisters.Controls.Add(this.ah_check);
            this.setregisters.Controls.Add(this.ah_value);
            this.setregisters.Controls.Add(this.cl_textbox);
            this.setregisters.Location = new System.Drawing.Point(12, 12);
            this.setregisters.Name = "setregisters";
            this.setregisters.Size = new System.Drawing.Size(211, 376);
            this.setregisters.TabIndex = 34;
            this.setregisters.TabStop = false;
            this.setregisters.Text = "SET_REGISTERS";
            // 
            // registers_progress
            // 
            this.registers_progress.BackColor = System.Drawing.Color.LightCoral;
            this.registers_progress.ForeColor = System.Drawing.Color.LawnGreen;
            this.registers_progress.Location = new System.Drawing.Point(20, 333);
            this.registers_progress.MarqueeAnimationSpeed = 50;
            this.registers_progress.Maximum = 8;
            this.registers_progress.Name = "registers_progress";
            this.registers_progress.Size = new System.Drawing.Size(171, 29);
            this.registers_progress.Step = 1;
            this.registers_progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.registers_progress.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "CURRENT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "SET:";
            // 
            // functions
            // 
            this.functions.Controls.Add(this.choose_function);
            this.functions.Location = new System.Drawing.Point(223, 12);
            this.functions.Name = "functions";
            this.functions.Size = new System.Drawing.Size(250, 376);
            this.functions.TabIndex = 35;
            this.functions.TabStop = false;
            this.functions.Text = "FUNCTIONS";
            // 
            // choose_function
            // 
            this.choose_function.FormattingEnabled = true;
            this.choose_function.Items.AddRange(new object[] {
            "MOV",
            "XCHG"});
            this.choose_function.Location = new System.Drawing.Point(28, 40);
            this.choose_function.Name = "choose_function";
            this.choose_function.Size = new System.Drawing.Size(83, 28);
            this.choose_function.TabIndex = 0;
            this.choose_function.Text = "SELECT";
            this.choose_function.SelectedIndexChanged += new System.EventHandler(this.choose_function_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.functions);
            this.Controls.Add(this.setregisters);
            this.Controls.Add(this.Reset);
            this.Name = "Form1";
            this.Text = "Mikroprocesor 8086";
            this.setregisters.ResumeLayout(false);
            this.setregisters.PerformLayout();
            this.functions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox al_textbox;
        private Label AL;
        private Label AH;
        private TextBox ah_textbox;
        private Label CL;
        private TextBox cl_textbox;
        private Label CH;
        private TextBox ch_textbox;
        private Label DL;
        private TextBox dl_textbox;
        private Label DH;
        private TextBox dh_textbox;
        private CheckBox al_check;
        private CheckBox ah_check;
        private CheckBox cl_check;
        private CheckBox ch_check;
        private CheckBox dl_check;
        private CheckBox dh_check;
        private Label al_value;
        private Label ah_value;
        private Label cl_value;
        private Label ch_value;
        private Label dl_value;
        private Label dh_value;
        private Button Reset;
        private Label BL;
        private Label BH;
        private TextBox bh_textbox;
        private TextBox bl_textbox;
        private Label bl_value;
        private Label bh_value;
        private CheckBox bl_check;
        private CheckBox bh_check;
        private GroupBox setregisters;
        private Label label1;
        private Label label2;
        private GroupBox functions;
        private ProgressBar registers_progress;
        private ComboBox choose_function;
    }
}