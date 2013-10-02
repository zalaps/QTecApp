﻿namespace QTec.Hrms.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Required,MaxLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [Required, MaxLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the designation id.
        /// </summary>
        public int DesignationId { get; set; }

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        public virtual Designation Designation { get; set; }   // Navigational Property

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [Required, MaxLength(50)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        [MaxLength(10)]
        public string Gender { get; set; }
    }
}
