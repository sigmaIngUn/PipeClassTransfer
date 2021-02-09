﻿// This file Head.cs is part of PipeClassTransfer
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
    /// Contains data for Cap
    /// </summary>
    public class Cap : Component, IAllowanceTolerance, IWallThickness
    {
        /// <summary>
        /// Type of Cap, <see cref="PipeClassTransferData.TypeOfCaps"/>
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int Type { get; set; } = 1;

        /// <inheritdoc/>
        [System.Xml.Serialization.XmlAttribute]
        public double C_Mill { get; set; }
        /// <inheritdoc/>
        [System.Xml.Serialization.XmlAttribute]
        public double C_Mill_Percent { get; set; }
        /// <inheritdoc/>
        [System.Xml.Serialization.XmlAttribute]
        public double C_Allowance { get; set; }
        /// <inheritdoc/>
        public StandardDef C_Mill_Standard { get; set; }
        /// <inheritdoc/>
        [System.Xml.Serialization.XmlAttribute]
        public double S { get; set; }
        /// <summary>
        /// The outer diameter of the Cap
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double Do { get; set; }
    }
}