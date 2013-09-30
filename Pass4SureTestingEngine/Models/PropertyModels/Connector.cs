using System;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Models.PropertyModels;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class Connector
    {
        public string Title { get; set; }

        public ConnectorType Type { get; set; }

        public DragObject SourceObject { get; set; }

        public DragObject TargetObject { get; set; }
    }
}
