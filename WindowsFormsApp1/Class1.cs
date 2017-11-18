using System;
using System.Collections;
using System.Reflection;
using Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{

    class SpellChecker
    {
        private ApplicationClass application;

        public SpellChecker()
        {
            object template = Type.Missing;
            object newtemplate = false;
            object doctype = WdNewDocumentType.wdNewBlankDocument;
            object visible = false;

            // объект MS word
            this.application = new ApplicationClass();
            this.application.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            this.application.Visible = false;
            this.application.Options.SuggestSpellingCorrections = true;

            // создаем новый документ
            Document document = this.application.Documents.Add(ref template, ref newtemplate, ref doctype, ref visible);
            document.Activate();
        }

        ~SpellChecker()
        {
            // завершить word, ничего не сохраняя
            object savenochanges = WdSaveOptions.wdDoNotSaveChanges;
            object nothing = Missing.Value;

            if (this.application != null)
                this.application.Quit(ref savenochanges, ref nothing, ref nothing);
            this.application = null;
        }

        /// <summary>
        /// Проверка слова
        /// </summary>
        public string[] Suggest(string word)
        {
            object nothing = Missing.Value;

            // Проверяем
            bool spelledright = this.application.CheckSpelling(word, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing);

            if (spelledright)
                return null;

            // получаем список слов для замены
            SpellingSuggestions suggestions = this.application.GetSpellingSuggestions(word, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing);

            // сохраняем список слов
            ArrayList words = new ArrayList();
            foreach (SpellingSuggestion suggestion in suggestions)
                words.Add(suggestion.Name);

            suggestions = null;

            // возвращаем массив слов
            return (string[])words.ToArray(typeof(string));
        }
    }
}
