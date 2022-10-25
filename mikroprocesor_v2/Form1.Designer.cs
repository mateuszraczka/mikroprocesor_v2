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
            this.errorMessage = new System.Windows.Forms.Label();
            this.functions = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reg2 = new System.Windows.Forms.ComboBox();
            this.reg1 = new System.Windows.Forms.ComboBox();
            this.execute = new System.Windows.Forms.Button();
            this.choose_function = new System.Windows.Forms.ComboBox();
            this.active_registers = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.setregisters.SuspendLayout();
            this.functions.SuspendLayout();
            this.active_registers.SuspendLayout();
            this.SuspendLayout();
            // 
            // al_textbox
            // 
            this.al_textbox.AccessibleDescription = "al_check";
            this.al_textbox.AccessibleName = "AL";
            this.al_textbox.BackColor = System.Drawing.Color.LightCoral;
            this.al_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.al_textbox.Location = new System.Drawing.Point(41, 29);
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
            this.AL.Location = new System.Drawing.Point(5, 32);
            this.AL.Name = "AL";
            this.AL.Size = new System.Drawing.Size(26, 20);
            this.AL.TabIndex = 1;
            this.AL.Text = "AL";
            // 
            // AH
            // 
            this.AH.AutoSize = true;
            this.AH.Location = new System.Drawing.Point(5, 67);
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
            this.ah_textbox.Location = new System.Drawing.Point(41, 63);
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
            this.CL.Location = new System.Drawing.Point(5, 165);
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
            this.cl_textbox.Location = new System.Drawing.Point(41, 163);
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
            this.CH.Location = new System.Drawing.Point(5, 199);
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
            this.ch_textbox.Location = new System.Drawing.Point(41, 196);
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
            this.DL.Location = new System.Drawing.Point(5, 232);
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
            this.dl_textbox.Location = new System.Drawing.Point(41, 229);
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
            this.DH.Location = new System.Drawing.Point(5, 265);
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
            this.dh_textbox.Location = new System.Drawing.Point(41, 261);
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
            this.al_check.Location = new System.Drawing.Point(101, 35);
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
            this.ah_check.Location = new System.Drawing.Point(101, 69);
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
            this.cl_check.Location = new System.Drawing.Point(101, 169);
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
            this.ch_check.Location = new System.Drawing.Point(101, 203);
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
            this.dl_check.Location = new System.Drawing.Point(101, 232);
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
            this.dh_check.Location = new System.Drawing.Point(101, 268);
            this.dh_check.Name = "dh_check";
            this.dh_check.Size = new System.Drawing.Size(18, 17);
            this.dh_check.TabIndex = 17;
            this.dh_check.UseVisualStyleBackColor = false;
            // 
            // al_value
            // 
            this.al_value.AutoSize = true;
            this.al_value.BackColor = System.Drawing.Color.Red;
            this.al_value.ForeColor = System.Drawing.Color.Black;
            this.al_value.Location = new System.Drawing.Point(51, 32);
            this.al_value.Name = "al_value";
            this.al_value.Size = new System.Drawing.Size(23, 20);
            this.al_value.TabIndex = 19;
            this.al_value.Text = "FF";
            this.al_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ah_value
            // 
            this.ah_value.AutoSize = true;
            this.ah_value.BackColor = System.Drawing.Color.Red;
            this.ah_value.ForeColor = System.Drawing.Color.Black;
            this.ah_value.Location = new System.Drawing.Point(51, 65);
            this.ah_value.Name = "ah_value";
            this.ah_value.Size = new System.Drawing.Size(23, 20);
            this.ah_value.TabIndex = 20;
            this.ah_value.Text = "FF";
            this.ah_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cl_value
            // 
            this.cl_value.AutoSize = true;
            this.cl_value.BackColor = System.Drawing.Color.Red;
            this.cl_value.ForeColor = System.Drawing.Color.Black;
            this.cl_value.Location = new System.Drawing.Point(51, 165);
            this.cl_value.Name = "cl_value";
            this.cl_value.Size = new System.Drawing.Size(23, 20);
            this.cl_value.TabIndex = 21;
            this.cl_value.Text = "FF";
            this.cl_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ch_value
            // 
            this.ch_value.AutoSize = true;
            this.ch_value.BackColor = System.Drawing.Color.Red;
            this.ch_value.ForeColor = System.Drawing.Color.Black;
            this.ch_value.Location = new System.Drawing.Point(51, 197);
            this.ch_value.Name = "ch_value";
            this.ch_value.Size = new System.Drawing.Size(23, 20);
            this.ch_value.TabIndex = 22;
            this.ch_value.Text = "FF";
            this.ch_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dl_value
            // 
            this.dl_value.AutoSize = true;
            this.dl_value.BackColor = System.Drawing.Color.Red;
            this.dl_value.ForeColor = System.Drawing.Color.Black;
            this.dl_value.Location = new System.Drawing.Point(51, 231);
            this.dl_value.Name = "dl_value";
            this.dl_value.Size = new System.Drawing.Size(23, 20);
            this.dl_value.TabIndex = 23;
            this.dl_value.Text = "FF";
            this.dl_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dh_value
            // 
            this.dh_value.AutoSize = true;
            this.dh_value.BackColor = System.Drawing.Color.Red;
            this.dh_value.ForeColor = System.Drawing.Color.Black;
            this.dh_value.Location = new System.Drawing.Point(51, 264);
            this.dh_value.Name = "dh_value";
            this.dh_value.Size = new System.Drawing.Size(23, 20);
            this.dh_value.TabIndex = 24;
            this.dh_value.Text = "FF";
            this.dh_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(17, 395);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 29);
            this.Reset.TabIndex = 25;
            this.Reset.Text = "RESET";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // BL
            // 
            this.BL.AutoSize = true;
            this.BL.Location = new System.Drawing.Point(5, 99);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(25, 20);
            this.BL.TabIndex = 26;
            this.BL.Text = "BL";
            // 
            // BH
            // 
            this.BH.AutoSize = true;
            this.BH.Location = new System.Drawing.Point(5, 133);
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
            this.bh_textbox.Location = new System.Drawing.Point(41, 131);
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
            this.bl_textbox.Location = new System.Drawing.Point(41, 96);
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
            this.bl_value.BackColor = System.Drawing.Color.Red;
            this.bl_value.ForeColor = System.Drawing.Color.Black;
            this.bl_value.Location = new System.Drawing.Point(51, 99);
            this.bl_value.Name = "bl_value";
            this.bl_value.Size = new System.Drawing.Size(23, 20);
            this.bl_value.TabIndex = 30;
            this.bl_value.Text = "FF";
            this.bl_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bh_value
            // 
            this.bh_value.AutoSize = true;
            this.bh_value.BackColor = System.Drawing.Color.Red;
            this.bh_value.ForeColor = System.Drawing.Color.Black;
            this.bh_value.Location = new System.Drawing.Point(51, 132);
            this.bh_value.Name = "bh_value";
            this.bh_value.Size = new System.Drawing.Size(23, 20);
            this.bh_value.TabIndex = 31;
            this.bh_value.Text = "FF";
            this.bh_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bl_check
            // 
            this.bl_check.AutoCheck = false;
            this.bl_check.AutoSize = true;
            this.bl_check.BackColor = System.Drawing.Color.Transparent;
            this.bl_check.Location = new System.Drawing.Point(101, 101);
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
            this.bh_check.Location = new System.Drawing.Point(101, 133);
            this.bh_check.Name = "bh_check";
            this.bh_check.Size = new System.Drawing.Size(18, 17);
            this.bh_check.TabIndex = 33;
            this.bh_check.UseVisualStyleBackColor = false;
            // 
            // setregisters
            // 
            this.setregisters.Controls.Add(this.registers_progress);
            this.setregisters.Controls.Add(this.al_textbox);
            this.setregisters.Controls.Add(this.BH);
            this.setregisters.Controls.Add(this.DH);
            this.setregisters.Controls.Add(this.dh_check);
            this.setregisters.Controls.Add(this.bh_check);
            this.setregisters.Controls.Add(this.dh_textbox);
            this.setregisters.Controls.Add(this.AL);
            this.setregisters.Controls.Add(this.DL);
            this.setregisters.Controls.Add(this.dl_check);
            this.setregisters.Controls.Add(this.bl_check);
            this.setregisters.Controls.Add(this.bh_textbox);
            this.setregisters.Controls.Add(this.ch_check);
            this.setregisters.Controls.Add(this.dl_textbox);
            this.setregisters.Controls.Add(this.CH);
            this.setregisters.Controls.Add(this.al_check);
            this.setregisters.Controls.Add(this.BL);
            this.setregisters.Controls.Add(this.cl_check);
            this.setregisters.Controls.Add(this.AH);
            this.setregisters.Controls.Add(this.ch_textbox);
            this.setregisters.Controls.Add(this.bl_textbox);
            this.setregisters.Controls.Add(this.CL);
            this.setregisters.Controls.Add(this.ah_textbox);
            this.setregisters.Controls.Add(this.ah_check);
            this.setregisters.Controls.Add(this.cl_textbox);
            this.setregisters.Location = new System.Drawing.Point(13, 12);
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
            this.registers_progress.Location = new System.Drawing.Point(6, 341);
            this.registers_progress.MarqueeAnimationSpeed = 1;
            this.registers_progress.Maximum = 8;
            this.registers_progress.Name = "registers_progress";
            this.registers_progress.Size = new System.Drawing.Size(199, 29);
            this.registers_progress.Step = 1;
            this.registers_progress.TabIndex = 37;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorMessage.ForeColor = System.Drawing.Color.Silver;
            this.errorMessage.Location = new System.Drawing.Point(28, 186);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(297, 31);
            this.errorMessage.TabIndex = 38;
            this.errorMessage.Text = "FILL ALL REGISTERS VALUES";
            // 
            // functions
            // 
            this.functions.Controls.Add(this.errorMessage);
            this.functions.Controls.Add(this.groupBox1);
            this.functions.Controls.Add(this.reg2);
            this.functions.Controls.Add(this.reg1);
            this.functions.Controls.Add(this.execute);
            this.functions.Controls.Add(this.choose_function);
            this.functions.Enabled = false;
            this.functions.Location = new System.Drawing.Point(223, 12);
            this.functions.Name = "functions";
            this.functions.Size = new System.Drawing.Size(357, 376);
            this.functions.TabIndex = 35;
            this.functions.TabStop = false;
            this.functions.Text = "FUNCTIONS";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(357, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 365);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // reg2
            // 
            this.reg2.AccessibleDescription = "";
            this.reg2.AccessibleName = "REG2";
            this.reg2.FormattingEnabled = true;
            this.reg2.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH"});
            this.reg2.Location = new System.Drawing.Point(213, 24);
            this.reg2.Name = "reg2";
            this.reg2.Size = new System.Drawing.Size(82, 28);
            this.reg2.TabIndex = 3;
            this.reg2.Text = "REG2";
            this.reg2.SelectedIndexChanged += new System.EventHandler(this.reg2_SelectedIndexChanged);
            // 
            // reg1
            // 
            this.reg1.AccessibleDescription = "";
            this.reg1.AccessibleName = "REG1";
            this.reg1.FormattingEnabled = true;
            this.reg1.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH"});
            this.reg1.Location = new System.Drawing.Point(125, 24);
            this.reg1.Name = "reg1";
            this.reg1.Size = new System.Drawing.Size(82, 28);
            this.reg1.TabIndex = 2;
            this.reg1.Text = "REG1";
            this.reg1.SelectedIndexChanged += new System.EventHandler(this.reg1_SelectedIndexChanged);
            // 
            // execute
            // 
            this.execute.Enabled = false;
            this.execute.Location = new System.Drawing.Point(6, 341);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(94, 29);
            this.execute.TabIndex = 1;
            this.execute.Text = "EXECUTE";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // choose_function
            // 
            this.choose_function.AccessibleDescription = "";
            this.choose_function.AccessibleName = "FUNCTION";
            this.choose_function.FormattingEnabled = true;
            this.choose_function.Items.AddRange(new object[] {
            "MOV",
            "XCHG"});
            this.choose_function.Location = new System.Drawing.Point(7, 24);
            this.choose_function.Name = "choose_function";
            this.choose_function.Size = new System.Drawing.Size(103, 28);
            this.choose_function.TabIndex = 0;
            this.choose_function.Text = "FUNCTION";
            this.choose_function.SelectedIndexChanged += new System.EventHandler(this.choose_function_SelectedIndexChanged);
            // 
            // active_registers
            // 
            this.active_registers.Controls.Add(this.label3);
            this.active_registers.Controls.Add(this.label4);
            this.active_registers.Controls.Add(this.label5);
            this.active_registers.Controls.Add(this.ah_value);
            this.active_registers.Controls.Add(this.label6);
            this.active_registers.Controls.Add(this.al_value);
            this.active_registers.Controls.Add(this.label7);
            this.active_registers.Controls.Add(this.bl_value);
            this.active_registers.Controls.Add(this.label8);
            this.active_registers.Controls.Add(this.cl_value);
            this.active_registers.Controls.Add(this.label9);
            this.active_registers.Controls.Add(this.ch_value);
            this.active_registers.Controls.Add(this.label10);
            this.active_registers.Controls.Add(this.dh_value);
            this.active_registers.Controls.Add(this.dl_value);
            this.active_registers.Controls.Add(this.bh_value);
            this.active_registers.Location = new System.Drawing.Point(579, 12);
            this.active_registers.Name = "active_registers";
            this.active_registers.Size = new System.Drawing.Size(203, 376);
            this.active_registers.TabIndex = 36;
            this.active_registers.TabStop = false;
            this.active_registers.Text = "ACTIVE_REGISTERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "BH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "DH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "AL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "DL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "CH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "BL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "AH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "CL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 433);
            this.Controls.Add(this.active_registers);
            this.Controls.Add(this.functions);
            this.Controls.Add(this.setregisters);
            this.Controls.Add(this.Reset);
            this.Name = "Form1";
            this.Text = "Mikroprocesor 8086";
            this.setregisters.ResumeLayout(false);
            this.setregisters.PerformLayout();
            this.functions.ResumeLayout(false);
            this.functions.PerformLayout();
            this.active_registers.ResumeLayout(false);
            this.active_registers.PerformLayout();
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
        private GroupBox functions;
        private ProgressBar registers_progress;
        private ComboBox choose_function;
        private Button execute;
        private ComboBox reg2;
        private ComboBox reg1;
        private GroupBox groupBox1;
        private GroupBox active_registers;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label errorMessage;
    }
}