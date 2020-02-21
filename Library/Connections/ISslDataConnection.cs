// <copyright file="ISslDataConnection.cs" company="Zhaoquan Huang">
// Copyright (c) Zhaoquan Huang. All rights reserved
// </copyright>

using System.Threading.Tasks;

namespace Zhaobang.FtpServer.Connections
{
    /// <summary>
    /// A data connection that can be upgraded to an encrypted one.
    /// </summary>
    public interface ISslDataConnection
    {
        /// <summary>
        /// Upgrade the plain text connection to an encrypted one.
        /// </summary>
        /// <returns>The task of the async operation.</returns>
        Task UpgradeToSslAsync();
    }
}
