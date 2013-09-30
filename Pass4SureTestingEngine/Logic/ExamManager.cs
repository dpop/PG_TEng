using System.Collections.Generic;
using System.Linq;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Logic.Filters;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Models.AnswerModels.DropAndConnect;
using Pass4SureTestingEngine.Models.PropertyModels;
using Pass4SureTestingEngine.Models.QuestionTypes;
using Pass4SureTestingEngine.Utils;

namespace Pass4SureTestingEngine.Logic
{
    public class ExamManager
    {
        private ExamBook _currentExamBooks;
        private static ExamManager _examManagerInstance;
        private Question _selectedQuestion;
        private Exam _selectedExam;

        public string Path { get; set; }

        private ExamManager()
        {
            _currentExamBooks = TestDataInit();
            _selectedExam = null;
            _selectedQuestion = null;
        }

        public static ExamManager GetInstance()
        {
            if (_examManagerInstance != null)
            {
                return _examManagerInstance;
            }

            _examManagerInstance = new ExamManager();

            return _examManagerInstance;
        }


        #region Exam
        public void AddExam(Exam exam)
        {
            if (exam.ExamName == Constants.ExamDefaultTitle)
            {
                exam.ExamName = string.Format("{0} {1}", exam.ExamName, _currentExamBooks.Exams.Count + 1);
            }
            _currentExamBooks.Exams.Add(exam);
        }

        public bool RemoveExam(Exam exam)
        {
            return _currentExamBooks.Exams.Remove(exam);
        }

        public void MoveExam(Exam exam, Direction direction)
        {
            var directionQuota = direction == Direction.Up ? -1 : 1;
            var nextIndex = _currentExamBooks.Exams.IndexOf(exam) + directionQuota;
            _currentExamBooks.Exams.Remove(exam);
            _currentExamBooks.Exams.Insert(nextIndex, exam);
        }

        public Exam GetExam(ExamFilter filter)
        {
            if (filter.ExamIndex.HasValue && (filter.ExamIndex < _currentExamBooks.Exams.Count && filter.ExamIndex >= 0))
            {
                _selectedExam = _currentExamBooks.Exams[(int) filter.ExamIndex];
                return _currentExamBooks.Exams[(int)filter.ExamIndex];
            }

            _selectedExam = _currentExamBooks.Exams.Find(x => x.ExamName == filter.ExamName); 
            return _currentExamBooks.Exams.Find(x => x.ExamName == filter.ExamName);
        }

        public void RenameExam(string newName)
        {
            _selectedExam.ExamName = newName;
        }

        #endregion

        #region Question
        public void AddQuestion(string parentName, Question question)
        {
            var exam = _currentExamBooks.Exams.FirstOrDefault(x => x.ExamName == parentName);

            if (exam != null )
            {
                exam.Questions.Add(question);
            }
        }

        public void MoveQuestion(Exam parent, Question question, Direction direction)
        {
            var directionQuota = direction == Direction.Up ? -1 : 1;
            var nextIndex = parent.Questions.IndexOf(question) + directionQuota;
            parent.Questions.Remove(question);
            parent.Questions.Insert(nextIndex, question);
        }

        public Question GetQuestion(string examName, int questionIndex)
        {
            var exam = _currentExamBooks.Exams.FirstOrDefault(x => x.ExamName == examName);

            if (exam != null && questionIndex > -1 && questionIndex < exam.Questions.Count)
            {
                _selectedQuestion = exam.Questions[questionIndex];
                _selectedExam = exam;
                return exam.Questions[questionIndex];
            }
            
            return null;
        }

        public bool RemoveQuestion(Question question)
        {
            _selectedQuestion = null;
             return _selectedExam != null && _selectedExam.Questions.Remove(question);
        }
        #endregion
      
        public ExamBook ExamBook 
        {
            get
            {
                return _currentExamBooks;
            }
            set
            {
                _currentExamBooks = value;
            }
        }

        public Question GetSelectedQuestion()
        {
            return _selectedQuestion;
        }

        public Exam GetSelectedExam()
        {
            return _selectedExam;
        }

        private ExamBook TestDataInit()
        {
            var examBook = new ExamBook
                {
                    Title = "Exam"
                };
            var firstExam = new Exam
                {
                    ExamName = "Exam 1",
                };
            Question question = new SingleChoiceQuestion
                {
                    Description = string.Empty
                };

            firstExam.Questions.Add(question);
            question = new MultipleChoiceQuestion
                {

                    Description = string.Empty
            };

            firstExam.Questions.Add(question);
            question = new FillInTheBlanksQuestion
                {

                    Description = string.Empty
            };

            firstExam.Questions.Add(question);
            question = new DragAndDropQuestion
                {
                    Description = string.Empty
            };

            firstExam.Questions.Add(question);

            question = new DropAndConnectQuestion
                {
                    Description = string.Empty,
                    CorrectAnswer = new DropAndConnectAnswer
                        {
                            Objects = new List<DragObject>
                                {
                                    new DragObject
                                        {
                                            Caption = "Obj 1"
                                        },
                                    new DragObject
                                        {
                                            Caption = "Obj 2"
                                        },
                                    new DragObject
                                        {
                                            Caption = "Obj 3"
                                        },

                                }
                        }
                };

            firstExam.Questions.Add(question);


            examBook.Exams.Add(firstExam);

            return examBook;
        }

    }
}
