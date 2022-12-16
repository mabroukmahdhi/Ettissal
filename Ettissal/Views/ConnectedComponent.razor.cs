// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Ettissal.Views
{
    public partial class ConnectedComponent : ComponentBase
    {
        [Parameter]
        public RenderFragment Online { get; set; }

        [Parameter]
        public RenderFragment Offline { get; set; }

        public bool IsOnline { get; set; }

        [JSInvokable("Connection.StatusChanged")]
        public void OnConnectionStatusChanged(bool isOnline)
        {
            if (IsOnline != isOnline)
            {
                IsOnline = isOnline;
            }

            StateHasChanged();
        }
    }
}