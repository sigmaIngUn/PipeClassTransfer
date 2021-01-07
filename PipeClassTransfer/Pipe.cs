// This file Pipe.cs is part of PipeClassTransfer
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
    /// Contains data for straight pipes
    /// </summary>
    [System.Xml.Serialization.XmlInclude(typeof(Bend))]
    public class Pipe : Component, IAllowanceTolerance
    {
        /// <summary>
        /// Wall-Thickness
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double S { get; set; }

        /// <summary>
        /// Pipe dimension name for identification
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

        /// <summary>
        /// Mill-Tolerance Standard ID
        /// </summary>
        public StandardDef C_Mill_Standard { get; set; } = new StandardDef();
    }
}