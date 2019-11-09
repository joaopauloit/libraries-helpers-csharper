using System.ComponentModel;

namespace console_libs
{
    public enum Enviroment
    {
        Development = 1,
        [Description("Homologação")]
        Homologation = 2,
        [Description("Produção")]
        Production = 3
    }

    public enum ProcessingStatus
    {
        [Description("Aguardando")]
        Waiting = 1,
        [Description("Processado")]
        Processed = 2,
        [Description("Ocorreu um erro no processamento")]
        Error = 3
    }
}


