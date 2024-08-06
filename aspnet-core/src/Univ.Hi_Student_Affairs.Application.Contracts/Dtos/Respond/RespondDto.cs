using System;
using System.Collections.Generic;
using System.Text;

namespace Univ.Hi_Student_Affairs.Dtos.Respond
{
    public class RespondDto
    {
        public bool? IsSuccess { get; set; }
        public string? Error { get; set; }
        public object? Result { get; set; }

        public int? Total_Result_Count { get; set; }
    }
}
