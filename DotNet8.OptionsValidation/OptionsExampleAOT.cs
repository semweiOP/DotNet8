using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace DotNet8.OptionsValidation;

public class OptionsExampleAOT
{
    public const string SectionName = nameof(OptionsExampleAOT);

    [EnumDataType(typeof(LogLevel))]
    public string LogLevel { get; set; }

    [ValidateObjectMembers]
    public OptionsExamplePort Port { get; set; }
}


public class OptionsExamplePort
{
    [Range(3030, 3039)]
    public int Port { get; set; }
}

[OptionsValidator]
public partial class OptionsExampleAOTValidator : IValidateOptions<OptionsExampleAOT>
{

}
[OptionsValidator]
public partial class OptionsExamplePortValidator : IValidateOptions<OptionsExamplePort>
{

}



