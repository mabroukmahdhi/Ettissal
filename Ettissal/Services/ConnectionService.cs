// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Microsoft.JSInterop;

namespace Ettissal.Services
{
    public class ConnectionService : IConnectionService
    {
        private readonly IJSRuntime jsRuntime;

        public ConnectionService(IJSRuntime jsRuntime) =>
            this.jsRuntime = jsRuntime;


        public ValueTask<bool> CheckConnectivityAsync()
        {
            throw new NotImplementedException();
        }
    }
}