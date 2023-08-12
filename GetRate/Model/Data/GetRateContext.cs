﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model.Data
{
    public class GetRateContext : DbContext
    {
        public GetRateContext(): base("MyConnString")   
        {
            //Database.CreateIfNotExists();
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresss { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<RoutePoint> RoutePoints { get; set; }
        public DbSet<Cargo> Cargoes { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<TransportMode> TransportModes { get; set; }
        public DbSet<TransportModeUnitType> TransportModesUnitTypes { get; set;}
        public DbSet<RoutePointTransportModeUnitType> RoutePointTransportModeUnitTypes { get; set; }
        public DbSet<TransportationType> TransportationTypes { get; set; }
    }
}