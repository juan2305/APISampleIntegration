using APISampleIntegration.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APISampleIntegration.Services
{
   public interface IFlightApiService
    {
        Task<FlightResponse> GetFlightResponseAsync();
    }
}
