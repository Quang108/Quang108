﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DXApplication2.Module.BusinessObjects.ORMDataModel1
{

    [DefaultProperty("TenSP")]
    public partial class SanPham : Dinhluong
    {
        string fTenSP;
        [Size(30)]
        [DevExpress.Xpo.DisplayName(@"Tên sản phẩm")]
        public string TenSP
        {
            get { return fTenSP; }
            set { SetPropertyValue<string>(nameof(TenSP), ref fTenSP, value); }
        }
        string fDvt;
        [Size(20)]
        [DevExpress.Xpo.DisplayName(@"Đơn vị tính")]
        public string Dvt
        {
            get { return fDvt; }
            set { SetPropertyValue<string>(nameof(Dvt), ref fDvt, value); }
        }
        decimal fGiaban;
        [DevExpress.Xpo.DisplayName(@"Giá bán")]
        [
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "### ### ### ###"),
DevExpress.ExpressApp.Model.ModelDefault("EditMask", "### ### ### ###")
]
        public decimal Giaban
        {
            get { return fGiaban; }
            set { SetPropertyValue<decimal>(nameof(Giaban), ref fGiaban, value); }
        }
        NhomSP fNhomID;
        [Size(30)]
        [Association(@"SanPhamReferencesNhomSP")]
        [DevExpress.Xpo.DisplayName(@"Nhóm ID")]
        public NhomSP NhomID
        {
            get { return fNhomID; }
            set { SetPropertyValue<NhomSP>(nameof(NhomID), ref fNhomID, value); }
        }
        [Association(@"HoadonCTReferencesSanPham"), Aggregated]
        public XPCollection<HoadonCT> HoadonCTs { get { return GetCollection<HoadonCT>(nameof(HoadonCTs)); } }
        [Association(@"TieuhaoReferencesSanPham"), Aggregated]
        public XPCollection<Tieuhao> Tieuhaos { get { return GetCollection<Tieuhao>(nameof(Tieuhaos)); } }
        [Association(@"DinhluongReferencesSanPham"), Aggregated]
        public XPCollection<Dinhluong> Dinhluongs { get { return GetCollection<Dinhluong>(nameof(Dinhluongs)); } }
        [Association(@"DongnhapReferencesSanPham"), Aggregated]
        public XPCollection<Dongnhap> Dongnhaps { get { return GetCollection<Dongnhap>(nameof(Dongnhaps)); } }
    }

}