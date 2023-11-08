

AppContext.SetData("GCHeapHardLimit", (ulong)1024 * 1024 * 1024); // 1024 MB
Console.WriteLine("Current memory limit: {0} MB", CurrentMemoryLimitInMb());
GC.RefreshMemoryLimit();
Console.WriteLine("Current memory limit: {0} MB", CurrentMemoryLimitInMb());

AppContext.SetData("GCHeapHardLimit", (ulong)50 * 1024 * 1024); // 50 MB
GC.RefreshMemoryLimit();
Console.WriteLine("New memory limit: {0} MB", CurrentMemoryLimitInMb());


static double CurrentMemoryLimitInMb() => GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / Math.Pow(1024, (int)2);