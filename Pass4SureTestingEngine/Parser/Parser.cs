using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Utils;

namespace Pass4SureTestingEngine.Parser
{
    public class Parser
    {
        private readonly RichTextBox _richTextBox;
        private readonly QuestionParser _questionParser;

        public Parser(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
            _questionParser = new QuestionParser();
        }


        public List<Question> ParseFile(string path, string pattern)
        {
            var resultQuestions = new List<Question>();

            var stringQuestions = GetContentFromFile(path,pattern);

            for (int index = 1; index < stringQuestions.Count; index++ )
            {
                var questionText = GetQuestionText(stringQuestions[index]);
                var question = _questionParser.ParseQuestion(questionText, pattern);
                if (question != null)
                {
                    resultQuestions.Add(question);
                }
            }

            return resultQuestions;
        }

        public List<string> GetContentFromFile(string path, string pattern)
        {
            var result = new List<string>();

            var suffix = path.Substring(path.Length - 4);

            if (string.Equals(suffix, Constants.RichTextFormatExtension))
            {
                _richTextBox.Clear();
                _richTextBox.LoadFile(path);
                result = GetContentFromRichTextBox(pattern);
            }
            else if (string.Equals(suffix, Constants.TextExtension))
            {
                _richTextBox.Clear();
                _richTextBox.Text = File.ReadAllText(path);
                result = GetContentFromRichTextBox(pattern);
            }
            else if (string.Equals(suffix, Constants.WordExtension) || string.Equals(suffix, Constants.NewWordExtension))
            {
                if (WordToRtfConvertor.ConvertToRtf(path, Constants.TempRtfPath))
                {
                    _richTextBox.Clear();
                    _richTextBox.LoadFile(Constants.TempRtfPath);
                    result = GetContentFromRichTextBox(pattern);
                }
            }

           // _richTextBox.Clear();
            return result;
        }

        private List<string> GetContentFromRichTextBox(string pattern)
        {
            var question = String.Empty;
            var questionsList = new List<string>();
            int startPosition = 0;
            var count = 1;
            var patternIndex = _richTextBox.Text.IndexOf(string.Format(pattern, count));
            var markPosition = 0;
            while (_richTextBox.Text != null && patternIndex > -1)
            {
                 markPosition = patternIndex;
                if (markPosition > startPosition)
                {
                    _richTextBox.Select(startPosition, markPosition - startPosition);
                    question = _richTextBox.SelectedRtf;
                    if (question != null)
                    {
                        var currentIndex = question.IndexOf(string.Format(pattern, count));
                        if (currentIndex > 0)
                        {
                            question = question.Substring(0, currentIndex);
                        }
                    }
                }

                startPosition = markPosition;
                count ++;
                patternIndex = _richTextBox.Text.IndexOf(string.Format(pattern, count));
                questionsList.Add(question);
            }

            markPosition = patternIndex;
            if (markPosition > startPosition)
            {
                _richTextBox.Select(startPosition, markPosition - startPosition);
                question = _richTextBox.SelectedRtf;
                if (question != null)
                {
                    var currentIndex = question.IndexOf(string.Format(pattern, count));
                    if (currentIndex > 0)
                    {
                        question = question.Substring(0, currentIndex);
                    }
                }
            }

            startPosition = markPosition;
            count++;
            patternIndex = _richTextBox.Text.IndexOf(string.Format(pattern, count));
            questionsList.Add(question);

            return questionsList;
        }

        private string GetQuestionText(string rtfText)
        {
            _richTextBox.Rtf = rtfText;
            return _richTextBox.Text;
        }
    }
}
