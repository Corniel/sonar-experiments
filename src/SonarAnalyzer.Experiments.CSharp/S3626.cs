using System.Collections.Generic;

namespace S3626;

public class NonCompliant
{
    void Continue(IEnumerable<int> numbers)
    {
        foreach (var n in numbers)
        {
            if (n is not 42) continue; // FN, is not different from n != 42.
        }
    }
}
