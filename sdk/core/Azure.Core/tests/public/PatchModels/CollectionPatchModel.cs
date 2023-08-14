// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.Json;

namespace Azure.Core.Tests.PatchModels
{
    /// <summary>
    /// This model illustrates collection properties on Patch models.
    /// </summary>
    public partial class CollectionPatchModel
    {
#pragma warning disable AZC0020 // Avoid using banned types in libraries
        private readonly MutableJsonElement _element;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public CollectionPatchModel()
        {
            _element = MutableJsonDocument.Parse(MutableJsonDocument.EmptyJson).RootElement;
        }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="element"></param>
        internal CollectionPatchModel(MutableJsonElement element)
        {
            _element = element;
        }

        /// <summary>
        /// Optional string property corresponding to JSON """{"id": "abc"}""".
        /// </summary>
        public string Id
        {
            get
            {
                if (_element.TryGetProperty("id", out MutableJsonElement value))
                {
                    return value.GetString();
                }
                return null;
            }
            set => _element.SetProperty("id", value);
        }

        private IDictionary<string, string> _environmentVariables;
        /// <summary> Environment variables which are defined as a set of &lt;name,value&gt; pairs. </summary>
        public IDictionary<string, string> EnvironmentVariables
        {
            get
            {
                if (_environmentVariables == null)
                {
                    if (!_element.TryGetProperty("environmentVariables", out MutableJsonElement element))
                    {
                        _element.SetProperty("environmentVariables", new { });
                        element = _element.GetProperty("environmentVariables");
                    }

                    _environmentVariables = new MutableJsonDictionary<string>(element);
                }

                return _environmentVariables;
            }

            // Dictionary property cannot be set because it must be a special
            // dictionary type that is backed by MutableJsonDocument.
        }

#pragma warning restore AZC0020 // Avoid using banned types in libraries
    }
}
