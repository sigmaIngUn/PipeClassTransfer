namespace PipeClassTransfer
{
    /// <summary>
    /// Contains data for straight pipes
    /// </summary>
    [System.Xml.Serialization.XmlInclude(typeof(Bend))]
    public class Pipe : Component
    {
        /// <summary>
        /// Wall-Thickness
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double S { get; set; }

        /// <summary>
        /// Pipe-Dimension for identification
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Dimension { get; set; } = string.Empty;

        /// <summary>
        /// Outside-Diameter
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double Do { get; set; }


        /// <summary>
        /// Outer-Diameter Standard-Row
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string DoNo { get; set; } = string.Empty;

        /// <summary>
        /// Mill-Tolerance value
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double C_Mill { get; set; }

        /// <summary>
        /// Switch if <see cref="C_Mill"/> was calculated from %
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int C_Mill_Percent { get; set; }

        /// <summary>
        /// Add. allowance
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double C_Allowance { get; set; }

        
        
    }
}