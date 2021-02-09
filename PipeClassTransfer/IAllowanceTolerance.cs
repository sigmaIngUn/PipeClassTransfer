// This file IAllowanceTolerance.cs is part of PipeClassTransfer
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
    /// Defines required Properties for Allowances and Tolerances
    /// </summary>
    public interface IAllowanceTolerance
    {
        /// <summary>
        /// Mill-Tolerance value
        /// </summary>
        double C_Mill { get; set; }

        /// <summary>
        /// Switch if <see cref="C_Mill"/> was calculated from %
        /// </summary>
        int C_Mill_Percent { get; set; }

        /// <summary>
        /// Add. allowance
        /// </summary>
        double C_Allowance { get; set; }

        /// <summary>
        /// Mill-Tolerance Standard ID
        /// </summary>
        StandardDef C_Mill_Standard { get; set; }
    }
}
