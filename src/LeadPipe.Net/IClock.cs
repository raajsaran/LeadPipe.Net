﻿// --------------------------------------------------------------------------------------------------------------------
// Copyright (c) Lead Pipe Software. All rights reserved.
// Licensed under the MIT License. Please see the LICENSE file in the project root for full license information.
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace LeadPipe.Net
{
    /// <summary>
    /// Allows for abstracting calls such as DateTime.Now particularly in unit tests.
    /// </summary>
    public interface IClock
    {
        /// <summary>
        /// Gets the current time.
        /// </summary>
        /// <returns>The current time.</returns>
        DateTime GetCurrentTime();

        /// <summary>
        /// Gets the current UTC time.
        /// </summary>
        /// <returns>The current UTC time.</returns>
        DateTime GetCurrentUtcTime();
    }
}