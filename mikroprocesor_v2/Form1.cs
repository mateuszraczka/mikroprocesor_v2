using System.Reflection;

namespace mikroprocesor_v2
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> register = new Dictionary<string, string>();
        public Dictionary<string, bool> registerValidationHistory = new Dictionary<string, bool>();
        public List<TextBox> registersTextBoxes = new List<TextBox>();
        public List<Label> registersValues = new List<Label>();
        public Form1()
        {
            ListsSettings();
            CreateRegisters();
            InitializeComponent();
        }

        const int MINIMUM_LENGTH = 2;
        const int MAXIMUM_LENGTH = 2;
        const string REGISTER_DEFAULT = "FF";
        char[] allowedCharacters = {
                '0',
                '1',
                '2',
                '3',
                '4',
                '5',
                '6',
                '7',
                '8',
                '9',
                'A',
                'B',
                'C',
                'D',
                'E',
                'F'
            };
        const int MAX_MEMORY_LENGTH = 2 ^ 16;
        List<string> memory = new List<string>();
        string result;
        private void ListsSettings()
        {
            registersTextBoxes.Add(al_textbox);
            registersTextBoxes.Add(ah_textbox);
            registersTextBoxes.Add(bl_textbox);
            registersTextBoxes.Add(bh_textbox);
            registersTextBoxes.Add(cl_textbox);
            registersTextBoxes.Add(ch_textbox);
            registersTextBoxes.Add(dl_textbox);
            registersTextBoxes.Add(dh_textbox);

            registersValues.Add(al_value);
            registersValues.Add(ah_value);
            registersValues.Add(bl_value);
            registersValues.Add(bh_value);
            registersValues.Add(cl_value);
            registersValues.Add(ch_value);
            registersValues.Add(dl_value);
            registersValues.Add(dh_value);
        }
        ///
        /// REGISTER
        ///
        public bool CheckDictionary(Dictionary<string, bool> dictToCheck)
        {
            var test = dictToCheck.Where(x => x.Value == false);
            if (test.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RefreshAllRegisters()
        {
            al_value.Text = register["AL"];
            ah_value.Text = register["AH"];
            bl_value.Text = register["BL"];
            bh_value.Text = register["BH"];
            cl_value.Text = register["CL"];
            ch_value.Text = register["CH"];
            dl_value.Text = register["DL"];
            dh_value.Text = register["DH"];
        }
        public void CreateRegisters()
        {
            register.Add("AL", REGISTER_DEFAULT);
            register.Add("AH", REGISTER_DEFAULT);
            register.Add("BL", REGISTER_DEFAULT);
            register.Add("BH", REGISTER_DEFAULT);
            register.Add("CL", REGISTER_DEFAULT);
            register.Add("CH", REGISTER_DEFAULT);
            register.Add("DL", REGISTER_DEFAULT);
            register.Add("DH", REGISTER_DEFAULT);

            registerValidationHistory.Add("AL", false);
            registerValidationHistory.Add("AH", false);
            registerValidationHistory.Add("BL", false);
            registerValidationHistory.Add("BH", false);
            registerValidationHistory.Add("CL", false);
            registerValidationHistory.Add("CH", false);
            registerValidationHistory.Add("DL", false);
            registerValidationHistory.Add("DH", false);
        }

        public void Clear()
        {
            setregisters.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);

            al_value.Text = "FF";
            ah_value.Text = "FF";
            bl_value.Text = "FF";
            bh_value.Text = "FF";
            cl_value.Text = "FF";
            ch_value.Text = "FF";
            dl_value.Text = "FF";
            dh_value.Text = "FF";

            al_value.BackColor = Color.Red;
            ah_value.BackColor = Color.Red;
            bl_value.BackColor = Color.Red;
            bh_value.BackColor = Color.Red;
            cl_value.BackColor = Color.Red;
            ch_value.BackColor = Color.Red;
            dl_value.BackColor = Color.Red;
            dh_value.BackColor = Color.Red;

            register = register.ToDictionary(p => p.Key, p => REGISTER_DEFAULT);
        }
        public void ChangeRegisterAndApply(Label currentValueBox, TextBox currentTextBox, string currentRegister)
        {
            register[currentRegister] = currentTextBox.Text;
            currentValueBox.Text = register[currentRegister];
            currentValueBox.BackColor = Color.Green;
        }

        ///
        /// REGISTERS PROGRESSBAR
        /// 

        public void UpdateProgressBar(ProgressBar currentProgress, bool validation, TextBox currentTextBox)
        {
            if (validation)
            {
                if (registerValidationHistory[currentTextBox.AccessibleName] == false)
                {
                    registerValidationHistory[currentTextBox.AccessibleName] = true;
                }
                if (currentProgress.Value < currentProgress.Maximum)
                {
                    currentProgress.Value++;
                }
            }
            else
            {
                if (registerValidationHistory[currentTextBox.AccessibleName] == true)
                {
                    registerValidationHistory[currentTextBox.AccessibleName] = false;
                    if (currentProgress.Value > currentProgress.Minimum)
                    {
                        currentProgress.Value--;
                    }
                }
            }
        }

        ///
        /// TEXTBOXES VALIDATION
        ///

        public bool ValidateTextBoxMinimumLength(string txt, int minimumLength)
        {
            bool valid = txt.Length >= minimumLength ? true : false;
            return valid;
        }

        public bool ValidateTextBoxMaximumLength(string txt, int maximumLength)
        {
            bool valid = txt.Length <= maximumLength ? true : false;
            return valid;
        }

        public bool ValidateStringContainsCharacters(string arr1, char[] arr2, int validateNumber)
        {
            int checkNumber = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        checkNumber++;
                        if (validateNumber == checkNumber)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool ValidateTextBox(string input)
        {
            if (ValidateTextBoxMinimumLength(input, MINIMUM_LENGTH) && ValidateTextBoxMaximumLength(input, MAXIMUM_LENGTH))
            {
                while (true)
                {
                    bool valid = ValidateStringContainsCharacters(input, allowedCharacters, input.Length) ? true : false;
                    return valid;
                }
            }
            return false;
        }
        public void ValidationVisualization(CheckBox currentCheckBox, TextBox currentTextBox, bool validated)
        {
            if (validated)
            {
                currentCheckBox.Checked = true;
                currentTextBox.BackColor = Color.White;
            }
            else
            {
                currentCheckBox.Checked = false;
                currentTextBox.BackColor = Color.LightCoral;
            }
        }
        private void ValidateIfAllRegistersAreSet()
        {
            bool allTrue = CheckDictionary(registerValidationHistory);
            if (allTrue == true)
            {
                functions.Enabled = true;
                memory_groupbox.Enabled = true;
                errorMessage.Visible = false;
            }
            else
            {
                functions.Enabled = false;
                memory_groupbox.Enabled = false;
                errorMessage.Visible = true;
            }
        }
        private void ValidateRegister(TextBox currentTextBox, CheckBox currentCheckBox, Label currentValueBox)
        {
            var currentProgress = registers_progress;
            bool validateTextBox = ValidateTextBox(currentTextBox.Text);

            if (validateTextBox)
            {
                ChangeRegisterAndApply(currentValueBox, currentTextBox, currentTextBox.AccessibleName);
            }
            UpdateProgressBar(currentProgress, validateTextBox, currentTextBox);
            ValidationVisualization(currentCheckBox, currentTextBox, validateTextBox);
            ValidateIfAllRegistersAreSet();
        }

        ///
        /// TEXTBOXES ONCHANGE
        ///

        private void al_textbox_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentCheckBox = al_check;
            var currentValueBox = al_value;
            ValidateRegister(currentTextBox, currentCheckBox, currentValueBox);
        }

        private void ah_textbox_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentCheckBox = ah_check;
            var currentValueBox = ah_value;
            ValidateRegister(currentTextBox, currentCheckBox, currentValueBox);
        }
        private void bl_textbox_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentCheckBox = bl_check;
            var currentValueBox = bl_value;
            ValidateRegister(currentTextBox, currentCheckBox, currentValueBox);
        }

        private void bh_textbox_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentCheckBox = bh_check;
            var currentValueBox = bh_value;
            ValidateRegister(currentTextBox, currentCheckBox, currentValueBox);
        }
        private void cl_textbox_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentCheckBox = cl_check;
            var currentValueBox = cl_value;
            ValidateRegister(currentTextBox, currentCheckBox, currentValueBox);
        }

        private void ch_textbox_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentCheckBox = ch_check;
            var currentValueBox = ch_value;
            ValidateRegister(currentTextBox, currentCheckBox, currentValueBox);
        }

        private void dl_textbox_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentCheckBox = dl_check;
            var currentValueBox = dl_value;
            ValidateRegister(currentTextBox, currentCheckBox, currentValueBox);
        }

        private void dh_textbox_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentCheckBox = dh_check;
            var currentValueBox = dh_value;
            ValidateRegister(currentTextBox, currentCheckBox, currentValueBox);
        }

        ///
        /// COMBOBOXES VALIDATION
        ///
        public void ValidateIfAllComboBoxesAreSet()
        {
            if ((reg1.SelectedIndex != -1 && (reg2.SelectedIndex != -1) && (choose_function.SelectedIndex != -1)) || (((choose_function.Items[choose_function.SelectedIndex].ToString() == "NOT") || (choose_function.Items[choose_function.SelectedIndex].ToString() == "DEC") || (choose_function.Items[choose_function.SelectedIndex].ToString() == "INC")) && (reg1.SelectedIndex != -1)))
            {
                execute.Enabled = true;
            }
            else
            {
                execute.Enabled = false;
            }
        }

        ///
        /// COMBOBOXES ON CHANGE
        ///

        private void choose_function_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateIfAllComboBoxesAreSet();
            if ((choose_function.Items[choose_function.SelectedIndex].ToString() == "NOT") || (choose_function.Items[choose_function.SelectedIndex].ToString() == "DEC") || (choose_function.Items[choose_function.SelectedIndex].ToString() == "INC"))
            {
                reg2.Enabled = false;
            }
            else
            {
                reg2.Enabled = true;
            }
        }

        private void reg1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateIfAllComboBoxesAreSet();
        }

        private void reg2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateIfAllComboBoxesAreSet();
        }
        /// 
        /// FUNCTIONS AND EXECUTION
        /// 
        private string hex2binary(string hexvalue)
        {
            string binaryval = "";
            binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
            return binaryval;
        }

        private string binary2hex(string binvalue)
        {
            string hexval = "";
            hexval = Convert.ToInt32(binvalue, 2).ToString("X2");
            return hexval;
        }
        private string int2hex(int intvalue)
        {
            string hexval = "";
            hexval = intvalue.ToString("X2");
            return hexval;
        }
        private string fullFillDigits(string toFullFill, int fullFillToLength)
        {
            string fullFilledRegister = "";
            string temp = toFullFill;
            int length = fullFillToLength - toFullFill.Length;
            for (int i = 0; i < length; i++)
            {
                fullFilledRegister += "0";
            }
            fullFilledRegister += temp;
            return fullFilledRegister;
        }

        private void Mov(string from, string to, bool access_to_memory, string fromMemory)
        {
            if (!access_to_memory)
                register[to] = register[from];
            else register[to] = fromMemory;
        }

        private void Xchg(string from, string to, bool access_to_memory, string fromMemory)
        {
            if (!access_to_memory)
            {
                string temp = register[to];
                register[to] = register[from];
                register[from] = temp;
            }
            else
            {
                register[to] = fromMemory;
            }
        }
        private void Not(string reg)
        {
            string binaryString = hex2binary(register[reg]);
            string afterOperation = "";
            if (binaryString.Length < 8)
            {
                binaryString = fullFillDigits(binaryString, 8);
            }
            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '1')
                {
                    afterOperation += '0';
                }
                else
                {
                    afterOperation += '1';
                }
            }
            register[reg] = binary2hex(afterOperation);
        }
        private void And(string reg1, string reg2, bool access_to_memory, string fromMemory)
        {
            string binaryString1 = "";
            if(!access_to_memory)
            {
                binaryString1 = hex2binary(register[reg1]);
            }
            else
            {
                binaryString1 = hex2binary(fromMemory);
            }
            string binaryString2 = hex2binary(register[reg2]);
            if (binaryString1.Length < 8)
            {
                binaryString1 = fullFillDigits(binaryString1, 8);
            }
            if (binaryString2.Length < 8)
            {
                binaryString2 = fullFillDigits(binaryString2, 8);
            }
            string afterOperation = "";
            for (int i = 0; i < binaryString1.Length; i++)
            {
                if (binaryString1[i] == '1' && binaryString2[i] == '1')
                {
                    afterOperation += "1";
                }
                else
                {
                    afterOperation += "0";
                }
            }
            register[reg1] = binary2hex(afterOperation);
        }
        private void Or(string reg1, string reg2, bool access_to_memory, string fromMemory)
        {
            string binaryString1 = "";
            if (!access_to_memory)
            {
                binaryString1 = hex2binary(register[reg1]);
            }
            else
            {
                binaryString1 = hex2binary(fromMemory);
            }
            string binaryString2 = hex2binary(register[reg2]);
            if (binaryString1.Length < 8)
            {
                binaryString1 = fullFillDigits(binaryString1, 8);
            }
            if (binaryString2.Length < 8)
            {
                binaryString2 = fullFillDigits(binaryString2, 8);
            }
            string afterOperation = "";
            for (int i = 0; i < binaryString1.Length; i++)
            {
                if (binaryString1[i] == '0' && binaryString2[i] == '0')
                {
                    afterOperation += "0";
                }
                else
                {
                    afterOperation += "1";
                }
            }
            register[reg1] = binary2hex(afterOperation);
        }
        private void NAnd(string reg1, string reg2, bool access_to_memory, string fromMemory)
        {
            string binaryString1 = "";
            if (!access_to_memory)
            {
                binaryString1 = hex2binary(register[reg1]);
            }
            else
            {
                binaryString1 = hex2binary(fromMemory);
            }
            string binaryString2 = hex2binary(register[reg2]);
            if (binaryString1.Length < 8)
            {
                binaryString1 = fullFillDigits(binaryString1, 8);
            }
            if (binaryString2.Length < 8)
            {
                binaryString2 = fullFillDigits(binaryString2, 8);
            }
            string afterOperation = "";
            for (int i = 0; i < binaryString1.Length; i++)
            {
                if (binaryString1[i] == '1' && binaryString2[i] == '1')
                {
                    afterOperation += "0";
                }
                else
                {
                    afterOperation += "1";
                }
            }
            register[reg1] = binary2hex(afterOperation);
        }
        private void NOr(string reg1, string reg2, bool access_to_memory, string fromMemory)
        {
            string binaryString1 = "";
            if (!access_to_memory)
            {
                binaryString1 = hex2binary(register[reg1]);
            }
            else
            {
                binaryString1 = hex2binary(fromMemory);
            }
            string binaryString2 = hex2binary(register[reg2]);
            if (binaryString1.Length < 8)
            {
                binaryString1 = fullFillDigits(binaryString1, 8);
            }
            if (binaryString2.Length < 8)
            {
                binaryString2 = fullFillDigits(binaryString2, 8);
            }
            string afterOperation = "";
            for (int i = 0; i < binaryString1.Length; i++)
            {
                if (binaryString1[i] == '0' && binaryString2[i] == '0')
                {
                    afterOperation += "1";
                }
                else
                {
                    afterOperation += "0";
                }
            }
            register[reg1] = binary2hex(afterOperation);
        }
        private void XOr(string reg1, string reg2, bool access_to_memory, string fromMemory)
        {
            string binaryString1 = "";
            if (!access_to_memory)
            {
                binaryString1 = hex2binary(register[reg1]);
            }
            else
            {
                binaryString1 = hex2binary(fromMemory);
            }
            string binaryString2 = hex2binary(register[reg2]);
            if (binaryString1.Length < 8)
            {
                binaryString1 = fullFillDigits(binaryString1, 8);
            }
            if (binaryString2.Length < 8)
            {
                binaryString2 = fullFillDigits(binaryString2, 8);
            }
            string afterOperation = "";
            for (int i = 0; i < binaryString1.Length; i++)
            {
                if ((binaryString1[i] == '0' && binaryString2[i] == '0') || (binaryString1[i] == '1' && binaryString2[i] == '1'))
                {
                    afterOperation += "0";
                }
                else
                {
                    afterOperation += "1";
                }
            }
            register[reg1] = binary2hex(afterOperation);
        }
        private void XNOr(string reg1, string reg2, bool access_to_memory, string fromMemory)
        {
            string binaryString1 = "";
            if (!access_to_memory)
            {
                binaryString1 = hex2binary(register[reg1]);
            }
            else
            {
                binaryString1 = hex2binary(fromMemory);
            }
            string binaryString2 = hex2binary(register[reg2]);
            if (binaryString1.Length < 8)
            {
                binaryString1 = fullFillDigits(binaryString1, 8);
            }
            if (binaryString2.Length < 8)
            {
                binaryString2 = fullFillDigits(binaryString2, 8);
            }
            string afterOperation = "";
            for (int i = 0; i < binaryString1.Length; i++)
            {
                if ((binaryString1[i] == '0' && binaryString2[i] == '0') || (binaryString1[i] == '1' && binaryString2[i] == '1'))
                {
                    afterOperation += "1";
                }
                else
                {
                    afterOperation += "0";
                }
            }
            register[reg1] = binary2hex(afterOperation);
        }
        private void Inc(string reg, bool access_to_memory, string fromMemory)
        {
            if (!access_to_memory)
            {
                if (register[reg] == "FF") return;
                int integerValue = int.Parse(register[reg], System.Globalization.NumberStyles.HexNumber);
                integerValue++;
                register[reg] = int2hex(integerValue);
            }
            else
            {
                if (fromMemory == "FF") return;
                int integerValue = int.Parse(fromMemory, System.Globalization.NumberStyles.HexNumber);
                integerValue++;
                register[reg] = int2hex(integerValue);
            }
        }
        private void Dec(string reg, bool access_to_memory, string fromMemory)
        {
            if (!access_to_memory)
            {
                if (register[reg] == "00") return;
                int integerValue = int.Parse(register[reg], System.Globalization.NumberStyles.HexNumber);
                integerValue--;
                register[reg] = int2hex(integerValue);
            }
            else
            {
                if (fromMemory == "00") return;
                int integerValue = int.Parse(fromMemory, System.Globalization.NumberStyles.HexNumber);
                integerValue--;
                register[reg] = int2hex(integerValue);
            }
        }
        private void AddToMemory(string result)
        {
            if (memory.Count < MAX_MEMORY_LENGTH)
            {
                memory.Add(result);
                listViewOfMemory.Items.Add((memory.Count-1).ToString("X4"));
            }
        }
        private void execute_Click(object sender, EventArgs e)
        {
            string currentSelectedFunction = choose_function.Items[choose_function.SelectedIndex].ToString();
            string firstRegister = reg1.Items[reg1.SelectedIndex].ToString();
            string secondRegister = "";
            bool access_to_memory = false;
            string fromMemory = "";
            access_memory.Text = "";
            for (int i =0; i<memory.Count;i++)
            {
                if (memory[i] == access_memory.Text)
                {
                    access_to_memory = true;
                    fromMemory = memory[i];
                }
            }

            if ((currentSelectedFunction != "NOT") && (currentSelectedFunction != "INC") && (currentSelectedFunction != "DEC"))
            {
                secondRegister = reg2.Items[reg2.SelectedIndex].ToString();
            }

            if (currentSelectedFunction == "MOV")
            {
                Mov(firstRegister, secondRegister, access_to_memory, fromMemory);
            }
            else if (currentSelectedFunction == "XCHG")
            {
                Xchg(firstRegister, secondRegister,access_to_memory, fromMemory);
            }
            else if (currentSelectedFunction == "NOT")
            {
                Not(firstRegister);
            }
            else if (currentSelectedFunction == "AND")
            {
                And(firstRegister, secondRegister, access_to_memory, fromMemory);
            }
            else if (currentSelectedFunction == "OR")
            {
                Or(firstRegister, secondRegister, access_to_memory, fromMemory);
            }
            else if (currentSelectedFunction == "NAND")
            {
                NAnd(firstRegister, secondRegister, access_to_memory, fromMemory);
            }
            else if (currentSelectedFunction == "NOR")
            {
                NOr(firstRegister, secondRegister, access_to_memory, fromMemory);
            }
            else if (currentSelectedFunction == "XOR")
            {
                XOr(firstRegister, secondRegister, access_to_memory, fromMemory);
            }
            else if (currentSelectedFunction == "XNOR")
            {
                XNOr(firstRegister, secondRegister, access_to_memory, fromMemory);
            }
            else if (currentSelectedFunction == "INC")
            {
                Inc(firstRegister, access_to_memory, fromMemory);
            }
            else if (currentSelectedFunction == "DEC")
            {
                Dec(firstRegister, access_to_memory, fromMemory);
            }

            if (firstRegister == al_value.AccessibleName)
            {
                result = al_value.Text;
            }
            else if (firstRegister == ah_value.AccessibleName)
            {
                result = ah_value.Text;
            }
            else if (firstRegister == bl_value.AccessibleName)
            {
                result = bl_value.Text;
            }
            else if (firstRegister == bh_value.AccessibleName)
            {
                result = bh_value.Text;
            }
            else if (firstRegister == cl_value.AccessibleName)
            {
                result = cl_value.Text;
            }
            else if (firstRegister == ch_value.AccessibleName)
            {
                result = ch_value.Text;
            }
            else if (firstRegister == dl_value.AccessibleName)
            {
                result = dl_value.Text;
            }
            else if (firstRegister == dh_value.AccessibleName)
            {
                result = dh_value.Text;
            }
            if(save_to_memory.Checked)
            {
                AddToMemory(result);
            }
            RefreshAllRegisters();
        }

        ///
        /// ADDITIONAL FUNCTIONS
        ///

        private void Reset_Click(object sender, EventArgs e)
        {
            Clear();
            registers_progress.Value = 0;
            functions.Enabled = false;
            reg1.SelectedIndex = -1;
            reg2.SelectedIndex = -1;
            choose_function.SelectedIndex = -1;
            reg1.Text = reg1.AccessibleName;
            reg2.Text = reg2.AccessibleName;
            choose_function.Text = choose_function.AccessibleName;
        }

        private void random_values_Click(object sender, EventArgs e)
        {
            Clear();
            for (int j = 0; j < 2; j++)
            {
                Random random = new Random();
                al_textbox.Text += allowedCharacters[random.Next(0, allowedCharacters.Length)];
            }
            for (int j = 0; j < 2; j++)
            {
                Random random = new Random();
                ah_textbox.Text += allowedCharacters[random.Next(0, allowedCharacters.Length)];
            }
            for (int j = 0; j < 2; j++)
            {
                Random random = new Random();
                bl_textbox.Text += allowedCharacters[random.Next(0, allowedCharacters.Length)];
            }
            for (int j = 0; j < 2; j++)
            {
                Random random = new Random();
                bh_textbox.Text += allowedCharacters[random.Next(0, allowedCharacters.Length)];
            }
            for (int j = 0; j < 2; j++)
            {
                Random random = new Random();
                cl_textbox.Text += allowedCharacters[random.Next(0, allowedCharacters.Length)];
            }
            for (int j = 0; j < 2; j++)
            {
                Random random = new Random();
                ch_textbox.Text += allowedCharacters[random.Next(0, allowedCharacters.Length)];
            }
            for (int j = 0; j < 2; j++)
            {
                Random random = new Random();
                dl_textbox.Text += allowedCharacters[random.Next(0, allowedCharacters.Length)];
            }
            for (int j = 0; j < 2; j++)
            {
                Random random = new Random();
                dh_textbox.Text += allowedCharacters[random.Next(0, allowedCharacters.Length)];
            }
        }
    }
}