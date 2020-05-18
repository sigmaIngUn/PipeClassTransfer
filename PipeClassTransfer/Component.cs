namespace PipeClassTransfer
{
    /// <summary>
    /// Common Type for Pipe-Class Components
    /// </summary>
    [System.Xml.Serialization.XmlInclude(typeof(Pipe))]
    [System.Xml.Serialization.XmlInclude(typeof(Tee))]
    [System.Xml.Serialization.XmlInclude(typeof(Reducer))]
    public class Component
    {

        /// <summary>
        /// Description
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Desc { get; set; } = string.Empty;

        /// <summary>
        /// Name of Component-Standard
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Standard { get; set; } = string.Empty;

        /// <summary>
        /// Material ID
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Material { get; set; } = string.Empty;
        
        /// <summary>
        /// Length of component
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double Length { get; set; }

        /// <summary>
        /// Welding-factor
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double V { get; set; }

        /// <summary>
        /// Group ID of this Component
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string GroupId { get; set; } = string.Empty;

    }
}