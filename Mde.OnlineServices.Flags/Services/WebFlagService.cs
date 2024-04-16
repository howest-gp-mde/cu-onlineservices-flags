using Mde.OnlineServices.Flags.Dtos;
using Mde.OnlineServices.Flags.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Mde.OnlineServices.Flags.Services
{
    public class WebFlagService : IFlagService
    {
        private readonly HttpClient _httpClient;
        public WebFlagService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient(Constants.FlagsClientName);
        }
        public async Task<IEnumerable<Flag>> GetFlags()
        {
            try
            {
                var flags = await _httpClient.GetFromJsonAsync<List<FlagDto>>("/flags");
                return flags.Select(flagdto => new Flag { Country = flagdto.CountryName, FlagImage = $"{Constants.FlagsApiUrl}/images/flags/{flagdto.Image}" });
            }
            catch
            {
                return new List<Flag>();
            }
        }
    }
}
