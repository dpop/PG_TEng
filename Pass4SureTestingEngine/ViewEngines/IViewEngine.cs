using System.Windows.Forms;
using Pass4SureTestingEngine.Models;

namespace Pass4SureTestingEngine.ViewEngines
{
    public interface IViewEngine
    {
        void UpdateContent(Control container, Question question);

        void UpdateProperties(Control container, Question question);


    }
}
