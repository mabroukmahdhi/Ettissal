// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Ettissal.Views;

namespace Ettissal.Services
{
    public interface IConnectionService
    {
        void StartConnectivityCheck(ConnectedComponent component);
        void DisposeConnectionCheck();
    }
}