using System.ComponentModel.DataAnnotations;
namespace ECOAPP.WebApi.Models.Order
{
    /// <summary>
    /// Order request entity
    /// </summary>
    public class OrderRequest
    {
        /// <summary>
        /// order id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// order number id
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// order type code
        /// </summary>
        public string TypeCode { get; set; }
        /// <summary>
        /// order manufacturing date
        /// </summary>
        [Required]
        public string ElaborationDate { get; set; }
        /// <summary>
        /// order planning date
        /// </summary>
        public string PlanningDate { get; set; }
        /// <summary>
        /// order product code
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// order product name
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// order aproved equipment
        /// </summary>
        [Required]
        public string ApprovedEquipment { get; set; }
        /// <summary>
        /// order status code
        /// </summary>
        public string StatusCode { get; set; }
        /// <summary>
        /// order planning quantity
        /// </summary>
        public string PlanningQuantity { get; set; }
        /// <summary>
        /// order required quantity
        /// </summary>
        [Required]
        public string RequiredQuantity { get; set; }
        /// <summary>
        /// order planning equipment
        /// </summary>
        public string PlanningEquipment { get; set; }
        /// <summary>
        /// order lot number
        /// </summary>
        public string LotNumber { get; set; }
        /// <summary>
        /// order presentation
        /// </summary>
        public string Presentation { get; set; }
    }
}
