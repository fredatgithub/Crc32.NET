﻿using System;

namespace Force.Crc32.Tests
{
  public static class Program
  {
    public static void Main()
    {
      var pt = new PerformanceTest();
#if !NETCORE
      pt.ThroughputCrc32_By_dariogriffo();
      pt.ThroughputCHCrc32_By_tanglebones();
      pt.ThroughputKlinkby_Checksum();
      pt.ThroughputCrc32_By_Data_HashFunction_Crc();
      pt.ThroughputCrc32_By_Me();
#else
			pt.ThroughputCrc32C_Standard();
			pt.ThroughputCrc32C_By_Me();
			pt.ThroughputCrc32_By_Me();
#endif

      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
