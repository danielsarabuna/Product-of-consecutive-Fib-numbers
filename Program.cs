using System;

public class Program
{  
  public static ulong[] productFib(ulong prod)
  {
    (ulong Fn, ulong Fn1) = (0, 1);
    while (Fn * Fn1 < prod) (Fn, Fn1) = (Fn1, Fn + Fn1);
    return new ulong[] { Fn, Fn1, Fn * Fn1 == prod ? 1ul : 0 };            
  }
}