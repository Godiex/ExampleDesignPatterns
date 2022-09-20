using System;
using System.Threading.Tasks;
using Domain.Exception;
using Domain.Ports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Domain.Tests.CellVehicleTest
{
    [TestClass]
    public class CellVehicleServiceTest
    {
        private Services.CellVehicleService _cellVehicleService = default!;
        private IGenericRepository<Entities.CellVehicle> _cellVehicleRepository = default!;
        private IGenericRepository<Entities.Vehicle> _vehicleRepository = default!;
        private IGenericRepository<Entities.Parking> _parkingRepository = default!;
        private IGenericRepository<Entities.Cell> _cellRepository = default!;
        private IGenericRepository<Entities.ParkingValues> _parkingValuesRepository = default!;
        private IGenericRepository<Domain.Entities.ParkingInvoice> _parkingInvoiceRepository = default!;
        private enum TypesVehicle { Carro = 1, Motocicleta };

        [TestInitialize]
        public void Init() 
        {
            _cellVehicleRepository = Substitute.For<IGenericRepository<Domain.Entities.CellVehicle>>();
            _vehicleRepository = Substitute.For<IGenericRepository<Domain.Entities.Vehicle>>();
            _parkingRepository = Substitute.For<IGenericRepository<Domain.Entities.Parking>>();
            _cellRepository = Substitute.For<IGenericRepository<Domain.Entities.Cell>>();
            _parkingValuesRepository = Substitute.For<IGenericRepository<Domain.Entities.ParkingValues>>();
            _parkingInvoiceRepository = Substitute.For<IGenericRepository<Domain.Entities.ParkingInvoice>>();
            _cellVehicleService = new Services.CellVehicleService
            (
                _cellVehicleRepository,
                _parkingRepository, 
                _vehicleRepository, 
                _cellRepository, 
                _parkingValuesRepository, 
                _parkingInvoiceRepository
            );
        }

        [TestMethod]
        public async Task FailedToRegisterEntranceVehicleWithPickAndPlate()
        {
            try
            {
                var plaque = IsDayPair() ? "ASD654" : "ASD123";
                var vehicle = new Entities.Vehicle((int)TypesVehicle.Motocicleta, plaque, 130);
                await _cellVehicleService.RegisterEntranceToParkingAsync(vehicle);
            }
            catch (System.Exception ex)
            {
                Assert.IsTrue(ex is PickAndPlateException);
            }
        }

        private bool IsDayPair()
        {
            int currentDay = DateTime.Now.Day;
            return currentDay % 2 == 0;
        }

        

    }
}
