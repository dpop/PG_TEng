using System.Windows.Forms;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.ViewModels.Questions;
using Pass4SureTestingEngine.Views.QuestionTypes;

namespace Pass4SureTestingEngine.ViewEngines.ViewEngineImplementation
{
    class HotAreaViewEngine : ViewEngine
    {
        public override void UpdateContent(Control container, Question question)
        {
            var template = new HotAreaTemplate();
            container.Controls.Clear();
            container.Controls.Add(template.Controls[0]);
        }
    }
}
