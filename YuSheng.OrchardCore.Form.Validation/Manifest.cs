using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "YuSheng.OrchardCore.Form",
    Author = "spike",
    Website = "",
    Version = "0.0.2"
)]

[assembly: Feature(
    Id = "YuSheng.OrchardCore.Form.Validation",
    Name = "YuSheng.OrchardCore.Form.Validation",
    Description = "Provides widgets and activities to implement forms.",
    Dependencies = new[] { "OrchardCore.Widgets", "OrchardCore.Flows" },
    Category = "Yusheng"
)]
