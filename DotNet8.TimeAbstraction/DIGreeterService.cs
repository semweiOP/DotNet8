public class DIGreeterService(ITimeProvider timeProvider)
{
    public string Greet()
    {
        return timeProvider.GetLocalNow().Hour switch
        {
            >= 5 and < 12 => "God morgon!",
            >= 12 and < 18 => "God eftermiddag!",
            _ => "God kväll!"
        } + $" Klockan är {timeProvider.GetLocalNow().ToString("HH:mm:ss")}.";
    }
}

public class MyTimeProvider : ITimeProvider
{
    public DateTimeOffset GetLocalNow() => DateTime.Now;
}

public interface ITimeProvider
{
    public DateTimeOffset GetLocalNow();
}