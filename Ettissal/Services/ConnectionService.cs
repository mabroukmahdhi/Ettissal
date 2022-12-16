// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Ettissal.Views;
using Microsoft.JSInterop;

namespace Ettissal.Services
{
    internal class ConnectionService : IConnectionService
    {
        private readonly IJSRuntime jsRuntime;

        public ConnectionService(IJSRuntime jsRuntime) =>
            this.jsRuntime = jsRuntime;

        public void StartConnectivityCheck(ConnectedComponent component)
        {
            _ = jsRuntime.InvokeVoidAsync(
                identifier: "Connection.Initialize",
                args: DotNetObjectReference.Create(component));
        }

        public void DisposeConnectionCheck()
        {
            _ = jsRuntime.InvokeVoidAsync("Connection.Dispose");
        }
    }
}