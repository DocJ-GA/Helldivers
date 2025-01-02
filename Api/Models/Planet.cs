using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers.Api.Models
{
    /// <summary>
    /// Contains all aggregated information AH has about a planet.
    /// </summary>
    public class Planet
    {
        /// <summary>
        /// The unique identifier ArrowHead assigned to this planet.
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// The name of the planet, as shown in game.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// The name of the sector the planet is in, as shown in game.
        /// </summary>
        public string Sector { get; set; } = string.Empty;
        /// <summary>
        /// The biome this planet has.
        /// </summary>
        public Biome Biome { get; set; } = null!;
        /// <summary>
        /// All Hazards that are applicable to this planet.
        /// </summary>
        public IEnumerable<Hazard> Hazards { get; set; } = [];
        /// <summary>
        /// A hash assigned to the planet by ArrowHead, purpose unknown.
        /// </summary>
        public int Hash { get; set; }
        /// <summary>
        /// The coordinates of this planet on the galactic war map.
        /// </summary>
        public Position Position { get; set; } = null!;
        /// <summary>
        /// A list of Index of all the planets to which this planet is connected.
        /// </summary>
        public IEnumerable<int> Waypoints { get; set; } = [];
        /// <summary>
        /// The maximum health pool of this planet.
        /// </summary>
        public long MaxHealth { get; set; }
        /// <summary>
        /// The current planet this planet has.
        /// </summary>
        public long Health { get; set; }
        /// <summary>
        /// Whether or not this planet is disabled, as assigned by ArrowHead.
        /// </summary>
        public bool Disabled { get; set; }
        /// <summary>
        /// The faction that originally owned the planet.
        /// </summary>
        public string InitialOwner { get; set; } = string.Empty;
        /// <summary>
        /// The faction that currently controls the planet.
        /// </summary>
        public string CurrentOwner { get; set; } = string.Empty;
        /// <summary>
        /// How much the planet regenerates per second if left alone.
        /// </summary>
        public double RegenPerSecond { get; set; }
        /// <summary>
        /// Information on the active event ongoing on this planet, if one is active.
        /// </summary>
        public Event Event { get; set; } = null!;
        /// <summary>
        /// A set of statistics scoped to this planet.
        /// </summary>
        public Statistics Statistics { get; set; }
        /// <summary>
        /// A list of Index integers that this planet is currently attacking.
        /// </summary>
        public IEnumerable<int> Attacking { get; set; } = [];

    }
}
