﻿// This file Component.cs is part of PipeClassTransfer
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
    [System.Xml.Serialization.XmlInclude(typeof(Cap))]
    [System.Xml.Serialization.XmlInclude(typeof(Blank))]
    [System.Xml.Serialization.XmlInclude(typeof(Flange))]
    public class Component
    {
        /// <summary>
        /// Contains the schedule or the row acc. to the standard (EN/ASME)
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Schedule_Row { get; set; } = string.Empty;
        /// <summary>
        /// Unique Id of this Component
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public Guid ComponentId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// The calculation Standard used for the analysis of this component
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string CalcBase { get; set; } = string.Empty;

        /// <summary>
        /// Description
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Desc { get; set; } = string.Empty;

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

        /// <summary>
        /// Dimension name for identification
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Dimension { get; set; } = string.Empty;

        /// <summary>
        /// Material ID
        /// </summary>
        public Material Material { get; set; } = new Material();

        /// <summary>
        /// Standard ID
        /// </summary>
        public StandardDef Standard { get; set; } = new StandardDef();

    }
}