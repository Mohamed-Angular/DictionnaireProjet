using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DictionnaireProject.DataAccess.Exceptions.Constants
{

    [ExcludeFromCodeCoverage]
    public static class MessagesConstantes
    { 
        public static readonly string MessageErrorReading = "Erreur de lecture de l'api: {0}";
        public static readonly string BAD_REQUEST_BAD_INPUT = "L'entrée est invalide";
    }
}
