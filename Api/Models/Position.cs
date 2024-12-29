using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers.Api.Models
{
    /// <summary>
    /// The coordinates of this planet on the galactic war map.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// The X coordinate.
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// The Y coordinate.
        /// </summary>
        public double Y { get; set; }
    }
}
