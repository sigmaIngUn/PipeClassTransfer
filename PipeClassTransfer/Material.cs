using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeClassTransfer
{
    /// <summary>
    /// Material Definition
    /// </summary>
    public class Material
    {
        

        /// <summary>
        /// Material-ID acc. to the Definition of the exporting Program
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string MaterialID { get; set; } = string.Empty;

        /// <summary>
        /// Descriptive Name of the Definition as a Fallback-Value for the user to choose the correct Material on import
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Desc { get; set; } = string.Empty;
    }
}
