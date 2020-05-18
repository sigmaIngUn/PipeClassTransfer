using System.Collections.Generic;

namespace PipeClassTransfer
{
    /// <summary>
    /// Container for Pipe-Class data
    /// </summary>
    public class PipeClassTransferData
    {
        const int CurrentFileVersion = 1;

        /// <summary>
        /// Creates a new instance of Type <see cref="PipeClassTransferData"/>
        /// </summary>
        public PipeClassTransferData()
        {
            this.FileVersion = PipeClassTransferData.CurrentFileVersion;
        }

        public enum UnitOfMeasure
        {
            SI,
            US
        }

        public enum TypeOfReducer
        {
            Concentric = 1,
            Excentric = 2
        }

        


        /// <summary>
        /// The File-Version of this instance
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int FileVersion { get; set; }

        /// <summary>
        /// Units of measure
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public UnitOfMeasure Unit { get; set; }
        
        /// <summary>
        /// List of Pipe-Class datasets
        /// </summary>
        public List<PipeClassData> PipeClasses { get; set; } = new List<PipeClassData>();

    }
}