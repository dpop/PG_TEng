using System;
using System.Collections.Generic;
using Pass4SureTestingEngine.Models.PropertyModels;
using Pass4SureTestingEngine.Models.QuestionTypes;

namespace Pass4SureTestingEngine.ViewModels.Questions
{
    [Serializable]
    class DropAndConnectPropertiesViewModel
    {
        private int _complexity = 5;
        public int Complexity
        {
            get { return _complexity; }
            set { _complexity = value; }
        }

        private string _section = string.Empty;
        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }

        private double _height = 70;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private double _width = 90;
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private string _connectorsTitle = "Connectors";
        public string ConnectorsTitle
        {
            get { return _connectorsTitle; }
            set { _connectorsTitle = value; }
        }

        private List<Connector> _connectors = new List<Connector>();
        public List<Connector> Connectors
        {
            get { return _connectors; }
            set { _connectors = value; }
        }

        private List<DragObject> _objects = new List<DragObject>();
        public List<DragObject> Objects
        {
            get { return _objects; }
            set { _objects = value; }
        }
    }
}
