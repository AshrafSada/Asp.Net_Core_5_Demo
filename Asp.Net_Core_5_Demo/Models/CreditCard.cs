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
    /// Customer credit card information.
    /// </summary>
    [Table("CreditCard", Schema = "Sales")]
    [Index(nameof(CardNumber), Name = "AK_CreditCard_CardNumber", IsUnique = true)]
    public partial class CreditCard
    {
        public CreditCard()
        {
            PersonCreditCards = new HashSet<PersonCreditCard>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Primary key for CreditCard records.
        /// </summary>
        [Key]
        [Column("CreditCardID")]
        public int CreditCardId { get; set; }
        /// <summary>
        /// Credit card name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string CardType { get; set; }
        /// <summary>
        /// Credit card number.
        /// </summary>
        [Required]
        [StringLength(25)]
        public string CardNumber { get; set; }
        /// <summary>
        /// Credit card expiration month.
        /// </summary>
        public byte ExpMonth { get; set; }
        /// <summary>
        /// Credit card expiration year.
        /// </summary>
        public short ExpYear { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty(nameof(PersonCreditCard.CreditCard))]
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }
        [InverseProperty(nameof(SalesOrderHeader.CreditCard))]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}