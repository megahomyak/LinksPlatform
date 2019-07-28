﻿using System;

namespace Platform.Data.Exceptions
{
    public class LinkWithSameValueAlreadyExistsException : Exception
    {
        private const string DefaultMessage = "Связь с таким же значением уже существует.";

        public LinkWithSameValueAlreadyExistsException(string message = DefaultMessage) : base(message) { }
    }
}
