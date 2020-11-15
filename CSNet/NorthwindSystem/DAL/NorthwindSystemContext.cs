﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespace
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using NorthwindSystem.Entities;
#endregion

namespace NorthwindSystem.DAL
{
    //restrict access to this class so ONLY other classes within this library has access priviledge
    //security measure

    //connect this class to EnntityFramework by inheriting DbContext
    internal class NorthwindSystemContext:DbContext
    {
        //you will need a constructor that passes the connection string name to EntityFramework via the
        //      inherited class DbContext
        //base refers to :DbContext
        public NorthwindSystemContext() : base("NWDB")
        {
           
        }
            //properties to interact with EntityFramework
            //these properties represent the whole table and all data  of the SQL database

        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
