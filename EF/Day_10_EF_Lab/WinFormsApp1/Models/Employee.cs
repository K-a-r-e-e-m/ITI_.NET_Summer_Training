﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Models;

[Table("Employee")]
public partial class Employee
{
    [StringLength(50)]
    public string Fname { get; set; }

    [StringLength(50)]
    public string Lname { get; set; }

    [Key]
    public int SSN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Bdate { get; set; }

    [StringLength(50)]
    public string Address { get; set; }

    [StringLength(50)]
    public string Sex { get; set; }

    public int? Salary { get; set; }

    public int? Superssn { get; set; }

    public int? Dno { get; set; }

    [InverseProperty("MGRSSNNavigation")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [InverseProperty("ESSNNavigation")]
    public virtual ICollection<Dependent> Dependents { get; set; } = new List<Dependent>();

    [ForeignKey("Dno")]
    [InverseProperty("Employees")]
    public virtual Department DnoNavigation { get; set; }

    [InverseProperty("SuperssnNavigation")]
    public virtual ICollection<Employee> InverseSuperssnNavigation { get; set; } = new List<Employee>();

    [ForeignKey("Superssn")]
    [InverseProperty("InverseSuperssnNavigation")]
    public virtual Employee SuperssnNavigation { get; set; }

    [InverseProperty("ESSnNavigation")]
    public virtual ICollection<Works_for> Works_fors { get; set; } = new List<Works_for>();
}