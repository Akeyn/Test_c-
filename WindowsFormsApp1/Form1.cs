using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        static void Main()
        {
            Application.Run(new Form1());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_Check_Click(object sender, EventArgs e)
        {
            try
            {
                // текст для проверки
                string sentence = richTextBox1.Text;

                // делим текст на слова
                string[] words = sentence.Split();

                // класс для проверки слов
                SpellChecker checker = new SpellChecker();

                textBox2.Text = "";
                this.richTextBox1.Rtf = @"{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red0\green0\blue0;}" +
                    @"" + richTextBox1.Text + @"}";

                // проверяем каждое слово
                foreach (string word in words)
                {
                    // проверка
                    string[] suggestions = checker.Suggest(word);

                    // правильно написано
                    if (suggestions == null)
                    {
                        textBox2.Text += "\"" + word + "\" написано верно\r\n";
                    }
                    else
                    {
                        int startIndex = 0;
                        while (startIndex < richTextBox1.TextLength)
                        {
                            int wordStartIndex = richTextBox1.Find(word, startIndex, RichTextBoxFinds.None);
                            if (wordStartIndex != -1)
                            {
                                richTextBox1.SelectionStart = wordStartIndex;
                                richTextBox1.SelectionLength = word.Length;
                                richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont, FontStyle.Underline);
                                //this.verifiableText.Rtf = rt; // String.Format(rt, "123");

                                String rt =
        @"{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red255\green0\blue0;}" +
            @"\ul0\ulwave\cf2" + richTextBox1.SelectedText + @"\ulnone}";  // \ulcN(0,1,2) не работает
                                richTextBox1.SelectedRtf = rt;
                            }
                            else
                                break;
                            startIndex += wordStartIndex + word.Length;
                        }

                        // ошибка - предлагаем варианты
                        textBox2.Text += "\"" + word + "\" написано не верно! Варианты:\r\n";
                        foreach (string suggestion in suggestions)
                            textBox2.Text += "\t" + suggestion + "\r\n";
                    }
                }
                checker = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // MessageBox.Show("");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
