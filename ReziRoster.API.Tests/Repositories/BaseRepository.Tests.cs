using NUnit.Framework;
using FakeItEasy;
using ReziRoster.API.Repositories.Interface;
using System.Linq.Expressions;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using ReziRoster.API.Models;
using ReziRoster.API.Context;
using Microsoft.EntityFrameworkCore;
using ReziRoster.API.Enums;

namespace ReziRoster.API.Repositories.Tests
{
    [TestFixture]
    public class GuardTest
    {
        //[Test]
        //public void BaseRepository_GetById_CallsDbSetWithProvidedId()
        //{
        //    var mockUsers = new List<User>()
        //    {
        //        new User("Email", "FirstName", "LastName", "Password", "UserName"),
        //        new User("Email2", "FirstName2", "LastName2", "Password2", "UserName2"),
        //        new User("Email3", "FirstName3", "LastName3", "Password3", "UserName3"),
        //    }.AsQueryable();

        //    var fakeDbSet = A.Fake<DbSet<User>>();
        //    var fakeDbContext = A.Fake<UserContext>();
        //    A.CallTo(() => fakeDbContext.User).Returns(fakeDbSet);


        //    A.CallTo(() => ((IQueryable<User>)fakeDbSet).Provider).Returns(mockUsers.Provider);
        //    A.CallTo(() => ((IQueryable<User>)fakeDbSet).Expression).Returns(mockUsers.Expression);
        //    A.CallTo(() => ((IQueryable<User>)fakeDbSet).ElementType).Returns(mockUsers.ElementType);
        //    A.CallTo(() => ((IQueryable<User>)fakeDbSet).GetEnumerator()).Returns(mockUsers.GetEnumerator());

        //    var baseRepositoryUnderTest = new BaseRepository<User>(fakeDbContext);
        //    var results = baseRepositoryUnderTest.GetByID(1);

            
        //}
    }
}
