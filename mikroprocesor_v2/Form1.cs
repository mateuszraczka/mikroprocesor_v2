using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;

namespace mikroprocesor_v2
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> register = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            register.Add("AL", REGISTER_DEFAULT);
            register.Add("AH", REGISTER_DEFAULT);
            register.Add("BL", REGISTER_DEFAULT);
            register.Add("BH", REGISTER_DEFAULT);
            register.Add("CL", REGISTER_DEFAULT);
            register.Add("CH", REGISTER_DEFAULT);
            register.Add("DL", REGISTER_DEFAULT);
            register.Add("DH", REGISTER_DEFAULT);
        }
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

        const int MINIMUM_LENGTH = 2;
        const int MAXIMUM_LENGTH = 2;
        const string REGISTER_DEFAULT = "FF";

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
                        if(validateNumber == checkNumber)
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
            if (ValidateTextBoxMinimumLength(input,MINIMUM_LENGTH) && ValidateTextBoxMaximumLength(input, MAXIMUM_LENGTH))
            {
                while (true)
                {
                    bool valid = ValidateStringContainsCharacters(input, allowedCharacters, input.Length) ? true : false;
                    return valid;
                }
            }
            return false;
        }

        public void ChangeRegisterAndApply(Label currentValueBox, TextBox currentTextBox, string currentRegister)
        {
            register[currentRegister] = currentTextBox.Text;
            currentValueBox.Text = register[currentRegister];
        }

        public void ClearRegisterAndApply()
        {
            al_textbox.Text = "";
            ah_textbox.Text = "";
            bl_textbox.Text = "";
            bh_textbox.Text = "";
            cl_textbox.Text = "";
            ch_textbox.Text = "";
            dl_textbox.Text = "";
            dh_textbox.Text = "";

            al_value.Text = "  ";
            ah_value.Text = "  ";
            bl_value.Text = "  ";
            bh_value.Text = "  ";
            cl_value.Text = "  ";
            ch_value.Text = "  ";
            dl_value.Text = "  ";
            dh_value.Text = "  ";

            register = register.ToDictionary(p => p.Key, p => REGISTER_DEFAULT);
        }
        public void RegistersProgress(CheckBox currentCheckBox, ProgressBar currentProgress)
        {
            if (currentCheckBox.Checked)
            {
                if (currentProgress.Value < registers_progress.Maximum) registers_progress.Value++;
            }
            else
            {
                if (currentProgress.Value > registers_progress.Minimum) registers_progress.Value--;
            }
        }
        public void ValidationVisualization(CheckBox currentCheckBox, TextBox currentTextBox, bool validated, ProgressBar currentProgress)
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
            RegistersProgress(currentCheckBox, currentProgress);
        }
        private void ValidateRegister(TextBox currentTextBox, CheckBox currentCheckBox, Label currentValueBox)
        {
            var currentProgress = registers_progress;
            bool validateTextBox = ValidateTextBox(currentTextBox.Text);

            if (validateTextBox)
            {
                ChangeRegisterAndApply(currentValueBox,currentTextBox,currentTextBox.AccessibleName);
            }
            ValidationVisualization(currentCheckBox, currentTextBox, validateTextBox, currentProgress);
        }
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

        private void Reset_Click(object sender, EventArgs e)
        {
            ClearRegisterAndApply();
            registers_progress.Value = 0;
        }
        private void mov(string from, string to)
        {
            to = from;
        }
        private void choose_function_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(choose_function.SelectedIndex == 0)
            {
                mov(register["AL"], register["AH"]);
            }
        }
    }
}