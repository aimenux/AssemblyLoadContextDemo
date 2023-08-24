using FluentValidation;

namespace App;

public class SettingsValidator : AbstractValidator<Settings>
{
    public SettingsValidator()
    {
        RuleFor(x => x.PluginsPaths)
            .NotEmpty();

        RuleForEach(x => x.PluginsPaths)
            .NotEmpty();
    }
}