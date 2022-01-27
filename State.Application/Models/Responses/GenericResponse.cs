namespace State.Application.Models.Responses
{
    public class GenericResponse
    {
        public GenericResponse(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}