﻿namespace StokEkstresi.Core
{
    public class EnumDefinitions
    {
        private EnumDefinitions()
        {
        }
    }

    public enum OperationResultType
    {
        None = 0,
        Success = 1,
        Warn = 2,
        Error = 3
    }

    public enum ServiceResultCode
    {
        None = 0,
        Duplicate = 5002,
        NotFound = 5003,
        ValidationError = 5004
    }


}