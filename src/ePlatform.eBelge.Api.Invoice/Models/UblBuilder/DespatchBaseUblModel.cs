using System.Collections.Generic;
using ePlatform.eBelge.Api.Invoice.Models;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class DespatchBaseUblModel<TGeneral, TLine, TOrderInfo, TDespatchShipmentInfo, TDeliveryAddressInfo>
        where TGeneral : GeneralInfoBaseModel, new()
        where TLine : DespatchLineBaseModel
        where TOrderInfo : OrderInfoBaseModel, new()
        where TDespatchShipmentInfo : DespatchShipmentInfoBaseModel, new()
        where TDeliveryAddressInfo : DeliveryAddressInfoBaseModel, new()
    {
        public bool isSend { get; set; }
        public string Note { get; set; }
        public virtual TGeneral GeneralInfo { get; set; }
        public virtual List<TLine> DespatchLines { get; set; }
        public virtual TOrderInfo OrderInfo { get; set; }
        public virtual TDespatchShipmentInfo DespatchShipmentInfo { get; set; }
        public virtual TDeliveryAddressInfo DeliveryAddressInfo { get; set; }

        public DespatchBaseUblModel()
        {
            this.GeneralInfo = new TGeneral();
            this.DespatchLines = new List<TLine>();
            this.OrderInfo = new TOrderInfo();
            this.DespatchShipmentInfo = new TDespatchShipmentInfo();
            this.DeliveryAddressInfo = new TDeliveryAddressInfo();
        }
    }
}