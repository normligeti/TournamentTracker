using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    /// <summary>
    /// represents one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// the set of teams that were involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// the winner of this match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// which round this match is a part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
