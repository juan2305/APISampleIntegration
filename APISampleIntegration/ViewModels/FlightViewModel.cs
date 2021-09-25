using APISampleIntegration.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace APISampleIntegration.ViewModels
{
   public class FlightViewModel : BaseViewModel
    {
       public string value { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string gate { get; set; }
        public string distance { get; set; }
        public ICommand DeployDataCommand { get; set; }
        public FlightViewModel()
        {
           
            
        }
       

    }
}
