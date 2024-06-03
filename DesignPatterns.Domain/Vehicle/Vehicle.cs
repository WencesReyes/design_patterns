using DesignPatterns.Domain.Shared;

namespace DesignPatterns.Domain.Vehicle
{
    public sealed class Vehicle : Entity<Guid>
    {
        private Vehicle(
            Guid id,
            string model,
            string brand,
            short year) : base(id)
        {
            Model = model;
            Brand = brand;
            Year = year;
        }

        public string Model { get; init; }

        public string Brand { get; init; }

        public short Year { get; init; }

        public static Vehicle Create(string model, string brand, short year)
        {
            return new(
                Guid.NewGuid(),
                model,
                brand,
                year);
        }
    }
}
