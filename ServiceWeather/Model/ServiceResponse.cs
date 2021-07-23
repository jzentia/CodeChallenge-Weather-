using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Weather.Model
{
    public class ServiceResponse
    {
        /// <summary>
        /// Response to Go outside
        /// </summary>
        public bool Go_OutSide { get; set; } = false;
        /// <summary>
        /// Response to Wear Sun Screen
        /// </summary>
        public bool Wear_SunScreen { get; set; } = false;
        /// <summary>
        /// Response to Fly a kite
        /// </summary>
        public bool Fly_Kite { get; set; } = false;
    }
}
