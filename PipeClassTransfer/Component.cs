// This file Component.cs is part of PipeClassTransfer
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
    /// Common Type for Pipe-Class Components
    /// </summary>
    [System.Xml.Serialization.XmlInclude(typeof(Pipe))]
    [System.Xml.Serialization.XmlInclude(typeof(Tee))]
    [System.Xml.Serialization.XmlInclude(typeof(Reducer))]
    public class Component
    {
        /// <summary>
        /// Unique Id of this Component
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public Guid ComponentId { get; set; } = Guid.NewGuid();

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
        public Guid GroupId { get; set; } = Guid.Empty;

    }
}