using Microsoft.Extensions.Configuration;

namespace VestaboardPackage;

public class VestaboardClient
{
    private string _key { get; }

    public VestaboardClient()
    {
        var config = new ConfigurationBuilder()
            .AddUserSecrets<VestaboardClient>()
            .Build();

        _key = config["READ_WRITE_KEY"];
    }
}