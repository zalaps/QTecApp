﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTec.Hrms.DataTier.Repositories
{
    using System.Data.Entity;

    using QTec.Hrms.DataTier.Contracts;
    using QTec.Hrms.Models;

    /// <summary>
    /// Employee Repository
    /// </summary>
    public class EmployeeRepository : EFRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        /// <summary>
        /// Determines whether the specified email id exists or not.
        /// </summary>
        /// <param name="emailId">The email id.</param>
        /// <returns>true if exists else returns false</returns>
        public bool IsEmailDuplicate(string emailId)
        {
            // TODO: Implement this method
            return false;

        }
    }
}
