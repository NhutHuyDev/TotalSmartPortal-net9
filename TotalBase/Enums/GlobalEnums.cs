namespace TotalBase.Enums
{
    public static class GlobalEnums
    {
        // Cá nhân hóa cho từng khách hàng
        #region Khách hàng
        public static bool VCP = true;
        public static bool CBPP = false;
        public static bool TDV = false;
        public static bool DMC = false;
        public static bool TTP = false;
        public static bool HLM = false;
        #endregion

        public static bool AutoCustomerCode = false;

        public static bool IndexDetails = true;

        public static bool UserCommodityCategories = false;
        public static bool CustomerCommodities = false;

        public static bool POS = false;
        public static bool PlannedOrderGBCID = false; //GROUP BY COMMODITY ID
        public static bool PlannedOrderByTO = false; //PlannedOrder BY TRANSFER ORDER

        public static bool HideCommodityName = true;
        public static bool HideSelfWarehouseAdjustments = true;

        public static bool AutoWHTransferAfterOrder = false;
        public static bool AutoGoodsIssueAfterDA = false;
        public static bool WarehouseTransferOneStep = false;
        public static bool GoodsArrivalOneStep = false;
        public static bool SalesReturnOneStep = false;

        public static bool SystemInfoValidate = false;
        public static bool ListedPrice = false;
        public static bool GrossPrice = false;
        public static bool LockDate = true;
        public static bool CombineIndex = false;

        // rnd* là các hằng số phục vụ cho việc làm tròn
        #region rnd* constants
        public static int rndQuantity = 0;
        public static int rndVolume = 0;
        public static int rndQuantityProduct = 0;
        public static int rndQuantityOthers = 0;
        public static int rndQuantityStuff = 0;

        public static int rndPrice = 0;
        public static int rndAmount = 0;
        public static string rndN0WarehouseID = "3";

        public static int rndN0 = 0;
        public static int rndN1 = 1;
        public static int rndN2 = 2;
        public static int rndN3 = 3;
        public static int rndN4 = 4;
        public static int rndN5 = 5;

        public static int rndDiscountPercent = 1;

        public static int rndWeight = 2;
        #endregion

        public static bool showStatementWithDetail = true;
        public static bool ShiftSaving = false;
        public static bool MonetaryAccountID = false;

        public static bool HideFQ = false; //FreeQuantity

        public static bool ERPConnected = false;
        public static bool SKUWarehouse = false;
        public static bool AllowOutOfStockSales = true;

        public static int CalculatingTypeID = 1; //JUST CHANGE FROM [0] TO [1] AT 12.00PM ON 24.MAR.2O18 => TO SHOW THE ORIGINAL GROSS PRICE, GROSS AMOUNT ON PXK. 
                                                 //THEO SỰ XEM XÉT NGÀY 24.MAR.2O18 THÌ THAY ĐỔI NÀY SẼ THAY ĐỔI 4 GIÁ TRỊ: ListedVATAmount, VATAmount, ListedGrossAmount, GrossAmount. 
                                                 //TUY NHIÊN, NÓ HOÀN TOÀN KHÔNG THAY ĐỔI GIÁ TRỊ CỦA TABLE MASTER, VÌ: VATbyRow = false: TỨC LÀ: TotalListedVATAmount, TotalVATAmount, TotalListedGrossAmount, TotalGrossAmount ĐƯỢC TÍNH BỞI definedExemplar.prototype._updateTotalVATAmountToModelProperty: CÁCH TÍNH VAT 1 DÒNG
                                                 //TÚM LẠI: CalculatingTypeID = [0] HAY [1] KHI VATbyRow = false: THÌ GIÁ TRỊ TỔNG CỦA TotalListedVATAmount, TotalVATAmount, TotalListedGrossAmount, TotalGrossAmount LÀ KHÔNG ĐỔI [DO: VATbyRow = false: CÁCH TÍNH VAT 1 DÒNG]

        public static bool VATbyRow = false;
        public static decimal VATPercent = 8; //01/07/2022

        public enum SubmitTypeOption
        {
            Save = 0, //Save and return (keep) current view
            Popup = 1, //Save popup windows
            Create = 3, //Save and the create new
            Indit = 5, //POS: Index + Edit = Indit
            Closed = 9 //Save and close (return index view)
        };

        // Đại diện cho các tác vụ (task) hoặc định danh chức năng (functional identifiers) trong hệ thống TotalSmartPortal. 
        public enum NmvnTaskID
        {
            RootTwin = 1000000000,
            UnKnown = 0,
            Report = 1,
            Dashboard = 2,

            Bom = 2002,
            Lab = 2001,
            Customer = 8001,
            Supplier = 8001001,

            Material = 8002,
            Item = 8002006,
            Product = 8002008,
            Service = 8002009,
            Credit = 8002007,

            CommodityBom = 680016311,

            Mold = 8007,
            BinLocation = 8008,
            MonetaryAccount = 8888,

            Promotion = 8003,
            Employee = 8005,
            CommodityPrice = 8006,

            PurchaseRequisition = 8020,

            PurchaseMaterial = 80210008,
            PurchaseItem = 80210009,
            PurchaseProduct = 80210010,

            GoodsArrival = 8022,

            MaterialArrival = 80210013,
            ItemArrival = 80210014,
            ProductArrival = 80210015,

            BlendingInstruction = 6800160,

            PlannedOrder = 100680016,
            PlannedItem = 680016008,
            PlannedProduct = 680016,
            PlannedBadge = 68001610,
            PlannedToken = 680016300,
            PlannedGadget = 680016331,

            #region
            PlannedCheckMaterial = 680016301,
            PlannedCheckSemifinished = 680016302,
            PlannedCheckFinished = 680016303,
            PlannedCheckDelivery = 680016304,

            PlannedQuantityAdditional = 680016308,
            PlannedWorkOrderScheduler = 680016309,
            #endregion

            ProductionOrder = 100680018,
            ProductOrder = 680018,
            ItemOrder = 680016010,

            WorkPlan = 100682016,
            WorkPlanProduct = 682016,
            WorkPlanItem = 680018008,

            SemifinishedItemOrder = 680021888,
            SemifinishedItem = 680020888,
            SemifinishedProduct = 680020,
            SemifinishedStuff = 680020889,
            SemifinishedWare = 680020686,

            SemifinishedHandover = 100680026,
            SemifinishedItemHandover = 680026888,
            SemifinishedProductHandover = 680026,
            SemifinishedStuffHandover = 680026889,
            SemifinishedRecyclateHandover = 680026666,
            SemifinishedWareHandover = 680026686,

            Recyclate = 680020075,
            SemifinishedProductRecyclate = 680020076,
            FinishedProductRecyclate = 680020077,
            SemifinishedItemRecyclate = 680020079,
            FinishedItemRecyclate = 680020078,
            ItemRecyclate = 680020080,
            ProductRecyclate = 680020081,

            FinishedItem = 680028888,
            FinishedProduct = 680028,
            FinishedStuff = 680028889,

            RefinedOrder = 580028800,
            RefinedItemOrder = 580028801,
            RefinedProductOrder = 580028802,
            RefinedStuffOrder = 580028805,
            RefinedStuff = 580028889,

            QualityControl = 20250010,
            QualityControlChecklist = 20250012,
            QualityControlRecoup = 20250015,
            OmniControl = 20250020,

            //NEW VERSION
            FinishedHandover = 680029, //100680029
            FinishedItemHandover = 680029888,
            FinishedProductHandover = 100680029, //680029
            FinishedStuffHandover = 680029889,
            RefinedStuffHandover = 580029889,
            FifinedStuffHandover = 580029890,

            Quotation = 8031,
            SalesOrder = 8032,
            DeliveryAdvice = 8035,

            SellingIssue = 80371010,
            MaterialSellingIssue = 80371001,
            ItemSellingIssue = 80371002,
            ProductSellingIssue = 80371003,

            WorkOrder = 100681016,
            MaterialWorkOrder = 100681116, //RESERVER ONLY
            ItemWorkOrder = 680017008,
            ProductWorkOrder = 681016,

            MaterialIssue = 1008039,
            MaterialStaging = 679344031,
            ItemStaging = 8039,
            ProductStaging = 680687987, //RESERVER ONLY

            RecyclateIssue = 8008038,
            SemifinishedRecyclate = 680020666,

            PackageIssue = 8008039,
            WarehouseAdjustment = 8036,

            MaterialAdjustment = 8036006,
            OtherMaterialReceipt = 80360061,
            OtherMaterialIssue = 80360062,

            ItemAdjustment = 8036007,
            OtherItemReceipt = 80360071,
            OtherItemIssue = 80360072,

            ProductAdjustment = 8036008,
            OtherProductReceipt = 80360081,
            OtherProductIssue = 80360082,

            SalesInvoice = 8051,

            VehiclesInvoice = 8052,
            PartsInvoice = 8053,
            ServicesInvoice = 8055,

            ServiceContract = 8056,

            AccountInvoice = 8057,
            WarehouseInvoice = 8057100,
            Receipt = 8059,

            SalesReturn = 8038,
            CreditNote = 8060,

            Payment = 108059,

            PurchaseReturn = 108038,
            DebitNote = 108060,

            StockTake = 1976001,
            InventoryAdjustment = 8078,
            VehicleAdjustment = 8078008,
            PartAdjustment = 8078009,

            HandlingUnit = 9010,
            GoodsDelivery = 9012,

            VehicleTransferOrder = 8071008,
            PartTransferOrder = 8071009,

            StockTransfer = 8073,
            VehicleTransfer = 8075,
            PartTransfer = 8076,

            TransferOrder = 8071,
            MaterialTransferOrder = 8081008,
            ItemTransferOrder = 8081009,
            ProductTransferOrder = 8081010,

            WarehouseTransfer = 1008071,
            MaterialTransfer = 9081008,
            ItemTransfer = 9081009,
            HeapTransfer = 908100910,
            ProductTransfer = 9081010,

            GoodsReceipt = 8077,
            MaterialReceipt = 10081008,
            RawReceipt = 1008100810,
            ItemReceipt = 10081009,
            HeapReceipt = 1008100910,
            ProductReceipt = 10081010,
            WareReceipt = 1008101010,

            SimpleReceipt = 8868001,
            SimpleIssue = 8886,
            SimpleIssuePlus = 8886333,

            Maintenance = 600068
        }

        public enum ActiveOption
        {
            Active = 0,
            InActive = 1,
            Both = -1
        }

        public static int RootNode = 999999900; //1 billion
        public static int AncestorNode = 1000000000; //1 billion

        public enum GoodsReceiptTypeID
        {
            AllGoodsReceipt = 999,
            PurchaseInvoice = 1,
            SalesReturn = 2,
            StockTransfer = 3,
            InventoryAdjustment = 4, //ERP VCP VB6
            WarehouseAdjustments = 5,
            GoodsArrival = 6,
            PurchaseRequisition = 61,
            MaterialIssue = 7,
            FinishedProduct = 8,
            FinishedItem = 18,
            FinishedStuff = 28,
            RefinedStuff = 29,
            Recyclate = 19,
            SemifinishedRecyclate = 20,
            SemifinishedWare = 68,

            ProductionFinish = 908, //ERmgrVCP

            WarehouseTransfer = 9,

            GoodsIssueTransfer = 3333,
            Pickup = 686868
        };

        public enum PlannedOrderTypeID
        {
            AllGoodsReceipt = 999,
            NoOrders = 1,
            SalesOrders = 2,
            TransferOrders = 3
        };

        public enum MaterialIssueTypeID
        {
            AllMaterialIssue = 999,
            FirmOrders = 6
        };

        public enum WarehouseAdjustmentTypeID
        {
            ALL = 0,

            ReceiptPRO = 10, // Production - Nhập kho hàng hóa để phục vụ công đoạn sản xuất.
            ReceiptSAM = 11, // Sample - Nhập kho hàng mẫu dùng để thử nghiệm hoặc quảng cáo.
            ReceiptRTN = 12, // Return - Nhập kho hàng bị trả lại từ khách hàng hoặc nhà cung cấp.
            ReceiptADJ = 13, // Adjustment - Nhập kho điều chỉnh do sai lệch số lượng hoặc kiểm kê kho.
            ReceiptPUR = 14, // Purchasing - Nhập kho từ đơn mua hàng (Purchase Order). 
            ReceiptREG = 15, // Regenerate - Nhập kho các hàng hóa đã qua tái chế hoặc sửa chữa.
            ReceiptOSS = 16, // Outsourcing services - Nhập kho hàng hóa từ một đơn vị gia công hoặc bên thứ ba sau khi đã hoàn thành gia công, xử lý hoặc kiểm tra.
            ReceiptBOR = 17, // Borrow - Nhập kho hàng mượn, có thể từ đối tác hoặc nội bộ.
            ReceiptFOI = 19, // Foil - Nhập kho giấy bạc (Foil), có thể áp dụng cho ngành in ấn, bao bì.
            ReceiptTXF = 25, // Transfer - Nhập kho hàng hóa được chuyển kho từ một kho khác.
            ReceiptOTH = 18, // Other - Nhập kho khác (không thuộc các danh mục trên).

            IssueINV = 60, // Invoicing (Sales) - Xuất kho hóa đơn bán hàng – Hàng được xuất kho để bán cho khách hàng.
            IssueOFS = 61, // Offset - Xuất kho bù trừ (Offset) – Điều chỉnh số lượng hàng hóa trong kho để bù trừ chênh lệch nhỏ, không đáng kể trong kiểm kê.
            IssueADJ = 62, // Adjustment - Xuất kho để điều chỉnh tồn kho khi có sai sót, liên quan đến kiểm kê tổng thể.
            IssueSAM = 63, // Sample - Xuất kho hàng được xuất kho để làm mẫu, thử nghiệm hoặc quảng bá.
            IssueDST = 64, // Destroy - Xuất kho hàng bị hỏng hoặc không đạt tiêu chuẩn phải bị hủy bỏ.
            IssuePRO = 65, // Production - Xuất kho hàng hóa để phục vụ công đoạn sản xuất.
            IssueREG = 66, // Regenerate - Xuất kho hàng hóa cần tái chế hoặc sửa chữa.
            IssueRTN = 67, // Return - Xuất kho hàng để trả lại nhà cung cấp.
            IssueOSS = 68, // Outsourcing services - Xuất kho hàng cho đơn vị gia công hoặc kiểm định bên ngoài.
            IssueTXF = 75, // Transfer - Xuất kho hàng cần chuyển kho từ một kho này đến kho khác.
            IssueOTH = 69, // Other - Xuất kho khác (không thuộc các loại đã liệt kê).

            BothReceiptIssues = 90, // Cả nhập và xuất kho, Áp dụng cho các giao dịch có cả nhập và xuất kho.

            ReceiptPENDING = 110, // Phục vụ Production - Sử dụng cho trường hợp hàng đã nhập kho nhưng chưa được xác nhận.
            IssuePENDING = 160, // Phục vụ Production - Sử dụng cho trường hợp hàng đã được đánh dấu để xuất kho nhưng chưa hoàn tất.
            RevokeLoss = 180 // RevokeDateLoss (MATERIAL LOSS) - Điều chỉnh do tổn thất vật tư, hàng hóa bị mất mát hoặc hỏng hóc cần điều chỉnh.
        };

        public enum SalesInvoiceTypeID
        {
            AllInvoice = 1,
            VehiclesInvoice = 10,
            PartsInvoice = 20,
            ServicesInvoice = 30
        };

        public enum StockTransferTypeID
        {
            VehicleTransfer = 10,
            PartTransfer = 20
        };

        public enum ServiceContractTypeID
        {
            Warranty = 1,
            Repair = 2,
            Maintenance = 3
        };

        public enum InventoryAdjustmentTypeID
        {
            AllAdjustment = 1,
            VehicleAdjustment = 10,
            PartAdjustment = 20
        };

        public enum CommodityTypeID
        {
            All = 999,

            Products = 1,
            Items = 2,
            Materials = 3,

            Consumables = 3333,
            Services = 6,
            CreditNote = 8,

            Unknown = 99
        };

        public static CommodityTypeID GetCommodityTypeID(GlobalEnums.NmvnTaskID nmvnTaskID, int? commodityCategoryID)
        {
            switch (nmvnTaskID)
            {
                case GlobalEnums.NmvnTaskID.Material:
                    return GlobalEnums.CommodityTypeID.Materials;

                case GlobalEnums.NmvnTaskID.Item:
                    return GlobalEnums.CommodityTypeID.Items;

                case GlobalEnums.NmvnTaskID.Product:
                    // Nếu HLM được bật và commodityCategoryID == 4, trả về Services, ngược lại trả về Products
                    return (GlobalEnums.HLM && commodityCategoryID == 4)
                        ? GlobalEnums.CommodityTypeID.Services
                        : GlobalEnums.CommodityTypeID.Products;

                default:
                    return GlobalEnums.CommodityTypeID.Unknown;
            }
        }

        public enum WarehouseTaskID
        {
            Unknown = -1,

            PurchaseOrder = 8021,
            GoodsArrival = 8022,

            SalesOrder = 8032,
            DeliveryAdvice = 8035,
            SalesReturn = 8038,

            MaterialAdjustment = 8036006,
            ItemAdjustment = 8036007,
            ProductAdjustment = 8036008,

            MaterialTransferOrder = 8081008,
            ItemTransferOrder = 8081009,
            ProductTransferOrder = 8081010
        };

        public enum WarehouseClassID
        {
            L1 = 1,// Loại 1
            L2 = 2,// Loại 2
            L3 = 3,// Loại 3
            TU = 4,// Thiếu
            TA = 5,// Thừa
            LD = 9 // Lên Đời
        }

        public enum WarehouseGroupID
        {
            CO = 1,
            HD = 2,
            MT = 3,
            TT = 4,
            XK = 5,
            ST = 6,
            BC = 7
        }

        public enum WarehouseID
        {
            MA = 1, // MATERIAL
            IT = 2, // ITEM
            FP = 3, // FINISHED PRODUCT
            RC = 5, // Recyclates
            PW = 6  // PRODUCTION WAREHOUSE
        }

        public enum ReceiptTypeID
        {
            ReceiveMoney = 1,
            ApplyCredit = 2
        };

        public enum ReceiptOptionID
        {
            Others = 0,
            Debtors = 1
        };

        public enum PaymentTypeID
        {
            SettleMoney = 1,
            ApplyDebit = 2
        };

        public enum PaymentOptionID
        {
            Others = 0,
            Credits = 1
        };

        public static int ApplyToSalesVersusReturns_ApplyToAll = (int)GlobalEnums.ApplyToSalesVersusReturns.ApplyToAll;
        public enum ApplyToSalesVersusReturns
        {
            ApplyToAll = 0,
            ApplyToSales = 1,
            ApplyToReturns = -1
        };

        public enum UpdateWarehouseBalanceOption
        {
            Add = 1,
            Minus = -1
        };

        public enum AccessLevel
        {
            Deny = 0,
            Readable = 1,
            Editable = 2
        };

        public enum FillingLine
        {
            None = 0,
            Smallpack = 1,
            Pail = 2,
            Drum = 3,

            BatchMaster = 18,

            TDV = 68,
            GoodsIssue = 88
        }

        public static int ConfigID = (int)GlobalEnums.FillingLine.TDV;
        public static int ConfigVersionID(int configID)
        {
            if (GlobalEnums.TDV)
                return 88;
            else if (GlobalEnums.DMC)
                return 88;
            else if (GlobalEnums.TTP)
                return 888;
            else if (GlobalEnums.HLM)
                return 86;

            else if (configID == (int)GlobalEnums.FillingLine.None)
                return 88;
            else if (configID == (int)GlobalEnums.FillingLine.TDV)
                return 88;
            else if (configID == (int)GlobalEnums.FillingLine.GoodsIssue)
                return 88;
            else if (configID == (int)GlobalEnums.FillingLine.BatchMaster)
                return 88;

            else if (configID == (int)GlobalEnums.FillingLine.Smallpack || configID == (int)GlobalEnums.FillingLine.Pail || configID == (int)GlobalEnums.FillingLine.Drum)
                return 2; //PAY ATTENTION WHEN CHANGE THIS VALUE BECAUSE: THIS IS USING ON THE FILLING LINES
            else
                return -1;
        }

        public static int MaxConfigVersionID()
        {
            int maxConfigVersionID = 0;
            foreach (GlobalEnums.FillingLine fillingLine in Enum.GetValues(typeof(GlobalEnums.FillingLine)))
            {
                if (maxConfigVersionID < GlobalEnums.ConfigVersionID((int)fillingLine))
                    maxConfigVersionID = GlobalEnums.ConfigVersionID((int)fillingLine);
            }

            return maxConfigVersionID;
        }

        public static int GetRndQuantity(int warehouseID)
        {
            return rndN0WarehouseID.IndexOf(warehouseID.ToString()) > 0 ? GlobalEnums.rndN0 : GlobalEnums.rndQuantity;
        }
        public static int GetRndPrice(int currencyID)
        {
            return currencyID == 1 ? 0 : 4;
        }

        public static string GetRndPriceSQL(string currencyID)
        {
            return "IIF(" + (currencyID ?? "CurrencyID") + " IS NULL, " + (int)GlobalEnums.rndPrice + ", IIF(" + (currencyID ?? "CurrencyID") + " = 1, 0, 4))";
        }

        public static int GetRndAmount(int currencyID)
        {
            return currencyID == 1 ? 0 : 2;
        }
    }

    public static class GlobalReceiptTypeID
    {
        public static int ApplyCredit
        {
            get
            {
                return (int)GlobalEnums.ReceiptTypeID.ApplyCredit;
            }
        }
        public static int ReceiveMoney
        {
            get
            {
                return (int)GlobalEnums.ReceiptTypeID.ReceiveMoney;
            }
        }
    }

    public static class GlobalCreditTypeID
    {
        public static int AdvanceReceipt
        {
            get
            {
                return (int)GlobalEnums.NmvnTaskID.Receipt;
            }
        }
        public static int SalesReturn
        {
            get
            {
                return (int)GlobalEnums.NmvnTaskID.SalesReturn;
            }
        }
        public static int CreditNote
        {
            get
            {
                return (int)GlobalEnums.NmvnTaskID.CreditNote;
            }
        }
    }


    public static class GlobalPaymentTypeID
    {
        public static int ApplyDebit
        {
            get
            {
                return (int)GlobalEnums.PaymentTypeID.ApplyDebit;
            }
        }
        public static int SettleMoney
        {
            get
            {
                return (int)GlobalEnums.PaymentTypeID.SettleMoney;
            }
        }
    }

    public static class GlobalDebitTypeID
    {
        public static int AdvancePayment
        {
            get
            {
                return (int)GlobalEnums.NmvnTaskID.Payment;
            }
        }
        public static int PurchaseReturn
        {
            get
            {
                return (int)GlobalEnums.NmvnTaskID.PurchaseReturn;
            }
        }
        public static int DebitNote
        {
            get
            {
                return (int)GlobalEnums.NmvnTaskID.DebitNote;
            }
        }
    }
}
