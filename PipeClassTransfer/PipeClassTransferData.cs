﻿// This file PipeClassTransferData.cs is part of PipeClassTransfer
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

        public enum TypeOfBend
        {
            Bend = 1,
            Elbow = 2
        }


        public enum TypeOfTee
        {
            //Kombination 0:nicht berücksichtigen   (00)
            CombinationNotUsed = 0,

            //    5: unverstärkt(xx)
            Unreinforced = 5,

            //    1: Hauptrohr-Verstärkung(>x)
            Reinforced_Run = 1,

            //2: Abzweig-Verstärkung(x>)
            Reinforced_Branch = 2,

            //    4: Abzweig- / Hauptrohr-Verstärkung(>>)
            Reinforced_Run_Branch = 4,

            //    3: Scheibenförmige Verstärkung(Pa)
            ReinforcementPad = 3,

            //    6: T-Fitting(TF)
            T_Fitting = 6,

            //    7: T-Fitting unverstärkt(Typ A)       (TA)
            T_Fitting_Unreinforced_TypeA = 7,

            //8: T-Fitting verstärkt(Typ B)       (TB)
            T_Fitting_Reinforced_TypeB = 8,

            //9: Weldolet(We)
            Weldolet = 9,

            //    11: Hauptrohr-Verstärkung Di fix(ix)
            Reinforced_Run_Di_Fix = 11,

            //    12: Abzweig-Verstärkung Di fix(xi)
            Reinforced_Branch_Di_Fix = 12,

            //    14: Abzweig- / Hauptrohr-Verstärkung Di fix(ii)
            Reinforced_Run_Branch_Di_Fix = 14,

            //    31: Hauptrohr-Verstärkung Dm fix(mx)
            Reinforced_Run_Dm_Fix = 31,

            //    32: Abzweig-Verstärkung Dm fix(xm)
            Reinforced_Branch_Dm_Fix = 32,

            //    34: Abzweig- / Hauptrohr-Verstärkung Dm fix(mm
            Reinforced_Run_Branch_Dm_Fix = 34,

        }

        public enum TypeOfHead
        {
            Korbbogenboden = 1,
            Klöpperboden = 2
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