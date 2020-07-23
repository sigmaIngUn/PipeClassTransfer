// This file PipeClassData.cs is part of PipeClassTransfer
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

using System.Collections.Generic;

namespace PipeClassTransfer
{
    /// <summary>
    /// A <see cref="PipeClassData"/>-Object contains essential Data to transfer information about Pipe-Classes
    /// </summary>
    public class PipeClassData
    {

        /// <summary>
        /// Description of Pipe-Class
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string Description { get; set; }
        
        /// <summary>
        /// List of Components of this Pipe-Class
        /// </summary>
        public List<Component> Components { get; set; } = new List<Component>();

        /// <summary>
        /// List of Load cases of this Pipe-Class
        /// </summary>
        public List<LoadcaseData> Loadcases { get; set; } = new List<LoadcaseData>();

    }
}