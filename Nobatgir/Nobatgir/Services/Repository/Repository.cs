﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nobatgir.Data;
using Nobatgir.Model;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        #region constructor
        private readonly MyContext _myContext;

        private readonly int allSiteId = 1;
        private int pageSize = 2;

        public Repository(MyContext myContext)
        {
            this._myContext = myContext;
        }

        #endregion

        #region common
        private void Authorize(BaseClass row)
        {
            //if (row.siteId != 0 && row.siteId != this.siteId)
            //    throw new Exception("شما مجوز تغییر این قسمت را ندارید.");
        }

        private void Labeling(BaseClass row)
        {
            //row.siteId = this.siteId;
            //row.updateUserId = this.userId;
            row.UpdateDateTime = DateTime.Now;
        }

        public BaseClass GetRow(int? id, Type type)
        {
            if (id == null)
                return null;

            BaseClass row = _myContext.Find(type, id) as BaseClass;
            this.Authorize(row);
            return row;
        }

        public BaseClass UpdateRow(BaseClass row)
        {
            this.Authorize(row);
            this.Labeling(row);
            this._myContext.Update(row);
            this._myContext.SaveChanges();
            return row;
        }
        public void DeleteRow(BaseClass row)
        {
            this.Authorize(row);
            this.Labeling(row);
            row.IsDeleted = true;
            this._myContext.Update(row);
            this._myContext.SaveChanges();
        }
        public BaseClass AddRow<T>(T row) where T : BaseClass
        {
            this.Labeling(row);
            this._myContext.Add(row);
            this._myContext.SaveChanges();
            return row;
        }

        #endregion



        public PagedResult<Expert> GetExperts(int pageNumber, string searchString = "")
        {
            if (pageNumber == 0)
                pageNumber = 1;

            IQueryable<Expert> query;

            if (!string.IsNullOrEmpty(searchString))
                query = _myContext.Experts.Where(e => e.Title.Contains(searchString) && !e.IsDeleted);
            else
                query = _myContext.Experts.Where(e => !e.IsDeleted);

            var result = new PagedResult<Expert>
            {
                PagingData =
                {
                    CurrentPage = pageNumber,
                    ItemsPerPage = pageSize,
                    TotalItems = query.Count()
                },
                Items = query.OrderBy(e => e.OrderIndex).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            };

            return result;
        }







        public IQueryable<T> FilterExist<T>(IQueryable<T> db) where T : BaseClass
        {
            return db.Where(am => !am.IsDeleted).OrderBy(am => am.OrderIndex);
        }

        public IQueryable<T> FilterActive<T>(IQueryable<T> db) where T : BaseClass
        {
            return db.Where(am => am.IsActive);
        }

        public PagedResult<T> GetPagedResult<T>(IQueryable<T> db, int pageNumber, string searchString = "") where T : BaseClass
        {
            if (pageNumber == 0)
                pageNumber = 1;

            IEnumerable<T> query;

            if (!string.IsNullOrEmpty(searchString))
                query = FilterExist(db).Where(e => e.Title.Contains(searchString));
            else
                query = FilterExist(db);

            var result = new PagedResult<T>
            {
                PagingData =
                {
                    CurrentPage = pageNumber,
                    ItemsPerPage = pageSize,
                    TotalItems = query.Count()
                },
                Items = query.OrderBy(e => e.OrderIndex).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            };

            return result;
        }

    }
}
