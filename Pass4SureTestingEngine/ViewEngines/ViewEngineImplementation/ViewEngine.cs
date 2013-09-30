using System.Windows.Forms;
using Pass4SureTestingEngine.Logic.PropertyHandlers;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Utils;
using PropertyGridEx;

namespace Pass4SureTestingEngine.ViewEngines.ViewEngineImplementation
{
    public abstract class ViewEngine : IViewEngine
    {
        public abstract void UpdateContent(Control container, Question question);

        public void UpdateProperties(Control container, Question question)
        {
            var propertiesBox = container.Controls[0] as PropertyGridEx.PropertyGridEx ?? new PropertyGridEx.PropertyGridEx();

            var properties = PropertyHandler.GetItems(QuestionHelper.GetTypeFromQuestion(question), question, container);

            propertiesBox.Item.Clear();

            foreach (var item in properties)
            {
                propertiesBox.Item.Add((CustomProperty)item);
            }

            propertiesBox.Refresh();
        }
    }
}
