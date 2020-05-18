namespace PipeClassTransfer
{
    /// <summary>
    /// Contains data for Tee-Pices
    /// </summary>
    public class Reducer : Component
    {

        /// <summary>
        /// Half Cone-Angle
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double Alpha { get; set; }

        /// <summary>
        /// Type of reducer, <see cref="PipeClassTransferData.TypeOfReducer"/>
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int Type { get; set; } = 1;

        /// <summary>
        /// Allowed utilization of straight pipe
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double StrPipeUtil { get; set; }

        /// <summary>
        /// Holds the data of the Reducers large connection
        /// </summary>
        public Pipe LargeConnection { get; set; }

        /// <summary>
        /// Holds the data of the Reducers small connection
        /// </summary>
        public Pipe SmallConnection { get; set; }
        
    }
}