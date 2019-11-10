using System;
using System.Collections.Concurrent;
using System.ComponentModel;

namespace console_libs.Tools 
{
  public static class Enumerators 
  {
    private static readonly ConcurrentDictionary<Enum, string> _descriptions = new ConcurrentDictionary<Enum, string>();

    /// <summary>
    /// Obtém o conteúdo do atributo <see cref="DescriptionAttribute"/> de um valor de um enum.
    /// </summary>
    /// <param name="value">Valor do enum.</param>
    /// <returns>Description configurada para o valor ou o próprio valor caso não encontrado.</returns>
    public static string GetDescription(this Enum value) 
    {
      // Retornando dados do cache, se disponível
      if(_descriptions.TryGetValue(value, out var description)) 
      {
        return description;
      }

      //Recuperando o tipo do enum
      var enumType = value.GetType();

      //Recuperando o nome do item do enum
      var field = enumType.GetField(value.ToString());

      //Recuperando o texto do enum
      var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

      //Senão tiver declarado o atributo Description é retornado o nome do item do enum
      description = attributes.Length == 0 ? value.ToString() : ((DescriptionAttribute)attributes[0]).Description;

      _descriptions.TryAdd(value, description);

      return description;
    }

    /// <summary>
    /// Obtém o valor de um índice de um enum.
    /// </summary>
    /// <typeparam name="T">Tipo do enum.</typeparam>
    /// <param name="index">Índice a pesquisar.</param>
    /// <returns>Valor do enum do índice pesquisado.</returns>
    public static T GetEnum<T>(string index) where T : Enum 
    {
      //Dado o tipo do enum, é realizado o parse para um item válido dado o indice informado.
      return (T)Enum.Parse(typeof(T), index);
    }

  }
}