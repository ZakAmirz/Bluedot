﻿using System;
using System.Collections.Generic;

using Bluedot.HabboServer.ApiUsage.Libraries.Subscriptions;
using Bluedot.HabboServer.Database;
using Bluedot.HabboServer.Database.Actions;
using Bluedot.HabboServer.Useful;
using Bluedot.HabboServer.Rooms.Figure;
using Bluedot.HabboServer.Habbos.Messenger;
using Bluedot.HabboServer.Network;
using Bluedot.HabboServer.Permissions;

namespace Bluedot.HabboServer.Rooms
{
    public interface IHuman : IRoomUnit
    {
        #region Property: Motto
        /// <summary>
        /// The motto of this IHuman.
        /// </summary>
        string Motto
        {
            get;
            set;
        }

        #endregion
    }
}