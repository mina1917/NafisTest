using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilterSorting.Models
{
    public class ItemsWithDetailModel
    {
        // Flat view for grid display
        public long Id { get; set; }

        [DisplayName("Account Number")]
        [StringLength(16)]
        public string AccountNumber { get; set; }

        [StringLength(256)]
        [DisplayName("Account Name")]
        public string AccountName { get; set; }

        [StringLength(256)]
        [DisplayName("Issue Summary")]
        [Required]
        public string IssueSummary { get; set; }

        [StringLength(255)]
        [DisplayName("Assigned 1")]
        public string Assigned1 { get; set; }

        [StringLength(255)]
        [DisplayName("Assigned 2")]
        public string Assigned2 { get; set; }

        [DisplayName("Date Opened")]
        public DateTime? OpenDate { get; set; }

        [DisplayName("Date Closed")]
        public DateTime? CloseDate { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [StringLength(4)]
        [DisplayName("Rep Code")]
        public string Rep { get; set; }

        [DisplayName("FA Name")]
        public string FaName { get; set; }

    }
}
