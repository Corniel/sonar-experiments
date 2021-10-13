class Generic<T>
{
    public static string Empty => string.Empty; // FP: Compliant, it only returns an external reference.
    public static object New => new object(); // FP: Compliant, every call returns a new instance.
}
