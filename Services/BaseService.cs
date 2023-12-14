using DotNetSampleConfigSection.Models;
using Microsoft.Extensions.Options;

namespace DotNetSampleConfigSection.Services;

public class BaseService
{
    private readonly SecretSettingDb _secretSettingDb;

    public BaseService(IOptions<SecretSettingDb> secretSettingDb)
    {
        _secretSettingDb = secretSettingDb.Value;
    }

    public void GetDatabaseSecret()
    {
        var secretName = _secretSettingDb.SecretName;
        var region = _secretSettingDb.Region;
        var versionStage = _secretSettingDb.VersionStage;
    }
}
