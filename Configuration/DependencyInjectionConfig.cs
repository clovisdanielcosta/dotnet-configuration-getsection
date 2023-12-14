using DotNetSampleConfigSection.Models;

namespace DotNetSampleConfigSection.Configuration;

public static class DependencyInjectionConfig
{
    public static WebApplicationBuilder AddDependencies(this WebApplicationBuilder builder )
    {
        builder.Services.Configure<SecretSettingDb>(builder.Configuration.GetSection("SecretSettingsDb"));

        return builder;
    }

    public static void AddSecretExtension(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient(c => configuration.GetSection("SecretSettingsDb").Get<SecretSettingDb>());
    }

}
