﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    
    public interface IDataConnection
    {
        /// <summary>
        /// asdasdasd
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        void CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        void UpdateMatchup(MatchupModel model);
        List<PersonModel> GetPerson_All();
        List<TeamModel> GetTeam_All();
        //List<PrizeModel> GetPrize_All();
        List<TournamentModel> GetTournament_All();
    }
}
