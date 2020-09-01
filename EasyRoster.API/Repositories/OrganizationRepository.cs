using ReziRoster.API.Interfaces;
using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ReziRoster.API.Repositories
{
    public class OrganizationRepository : BaseRepository<Organization>
    {
        public OrganizationRepository(DbContext context) : base(context)
        {

        }
    }
}