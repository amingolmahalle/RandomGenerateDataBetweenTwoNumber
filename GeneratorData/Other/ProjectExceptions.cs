using System;

namespace GeneratorData.Other
{
        public class ApplicationConnectToDatabaseException : Exception
        {
            public ApplicationConnectToDatabaseException() : base("Cannot Application Connect To Database,Please Check ConnectionString")
            { }
        }
}
