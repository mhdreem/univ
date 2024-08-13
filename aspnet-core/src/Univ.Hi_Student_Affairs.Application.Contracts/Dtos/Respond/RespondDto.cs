namespace Univ.Hi_Student_Affairs.Dtos.Respond
{
    public class RespondDto
    {
        public bool? IsSuccess { get; set; }
        public string? Error { get; set; }
        public object? Result { get; set; }

        public long Total_Result_Count { get; set; }
    }
}
