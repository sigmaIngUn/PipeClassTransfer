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
