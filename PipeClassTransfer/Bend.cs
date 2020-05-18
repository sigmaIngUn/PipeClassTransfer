namespace PipeClassTransfer
{
    /// <summary>
    /// Contains data for bends and elbows
    /// </summary>
    public class Bend : Pipe
    {

        /// <summary>
        /// Wall-thickness intrados
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double Si { get; set; }

        /// <summary>
        /// Wall-thickness extrados
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double So { get; set; }

        /// <summary>
        /// Bending radius
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double Radius { get; set; }

    }
}