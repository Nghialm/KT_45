using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using NHibernate;
using Spring.Data.NHibernate.Generic.Support;
using NHibernate.Cfg;
using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Dao;
using NHibernate.Criterion;

namespace Vns.Erp.Core.Dao.NHibernate
{
    public abstract class GenericDao<T, IdT> : HibernateDaoSupport, IDao<T, IdT> where T : new()
    {
        private Type persitentType = typeof(T);
        public IDbConnection Connection 
        {
            get { return Session.Connection; }
        }

        public T Get(IdT id)
        {
            //return HibernateTemplate.Load<T>(id);
            return HibernateTemplate.Get<T>(id);
        }
        public IList<T> GetAll()
        {
            return HibernateTemplate.LoadAll<T>();
        }
        public IList<T> List()
        {
            return GetAll();
        }
        protected IList<T> List(int recordStart, int recordCount, ICriteria criteria)
        {
            if (recordStart >= 0)
            {
                criteria.SetFirstResult(recordStart);
            }
            if (recordCount > 0)
            {
                criteria.SetMaxResults(recordCount);
            }
            return criteria.List<T>();
        }
        protected IList<T> List(int recordStart, int recordCount, IQuery query)
        {
            if (recordStart >= 0)
            {
                query.SetFirstResult(recordStart);
            }
            if (recordCount > 0)
            {
                query.SetMaxResults(recordCount);
            }
            return query.List<T>();
        }
        
