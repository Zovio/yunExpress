//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using LMS.Data.Entity;
    
    
    internal partial class CustomerOrderInfo_Mapping : EntityTypeConfiguration<CustomerOrderInfo>
    {
        public CustomerOrderInfo_Mapping()
        {                        
              this.HasKey(t => t.CustomerOrderID);        
              this.ToTable("CustomerOrderInfos");
              this.Property(t => t.CustomerOrderID).HasColumnName("CustomerOrderID");
              this.Property(t => t.CustomerOrderNumber).HasColumnName("CustomerOrderNumber").HasMaxLength(50);
              this.Property(t => t.CustomerCode).HasColumnName("CustomerCode").HasMaxLength(20);
              this.Property(t => t.TrackingNumber).HasColumnName("TrackingNumber").HasMaxLength(50);
              this.Property(t => t.ShippingMethodId).HasColumnName("ShippingMethodId");
              this.Property(t => t.ShippingMethodName).HasColumnName("ShippingMethodName").HasMaxLength(100);
              this.Property(t => t.ShippingInfoID).HasColumnName("ShippingInfoID");
              this.Property(t => t.SenderInfoID).HasColumnName("SenderInfoID");
              this.Property(t => t.GoodsTypeID).HasColumnName("GoodsTypeID");
              this.Property(t => t.IsReturn).HasColumnName("IsReturn");
              this.Property(t => t.IsInsured).HasColumnName("IsInsured");
              this.Property(t => t.IsBattery).HasColumnName("IsBattery");
              this.Property(t => t.IsHold).HasColumnName("IsHold");
              this.Property(t => t.InsuredID).HasColumnName("InsuredID");
              this.Property(t => t.IsPrinted).HasColumnName("IsPrinted");
              this.Property(t => t.Status).HasColumnName("Status");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
              this.Property(t => t.SensitiveTypeID).HasColumnName("SensitiveTypeID");
              this.Property(t => t.PackageNumber).HasColumnName("PackageNumber");
              this.Property(t => t.InsureAmount).HasColumnName("InsureAmount");
              this.Property(t => t.AppLicationType).HasColumnName("AppLicationType");
              this.Property(t => t.Weight).HasColumnName("Weight");
              this.Property(t => t.Length).HasColumnName("Length");
              this.Property(t => t.Width).HasColumnName("Width");
              this.Property(t => t.Height).HasColumnName("Height");
              this.Property(t => t.EnableTariffPrepay).HasColumnName("EnableTariffPrepay");
              this.Property(t => t.Remark).HasColumnName("Remark").HasMaxLength(500);
              this.HasOptional(t => t.GoodsTypeInfo).WithMany(t => t.CustomerOrderInfos).HasForeignKey(d => d.GoodsTypeID);
              this.HasOptional(t => t.InsuredCalculation).WithMany(t => t.CustomerOrderInfos).HasForeignKey(d => d.InsuredID);
              this.HasOptional(t => t.SensitiveTypeInfo).WithMany(t => t.CustomerOrderInfos).HasForeignKey(d => d.SensitiveTypeID);
              this.HasOptional(t => t.ShippingInfo).WithMany(t => t.CustomerOrderInfos).HasForeignKey(d => d.ShippingInfoID);
              this.HasOptional(t => t.SenderInfo).WithMany(t => t.CustomerOrderInfos).HasForeignKey(d => d.SenderInfoID);
         }
    }
}