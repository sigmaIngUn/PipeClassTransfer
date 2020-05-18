using System.Collections.Generic;

namespace PipeClassTransfer
{
    /// <summary>
    /// A <see cref="PipeClassData"/>-Object contains essential Data to transfer information about Pipe-Classes
    /// </summary>
    public class PipeClassData
    {

        /// <summary>
        /// Description on Pipe-Class
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Description { get; set; }
        
        /// <summary>
        /// Components of this Pipe-Class
        /// </summary>
        public List<Component> Components { get; set; } = new List<Component>();

    }
}