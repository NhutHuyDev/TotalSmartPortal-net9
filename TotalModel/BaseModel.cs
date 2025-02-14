using System.ComponentModel.DataAnnotations;
using TotalBase.Enums;

namespace TotalModel
{
    public interface IBaseModel : IValidatableObject
    {
        GlobalEnums.NmvnTaskID NMVNTaskID { get; set; }

        DateTime? EntryDate { get; set; }
        int LocationID { get; set; }

        Nullable<int> ParentID { get; set; }

        bool Approved { get; set; }
        Nullable<System.DateTime> ApprovedDate { get; set; }

        bool InActive { get; set; }
        Nullable<System.DateTime> InActiveDate { get; set; }

        bool InActivePartial { get; set; }
        Nullable<System.DateTime> InActivePartialDate { get; set; }

        Nullable<int> VoidTypeID { get; set; }

        [Display(Name = "Mô tả")]
        string Caption { get; set; }
        [Display(Name = "Diễn giải")]
        string Description { get; set; }
        [Display(Name = "Ghi chú")]
        string Remarks { get; set; }

        int SerialID { get; set; }

        #region
        int rndN0 { get; }
        int rndN3 { get; }
        int rndQuantity { get; }
        int rndPrice { get; }
        int rndAmount { get; }
        int rndDiscountPercent { get; }
        int rndWeight { get; }
        
        string kfmN0 { get; }
        string kfmN3 { get; }
        string kfmPercentN0 { get; }
        string kfmQuantity { get; }
        string kfmPrice { get; }
        string kfmAmount { get; }
        string kfmDiscountPercent { get; }
        string kfmWeight { get; }
        #endregion

        void PerformAutoRule();
    }

    public abstract class BaseModel : IBaseModel
    {
        protected BaseModel() { this.EntryDate = DateTime.Now; this.ModuleDetailID = this.NMVNTaskID; }

        [UIHint("DateTimeReadonly")]
        [Display(Name = "Ngày lập")]
        [Required(ErrorMessage = "Vui lòng nhập ngày lập")]
        public DateTime? EntryDate { get; set; }

        public virtual GlobalEnums.NmvnTaskID NMVNTaskID { get; set; }
        public virtual GlobalEnums.NmvnTaskID ModuleDetailID { get; set; }
        public virtual string ControllerName { get { return this.ModuleDetailID.ToString() + "s"; } } //this.NMVNTaskID.ToString()

        public int LocationID { get; set; }

        public Nullable<int> ParentID { get; set; }

        [Display(Name = "Mô tả")]
        public virtual string Caption { get; set; }

        [Display(Name = "Diễn giải")]
        public string Description { get; set; }
        [Display(Name = "Ghi chú")]
        public virtual string Remarks { get; set; }

        public int SerialID { get; set; }

        public virtual bool ApprovedSubmited { get; set; }

        public virtual bool Approved { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }

        public virtual bool InActive { get; set; }
        public Nullable<System.DateTime> InActiveDate { get; set; }

        public bool InActivePartial { get; set; }
        public Nullable<System.DateTime> InActivePartialDate { get; set; }

        public virtual Nullable<int> VoidTypeID { get; set; }

        protected virtual void ShiftSaving(int shiftID)
        {
            if (GlobalEnums.ShiftSaving)
                this.EntryDate = this.GetShiftSaving(shiftID);
        }

