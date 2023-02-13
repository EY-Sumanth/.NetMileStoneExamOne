using System;
using System.Collections.Generic;

namespace MileStone1_Feb13.Models
{
	//This class field shows the details of BOOK  which we will be given 
	public partial class TBookDetail
    {
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public int? AuthorId { get; set; }
        public int? PageCount { get; set; }
    }
}
