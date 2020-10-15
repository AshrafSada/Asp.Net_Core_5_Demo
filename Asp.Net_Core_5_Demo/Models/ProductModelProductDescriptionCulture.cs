﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Asp.Net_Core_5_Demo.Models
{
    /// <summary>
    /// Cross-reference table mapping product descriptions and the language the description is written in.
    /// </summary>
    [Table("ProductModelProductDescriptionCulture", Schema = "Production")]
    public partial class ProductModelProductDescriptionCulture
    {
        /// <summary>
        /// Primary key. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        [Key]
        [Column("ProductModelID")]
        public int ProductModelId { get; set; }
        /// <summary>
        /// Primary key. Foreign key to ProductDescription.ProductDescriptionID.
        /// </summary>
        [Key]
        [Column("ProductDescriptionID")]
        public int ProductDescriptionId { get; set; }
        /// <summary>
        /// Culture identification number. Foreign key to Culture.CultureID.
        /// </summary>
        [Key]
        [Column("CultureID")]
        [StringLength(6)]
        public string CultureId { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(CultureId))]
        [InverseProperty("ProductModelProductDescriptionCultures")]
        public virtual Culture Culture { get; set; }
        [ForeignKey(nameof(ProductDescriptionId))]
        [InverseProperty("ProductModelProductDescriptionCultures")]
        public virtual ProductDescription ProductDescription { get; set; }
        [ForeignKey(nameof(ProductModelId))]
        [InverseProperty("ProductModelProductDescriptionCultures")]
        public virtual ProductModel ProductModel { get; set; }
    }
}