using Microsoft.Extensions.Configuration;

// Make sure to add user secrets before running this file

IConfigurationRoot config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();
    
    