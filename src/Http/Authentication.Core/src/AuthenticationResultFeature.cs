// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Authentication
{
    /// <summary>
    /// Used to store the default AuthenticateResult for the request.
    /// </summary>
    public class AuthenticationResultFeature : IAuthenticationResultFeature
    {
        /// <summary>
        /// The <see cref="AuthenticateResult"/> for the request.
        /// </summary>
        public AuthenticateResult Result { get; set; }
    }
}
