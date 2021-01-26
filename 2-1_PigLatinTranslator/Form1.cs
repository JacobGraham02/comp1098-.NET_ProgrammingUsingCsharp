using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _2_1_PigLatinTranslator
{
    public partial class Form1 : Form
    {
        private static readonly char[] specialChars = "!@#$%^&*()".ToCharArray();
        private static readonly char[] numberChars = "1234567890".ToCharArray();
        List<TextBox> textBoxList = new List<TextBox>();
        string[] strArr;

        public Form1()
        {
            InitializeComponent();
            textBoxList.Add(this.txtEnglish);
            textBoxList.Add(this.txtPigLatin);
        }

        // System defined methods
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            // If the word starts with a consonant, move the consonants before the first vowel to the end of the word, and add 'ay' 
            string temp;
            temp = txtEnglish.Text;
            
            if (string.IsNullOrEmpty(temp))
            {
                MessageBox.Show("Please enter some text to translate");
                return;
            }
            
            strArr = txtEnglish.Text.Split(" ");
            
            foreach (string item in strArr)
            {
                int indexOfChar = item.IndexOfAny(specialChars);
                int indexOfNum = item.IndexOfAny(numberChars);

                if (indexOfChar != -1 || indexOfNum != -1)
                {
                    displayConvertedText(item);
                }
                else if (IsUpper(item) || IsLower(item) || IsUpper(item[0]))  
                {
                    displayConvertedText(TranslateWordWithCaps(item));
                } 
                else
                {
                    displayConvertedText(TranslateWord(item));
                }
            } 
        }
        private void displayConvertedText(string word)
        {
            word += " ";
            txtPigLatin.Text += word;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears all textboxes in collection, for possible future expansion
            foreach (TextBox item in textBoxList)
            {
                item.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // User defined methods
        private string TranslateWordWithCaps(string word)
        {
            // remove punctuation from the end of the word and store for later
            string punct = "";
            if (word.EndsWith(".") || word.EndsWith(",") || word.EndsWith(";")
                || word.EndsWith(":") || word.EndsWith("!") || word.EndsWith("?"))
            {
                punct = word.Substring(word.Length - 1);
                word = word.Remove(word.Length - 1, 1);
            }
            if (IsUpper(word))
            {
                word = TranslateWord(word).ToUpper();
            } 
            else if (IsInitialCap(word))
            {
                word = ToInitialCap(TranslateWord(word));
            } 
            else if (IsLower(word))
            {
                word = TranslateWord(word).ToLower();
            } 
            
            word += punct;

            return word;
        }
        private string TranslateWord(string word)
        {
            char c = word[0];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                word += "way";
            }
            else
            {
                if (c == 'y' || c == 'Y')
                {
                    word = word.Remove(0, 1);
                    word += c.ToString();
                    c = word[0];
                }
                while (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' && c != 'A' && c != 'E' && c != 'I' && c != 'O' && c != 'U'
                    && c != 'Y' && c != 'y')
                {
                    word = word.Remove(0, 1);
                    word += c.ToString();
                    c = word[0];
                }
                word += "ay";
            }
            return word;
        }
        private bool IsLower(char c)
        {
            // All ASCII values for lowercase letters
            if (c >= 97 && c <= 122 || c.ToString() == "'")
                return true;
            else
                return false;
        }
        private bool IsInitialCap(string word)
        {
            // All ASCII values for uppercase letters
            int c = word[0];
            if (c >= 65 && c <= 90)
            {
                return true;
            } else
            {
                return false;
            }
            
        }
        private bool IsUpper(char c)
        {
            // All ASCII values for uppercase letters
            if (c >= 65 && c <= 90)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private bool IsUpper(string word)
        {
            // Checks entire string
            for (int i = 0; i < word.Length; i++)
                if (IsUpper(word[i]) == false)
                    return false;
            return true;
        }
        private bool IsLower(string word)
        {
            // Checks entire string
            for (int i = 0; i < word.Length; i++)
                if (IsLower(word[i]) == false)
                    return false;
            return true;
        }
        private string ToInitialCap(string word)
        {
            // Convert entire word to lowercase, then make 1st letter uppercase
            word = word.ToLower();
            word = char.ToUpper(word[0]) + word.Substring(1);
            return word;

        }
    }
}
