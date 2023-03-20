using ErrorOr;

namespace BuberBreakfast.ServiceErrors;

public static class Errors
{
    public static class Breakfast
    {
        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName",
            description: $"Breakfast name must be at least {Models.Breakfast.MIN_NAME_LENGTH}" +
            $" characters long and at most {Models.Breakfast.MAX_NAME_LENGTH} characters long.");

        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.InvalidDescription",
            description: $"Breakfast description must be at least {Models.Breakfast.MIN_DESCRIPTION_LENGTH}" +
            $" characters long and at most {Models.Breakfast.MAX_DESCRIPTION_LENGTH} characters long.");

        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast not found");
    }
}