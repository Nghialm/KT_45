using System;
using System.Collections.Generic;
using System.Text;

using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Dao;
using System.Data;
using System.Collections;
using Vns.Erp.Core.Service.Interface;
using System.ServiceModel.Activation;
using System.Security.Permissions;

namespace Vns.Erp.Core.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public abstract class GenericService<T, IdT> : IErpService<T,IdT>
    {
        private IDao<T, IdT> _dao;

        protected IDao<T, IdT> Dao
        {
            get { return _dao; }
            set { _dao = value; }
        }

        protected IDbConnection Connection
        {
            get { return Dao.Connection; }
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated=true)]
        public T Get(IdT id)
        {
            return Dao.Get(id);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public T GetById(IdT id)
        {
            return Dao.Get(id);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public T GetByKey(string Key, object Value)
        {
            return Dao.GetByKey(Key, Value);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public IList<T> GetAll()
        {
            return Dao.GetAll();
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public IList<T> List()
        {
            return Dao.List();
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public IList<T> List(int recordStart, int recordCount)
        {
            return Dao.List(recordStart, recordCount);
        }
        public int RecordCount()
        {
            return Dao.RecordCount();
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public T Save(T entity)
        {
            return Dao.Save(entity);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public T SaveOrUpdate(T entity)
        {
            return Dao.SaveOrUpdate(entity);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public T Merge(T entity)
        {
            return Dao.Merge(entity);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public T Update(T entity)
        {
            return Dao.Update(entity);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public void DeleteById(IdT id)
        {
            Dao.DeleteById(id);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public void Delete(T entity)
        {
            Dao.Delete(entity);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public IList<T> List(int pageIndex, int numberResultPerPage, IList props, IList values, IList<VnsOrder> orders)
        {
            int recordStart = 0;
            if((pageIndex>0) && (numberResultPerPage>0))
                recordStart =(pageIndex - 1) * numberResultPerPage;
            return Dao.List(recordStart, numberResultPerPage, props, values, orders);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public IList<T> ListLike(int recordStart, int recordCount, IList props, IList values, IList likeProps, IList likeValues, IList<VnsOrder> Orders)
        {
            return Dao.ListLike(recordStart, recordCount, props, values,likeProps,likeValues, Orders);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public T GetLast()
        {
            return Dao.GetLast();
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public int GetCount()
        {
            return RecordCount();
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public int GetCount(IList props, IList values, IList expressions)
        {
            return Dao.GetCount(props,values,expressions);
        }
        //[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public virtual DataTable GetData(List<object> lstProps, List<object> lstValues)
        {
            return null;
        }
    }
}
