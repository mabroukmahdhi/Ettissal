// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Ettissal.Views;
using Microsoft.JSInterop;

namespace Ettissal.Services
{
    internal class ConnectionService : IConnectionService
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public ConnectionService(IJSRuntime jsRuntime) =>
            this.moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/Ettissal/ettissal.js").AsTask());

        public async void StartConnectivityCheck(ConnectedComponent component)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync(
               identifier: "initializeConnectedComponent",
               args: DotNetObjectReference.Create(component));
        }

        public async void DisposeConnectionCheck()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.InvokeVoidAsync(
                   identifier: "disposeConnectedComponent");
            }
        }
    }
}