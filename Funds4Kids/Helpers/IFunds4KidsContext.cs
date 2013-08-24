﻿using System;
namespace Funds4Kids.Helpers
{
    public interface IFunds4KidsContext
    {
        System.Data.Entity.DbSet<Funds4Kids.Models.EventCoordinator> Denominations { get; set; }
        System.Data.Entity.DbSet<Funds4Kids.Models.EventCoordinator> Donations { get; set; }
        System.Data.Entity.DbSet<Funds4Kids.Models.EventCoordinator> EventCoordinators { get; set; }
        System.Data.Entity.DbSet<Funds4Kids.Models.EventCoordinator> EventInfos { get; set; }
        System.Data.Entity.DbSet<Funds4Kids.Models.UserProfile> UserProfiles { get; set; }
    }
}