using Domain.Entities;

namespace Domain.Tests.ParkingInvoice
{
    public class ParkingInvoiceDataBuilder
    {
        private Entities.CellVehicle _cellVehicle = default!;
        private ParkingValues _parkingValues = default!;
        private double _subtotal;
        private double _surchangeValue;
        private double _totalValue;

        public Domain.Entities.ParkingInvoice Build()
        {
            return new Entities.ParkingInvoice
            {
                CellVehicle = _cellVehicle,
                ParkingValues = _parkingValues,
                Subtotal = _subtotal,
                SurchangeValue = _surchangeValue,
                TotalValue = _totalValue
            };
        }

        public ParkingInvoiceDataBuilder WithCellVehicle(Entities.CellVehicle cellVehicle)
        {
            _cellVehicle = cellVehicle;
            return this;
        }

        public ParkingInvoiceDataBuilder WithParkingValues(ParkingValues parkingValues)
        {
            _parkingValues = parkingValues;
            return this;
        }

        public ParkingInvoiceDataBuilder WithSubtotalValue(double subTotalValue)
        {
            _totalValue = subTotalValue;
            return this;
        }

        public ParkingInvoiceDataBuilder WithSurchangeValue(double surchangeValue)
        {
            _surchangeValue = surchangeValue;
            return this;
        }

        public ParkingInvoiceDataBuilder WithTotalValue(double totalValue)
        {
            _totalValue = totalValue;
            return this;
        }
    }
}
