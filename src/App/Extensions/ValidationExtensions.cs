using FluentValidation;

namespace App.Extensions;

public static class ValidationExtensions
{
    public static Settings ValidateAndThrow(this Settings obj)
    {
        return obj.ValidateAndThrow(new SettingsValidator());
    }
    
    private static T ValidateAndThrow<T>(this T obj, IValidator<T> validator)
    {
        validator.ValidateAndThrow(obj);
        return obj;
    }
}