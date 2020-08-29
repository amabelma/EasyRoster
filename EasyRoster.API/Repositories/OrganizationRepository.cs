using EasyRoster.API.Interfaces;
using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EasyRoster.API.Repositories
{
    public class OrganizationRepository : BaseRepository<Organization>
    {
        public OrganizationRepository(DbContext context) : base(context)
        {

        }
    }
}