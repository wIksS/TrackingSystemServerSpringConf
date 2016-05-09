﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Models;

namespace TrackingSystem.Services.Contracts
{
    public interface ILocationService
    {
        /// <summary>
        /// Returns the last coordinate for specific user
        /// </summary>
        /// <param name="user">The user to get the coordinate</param>
        /// <returns>Coordinate</returns>
        Coordinate Get(ApplicationUser user);

        /// <summary>
        /// Adds new coordinate for user
        /// </summary>
        /// <param name="coordinate"></param> //TODO: fix
        void AddCoodinate(Coordinate coordinate, ApplicationUser user);

        /// <summary>
        /// Return all distant users from the current user
        /// </summary>
        /// <param name="user"> The user to get the distant users from</param>
        /// <returns>Distance list</returns>
        IEnumerable<DistanceModel> GetDistantUsers(ApplicationUser user);

    }
}
