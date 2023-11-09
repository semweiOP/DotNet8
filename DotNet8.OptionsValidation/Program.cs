


using DotNet8.OptionsValidation;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

//builder.Services
//    .AddOptions<OptionsExample>()
//    .Bind(config.GetSection(OptionsExample.SectionName))
//    .ValidateDataAnnotations();
//.ValidateOnStart();


// AOT
//builder.Services
//    .Configure<OptionsExampleAOT>(config.GetSection(OptionsExampleAOT.SectionName));
//builder.Services.AddSingleton<IValidateOptions<OptionsExampleAOT>, OptionsExampleAOTValidator>();
//builder.Services.AddSingleton<IValidateOptions<OptionsExamplePort>, OptionsExamplePortValidator>();



var app = builder.Build();

app.Map("hello", (IOptions<OptionsExample> opt) => opt.Value);
app.Map("helloAOT", (IOptions<OptionsExampleAOT> opt) => opt.Value);


app.Run();


