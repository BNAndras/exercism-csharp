public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new NotImplementedException("You need to implement this method.");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        throw new NotImplementedException("You need to implement this method.");
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        throw new NotImplementedException("You need to implement this method.");
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        throw new NotImplementedException("You need to implement this method.");
    }
}
