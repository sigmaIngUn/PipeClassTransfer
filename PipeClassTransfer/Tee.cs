namespace PipeClassTransfer
{
    /// <summary>
    /// Contains data for Tee-Pieces
    /// </summary>
    public class Tee : Component
    {

        /// <summary>
        /// Switch if component has reinforcement pad
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int Reinf { get; set; } = 0;

        /// <summary>
        /// Internal projection
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double InternalProj { get; set; }

        /// <summary>
        /// Switch if Tee is extruded
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int Extruded { get; set; } = 0;

        /// <summary>
        /// Width of reinforcement-pad
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double WidthPad { get; set; }

        /// <summary>
        /// Thickness of reinforcement-pad
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double ThicknessPad { get; set; }

        /// <summary>
        /// Allowed utilization of straight pipe
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double StrPipeUtil { get; set; }

        /// <summary>
        /// Material of reinforcement-pad
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string MaterialPad { get; set; } = string.Empty;
        
        /// <summary>
        /// Holds the data of the Tees run pipe
        /// </summary>
        public Pipe Run { get; set; } = new Pipe();
        
        /// <summary>
        /// Holds the data of the Tees branch pipe
        /// </summary>
        public Pipe Branch { get; set; } = new Pipe();
    }
}