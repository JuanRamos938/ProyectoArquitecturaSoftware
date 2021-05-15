namespace ECOAPP.Core.Common.Enums
{
    public class OrderStatus
    {
        public string Code { get; }
        public string Description { get; }

        private OrderStatus(string code, string description)
        {
            Code = code;
            Description = description;
        }

        private static OrderStatus Planned = new OrderStatus("PLA", "Planificada");
        private static OrderStatus Prioritary = new OrderStatus("PRI", "Prioritaria");
        private static OrderStatus ToSupply = new OrderStatus("TSP", "Por surtir");
        private static OrderStatus ReceivedMaterial = new OrderStatus("RMA", "Material recibido");
        private static OrderStatus InProduction = new OrderStatus("INP", "En producción");
        private static OrderStatus ProductionEnded = new OrderStatus("END", "Producción finalizada");
        private static OrderStatus DeliveredToLogistic = new OrderStatus("DTL", "Entregada a logistica");

        public static OrderStatus GetByCode(string code)
        {
            if (code.Equals("PLA"))
            {
                return Planned;
            }
            else if (code.Equals("PRI"))
            {
                return Prioritary;
            }
            else if (code.Equals("TSP"))
            {
                return ToSupply;
            }
            else if (code.Equals("RMA"))
            {
                return ReceivedMaterial;
            }
            else if (code.Equals("INP"))
            {
                return InProduction;
            }
            else if (code.Equals("END"))
            {
                return ProductionEnded;
            }
            else if (code.Equals("DTL"))
            {
                return DeliveredToLogistic;
            }
            return null;
        }
        public static OrderStatus GetByDescription(string description)
        {
            if (description.Equals("Planificada"))
            {
                return Planned;
            }
            else if (description.Equals("Prioritaria"))
            {
                return Prioritary;
            }
            else if (description.Equals("Por surtir"))
            {
                return ToSupply;
            }
            else if (description.Equals("Material recibido"))
            {
                return ReceivedMaterial;
            }
            else if (description.Equals("En producción"))
            {
                return InProduction;
            }
            else if (description.Equals("Producción finalizada"))
            {
                return ProductionEnded;
            }
            else if (description.Equals("Entregada a logistica"))
            {
                return DeliveredToLogistic;
            }
            return null;
        }
    }
}
