// <copyright file="AnonymousAuthenticator.cs" company="Zhaoquan Huang">
// Copyright (c) Zhaoquan Huang. All rights reserved
// </copyright>

using System;
using System.Net;

namespace Zhaobang.FtpServer.Authenticate
{
    /// <summary>
    /// A simple authenticator that only allows anonymous authenticator.
    /// </summary>
    public class AnonymousAuthenticator : IAuthenticator
    {
        /// <summary>
        /// Allows anonymous access.
        /// </summary>
        /// <param name="userName">The user name user inputted.</param>
        /// <param name="password">The password user inputted.</param>
        /// <param name="remoteEndPoint">The remote endpoint the user connected from.</param>
        /// <returns>Whether the user name is "anonymous".</returns>
        public bool Authenticate(string userName, string password, IPEndPoint remoteEndPoint, out Guid Id)
        {
            Id = Guid.Empty;
            return userName.ToUpper() == "ANONYMOUS";
        }
    }
}
