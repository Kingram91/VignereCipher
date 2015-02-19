//Copyright 2012, Kquane Ingram, All rights reserved.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vigenere_CipherCS
{
    public partial class Form1 : Form
    {
        bool labelChangedFlag = true;
        string PassPhrz;
        string PlainTxt;
        string DecryptedTxt;
        string  alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public Form1()
        {
            InitializeComponent();
        }

        private void PlainTextBox_TextChanged(object sender, EventArgs e)
        {
            // Grab text from PlainTextBox and store in PlainTxt string.
        }

        private void EncryptedTextBox_TextChanged(object sender, EventArgs e)
        {
            // Display Encrypted Text
        }

        private void PassPhrzTextBox_TextChanged(object sender, EventArgs e)
        {
            // Grab text from textbox and store in PassPhrz string.
        }


        private void EncryptDTC()
        {
            
		}
		
#region Encrypt using "Vigenere Cipher"
        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            /* Check if pass phrase and plain textboxes are not empty
             * and do not contain numerical values or punctions. 
             * If the PassphrzeTextBox and PlainTextbox is empty or contains incorrect data prompt the user accordingly.
             */
            if (labelChangedFlag)
            {

                if (PlainTextBox.Text.Length != 0 && PassPhrzTextBox.Text.Length != 0)
                {
                    PlainTxt = PlainTextBox.Text;
                    PassPhrz = PassPhrzTextBox.Text;
                    bool t = CharactersOnly(PassPhrz);
                    bool t2 = CharactersOnly(PlainTxt);
                    if (t && t2)
                    {
                        // begin encryption

                        char encryptedChar;
                        string encryptedText = "";
                        int charIndexOfText, charIndexOfPassword, newIndex;
                        char charOfText;
                        char charOfPassword;
                        string table = "";
                        string result = "";
                        alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        charIndexOfText = charIndexOfPassword = newIndex = 0;

                        //If want to use both key and password else it will only use password
                        // if (advanceRadioButton.Checked)
                        //{
                        //Removes duplicate characters from the string "alphabets"
                        //For example: if the key is "MRINMAY"
                        //The string "alphabets" will be modified to "MRINAYBCDEFGHJKLOPQSTUVWXZ"
                        //string key = RemoveDuplicateChars(keyTextBox.Text);
                        // alphabets = RemoveDuplicateChars(key.ToUpper() + alphabets);
                        // }
                        // else// If basic radio button is selected
                        //{
                        alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        // }

                        //look for white space in the password and discard it
                        //it is very that, a vigenere cipher's password should not have white space

                        foreach (char value in PassPhrz)
                        {
                            // if character is white space.
                            if (value == ' ')
                            {
                                //do nothing
                            }
                            else
                            {
                                // Append valid character to the table and the result.
                                table += value;
                                result += value;
                            }
                            //password without white space
                            PassPhrz = result;
                        }

                        for (int i = 0; i < PlainTxt.Length; i++)
                        {
                            for (int j = 0; j < PassPhrz.Length; j++)
                            {
                                if (i < PlainTxt.Length)
                                {
                                    //get each character of the text and the password 
                                    //Note: I have used only Upper Case alphabets 
                                    //but if you want to include lower case alphabets, add lower case alphabets(a-z) to string "alphabets"
                                    //replace the next two lines of code with this:/* charOfText = text[i]; charOfPassword = password[j];*/
                                    charOfText = char.ToUpper(PlainTxt[i]);
                                    charOfPassword = char.ToUpper(PassPhrz[j]);

                                    if (charOfText == ' ')// if encounters a white space in the text
                                    {
                                        //add the white case character to the encrypted text
                                        encryptedChar = charOfText;
                                        encryptedText = encryptedText + encryptedChar;
                                        i++;
                                        j--;
                                    }
                                    else if (charOfText == '\n')// if encounters a new line in the text
                                    {
                                        //add the new line character to the encrypted text
                                        encryptedChar = charOfText;
                                        encryptedText = encryptedText + encryptedChar;
                                        i++;
                                        j--;
                                    }
                                    else
                                    {
                                        //Get the index of the character of text from alphabets variable
                                        charIndexOfText = alphabets.IndexOf(charOfText);

                                        //Get the index of the character of password from alphabets variable
                                        charIndexOfPassword = alphabets.IndexOf(charOfPassword);

                                        //Get the encrypted character
                                        newIndex = (charIndexOfText + charIndexOfPassword) % 26;
                                        encryptedChar = alphabets[newIndex];

                                        //add the encrypted character to a string every time to get an encrypted string
                                        encryptedText = encryptedText + encryptedChar;
                                        i++;
                                    }
                                }
                            }
                            i--;
                        }
                        //Display Encrypted text
                        EncryptedTextBox.Clear();
                        EncryptedTextBox.Text = encryptedText;
                    }
                    else
                    {
                        showDialogBox();
                    }
                }
                else
                {
                    showDialogBox();
                }
            }
            else {
                EncryptDTC();
            }
        }
#endregion

        bool CharactersOnly(string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z ]+$");
        }

        public void showDialogBox()
        {
            DialogResult result = MessageBox.Show("The text in the Pass Phrase and plain text TextBoxes must only contain Alpahbetical values, spaces are permissable only in the plain text. All fields must contain an input, except the encrypted field");
        }

