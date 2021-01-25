using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _2_1_PigLatinTranslator
{
    public partial class Form1 : Form
    {
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

            strArr = txtEnglish.Text.Split(" ");
            foreach (string item in strArr)
            {
                if (IsUpper(item) || IsLower(item)) 
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
                MessageBox.Show("Initial capital");
                
               
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
            // Check if c is a lowercase letter (int value 65 to 90, or an apostrophe
            if (c >= 97 && c <= 122 || c.ToString() == "'")
                return true;
            else
                return false;
        }
        private bool IsInitialCap(string word)
        {
            // This method returns whether or not the initial letter in a word is a capitol 
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
            for (int i = 0; i < word.Length; i++)
                if (IsUpper(word[i]) == false)
                    return false;
            return true;
        }
        private bool IsLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
                if (IsLower(word[i]) == false)
                    return false;
            return true;
        }
        private string ToInitialCap(string word)
        {
            // Make the entire string go to lowercase, then make only the first character uppercase
            word = word.ToLower();
            return word;

        }

        private void txtEnglish_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
