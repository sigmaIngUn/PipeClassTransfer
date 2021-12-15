// This file LoadcaseData.cs is part of PipeClassTransfer
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

using System;

namespace PipeClassTransfer
{
    /// <summary>
    /// Definition of Load case-Data
    /// </summary>
    public class LoadcaseData
    {
        /// <summary>
        /// Unique Id of this Load case-Data
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public Guid LoadcaseDataId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Temperature of this Load case
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double Temperature { get; set; }

        /// <summary>
        /// Pressure of this Load case
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double Pressure { get; set; }

        /// <summary>
        /// Type of Loadcase, <see cref="PipeClassTransferData.TypeOfLoadcase"/>
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int TypeOfLoadcase { get; set; }

        /// <summary>
        /// Description of the Load case
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Desc { get; set; } = string.Empty;
    }
}
