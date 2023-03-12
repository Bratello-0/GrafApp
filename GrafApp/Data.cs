using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GrafApp
{
    [Serializable]
    public class Data
    {
        [XmlElement("Matrix")]
        public List<string> Matrix { get; set; }

        [XmlElement("Result")]
        public string Result { get; set; }

        public Data() {
        }
        public Data(List<string> matrix) {
            Matrix = matrix;
        }
    }
}
