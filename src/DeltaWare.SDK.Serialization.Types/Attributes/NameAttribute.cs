﻿using System;

namespace DeltaWare.SDK.Serialization.Types.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NameAttribute : Attribute
    {
        public string Value { get; }

        public NameAttribute(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }
    }
}