#region Decrypt using "Vigenere Cipher"
        private void DecryptBtn_Click(object sender, EventArgs e)
        {

            // Check if Encrypted Textbox is not empty, if not empty proceed with decrpytion.
            if (PlainTextBox.Text.Length != 0 && PassPhrzTextBox.Text.Length != 0)
            {
                PlainTxt = PlainTextBox.Text;
                PassPhrz = PassPhrzTextBox.Text;
                bool t = CharactersOnly(PassPhrz);
                bool t2 = CharactersOnly(PlainTxt);
                if (t && t2)
                {

                    char newChar;
                    string encryptedText = EncryptedTextBox.Text;
                    //string decryptedText = "";
                    int charIndexOfEncryptedText, charIndexOfPassword, newIndex;
                    char charOfEncryptedText;
                    char charOfPassword;
                    string table = "";
                    string result = "";
                    alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    charIndexOfEncryptedText = charIndexOfPassword = newIndex = 0;

                   
                    alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    // }

                    //look for white space in the password and discard it
                    //it is very that, a vigenere cipher's password should not have white space
                    foreach (char value in PassPhrz)
                    {
                        // See if character is in the table.
                        if (value == ' ')
                        {
                            //do nothing
                        }
                        else
                        {
                            // Append valid character to the table and the result.
                            table += value;
                            result += value;
                        }
                        //password without white space
                        PassPhrz = result;
                    }

                    for (int i = 0; i < encryptedText.Length; i++)
                    {
                        for (int j = 0; j < PassPhrz.Length; j++)
                        {
                            if (i < encryptedText.Length)
                            {
                                charOfEncryptedText = char.ToUpper(encryptedText[i]);
                                charOfPassword = char.ToUpper(PassPhrz[j]);

                                if (charOfEncryptedText == ' ')// if encounters a white space in the encrypted text
                                {
                                    //add the white case character to the decrypted text
                                    newChar = charOfEncryptedText;
                                    DecryptedTxt += newChar;
                                    i++;
                                    j--;
                                }
                                else if (charOfEncryptedText == '\n')// if encounters a new line in the encrypted text
                                {
                                    //add the new line character to the decrypted text
                                    newChar = charOfEncryptedText;
                                    DecryptedTxt += newChar;
                                    i++;
                                    j--;
                                }
                                else
                                {
                                    //Get the index of the character of encrypted text from alphabets variable
                                    charIndexOfEncryptedText = alphabets.IndexOf(charOfEncryptedText);

                                    //Get the index of the character of password from alphabets variable
                                    charIndexOfPassword = alphabets.IndexOf(charOfPassword);
                                    newIndex = (charIndexOfEncryptedText - charIndexOfPassword) % 26;

                                    //if the character is at the start of the string "alphabets"
                                    if ((charIndexOfEncryptedText - charIndexOfPassword) < 0)
                                    {
                                        //Get the decrypted character
                                        newChar = alphabets[newIndex + 26];

                                        //add the decrypted character to a string every time to get an encrypted string
                                        DecryptedTxt += newChar;
                                        i++;
                                    }
                                    else
                                    {
                                        //Get the decrypted character
                                        newChar = alphabets[newIndex];

                                        //add the decrypted character to a string every time to get an decrypted string
                                        DecryptedTxt += newChar;
                                        i++;
                                    }
                                }
                            }
                        }
                        i--;
                    }
                    EncryptedTextBox.Clear();
                    PassPhrz = "";
                    PassPhrzTextBox.Clear();
                    PlainTxt = "";
                    PlainTextBox.Clear();
                    DecryptedTextBox.Text = DecryptedTxt;
                }
                else
                {
                    showDialogBox();
                }
            }
            else
            {
                showDialogBox();
            }
        }

#endregion
 
        static string RemoveDuplicateChars(string key)
        {
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string text = "";

            // Store the result in this string.
            string final = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (text.IndexOf(value) == -1)
                {
                    if (value == ' ')
                    {
                        //do nothing
                    }
                    else
                    {
                        // Append to the table and the result.
                        text += value;
                        final += value;
                    }
                }
            }
            return final;
        }

        private void VingnereRB_CheckedChanged(object sender, EventArgs e)
        {
            // if label change is true, change label and set to false.
            if (labelChangedFlag){
                PassPhraseLabel.Text = "Pass Phrase:";
                PlainTxtLabel.Text = "Plain Text:";
                VignereEncryptedTxtLabel.Text = "Encrypted Text:";
                EncryptedTextBox.Location = new Point(145, 144);
                EncryptedTextBox.Enabled = false;
                VignereDecryptedTxtLbl.Text = "Decrypted Text:";
                DecryptedTextBox.Location = new Point(145, 193);
                DecryptedTextBox.Enabled = false;
                DTCColumnOrderLabel.Hide();
                ColumnPermuationTextBox.Hide();
                DTCEncryptedLabel.Hide();
                TranspositionEncryptedTextBox.Hide();
                DTCDecryptedTxtLabel.Hide();
                TranspositionDecryptedTextBox.Hide();
                labelChangedFlag = false;
            }
        }

        private void DoubleTRB_CheckedChanged(object sender, EventArgs e)
        {
            // change label and set changeLabel flag to true.
            PassPhraseLabel.Text = "Plain text:";
            PlainTxtLabel.Text = "Matrix row Size:";
            VignereEncryptedTxtLabel.Text = "Matrix column size:";
            VignereDecryptedTxtLbl.Text = "Row Permutation Order:";
            EncryptedTextBox.Location = new Point(155, 144);
            EncryptedTextBox.Enabled = true;
            DecryptedTextBox.Location = new Point(180, 193);
            DecryptedTextBox.Enabled = true;
            DTCColumnOrderLabel.Show();
            ColumnPermuationTextBox.Show();
            DTCEncryptedLabel.Show();
            TranspositionEncryptedTextBox.Show();
            DTCDecryptedTxtLabel.Show();
            TranspositionDecryptedTextBox.Show();
            labelChangedFlag = true;
        }

        private void CPOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TranspositionEncryptedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}