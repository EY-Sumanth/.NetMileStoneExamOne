using System;
using System.Collections.Generic;

namespace MileStone1_Feb13.Models
{
    //This class field shows the details of Author which we will be given 
    public partial class TAuthorDetail
    {
        public int AuthorId { get; set; }
        public string? AuthorName { get; set; }
        public string? AuthorSurname { get; set; }
    }
}
