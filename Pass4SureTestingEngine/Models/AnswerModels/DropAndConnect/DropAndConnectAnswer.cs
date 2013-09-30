using System;
using System.Collections.Generic;
using System.Linq;
using Pass4SureTestingEngine.Models.PropertyModels;
using Pass4SureTestingEngine.Models.QuestionTypes;

namespace Pass4SureTestingEngine.Models.AnswerModels.DropAndConnect
{
    [Serializable]
    class DropAndConnectAnswer 
    {
        public List<DragObject> Objects { get; set; }
        public List<Connector> Connectors { get; set; }

        public bool IsCorrect(DropAndConnectAnswer correctAnswer)
        {
            var isCorrect = correctAnswer.Connectors.Count == Connectors.Count && Objects.Count == correctAnswer.Objects.Count;
            foreach (var connector in Connectors)
            {
                isCorrect = isCorrect && correctAnswer.Connectors.Any(x => x.Type == connector.Type &&
                                                                                (x.SourceObject.Caption ==
                                                                                 connector.SourceObject.Caption ||
                                                                                 x.SourceObject.Caption ==
                                                                                 connector.TargetObject.Caption) &&
                                                                                (x.TargetObject.Caption ==
                                                                                 connector.SourceObject.Caption ||
                                                                                 x.TargetObject.Caption ==
                                                                                 connector.TargetObject.Caption));
            }
            return isCorrect;
        }
    }
}
