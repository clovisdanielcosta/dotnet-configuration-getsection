using DotNetSampleConfigSection.Models;

namespace DotNetSampleConfigSection.Configuration;

public static class DependencyInjectionConfig
{
    public static WebApplicationBuilder AddDependencies(this WebApplicationBuilder builder )
    {
        builder.Services.Configure<SecretSettingDb>(builder.Configuration.GetSection("SecretSettingsDb"));

        return builder;
    }
}
