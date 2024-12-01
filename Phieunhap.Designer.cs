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

    [DefaultProperty("So")]
    public partial class Phieunhap : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Nhacungcap fNCCID;
        [Association(@"PhieunhapReferencesNhacungcap")]
        [DevExpress.Xpo.DisplayName(@"ID nhà cung cấp")]
        public Nhacungcap NCCID
        {
            get { return fNCCID; }
            set { SetPropertyValue<Nhacungcap>(nameof(NCCID), ref fNCCID, value); }
        }
        Nhanvien fNhanvienID;
        [Association(@"PhieunhapReferencesNhanvien")]
        [DevExpress.Xpo.DisplayName(@"ID Nhân viên")]
        public Nhanvien NhanvienID
        {
            get { return fNhanvienID; }
            set { SetPropertyValue<Nhanvien>(nameof(NhanvienID), ref fNhanvienID, value); }
        }
        string fSo;
        [DevExpress.Xpo.DisplayName(@"Số")]
        public string So
        {
            get { return fSo; }
            set { SetPropertyValue<string>(nameof(So), ref fSo, value); }
        }
        DateTime fNgay;
        [DevExpress.Xpo.DisplayName(@"Ngày")]
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime Ngay
        {
            get { return fNgay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref fNgay, value); }
        }
        [Association(@"DongnhapReferencesPhieunhap"), Aggregated]
        public XPCollection<Dongnhap> Dongnhaps { get { return GetCollection<Dongnhap>(nameof(Dongnhaps)); } }
    }

}
