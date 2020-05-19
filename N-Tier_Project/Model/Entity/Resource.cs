using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type;
namespace Model
{
    public class Resource
    {
        public int ResourceId { get; set; }
        public string StudentId { get; set; }
        public ResourceType ResourceType { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string PubRefNumber { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public decimal PurchasePrice { get; set; }
        public ResourceStatus ResourceStatus { get; set; }
        public bool IsReserved { get; set; }
        public DateTime DateRemoved { get; set; }
        public string ImageOfItem { get; set; }
    }
}
