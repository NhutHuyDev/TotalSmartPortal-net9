using TotalBase.Enums;
using TotalCore.Repositories;

namespace TotalCore.Services
{
    public interface IBaseService
    {
        Dictionary<string, object> ServiceBag { get; set; }

        IBaseRepository BaseRepository { get; }

        int UserID { get; set; }
        int LocationID { get; }

        int? GetStoredID(int configID);
        int? GetVersionID(int configID);
        int? GetApiVersionID(int configID);
        bool VersionValidate(bool bothKeyID);

        GlobalEnums.NmvnTaskID NmvnTaskID { get; set; }
        int GetModuleID(GlobalEnums.NmvnTaskID moduleDetailID);

        int GetUser(string aspUserID);
        GlobalEnums.AccessLevel GetAccessLevel();
        GlobalEnums.AccessLevel GetAccessLevel(int? organizationalUnitID);

        bool GetUnApprovalPermitted();
        bool GetUnApprovalPermitted(int? organizationalUnitID);

        bool GetVoidablePermitted();
        bool GetVoidablePermitted(int? organizationalUnitID);

        bool GetUnVoidablePermitted();
        bool GetUnVoidablePermitted(int? organizationalUnitID);

        bool GetShowValues();
        bool GetShowDiscount();

        bool GetShowListedPrice(int? priceCategoryID);
        bool GetShowListedGrossPrice(int? priceCategoryID);

        string GetMatrixSymbologies(string barcode);
        void AddReportServers(DateTime? entryDate, string reference, string category, string name, string customerName, string commodityCode, string barcode, decimal quantity, string reportPath, int? reportTypeID, int? serialID, int? printCounts, string remarks, string reportServerDetails);
    }
}
