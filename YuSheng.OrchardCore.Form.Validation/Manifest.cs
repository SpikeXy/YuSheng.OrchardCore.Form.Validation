using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "YuSheng.OrchardCore.Form",
    Author = ManifestConstants.OrchardCoreTeam,
    Website = ManifestConstants.OrchardCoreWebsite,
    Version = ManifestConstants.OrchardCoreVersion
)]

[assembly: Feature(
    Id = "YuSheng.OrchardCore.Form.Validation",
    Name = "YuSheng.OrchardCore.Form.Validation",
    Description = "Provides widgets and activities to implement forms.",
    Dependencies = new[] { "OrchardCore.Widgets", "OrchardCore.Flows" },
    Category = "Yusheng"
)]
