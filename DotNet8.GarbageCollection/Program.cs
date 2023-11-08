

AppContext.SetData("GCHeapHardLimit", (ulong)1024 * 1024 * 1024); // 1024 MB
Console.WriteLine("Current memory limit: {0} MB", ToMb(GC.GetGCMemoryInfo().TotalAvailableMemoryBytes));
GC.RefreshMemoryLimit();
Console.WriteLine("Current memory limit: {0} MB", ToMb(GC.GetGCMemoryInfo().TotalAvailableMemoryBytes));

AppContext.SetData("GCHeapHardLimit", (ulong)50 * 1024 * 1024); // 50 MB
GC.RefreshMemoryLimit();
Console.WriteLine("New memory limit: {0} MB", ToMb(GC.GetGCMemoryInfo().TotalAvailableMemoryBytes));


static double ToMb(double value) =>
    (value / Math.Pow(1024, (int)2));