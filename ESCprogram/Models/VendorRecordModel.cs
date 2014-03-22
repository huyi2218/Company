using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ESCprogram.Models
{
    public class VendorRecordModel
    {
        public int ID { get; set; }
        public string topic { get; set; }
        public int totalthreads { get; set; }
        public int escthreads { get; set; }
        public int oobthreads { get; set; }
        public string alias { get; set; }
        public DateTime recordtime { get; set; }
             
    }
    public class VendorRecordModelDBContext : DbContext
    {
        public DbSet<VendorRecordModel> VendorRecords { get; set; }
    }
}