        public T Merge(T entity)
        {
            HibernateTemplate.Merge(entity);
            return entity;
        }
        public IList<T> List(int recordStart, int recordCount)
        {
            ICriteria cri = Session.CreateCriteria(typeof(T));
            //if (recordStart >= 0)
            //{
            //    cri.SetFirstResult(recordStart);
            //}
            //if (recordCount > 0)
            //{
            //    cri.SetMaxResults(recordCount);
            //}
            //return cri.List<T>();
            return List(recordStart, recordCount, cri);
        }
        public IList<T> List(int recordStart, int recordCount,IList props, IList values)
        {
            ICriteria cri = Session.CreateCriteria(typeof(T));
            if ((props != null) && (values != null))
            {
                for (int i = 0; i < Math.Min(props.Count, values.Count); i++)
                {                    
                    cri.Add(Expression.Eq(props[i].ToString(), values[i]));
                }
            }
            if (recordStart >= 0)
            {
                cri.SetFirstResult(recordStart);
            }
            if (recordCount > 0)
            {
                cri.SetMaxResults(recordCount);
            }
            return cri.List<T>();                
        }
        public IList<T> List(int recordStart, int recordCount, IList props, IList values,IList<VnsOrder> Orders)
        {
            ICriteria cri = Session.CreateCriteria(typeof(T));
            if ((props != null) && (values != null))
            {
                for (int i = 0; i < Math.Min(props.Count, values.Count); i++)
                {                    
                    cri.Add(Expression.Eq(props[i].ToString(), values[i]));
                }
            }
            if (recordStart >= 0)
            {
                cri.SetFirstResult(recordStart);
            }
            if (recordCount > 0)
            {
                cri.SetMaxResults(recordCount);
            }
            if(Orders!=null){
                for (int i = 0; i < Orders.Count; i++)
                {
                    Order order = new Order(Orders[i].PropertyName, Orders[i].Asc);
                    cri.AddOrder(order);
                }
            //cri.AddOrder(Order.Asc(Orders))
            }
            return cri.List<T>();
        }
        public IList<T> ListLike(int recordStart, int recordCount, IList props, IList values,IList likeProps, IList likeValues, IList<VnsOrder> Orders)
        {
            ICriteria cri = Session.CreateCriteria(typeof(T));
            if ((props != null) && (values != null))
            {
                for (int i = 0; i < Math.Min(props.Count, values.Count); i++)
                {
                    cri.Add(Expression.Eq(props[i].ToString(), values[i]));
                }
            }
            if ((likeProps != null) && (likeValues != null))
            {
                for (int i = 0; i < Math.Min(likeProps.Count, likeValues.Count); i++)
                {
                    cri.Add(Expression.Like(likeProps[i].ToString(), likeValues[i]));
                }
            }

            if (recordStart >= 0)
            {
                cri.SetFirstResult(recordStart);
            }
            if (recordCount > 0)
            {
                cri.SetMaxResults(recordCount);
            }
            if (Orders != null)
            {
                for (int i = 0; i < Orders.Count; i++)
                {
                    Order order = new Order(Orders[i].PropertyName, Orders[i].Asc);
                    cri.AddOrder(order);
                }
                //cri.AddOrder(Order.Asc(Orders))
            }
            return cri.List<T>();
        }
        public List<T> List(int pageIndex, int numberResultPerPage, IList props, IList values, IList expressions, VnsOrder[] orders)
        {

            int start = 0;
            if (pageIndex >= 1)
            {
                start = (pageIndex - 1) * numberResultPerPage;
            }
   
            string sql = "from " + persitentType.ToString() + " a where (1=1) ";


            IList<string> paramList = new List<string>();
            if ((props != null) && (values != null))
            {
                for (int i = 0; i < props.Count; i++)
                {
                    if (values.Count > i && expressions.Count > i)
                    {
                        string param = "paramList" + i;
                        paramList.Add(param);
                        string expression = "(a." + props[i] + " " + expressions[i].ToString() + " (:" + param + "))";
                        sql += " and " + expression;
                    }
                }
            }

            if (orders != null)
            {
                for (int i = 0; i < orders.Length; i++)
                {
                    if (i == 0)
                    {
                        sql += " order by ";
                    }
                    else
                    {
                        sql += ", ";
                    }
                    sql += orders[i].PropertyName;
                    sql += (orders[i].Asc ? " asc" : " desc");
                }
            }
            IQuery q = NHibernateSession.CreateQuery(sql);
            if ((props != null) && (values != null))
            {
                for (int i = 0; i < props.Count; i++)
                {
                    if (values.Count > i && expressions.Count > i)
                    {
                        string param = "paramList" + i;
                        string expression = expressions[i].ToString();
                        if (expression.ToLower().Equals("in"))
                        {
                            q.SetParameterList(param, (ICollection)values[i]);
                        }
                        else
                        {
                            q.SetParameter(param, values[i]);
                        }
                    }
                }
            }

            q.SetFirstResult(start);
            if (numberResultPerPage >= 0)
            {
                q.SetMaxResults(numberResultPerPage);
            }
            return q.List<T>() as List<T>;
        }
        protected int RecordCount(ICriteria criteria)
        {
            criteria.SetProjection(Projections.ProjectionList().Add(Projections.RowCount()));
            return criteria.UniqueResult<int>();
        }
        public int RecordCount()
        {
            ICriteria cri = Session.CreateCriteria(typeof(T));
            //cri.SetProjection(Projections.ProjectionList().Add(Projections.RowCount()));
            //return cri.UniqueResult<int>();
            return RecordCount(cri);
        }
        public T Save(T entity)
        {
            HibernateTemplate.Save(entity);
            return entity;
        }
        public T SaveOrUpdate(T entity)
        {
            HibernateTemplate.SaveOrUpdate(entity);
            return entity;
        }
        public T Update(T entity)
        {
            HibernateTemplate.Update(entity);
            return entity;
        }
        public void DeleteById(IdT id)
        {
            T entity = Get(id);
            Delete(entity);
        }
        public void Delete(T entity)
        {
            HibernateTemplate.Delete(entity);
        }
        public T GetLast()
        {
            ICriteria cri = Session.CreateCriteria(typeof(T));
            int max = RecordCount();
            cri.SetMaxResults(1);
            cri.SetFirstResult(max - 1);
            return cri.UniqueResult<T>();
        }
        /// <summary>
        /// Get Object by Key=value
        /// </summary>
        public T GetByKey(string Key, object Value)
        {
            ICriteria crit = NHibernateSession.CreateCriteria(persitentType);
            crit.Add(Expression.Eq(Key, Value));
            crit.SetMaxResults(1);

            return crit.UniqueResult<T>();
        }
        // --> End	
        //public void Delete(IList props, IList values,string tableName)
        //{
        //    ISession session = this.NHibernateSession;
        //    ITransaction tx = session.BeginTransaction();
        //    session.Delete("select A from " +tableName + " A where A." +props[0]+ "= :value",
        //     props[0], values[0]);
        //    tx.Commit();
        //}
        //protected int DemSoLuongBanGhiBietTenBangTenTruongVaGiaTri(string tableName, string columnName, object value)
        //{
        //    string nativeQuery = "SELECT count(*) as RecordCount FROM " + tableName + " WHERE " + columnName + "=" + value;
        //    ISQLQuery query = NHibernateSession.CreateSQLQuery(nativeQuery);
        //    query.AddScalar("RecordCount", NHibernateUtil.Int32);            
        //    return (int)query.UniqueResult();
        //}

