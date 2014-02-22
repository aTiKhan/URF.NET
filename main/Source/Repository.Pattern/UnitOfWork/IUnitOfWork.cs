﻿using System;
using Repository.Pattern.Repositories;

namespace Repository.Pattern.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : Infrastructure.Entity;
        void BeginTransaction();
        bool Commit();
        void Rollback();
    }
}