using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace WindowsFormsApp1
{
    public partial class formEnglishSpellCheck : System.Windows.Forms.Form
    {
        [STAThreadAttribute]
        static void Main()
        {
            Application.Run(new formEnglishSpellCheck());
        }

        public formEnglishSpellCheck()
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
                string[] words = sentence.Split(' ', ',', '.', ';', '\n', '?', '!', '/', ':');

                // класс для проверки слов
                SpellChecker checker = new SpellChecker();

                this.richTextBox1.Rtf = @"{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red0\green0\blue0;}" +
                    @"" + richTextBox1.Text + @"}";

                // проверяем каждое слово
                foreach (string word in words)
                {
                    // проверка
                    string[] suggestions = checker.Suggest(word);

                    // правильно написано
                    if (suggestions != null)
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
                    }
                }
                checker = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void PasteAction(object sender, EventArgs e, string suggestion)
        {
            Clipboard.SetData(DataFormats.Rtf, "");
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf = @"{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red0\green0\blue0;}" +
                    @"\ul0\cf2" + suggestion + @"}";
            }
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                if (e.Button == MouseButtons.Right)
                {
                    Point point = new Point(e.X, e.Y);
                    int index = richTextBox1.GetCharIndexFromPosition(point);

                    int length = 1;

                    if (!Char.IsWhiteSpace(richTextBox1.Text[index]))
                    {
                        while (index > 0 && !Char.IsWhiteSpace(richTextBox1.Text[index - 1]))
                        { index--; length++; }

                        while (index + length < richTextBox1.Text.Length &&
                            !Char.IsWhiteSpace(richTextBox1.Text[index + length]) &&
                            (!Char.IsPunctuation(richTextBox1.Text[index + length]) ||
                            richTextBox1.Text[index + length] == Char.Parse("'"))
                        ) length++;

                        richTextBox1.SelectionStart = index;
                        richTextBox1.SelectionLength = length;

                        // текст для проверки
                        string sentence = richTextBox1.Text;

                        // делим текст на слова
                        string[] words = sentence.Split(' ', ',', '.', ';', '\n', '?', '!', '/', ':');

                        // класс для проверки слов
                        SpellChecker checker = new SpellChecker();

                        // проверяем каждое слово
                        foreach (string word in words)
                        {
                            // проверка
                            string[] suggestions = checker.Suggest(word);

                            // не правильно написано
                            if (suggestions != null)
                            {
                                if (word == richTextBox1.SelectedText)
                                {
                                    foreach (string suggestion in suggestions)
                                        contextMenu.MenuItems.Add(suggestion, (sender2, e2) => PasteAction(sender2, e2, suggestion));
                                }
                            }
                        }
                        checker = null;
                        richTextBox1.ContextMenu = contextMenu;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}