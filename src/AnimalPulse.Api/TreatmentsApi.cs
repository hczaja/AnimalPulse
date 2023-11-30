namespace AnimalPulse.Api;

internal static class TreatmentsApi
{
    public static WebApplication UseTreatmentsApi(this WebApplication app)
    {
        var group = app.MapGroup("treatments");

        group.MapGet("/", () => "Hello from Treatments!");

        return app;
    }
}
