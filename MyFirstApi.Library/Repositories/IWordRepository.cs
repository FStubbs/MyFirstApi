using System.Collections.Generic;

namespace MyFirstApi.Library.Repositories
{
    public interface IWordRepository
    {
        string ReverseWord(string word);
        IEnumerable<string> SayHello(string recipient, int iterations);
    }
}