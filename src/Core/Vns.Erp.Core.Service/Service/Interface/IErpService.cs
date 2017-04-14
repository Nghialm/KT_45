
	/*
	insert license info here
	*/
	using System.Collections;
	using System.ComponentModel;
	using System.Data;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections;
    using Vns.Erp.Core.Domain;
using System.ServiceModel;
	namespace Vns.Erp.Core.Service.Interface
	{
        [ServiceContract(Namespace = "http://Vns.Erp.Core.Service")]
        public interface IErpService<T, IdT>
        {
            [OperationContract]
            T Get(IdT id);
            [OperationContract]
            T GetById(IdT id);
            [OperationContract]
            T GetByKey(string Key, object Value);
            [OperationContract]
            IList<T> GetAll();
            [OperationContract]
            T Save(T entity);
            [OperationContract]
            T SaveOrUpdate(T entity);
            [OperationContract]
            T Merge(T entity);
            [OperationContract]
            void Delete(T entity);
            [OperationContract]
            void DeleteById(IdT id);
            //IList<T> List(int pageIndex, int numberResultPerPage, IList props, IList values, IList expressions, IList<VnsOrder> orders);
            [OperationContract]
            IList<T> List(int pageIndex, int numberResultPerPage, IList props, IList values, IList<VnsOrder> orders);
            [OperationContract]
            IList<T> ListLike(int recordStart, int recordCount, IList props, IList values, IList likeProps, IList likeValues, IList<VnsOrder> Orders);
            [OperationContract(Name = "GetCount")]
            int GetCount();
            [OperationContract(Name = "GetCountByPropValues")]
            int GetCount(IList props, IList values, IList expressions);
            [OperationContract]
            DataTable GetData(List<object> lstProps, List<object> lstValues);
        }

        public interface IErpReportService
        { 
        }
	}
	