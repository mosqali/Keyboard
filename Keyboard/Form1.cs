namespace Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Keys
        private void btnQ_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "q";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "w";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "e";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "r";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "t";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "y";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "u";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "i";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "o";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "p";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "a";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "s";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "d";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "f";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "g";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "h";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "j";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "k";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "l";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "z";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "x";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "c";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "v";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "b";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "n";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            tbOutput.Text += "m";
        }


        private void btnSpace_Click(object sender, EventArgs e)
        {
            tbOutput.Text += " ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //creates a string minus the last letter as deletedCharOfText
            string deletedCharOfText = RemoveLastCharacter(tbOutput.Text);

            tbOutput.Text = deletedCharOfText;

            string RemoveLastCharacter(string text)
            {
                //Check if the string is not empty
                if (!string.IsNullOrEmpty(text))
                {
                    //Use Substring to create a new string excluding the last character
                    return text.Substring(0, text.Length - 1);
                }

                //Return an empty string if the input is empty
                return string.Empty;
            }
        }
        #endregion
    }
}