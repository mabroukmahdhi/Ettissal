// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

namespace Ettissal.Services
{
    public interface IConnectionService
    {
        ValueTask<bool> CheckConnectivityAsync();
    }
}