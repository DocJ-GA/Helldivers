using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers.Api.Models
{
    /// <summary>
    /// Contains statistics of missions, kills, success rate etc.
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// The amount of missions won.
        /// </summary>
        public long MissionsWon { get; set; }
        /// <summary>
        /// The amount of missions lost.
        /// </summary>
        public long MissionsLost { get; set; }
        /// <summary>
        /// The total amount of time spent planetside (in seconds).
        /// </summary>
        public long MissionTime { get; set; }
        /// <summary>
        /// The total amount of bugs killed since start of the season.
        /// </summary>
        public long TerminidKills { get; set; }
        /// <summary>
        /// The total amount of automatons killed since start of the season.
        /// </summary>
        public long AutomatonKills { get; set; }
        /// <summary>
        /// The total amount of Illuminate killed since start of the season.
        /// </summary>
        public long IlluminateKills { get; set; }
        /// <summary>
        /// The total amount of bullets fired
        /// </summary>
        public long BulletsFired { get; set; }
        /// <summary>
        /// The total amount of bullets hit
        /// </summary>
        public long BulletsHit { get; set; }
        /// <summary>
        /// The total amount of time played (including off-planet) in seconds.
        /// </summary>
        public long TimePlayed { get; set; }
        /// <summary>
        /// The amount of casualties on the side of humanity.
        /// </summary>
        public long Deaths { get; set; }
        /// <summary>
        /// The amount of revives(?).
        /// </summary>
        public long Revivies { get; set; }
        /// <summary>
        /// The amount of friendly fire casualties.
        /// </summary>
        public long Friendlies { get; set; }
        /// <summary>
        /// A percentage indicating how many started missions end in success.
        /// </summary>
        public long MissionSuccessRate { get; set; }
        /// <summary>
        /// A percentage indicating average accuracy of Helldivers.
        /// </summary>
        public long Accuracy { get; set; }
        /// <summary>
        /// The total amount of players present (at the time of the snapshot).
        /// </summary>
        public long PlayerCount { get; set; }
    }
}
