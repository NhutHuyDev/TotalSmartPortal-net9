using TotalModel.Models;
using System.Data.Common;
using System.Linq.Expressions;
using TotalBase.Enums;

namespace TotalCore.Repositories
{
    public interface IBaseRepository
    {
        TotalSmartPortalEntities TotalSmartPortalEntities { get; }

        bool IsDirty();

        Dictionary<string, object> RepositoryBag { get; set; }

        int GetModuleID(int moduleDetailID);
        ICollection<TElement> ExecuteFunction<TElement>(string functionName, params DbParameter[] parameters);
        int ExecuteFunction(string functionName, params DbParameter[] parameters);
        int ExecuteStoreCommand(string commandText, params Object[] parameters);

        T GetEntity<T>(params Expression<Func<T, object>>[] includes) where T : class;
        T GetEntity<T>(bool proxyCreationEnabled, params Expression<Func<T, object>>[] includes) where T : class;
        T GetEntity<T>(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes) where T : class;
        T GetEntity<T>(bool proxyCreationEnabled, Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes) where T : class;

        ICollection<T> GetEntities<T>(params Expression<Func<T, object>>[] includes) where T : class;
        ICollection<T> GetEntities<T>(bool proxyCreationEnabled, params Expression<Func<T, object>>[] includes) where T : class;
        ICollection<T> GetEntities<T>(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes) where T : class;
        ICollection<T> GetEntities<T>(bool proxyCreationEnabled, Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes) where T : class;

        DateTime GetLockedDate(int? locationID, int nmvnTaskID);

        int GetUser(string aspUserID);
        OrganizationalUnitUser GetOrganizationalUnitUser(int userID);

        GlobalEnums.AccessLevel GetAccessLevel(int? userID, int nmvnTaskID, int? organizationalUnitID);
        bool GetApprovalPermitted(int? userID, int nmvnTaskID, int? organizationalUnitID);
        bool GetUnApprovalPermitted(int? userID, int nmvnTaskID, int? organizationalUnitID);
        bool GetVoidablePermitted(int? userID, int nmvnTaskID, int? organizationalUnitID);
        bool GetUnVoidablePermitted(int? userID, int nmvnTaskID, int? organizationalUnitID);

        bool GetShowValues(int? userID, int nmvnTaskID);
        bool GetShowDiscount(int? userID, int nmvnTaskID);

        bool GetShowListedPrice(int? priceCategoryID);
        bool GetShowListedGrossPrice(int? priceCategoryID);
        
        string GetSystemInfos();
        string GetSystemInfos(bool secureEncoding);

        string GetMatrixSymbologies(string barcode);
        void AddReportServers(DateTime? entryDate, string reference, string category, string name, string customerName, string commodityCode, string barcode, decimal quantity, string reportPath, int? reportTypeID, int? serialID, int? printCounts, string remarks, string reportServerDetails);

        bool SystemInfoValidate();
        int? GetStoredID(int configID);
        int? GetVersionID(int configID);
        int? GetApiVersionID(int configID);
        bool VersionValidate(bool bothKeyID);

        bool AutoUpdates(bool restoreProcedures);
    }
}
