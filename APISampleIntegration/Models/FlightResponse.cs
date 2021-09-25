using System;
using System.Collections.Generic;
using System.Text;

namespace APISampleIntegration.Models
{
    public class FlightResponse
    {
        string Origin { get; set; }
        string Destination { get; set; }
        double Currency { get; set; }
        string AirlineCode { get; set; }
    }
}
