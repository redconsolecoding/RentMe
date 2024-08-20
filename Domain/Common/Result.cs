namespace Domain.Common
{
    public class Result
    {
        private Result(bool isSuccess, Error error)
        {
            if (isSuccess && error != Error.None || !isSuccess && error == Error.None)
            {
                throw new ArgumentException("Invalid error", nameof(error));
            }

            IsSuccess = isSuccess;
            Error = error;
        }

        public bool IsSuccess { get; }

        public bool IsError => !IsSuccess;

        public Error Error { get; set; }

        public static Result Success() => new(true, Error.None);

        public static Result Failure(Error error) => new(false, error);
    }

    public class Result<T>
    {
        private Result(T value, bool isSuccess, Error error)
        {
            if (isSuccess && error != Error.None || !isSuccess && error == Error.None)
            {
                throw new ArgumentException("Invalid error", nameof(error));
            }
            Value = value;
            IsSuccess = isSuccess;
            Error = error;
        }

        public bool IsSuccess { get; }

        public bool IsError => !IsSuccess;

        public T Value { get; }

        public Error Error { get; set; }

        public static Result<T> Success(T value)
        {
            return new Result<T>(value, true, Error.None);
        }

        public static Result<T> Failure(Error error)
        {
            return new Result<T>(default, true, error);
        }
    }
}
