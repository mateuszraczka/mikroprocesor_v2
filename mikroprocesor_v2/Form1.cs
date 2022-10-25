namespace mikroprocesor_v2
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> register = new Dictionary<string, string>();
        public Dictionary<string, bool> registerValidationHistory = new Dictionary<string, bool>();
        public Form1()
        {
            createRegisters();
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

        ///
        /// REGISTER
        ///
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
        public void createRegisters()
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
                errorMessage.Visible = false;
            }
            else
            {
                functions.Enabled = false;
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
            if ((reg1.SelectedIndex != -1 && (reg2.SelectedIndex != -1) && (choose_function.SelectedIndex != -1)))
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

        private void Mov(string from, string to)
        {
            register[to] = register[from];
        }

        private void Xchg(string from, string to)
        {
            string temp = register[to];
            register[to] = register[from];
            register[from] = temp;
        }

        private void execute_Click(object sender, EventArgs e)
        {
            string currentSelectedFunction = choose_function.Items[choose_function.SelectedIndex].ToString();
            string firstRegister = reg1.Items[reg1.SelectedIndex].ToString();
            string secondRegister = reg2.Items[reg2.SelectedIndex].ToString();

            if (currentSelectedFunction == "MOV")
            {
                Mov(firstRegister, secondRegister);
            }
            else if (currentSelectedFunction == "XCHG")
            {
                Xchg(firstRegister, secondRegister);
            }
            RefreshAllRegisters();
        }

        ///
        /// MAIN PROGRAM FUNCTIONS
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
    }
}