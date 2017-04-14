using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Dao
{
    public interface IDao<T, IdT>
    {
        IDbConnection Connection { get; }
        T Get(IdT id);
        IList<T> GetAll();
        IList<T> List();
        IList<T> List(int recordStart, int recordCount);
        IList<T> List(int recordStart, int recordCount, IList props, IList values);
        IList<T> List(int recordStart, int recordCount, IList props, IList values, IList<VnsOrder> Orders);
        IList<T> ListLike(int recordStart, int recordCount, IList props, IList values, IList likeProps, IList likeValues, IList<VnsOrder> Orders);
        List<T> List(int pageIndex, int numberResultPerPage, IList props, IList values, IList expressions, VnsOrder[] orders);
        int RecordCount();
        int GetCount(IList props, IList values, IList expressions);
        T Save(T entity);
        T SaveOrUpdate(T entity);
        T Merge(T entity);
        T Update(T entity);
        void DeleteById(IdT id);
        void Delete(T entity);
        T GetLast();
        T GetByKey(string Key, object Value);
        IList GetByQuery(String sQuery, List<String> parameters, IList expressions);
        DataTable GetDtByQuery(String sQuery, List<String> parameters, IList expressions);
    }
}
