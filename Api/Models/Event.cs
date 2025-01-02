using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers.Api.Models
{
    /// <summary>
    /// An ongoing event on a Planet.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// The unique identifier of this event.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The type of event.
        /// </summary>
        public int EventType { get; set; }
        /// <summary>
        /// The faction that initiated the event.
        /// </summary>
        public string Faction { get; set; } = string.Empty;
        /// <summary>
        /// The health of the Event at the time of snapshot.
        /// </summary>
        public long Health { get; set; }
        /// <summary>
        /// The maximum health of the Event at the time of snapshot.
        /// </summary>
        public long MaxHealth { get; set; }
        /// <summary>
        /// The maximum health of the Event at the time of snapshot.
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// When the event started.
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// The identifier of the Campaign linked to this event.
        /// </summary>
        public int CampaignId { get; set; }
        /// <summary>
        /// A list of joint operation identifier linked to this event.
        /// </summary>
        public IEnumerable<int> JointOperationIds { get; set; } = [];
    }
}
