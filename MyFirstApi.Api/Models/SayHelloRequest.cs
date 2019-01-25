namespace MyFirstApi.Api.Models
{
    public class SayHelloRequest
    {
        public string Recipient { get; set;}
        public int Iterations { get; set; } = 5;
    }
}