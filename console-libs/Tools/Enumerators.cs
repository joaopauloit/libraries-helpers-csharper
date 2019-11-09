using System;
using System.ComponentModel;

namespace console_libs.Tools
{
    public static class Enumerators
    {
        public static string GetDescription(this Enum value)
        {
            //Recuperando o tipo do enum
            var enumType = value.GetType();
            
            //Recuperando o nome do item do enum
            var field = enumType.GetField(value.ToString());

            //Recuperando o texto do enum
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            //Senão tiver declarado o atributo Description é retornado o nome do item do enum
            return attributes.Length == 0 ? value.ToString() : ((DescriptionAttribute)attributes[0]).Description;
        }

        public static T GetEnum<T>(string index) where T : Enum
        {
            //Dado o tipo do enum, é realizado o parse para um item válido dado o indice informado.
            return (T)Enum.Parse(typeof(T), index);
        }


    }
}