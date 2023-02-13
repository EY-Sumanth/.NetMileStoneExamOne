using System;
using System.Collections.Generic;

namespace MileStone1_Feb13.Models
{
	//This class field shows the details of Student which we will be given 
	public partial class TStudentDetail
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int? StudentAge { get; set; }
        public string? StudentGender { get; set; }
        public int? StudentClass { get; set; }
    }
}
