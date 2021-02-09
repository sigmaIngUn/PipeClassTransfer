﻿// This file Material.cs is part of PipeClassTransfer
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeClassTransfer
{
    /// <summary>
    /// Material Definition
    /// </summary>
    public class Material
    {
        

        /// <summary>
        /// Material-ID acc. to the Definition of the exporting Program
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string MaterialID { get; set; } = string.Empty;

        /// <summary>
        /// Descriptive Name of the Definition as a Fallback-Value for the user to choose the correct Material on import
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Desc { get; set; } = string.Empty;
    }
}
