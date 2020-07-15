// This file PipeClassTransferData.cs is part of PipeClassTransfer
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
    /// Container for Pipe-Class data
    /// </summary>
    public class PipeClassTransferData
    {
        const int CurrentFileVersion = 1;

        /// <summary>
        /// Creates a new instance of Type <see cref="PipeClassTransferData"/>
        /// </summary>
        public PipeClassTransferData()
        {
            this.FileVersion = PipeClassTransferData.CurrentFileVersion;
        }

        public enum UnitOfMeasure
        {
            SI,
            US
        }

        public enum TypeOfReducer
        {
            Concentric = 1,
            Excentric = 2
        }

        /// <summary>
        /// ID of the exporting Programm see https://github.com/sigmaIngUn/PipeClassTransfer/wiki/KnownExporters
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public string ExporterID { get; set; } = string.Empty;

        /// <summary>
        /// The File-Version of this instance
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public int FileVersion { get; set; }

        /// <summary>
        /// Units of measure
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public UnitOfMeasure Unit { get; set; }
        
        /// <summary>
        /// List of Pipe-Class datasets
        /// </summary>
        public List<PipeClassData> PipeClasses { get; set; } = new List<PipeClassData>();

    }
}