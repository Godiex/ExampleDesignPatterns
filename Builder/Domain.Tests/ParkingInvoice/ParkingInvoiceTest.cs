using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Tests.ParkingInvoice
{
    [TestClass]
    public class ParkingInvoiceTest
    {
        private Entities.ParkingValues _parkingValues = default!;

        [TestInitialize]
        public void Init() 
        {
            _parkingValues = new Entities.ParkingValues
            {
                MotorcycleHourValue = 500,
                DayMotorcycleValue = 4000,
                CarHourValue = 1000,
                CarDayValue = 8000,
                ValueSurchange = 2000
            };
        }

        [TestMethod]
        public void CalculatingTotalValueWhenNumberHoursIsMinorToNine() 
        {
            var invoiceParking = new ParkingInvoiceDataBuilder()
                .WithCellVehicle( new Entities.CellVehicle { 
                    Vehicle = new Entities.Vehicle { Type = "Carro" },
                    EntryDate = DateTime.Now.AddHours(-8),
                    DepartureDate = DateTime.Now
                })
                .WithParkingValues(_parkingValues)
                .Build();

            invoiceParking.CalculateTotalValue();

            Assert.AreEqual(8000, invoiceParking.TotalValue);
        }

        [TestMethod]
        public void CalculatingTotalValueWhenVehicleIsMotorcycleAndTheCylinderIsGreaterThanFiveHundred()
        {
            var invoiceParking = new ParkingInvoiceDataBuilder()
                .WithCellVehicle(new Entities.CellVehicle
                {
                    Vehicle = new Entities.Vehicle { Type = "Motocicleta", Cylinders = 650 },
                    EntryDate = DateTime.Now.AddHours(-10),
                    DepartureDate = DateTime.Now
                })
                .WithParkingValues(_parkingValues)
                .Build();

            invoiceParking.CalculateTotalValue();

            Assert.AreEqual(6000, invoiceParking.TotalValue);
        }

        [TestMethod]
        public void CalculatingTotalValueWhenVehicleIsCarAndTheTimeInParkingIsGreaterThanOneDay()
        {
            var invoiceParking = new ParkingInvoiceDataBuilder()
                .WithCellVehicle(new Entities.CellVehicle
                {
                    Vehicle = new Entities.Vehicle { Type = "Car"},
                    EntryDate = DateTime.Now.AddHours(-27),
                    DepartureDate = DateTime.Now
                })
                .WithParkingValues(_parkingValues)
                .Build();

            invoiceParking.CalculateTotalValue();

            Assert.AreEqual(11000, invoiceParking.TotalValue);
        }

        [TestMethod]
        public void CalculatingTotalValueWhenVehicleIsMotorcycleAndTheTimeInParkingIsGreaterThanOneDay()
        {
            var invoiceParking = new ParkingInvoiceDataBuilder()
                .WithCellVehicle(new Entities.CellVehicle
                {
                    Vehicle = new Entities.Vehicle { Type = "Motocicleta", Cylinders = 125 },
                    EntryDate = DateTime.Now.AddHours(-51),
                    DepartureDate = DateTime.Now
                })
                .WithParkingValues(_parkingValues)
                .Build();

            invoiceParking.CalculateTotalValue();

            Assert.AreEqual(9500, invoiceParking.TotalValue);
        }

    }
}
