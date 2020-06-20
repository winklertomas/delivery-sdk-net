﻿using Kentico.Kontent.Delivery.Abstractions;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace Kentico.Kontent.Delivery.ContentItems.ContentLinks
{
    /// <inheritdoc/>
    [DebuggerDisplay("Codename = {" + nameof(Codename) + "}")]
    internal sealed class ContentLink : IContentLink
    {
        /// <inheritdoc/>
        public string Id
        {
            get;
        }

        /// <inheritdoc/>
        public string Codename
        {
            get;
        }

        /// <inheritdoc/>
        public string UrlSlug
        {
            get;
        }

        /// <inheritdoc/>
        public string ContentTypeCodename
        {
            get;
        }

        public ContentLink(string id, JToken source)
        {
            Id = id;
            Codename = source.Value<string>("codename");
            UrlSlug = source.Value<string>("url_slug");
            ContentTypeCodename = source.Value<string>("type");
        }
    }
}
