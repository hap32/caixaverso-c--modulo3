using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public static class EnumHelper
{
    public static string ObterValorEnum(Enum valorEnum)
    {
        var tipo = valorEnum.GetType();
        var membro = tipo.GetMember(valorEnum.ToString());

        if (membro.Length > 0)
        {
            var atributoDisplay = membro[0]
                .GetCustomAttribute<DisplayAttribute>();

            if (atributoDisplay != null)
                return atributoDisplay.Name;
        }

        return valorEnum.ToString();
    }
}
