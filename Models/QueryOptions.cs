﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Dynamic;
namespace ProfileWebsite.Models
{
    public class QueryOptions
    {
        public QueryOptions()
        {
            SortField = "Id";
            SortOrder = SortOrder.ASC;
        }

        public string SortField { get; set; }
        public SortOrder SortOrder { get; set; }
        public string Sort
        {
            get
            {
                return string.Format("{0} {1}",
                SortField, SortOrder.ToString());
            }
        }
    }
}