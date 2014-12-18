﻿namespace Sporacid.Simplets.Webapp.Services.Services.Impl
{
    using System;
    using System.Data.Linq.SqlClient;
    using System.Linq;
    using System.Web.Http;
    using Sporacid.Simplets.Webapp.Core.Repositories;
    using Sporacid.Simplets.Webapp.Services.Database;

    /// <authors>Simon Turcotte-Langevin, Patrick Lavallée, Jean Bernier-Vibert</authors>
    /// <version>1.9.0</version>
    [RoutePrefix(BasePath + "/{clubName:alpha}/subscription")]
    public class SubscriptionService : BaseService, ISubscriptionService
    {
        private readonly IRepository<Int32, Club> clubRepository;
        private readonly IRepository<Int32, Membre> membreRepository;

        public SubscriptionService(IRepository<Int32, Membre> membreRepository, IRepository<Int32, Club> clubRepository)
        {
            this.membreRepository = membreRepository;
            this.clubRepository = clubRepository;
        }

        /// <summary>
        /// Subscribes a member entity to a club entity.
        /// </summary>
        /// <param name="clubName">The unique club name of the club entity.</param>
        /// <param name="membreId">The id of the member entity.</param>
        [HttpPost]
        [Route("{membreId:int}")]
        public void SubscribeToClub(String clubName, int membreId)
        {
            var membreEntity = this.membreRepository.Get(membreId);
            var clubEntity = this.clubRepository.GetUnique(c => SqlMethods.Like(c.Nom, clubName));

            membreEntity.MembreClubs.Add(new MembreClub
            {
                Membre = membreEntity,
                ClubId = clubEntity.Id,
                DateDebut = DateTime.UtcNow
            });

            this.membreRepository.Update(membreEntity);
        }

        /// <summary>
        /// Unsubscribes a member entity from a club entity.
        /// </summary>
        /// <param name="clubName">The unique club name of the club entity.</param>
        /// <param name="membreId">The id of the member entity.</param>
        [HttpDelete]
        [Route("{membreId:int}")]
        public void UnsubscribeFromClub(String clubName, int membreId)
        {
            var membreEntity = this.membreRepository.Get(membreId);
            var clubEntity = this.clubRepository.GetUnique(c => SqlMethods.Like(c.Nom, clubName));

            membreEntity.MembreClubs.Remove(membreEntity.MembreClubs
                .FirstOrDefault(mc => mc.ClubId == clubEntity.Id && mc.MembreId == membreId));
            clubEntity.MembreClubs.Remove(membreEntity.MembreClubs
                .FirstOrDefault(mc => mc.ClubId == clubEntity.Id && mc.MembreId == membreId));

            this.membreRepository.Update(membreEntity);
            this.clubRepository.Update(clubEntity);
        }
    }
}