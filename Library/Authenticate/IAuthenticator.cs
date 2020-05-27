// <copyright file="IAuthenticator.cs" company="Zhaoquan Huang">
// Copyright (c) Zhaoquan Huang. All rights reserved
// </copyright>

using System;
using System.Net;

namespace Zhaobang.FtpServer.Authenticate
{
    /// <summary>
    /// Used to authenticate FTP login.
    /// </summary>
    public interface IAuthenticator
    {
        /// <summary>
        /// Verifies if the username-password pair is correct.
        /// </summary>
        /// <param name="userName">The user name user inputted.</param>
        /// <param name="password">The password user inputted.</param>
        /// <param name="remoteEndPoint">The remote endpoint the user connected from.</param>
        /// <param name="sessionId">The Id of the authenticated session.</param>
        /// <returns>Whether the pair is correct.</returns>
        bool Authenticate(string userName, string password, IPEndPoint remoteEndPoint, out Guid sessionId);
    }
}
