﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Services.Work
{
    [Serializable]
    public class InvalidJobRequestException : Exception
    {
        public InvalidJobRequestException() { }
        public InvalidJobRequestException(string message) : base(message) { }
        public InvalidJobRequestException(string message, Exception inner) : base(message, inner) { }
        protected InvalidJobRequestException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
