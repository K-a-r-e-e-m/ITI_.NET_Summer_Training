﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Models;

[PrimaryKey("ESSn", "Pno")]
[Table("Works_for")]
public partial class Works_for
{
    [Key]
    public int ESSn { get; set; }

    [Key]
    public int Pno { get; set; }

    public int? Hours { get; set; }

    [ForeignKey("ESSn")]
    [InverseProperty("Works_fors")]
    public virtual Employee ESSnNavigation { get; set; }

    [ForeignKey("Pno")]
    [InverseProperty("Works_fors")]
    public virtual Project PnoNavigation { get; set; }
}