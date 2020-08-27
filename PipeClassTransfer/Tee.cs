// This file Tee.cs is part of PipeClassTransfer
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
        public Material MaterialPad { get; set; } = new Material();
        
        /// <summary>
        /// Holds the data of the Tees run pipe
        /// </summary>
        public Pipe Run { get; set; } = new Pipe();
        
        /// <summary>
        /// Holds the data of the Tees branch pipe
        /// </summary>
        public Pipe Branch { get; set; } = new Pipe();

        /// <summary>
        /// Type of the Branch, see dokumentation
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int TypeOfBranch { get; set; } = 0;
    }
}