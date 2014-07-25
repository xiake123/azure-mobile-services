﻿// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;

namespace Microsoft.WindowsAzure.MobileServices
{
    /// <summary>
    /// The list of mobile services features exposed in the HTTP headers of requests
    /// for tracking usages.
    /// </summary>
    [Flags]
    internal enum MobileServiceFeatures
    {
        None = 0x00,

        /// <summary>
        /// Feature header value for requests going through typed tables.
        /// </summary>
        [FeatureCode("TT")]
        TypedTable = 0x01,

        /// <summary>
        /// Feature header value for requests going through untyped (JSON) tables.
        /// </summary>
        [FeatureCode("TU")]
        UntypedTable = 0x02,

        /// <summary>
        /// Feature header value for API calls using typed (generic) overloads.
        /// </summary>
        [FeatureCode("AT")]
        TypedApiCall = 0x04,

        /// <summary>
        /// Feature header value for API calls using JSON overloads.
        /// </summary>
        [FeatureCode("AJ")]
        JsonApiCall = 0x08,

        /// <summary>
        /// Feature header value for API calls using the generic (HTTP) overload.
        /// </summary>
        [FeatureCode("AG")]
        GenericApiCall = 0x10,

        /// <summary>
        /// Feature header value for table / API requests which include additional query string parameters.
        /// </summary>
        [FeatureCode("QS")]
        AdditionalQueryParameters = 0x20,

        /// <summary>
        /// Feature header value for requests originated from the <see cref="MobileServiceCollection"/> and derived types.
        /// </summary>
        [FeatureCode("TC")]
        TableCollection = 0x40,
    }
}
