// This file Reducer.cs is part of PipeClassTransfer
// Copyright (C) 2020 SIGMA Ingenieurgesellschaft mbH, Unna, Germany
// 
// PipeClassTransfer is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// PipeClassTransfer is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with PipeClassTransfer.  If not, see <http://www.gnu.org/licenses/>.

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
        /// Switch if the Reducer has knuckles
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int HasKnuckle { get; set; } = 0;

        /// <summary>
        /// Holds the data of the Reducers large connection
        /// </summary>
        public Pipe LargeConnection { get; set; } = new Pipe();

        /// <summary>
        /// Holds the data of the Reducers small connection
        /// </summary>
        public Pipe SmallConnection { get; set; } = new Pipe();

    }
}