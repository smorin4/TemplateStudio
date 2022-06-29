//{[{
using Param_RootNamespace.Models;
//}]}      
            // Services
//{[{
            services.AddSingleton<ILocalSettingsService, LocalSettingsService>();
//}]}
            // Configuration
//{[{
            services.Configure<LocalSettingsOptions>(context.Configuration.GetSection(nameof(LocalSettingsOptions)));
//}]}
