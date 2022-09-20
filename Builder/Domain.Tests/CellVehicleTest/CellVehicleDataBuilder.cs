using System;
using Domain.Entities;

namespace Domain.Tests.CellVehicleTest
{
    public class CellVehicleDataBuilder
    {
        private Vehicle _vehicle = default!;
        private Cell _cell = default!;
        private DateTime _entryDate;
        private DateTime _departureDate;

        public Domain.Entities.CellVehicle Build()
        {
            return new Entities.CellVehicle
            {
                Vehicle = _vehicle,
                Cell = _cell,
                DepartureDate = _departureDate,
                EntryDate = _entryDate
            };
        }

        public CellVehicleDataBuilder WithCell(Cell cell)
        {
            _cell = cell;
            return this;
        }

        public CellVehicleDataBuilder WithVehicle(Vehicle vehicle)
        {
            _vehicle = vehicle;
            return this;
        }

        public CellVehicleDataBuilder WithEntryDate(DateTime entryDate)
        {
            _entryDate = entryDate;
            return this;
        }

        public CellVehicleDataBuilder WithDepartureDate(DateTime departureDate)
        {
            _departureDate = departureDate;
            return this;
        }

    }
}
