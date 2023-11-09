using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace DotNet8.OptionsValidation;
public class OptionsExample
{
    public const string SectionName = nameof(OptionsExample);

    [EnumDataType(typeof(LogLevel))]
    public string LogLevel { get; set; }

    [Range(3030, 3039)]
    public int Port { get; set; }
}