        public ISession NHibernateSession
        {
            //get { return HibernateTemplate.SessionFactory.GetCurrentSession(); }
            get { return Session; }
        }

        public IList GetByQuery(String sQuery, List<String> parameters, IList expressions)
        {
            IQuery q = NHibernateSession.CreateQuery(sQuery);
            if (expressions != null)
            {
                for (int i = 0; i < expressions.Count; i++)
                {
                    q.SetParameter(parameters[i], expressions[i]);
                }
            }
            return q.List();
        }

        public int GetCount(IList props, IList values, IList expressions)
        {
            string sql = "select count (*) from " + persitentType.ToString() + " a where (1=1) ";


            IList<string> paramList = new List<string>();
            if ((props != null) && (values != null))
            {
                for (int i = 0; i < props.Count; i++)
                {
                    if (values.Count > i && expressions.Count > i)
                    {
                        string param = "paramList" + i;
                        paramList.Add(param);
                        string expression = "(a." + props[i] + " " + expressions[i].ToString() + " (:" + param + "))";
                        sql += " and " + expression;
                    }
                }
            }

            IQuery q = NHibernateSession.CreateQuery(sql);
            if ((props != null) && (values != null))
            {
                for (int i = 0; i < props.Count; i++)
                {
                    if (values.Count > i && expressions.Count > i)
                    {
                        string param = "paramList" + i;
                        string expression = expressions[i].ToString();
                        if (expression.ToLower().Equals("in"))
                        {
                            q.SetParameterList(param, (ICollection)values[i]);
                        }
                        else
                        {
                            q.SetParameter(param, values[i]);
                        }
                    }
                }
            }
            long ret = (long)q.UniqueResult();
            return (int)ret;
        }

        public DataTable GetDtByQuery(String sQuery, List<String> parameters, IList expressions)
        {
            IQuery q = NHibernateSession.CreateQuery(sQuery);
            if (expressions != null)
            {
                for (int i = 0; i < expressions.Count; i++)
                {
                    q.SetParameter(parameters[i], expressions[i]);
                }
            }
            IList lst = q.List();
            List<String> lstcolumns = GetListColumnFromSQL(sQuery);
            return ToDataTable(lstcolumns, lst);
        }

        private DataTable ToDataTable(List<string> columns, IList results)
        {
            DataTable dataTable = new DataTable();
            foreach (string column in columns)
            {
                dataTable.Columns.Add(column, typeof(string));
            }
            if (columns.Count > 1)
            {
                foreach (object[] row in results)
                {
                    dataTable.Rows.Add(row);
                }
            }
            return dataTable;
        }

        private List<string> GetListColumnFromSQL(string sQuery)
        {
            string columns = sQuery.ToUpper();
            int frompos = columns.IndexOf("FROM");
            columns = sQuery.Substring(5, frompos);
            string[] arrColumns = columns.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            List<string> lstcolumns = new List<string>();
            for (int i = 0; i <= arrColumns.Length - 1; i++)
            {
                lstcolumns.Add(arrColumns[i].Trim());
            }
            return lstcolumns;
        }
    }
}
