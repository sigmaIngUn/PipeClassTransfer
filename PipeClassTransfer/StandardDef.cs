namespace PipeClassTransfer
{
    /// <summary>
    /// Standard Definition
    /// </summary>
    public class StandardDef
    {
        

        /// <summary>
        /// Standard-ID acc. to the Definition of the exporting Program
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string StandardID { get; set; } = string.Empty;

        /// <summary>
        /// Descriptive Name of the Definition as a Fallback-Value for the user to choose the correct Standard on import
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Desc { get; set; } = string.Empty;
    }
}