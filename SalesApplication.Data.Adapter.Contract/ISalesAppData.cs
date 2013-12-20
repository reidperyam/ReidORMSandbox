﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApplication.Data.Adapter.Contract
{
    /// <summary>
    /// This interface abstracts all data-retrieval operations required by the SalesApplication
    /// </summary>
    public interface ISalesAppData
    {
        // TODO define all data operations wanted/needed by the SalesApplication
        IEnumerable<dynamic> GetAllCustomers();

        IEnumerable<dynamic> GetAllAddresses();

        IEnumerable<dynamic> GetAllPhoneNumbers();

        Type ORM { get; }
    }
}
