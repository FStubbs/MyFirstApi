using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Api.Models;
using MyFirstApi.Library.Repositories;

namespace MyFirstApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController: ControllerBase
    {
        private readonly IWordRepository _wordRepository;

        public WordsController(IWordRepository wordRepository) 
        {
            _wordRepository = wordRepository;
        }

        [HttpPost("reverse/{word}")]
        public async Task<string> ReverseWord(string word) 
        {
            return await Task.FromResult(_wordRepository.ReverseWord(word));
        }

        [HttpPost("hello")]
        public async Task<IEnumerable<string>> SayHello(SayHelloRequest request) 
        {
            return await Task.FromResult(_wordRepository.SayHello(request.Recipient, request.Iterations));
        }
    }
}