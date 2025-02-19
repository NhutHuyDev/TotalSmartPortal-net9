﻿using TotalBase.Enums;

namespace TotalBase
{
    public static class ModelSettingManager
    {
        public static int ReferenceLength = 6;

        public static string ReferencePrefix(GlobalEnums.NmvnTaskID nmvnTaskID)
        {
            switch (nmvnTaskID)
            {
                case GlobalEnums.NmvnTaskID.Customer:
                    return @"CASE WHEN @IsSupplier = 1 THEN 'S' ELSE 'C' END ";

                case GlobalEnums.NmvnTaskID.Maintenance:
                    return "M";

                case GlobalEnums.NmvnTaskID.PurchaseRequisition:
                    return "PR";
                case GlobalEnums.NmvnTaskID.PurchaseItem:
                    return "PO";
                case GlobalEnums.NmvnTaskID.ItemArrival:
                    return "GA";
                case GlobalEnums.NmvnTaskID.Lab:
                    return "LB";

                case GlobalEnums.NmvnTaskID.GoodsArrival:
                    return "GA";

                case GlobalEnums.NmvnTaskID.BlendingInstruction:
                    return "BI";

                case GlobalEnums.NmvnTaskID.PlannedOrder:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.PlannedItem + @" THEN 'PM' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.PlannedProduct + @" THEN 'PL' ELSE '#' END
                             END ";

                case GlobalEnums.NmvnTaskID.ProductionOrder:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemOrder + @" THEN 'IO' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductOrder + @" THEN 'KO' ELSE '#' END
                             END ";

                case GlobalEnums.NmvnTaskID.WorkPlan:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.WorkPlanItem + @" THEN 'IP' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.WorkPlanProduct + @" THEN 'PP' ELSE '#' END
                             END ";

                case GlobalEnums.NmvnTaskID.RefinedOrder:
                    return "RS";
                case GlobalEnums.NmvnTaskID.SemifinishedItemOrder:
                    return "TR";
                case GlobalEnums.NmvnTaskID.SemifinishedItem:
                    return "L";
                case GlobalEnums.NmvnTaskID.SemifinishedProduct:
                    return "P";
                case GlobalEnums.NmvnTaskID.SemifinishedStuff:
                    return "CX";
                case GlobalEnums.NmvnTaskID.SemifinishedWare:
                    return "SX";

                case GlobalEnums.NmvnTaskID.Recyclate:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.SemifinishedProductRecyclate + @" THEN 'RP' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.FinishedProductRecyclate + @" THEN 'RK' ELSE
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.SemifinishedItemRecyclate + @" THEN 'RH' ELSE
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.FinishedItemRecyclate + @" THEN 'RM' ELSE
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductRecyclate + @" THEN 'TK' ELSE
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemRecyclate + @" THEN 'TM' ELSE '#' END
                             END END END END END ";

                case GlobalEnums.NmvnTaskID.SemifinishedHandover:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.SemifinishedItemHandover + @" THEN 'HI' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.SemifinishedProductHandover + @" THEN 'HP' ELSE '#' END
                             END ";

                case GlobalEnums.NmvnTaskID.WorkOrder:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialWorkOrder + @" THEN 'MW' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemWorkOrder + @" THEN 'MW' ELSE
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductWorkOrder + @" THEN 'MW' ELSE '#' END
                             END END ";

                case GlobalEnums.NmvnTaskID.MaterialIssue:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialStaging + @" THEN 'ME' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemStaging + @" THEN 'MI' ELSE
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductStaging + @" THEN 'MP' ELSE '#' END
                             END END ";

                case GlobalEnums.NmvnTaskID.RecyclateIssue:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.RecyclateIssue + @" THEN 'RI' ELSE '#'
                             END ";
                case GlobalEnums.NmvnTaskID.SemifinishedRecyclate:
                    return "RF";

                case GlobalEnums.NmvnTaskID.PackageIssue:
                    return "PI";

                case GlobalEnums.NmvnTaskID.FinishedHandover:
                    return "V";

                case GlobalEnums.NmvnTaskID.FinishedItem:
                    return "FI";
                case GlobalEnums.NmvnTaskID.FinishedProduct:
                    return "F";
                case GlobalEnums.NmvnTaskID.FinishedStuff:
                    return "E";

                case GlobalEnums.NmvnTaskID.RefinedStuff:
                    return "BT";

                case GlobalEnums.NmvnTaskID.SalesOrder:
                    return "O";
                case GlobalEnums.NmvnTaskID.DeliveryAdvice:
                    return "D";
                case GlobalEnums.NmvnTaskID.SalesReturn:
                    return "SR";

                case GlobalEnums.NmvnTaskID.SellingIssue:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialSellingIssue + @" THEN 'R' ELSE
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemSellingIssue + @" THEN 'E' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductSellingIssue + @" THEN 'K' ELSE '#' END
                             END END";
                case GlobalEnums.NmvnTaskID.HandlingUnit:
                    return "C";
                case GlobalEnums.NmvnTaskID.GoodsDelivery:
                    return "GH";

                case GlobalEnums.NmvnTaskID.Quotation:
                    return "Q";

                case GlobalEnums.NmvnTaskID.SalesInvoice:
                    return @"CASE WHEN @SalesInvoiceTypeID = 
                                    " + (int)GlobalEnums.SalesInvoiceTypeID.VehiclesInvoice + @" THEN 'X' ELSE 
                             CASE WHEN @SalesInvoiceTypeID = 
                                    " + (int)GlobalEnums.SalesInvoiceTypeID.PartsInvoice + @" THEN 'Z' ELSE 
                             CASE WHEN @SalesInvoiceTypeID = 
                                    " + (int)GlobalEnums.SalesInvoiceTypeID.ServicesInvoice + @" THEN 'S' ELSE '#' END
                             END END";

                case GlobalEnums.NmvnTaskID.AccountInvoice:
                    return "X";
                case GlobalEnums.NmvnTaskID.Receipt:
                    return "R";
                case GlobalEnums.NmvnTaskID.CreditNote:
                    return "CR";

                case GlobalEnums.NmvnTaskID.GoodsReceipt:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialReceipt + @" AND @LocationID = 1 THEN 'N' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialReceipt + @" AND @LocationID = 2 THEN 'H' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemReceipt + @" AND @LocationID = 1 THEN 'M' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemReceipt + @" AND @LocationID = 2 THEN 'D' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductReceipt + @" AND @LocationID = 1 THEN 'T' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductReceipt + @" AND @LocationID = 2 THEN 'B' ELSE '#' END
                             END END END END END";

                case GlobalEnums.NmvnTaskID.TransferOrder:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialTransferOrder + @" AND @LocationID = 1 THEN 'TH' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialTransferOrder + @" AND @LocationID = 2 THEN 'TR' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemTransferOrder + @" AND @LocationID = 1 THEN 'TD' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemTransferOrder + @" AND @LocationID = 2 THEN 'TO' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductTransferOrder + @" AND @LocationID = 1 THEN 'TK' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductTransferOrder + @" AND @LocationID = 2 THEN 'TP' ELSE '#' END
                             END END END END END";

                case GlobalEnums.NmvnTaskID.WarehouseTransfer:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialTransfer + @" AND @LocationID = 1 THEN 'NC' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialTransfer + @" AND @LocationID = 2 THEN 'HC' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemTransfer + @" AND @LocationID = 1 THEN 'MC' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemTransfer + @" AND @LocationID = 2 THEN 'DC' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductTransfer + @" AND @LocationID = 1 THEN 'TC' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductTransfer + @" AND @LocationID = 2 THEN 'KC' ELSE '#' END
                             END END END END END";

                case GlobalEnums.NmvnTaskID.WarehouseAdjustment:
                    return @"CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.MaterialAdjustment + @" THEN 'NA' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.OtherMaterialReceipt + @" THEN 'NN' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.OtherMaterialIssue + @" THEN 'NX' ELSE 


                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ItemAdjustment + @" THEN 'MA' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.OtherItemReceipt + @" THEN 'MN' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.OtherItemIssue + @" THEN 'MX' ELSE 


                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.ProductAdjustment + @" THEN 'TA' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.OtherProductReceipt + @" THEN 'TN' ELSE 
                             CASE WHEN @NmvnTaskID = 
                                    " + (int)GlobalEnums.NmvnTaskID.OtherProductIssue + @" THEN 'TX' ELSE '#' END

                             END END END END END END END END";

                case GlobalEnums.NmvnTaskID.ServiceContract:
                    return "SC";


                case GlobalEnums.NmvnTaskID.StockTransfer:
                    return @"CASE WHEN @StockTransferTypeID = 
                                    " + (int)GlobalEnums.StockTransferTypeID.VehicleTransfer + @" THEN 'DX' ELSE 
                             CASE WHEN @StockTransferTypeID = 
                                    " + (int)GlobalEnums.StockTransferTypeID.PartTransfer + @" THEN 'DP' ELSE '#' END 
                             END";
                case GlobalEnums.NmvnTaskID.InventoryAdjustment:
                    return @"CASE WHEN @InventoryAdjustmentTypeID = 
                                    " + (int)GlobalEnums.InventoryAdjustmentTypeID.VehicleAdjustment + @" THEN 'AX' ELSE 
                             CASE WHEN @InventoryAdjustmentTypeID = 
                                    " + (int)GlobalEnums.InventoryAdjustmentTypeID.PartAdjustment + @" THEN 'AP' ELSE '#' END 
                             END";

                case GlobalEnums.NmvnTaskID.Promotion:
                    return "PS";

                default:
                    return "A";
            }
        }
    }
}
