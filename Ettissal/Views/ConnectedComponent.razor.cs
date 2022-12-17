// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using Ettissal.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Ettissal.Views
{
    public partial class ConnectedComponent : ComponentBase, IDisposable
    {
        [Inject]
        public IConnectionService ConnectionService { get; set; }

        [Parameter]
        public RenderFragment Online { get; set; }

        [Parameter]
        public RenderFragment Offline { get; set; }

        public bool IsOnline { get; set; }

        protected override void OnInitialized() =>
            ConnectionService.StartConnectivityCheck(this);

        [JSInvokable("Connection.StatusChanged")]
        public void OnConnectionStatusChanged(bool isOnline)
        {
            if (IsOnline != isOnline)
            {
                IsOnline = isOnline;
            }

            StateHasChanged();
        }

        public void Dispose() =>
            ConnectionService.DisposeConnectionCheck();
    }
}