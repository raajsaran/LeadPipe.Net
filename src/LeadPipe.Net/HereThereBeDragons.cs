﻿// --------------------------------------------------------------------------------------------------------------------
// Copyright (c) Lead Pipe Software. All rights reserved.
// Licensed under the MIT License. Please see the LICENSE file in the project root for full license information.
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace LeadPipe.Net
{
    /// <summary>
    /// This attribute allows developers to decorate dangerous parts of the code.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The intent of this attribute is to give developers a way to decorate code where, for whatever reason, the
    /// developer decided to do something in a way that is not straight-forward. The phrase denotes dangerous or
    /// unexplored territories much like the medieval practice of putting dragons and other mythological creatures in
    /// the blank areas of maps.
    /// </para>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate | AttributeTargets.Method)]
    public sealed class HereThereBeDragons : Attribute
    {
        /// <summary>
        /// A brief description of why the decorated code is dangerous.
        /// </summary>
        private readonly string explanation;

        /// <summary>
        /// Initializes a new instance of the <see cref="HereThereBeDragons"/> class.
        /// </summary>
        public HereThereBeDragons()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HereThereBeDragons"/> class.
        /// </summary>
        /// <param name="explanation">
        /// A brief description of why the decorated code is dangerous.
        /// </param>
        public HereThereBeDragons(string explanation)
        {
            this.explanation = explanation;
        }

        /// <summary>
        /// Gets the explanation.
        /// </summary>
        public string Explanation
        {
            get
            {
                return this.explanation;
            }
        }
    }
}