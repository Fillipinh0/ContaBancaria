using System;


namespace ContaBancaria.Entities.Exeptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
