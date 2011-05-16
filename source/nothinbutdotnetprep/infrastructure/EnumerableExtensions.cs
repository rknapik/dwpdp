using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
    {
      foreach (T item in items)
      {
        yield return item;
      }
    }
  }
}