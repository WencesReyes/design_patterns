namespace DesignPatterns.Domain.Abstractions
{
    public class Result
    {
    }

    public class Result<TValue> : Result
    {
        public TValue Value { get; init; }

        private Result(TValue value)
        {
            Value = value;
        }

        public static Result<TValue> Create(TValue value)
            => new(value);

        public static implicit operator Result<TValue>(TValue value)
            => Create(value);
    }
}
