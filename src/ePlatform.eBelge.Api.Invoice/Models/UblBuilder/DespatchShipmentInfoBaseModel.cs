using System;
using System.Collections.Generic;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class DespatchShipmentInfoBaseModel
    {
        public string ShipmentSenderTcknVkn { get; set; }
        public string ShipmentSenderTitle { get; set; }
        public string ShipmentPlateNo { get; set; }
        public List<DespatchDriverModel> DriverLines { get; set; }
        public List<DespatchPlateModel> PlateLines { get; set; }
    }
}