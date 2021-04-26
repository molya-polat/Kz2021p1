﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.EfStuff.Model.Airport;

namespace WebApplication1.EfStuff.Repositoryies.Airport
{
    public class PassengersRepository : BaseRepository<Passenger>
    {
        public PassengersRepository(KzDbContext kzDbContext) : base(kzDbContext)
        {
        }
    }
}
