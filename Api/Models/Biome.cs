using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers.Api.Models
{
    /// <summary>
    /// Represents information about a biome of a planet.
    /// </summary>
    public class Biome
    {
        /// <summary>
        /// The name of this biome.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// A human-readable description of the biome.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
