﻿using System;

namespace Kontent.Ai.Delivery.Extensions.DependencyInjection
{
    /// <summary>
    /// An enum represents a type of named service provider.
    /// </summary>
    [Obsolete("#312")]
    public enum NamedServiceProviderType
    {
        /// <summary>
        /// No custom service provider.
        /// </summary>
        None = 0,

        /// <summary>
        /// The autofac service provider.
        /// </summary>
        Autofac = 1
    }
}