        protected virtual DateTime? GetShiftSaving(int shiftID)
        {
            DateTime? shiftEntryDate = this.EntryDate;

            TimeSpan midnight = new TimeSpan(0, 0, 0);
            TimeSpan sevenOclock = new TimeSpan(7, 0, 0);
            TimeSpan atNoon = new TimeSpan(12, 0, 0);

            TimeSpan entryTime = ((DateTime)shiftEntryDate).TimeOfDay;

            if (GlobalEnums.HLM)
            {
                TimeSpan at19PM30 = new TimeSpan(19, 30, 0);

                if (entryTime > at19PM30)
                    shiftEntryDate = ((DateTime)shiftEntryDate).AddDays(1) - entryTime;
            }
            else
            {
                if (shiftID == 1 && entryTime >= midnight && entryTime < sevenOclock)
                    shiftEntryDate = ((DateTime)shiftEntryDate).AddMinutes(-1) - entryTime;
                if (shiftID == 2 && entryTime >= midnight && entryTime < atNoon)
                    shiftEntryDate = ((DateTime)shiftEntryDate).AddMinutes(-1) - entryTime;
            }
            return shiftEntryDate;
        }

        #region Implementation of IValidatableObject

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (false)
                yield return new ValidationResult("", new[] { "" });
        }

        #endregion

        public virtual void PerformAutoRule() { }

        #region POS
        public virtual bool POS { get { return false; } }
        #endregion

        #region rnd*
        public virtual int rndN0 { get { return GlobalEnums.rndN0; } }
        public virtual int rndN1 { get { return GlobalEnums.rndN1; } }
        public virtual int rndN2 { get { return GlobalEnums.rndN2; } }
        public virtual int rndN3 { get { return GlobalEnums.rndN3; } }
        public virtual int rndN4 { get { return GlobalEnums.rndN4; } }
        public virtual int rndN5 { get { return GlobalEnums.rndN5; } }
        public virtual int rndQuantity { get { return GlobalEnums.rndQuantity; } }
        public virtual int rndPrice { get { return GlobalEnums.rndPrice; } }
        public virtual int rndAmount { get { return GlobalEnums.rndAmount; } }
        public virtual int rndDiscountPercent { get { return GlobalEnums.rndDiscountPercent; } }
        public virtual int rndWeight { get { return GlobalEnums.rndWeight; } }
        #endregion

        #region fm* & kfm*
        public virtual string fmN0 { get { return "N" + this.rndN0.ToString("N0"); } }
        public virtual string fmN3 { get { return "N" + this.rndN3.ToString("N0"); } }
        public virtual string fmQuantity { get { return "N" + this.rndQuantity.ToString("N0"); } }
        public virtual string fmPrice { get { return "N" + this.rndPrice.ToString("N0"); } }
        public virtual string fmAmount { get { return "N" + this.rndAmount.ToString("N0"); } }
        public virtual string fmWeight { get { return "N" + this.rndWeight.ToString("N0"); } }
        public virtual string kfmN0 { get { return "{0:n" + this.rndN0.ToString("N0") + "}"; } }
        public virtual string kfmN1 { get { return "{0:n" + this.rndN1.ToString("N0") + "}"; } }
        public virtual string kfmN2 { get { return "{0:n" + this.rndN2.ToString("N0") + "}"; } }
        public virtual string kfmN3 { get { return "{0:n" + this.rndN3.ToString("N0") + "}"; } }
        public virtual string kfmN4 { get { return "{0:n" + this.rndN4.ToString("N0") + "}"; } }
        public virtual string kfmN5 { get { return "{0:n" + this.rndN5.ToString("N0") + "}"; } }
        public virtual string kfmPercentN0 { get { return "{0:n" + this.rndN0.ToString("N0") + "}%"; } }
        public virtual string kfmQuantity { get { return "{0:n" + this.rndQuantity.ToString("N0") + "}"; } }
        public virtual string kfmPrice { get { return "{0:n" + this.rndPrice.ToString("N0") + "}"; } }
        public virtual string kfmAmount { get { return "{0:n" + this.rndAmount.ToString("N0") + "}"; } }
        public virtual string kfmDiscountPercent { get { return "{0:n" + this.rndDiscountPercent.ToString("N0") + "}%"; } }
        public virtual string kfmWeight { get { return "{0:n" + this.rndWeight.ToString("N0") + "}"; } }
        #endregion
    }

}
