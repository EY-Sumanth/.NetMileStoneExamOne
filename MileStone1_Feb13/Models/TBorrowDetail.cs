using System;
using System.Collections.Generic;

namespace MileStone1_Feb13.Models
{

	//This class field shows the details of Borrower which we will be given 
	public partial class TBorrowDetail
    {
        public int BorrowId { get; set; }
        public int? BookId { get; set; }
        public int? StudentId { get; set; }
        public DateTime? BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
