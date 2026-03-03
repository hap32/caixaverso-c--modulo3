using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class MiniSerializer
{
    public string Serializar(object obj)
    {
        if (obj == null)
            return string.Empty;

        var builder = new StringBuilder();
        SerializarObjeto(obj, builder, null);

        if (builder.Length > 0)
            builder.Length--;

        return builder.ToString();
    }

    private void SerializarObjeto(object obj, StringBuilder builder, string? prefixo)
    {
        var tipo = obj.GetType();

        var propriedades = tipo
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.GetIndexParameters().Length == 0);

        foreach (var prop in propriedades)
        {
            if (prop.GetCustomAttribute<OcultarAttribute>() != null)
                continue;

            var valor = prop.GetValue(obj);

            if (valor == null)
                continue;

            var nomePropriedade = prefixo == null
                ? prop.Name
                : $"{prefixo}.{prop.Name}";

            var tipoPropriedade = prop.PropertyType;

            if (tipoPropriedade.IsEnum)
            {
                var valorEnum = (Enum)valor;
                builder.Append($"{nomePropriedade}={EnumHelper.ObterValorEnum(valorEnum)};");
            }
            else if (tipoPropriedade == typeof(DateTime))
            {
                var data = (DateTime)valor;
                builder.Append($"{nomePropriedade}={data:yyyy-MM-dd};");
            }
            else if (tipoPropriedade.IsPrimitive ||
                     tipoPropriedade == typeof(string) ||
                     tipoPropriedade == typeof(decimal))
            {
                builder.Append($"{nomePropriedade}={valor};");
            }
            else
            {
                SerializarObjeto(valor, builder, nomePropriedade);
            }
        }
    }
}
