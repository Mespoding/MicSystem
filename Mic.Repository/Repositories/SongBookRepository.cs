﻿using Dapper;
using Mic.Entity;
using Mic.Repository.Dapper;
using Mic.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Mic.Repository.Repositories
{
    //ZNJSToolUtil.MD5Encrypt(password)

    public class SongBookRepository
    {
        DapperHelper<SqlConnection> helper;
        public SongBookRepository()
        {
            helper = new DapperHelper<SqlConnection>(WebConfig.SqlConnection);
        }



        public List<SongBookEntity> GetAll()
        {
            return helper.Query<SongBookEntity>("select * from [SongBook]").ToList();
        }

       

        public User GetById(int id)
        {
            return helper.Query<User>($@"select * from [User] where Id={id}").FirstOrDefault();
        }

        public PageEnumerable<User> GetPage(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Remove(User item)
        {
            helper.Execute($@"delete from [User] where Id = {item.Id}");
        }

        public void Save(User item)
        {
            //helper.Execute(
            //    "UPDATE Cat SET BreedId = @BreedId, Name = @Name, Age = @Age WHERE CatId = @CatId",
            //    //param: new { CatId = entity.CatId, BreedId = entity.BreedId, Name = entity.Name, Age = entity.Age },

            //);
        }

    }
}
