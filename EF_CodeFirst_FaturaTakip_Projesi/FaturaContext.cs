﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst_FaturaTakip_Projesi
{
    public class FaturaContext:DbContext 
    {
        public FaturaContext() : base("name = cnn") { }
        public virtual DbSet<FaturaMaster> faturaMasters { get; set; }
        public virtual DbSet<FaturaDetay> faturaDetays { get; set; }
        //------------------------------------------------------------
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Birim> Birimler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        //----------------------------------------------------------------
        public virtual DbSet<Ilce> Ilceler { get; set; }
        public virtual DbSet<Il> Iller { get; set; }
        
    }
    [Table("FaturaMaster")]
    public class FaturaMaster
    {
        public FaturaMaster()
        {
            this.FaturaTarihi = DateTime.Now;
            this.OdemeTarihi = DateTime.Now;

            this.faturaDetay = new HashSet<FaturaDetay>();
            
        }
        [Key] 
        public int FaturaID { get; set; }
        //-------------------------------------------------------
       
        public int MusteriID { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public int IrsaliyeNo { get; set; }
        public DateTime OdemeTarihi { get; set; }
        //-----------------------------------------------------
        public virtual Musteri musteri { get; set; } 

        public virtual ICollection<FaturaDetay> faturaDetay { get; set; } 
        
    }
    //--------------------------------------------
    [Table("FaturaDetay")]
    public class FaturaDetay
    {
        public FaturaDetay()
        {
            this.Aciklama = " Vadesinden sonra ödenen faturalara -> %5 kanuni ceza faizi uygulanır!!! ";
        }
        [Key][Column(Order = 0)]
        public int FaturaID { get; set; }
        [Key][Column(Order = 1)]
        public int UrunID { get; set; }
        //-----------------------------------------
        public decimal Miktar { get; set; }
        public decimal ToplamFiyat { get; set; }
        public decimal KDV { get; set; }
        public decimal KDVliFiyat { get; set; }
        public string Aciklama { get; set; }
        //-----------------------------------------
        public virtual FaturaMaster faturaMaster { get; set; }
        public virtual Urun urun { get; set; }
    }
    //---------------------------------------------------
    [Table("Urun")]
    public class Urun
    {
        public Urun()
        {
            this.faturaDetay = new HashSet<FaturaDetay>();
        }
        [Key]
        public int UrunID { get; set; }
        //-------------------------------------
        public string UrunAdi { get; set; }
        public int UrunKodu { get; set; }
        public int BirimID { get; set; }
        public decimal BirimFiyati { get; set; }
        //---------------------------------------------------
        public virtual Birim birim { get; set; } 

        public virtual ICollection<FaturaDetay> faturaDetay { get; set; } 

    }
    [Table("Birim")]
    public class Birim
    {
        public Birim()
        {
            this.urun = new HashSet<Urun>();
        }
        [Key]
        public int BirimID { get; set; }
        public string BirimAdi { get; set; }
        //-----------------------------------------------
        public virtual ICollection<Urun> urun { get; set; }
    }
    [Table("Musteri")]
    public class Musteri
    {
        public Musteri()
        {
            this.faturaMaster = new HashSet<FaturaMaster>();
        }
        [Key]
        public int MusteriID { get; set; }
        //-----------------------------------------------
        public string MusteriUnvani { get; set; }
        public string MusteriAdresi { get; set; }
        public int IlceID { get; set; }
        //-------------------------------------------------
        public virtual Ilce ilce { get; set; }

        public virtual ICollection<FaturaMaster> faturaMaster { get; set; }


    }
    [Table("Il")]
    public class Il
    {
        public Il()
        {
            this.ilce = new HashSet<Ilce>();
        }
        [Key]
        public int IlID { get; set; }
        public string IlAdi { get; set; }
        //--------------------------------------------
        public virtual ICollection<Ilce> ilce { get; set; }
    }
    [Table("Ilce")]
    public class Ilce
    {
        public Ilce()
        {
            this.musteri = new HashSet<Musteri>();
        }
        [Key]
        public int IlceID { get; set; }
        public string IlceAdi { get; set; }
        public int IlID { get; set; }
        //--------------------------------------------
        public virtual Il il { get; set; }
        public virtual ICollection<Musteri> musteri { get; set; }
    }
    
}
