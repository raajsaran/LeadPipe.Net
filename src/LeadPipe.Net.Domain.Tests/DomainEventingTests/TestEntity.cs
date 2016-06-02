﻿// --------------------------------------------------------------------------------------------------------------------
// Copyright (c) Lead Pipe Software. All rights reserved.
// Licensed under the MIT License. Please see the LICENSE file in the project root for full license information.
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace LeadPipe.Net.Domain.Tests.DomainEventingTests
{
    public class TestEntity : PersistableObject<Guid>, IEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestEntity" /> class.
        /// </summary>
        /// <param name="code">The test object's unique code.</param>
        /// <param name="name">The test object's name.</param>
        public TestEntity(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestEntity" /> class.
        /// </summary>
        /// <remarks>Required for NHibernate support.</remarks>
        protected TestEntity()
        {
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        public virtual string Code { get; set; }

        /// <summary>
        /// Gets the natural id.
        /// </summary>
        public virtual string Key
        {
            get
            {
                return this.Code;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public virtual string Name { get; protected set; }

        /// <summary>
        /// Changes the name.
        /// </summary>
        /// <param name="name">The new name.</param>
        public void ChangeName(string name)
        {
            this.Name = name;

            DomainEvents.Raise(new TestDomainEvent() { NewName = this.Name });
        }
    }
}