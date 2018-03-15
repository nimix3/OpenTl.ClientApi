﻿namespace OpenTl.ClientApi
{
    using System;
    using System.Threading.Tasks;

    /// <summary>Works with session</summary>
    public interface ISessionStore : IDisposable
    {
        /// <summary>Load session</summary>
        /// <returns></returns>
        byte[] Load();

        /// <summary>Save session</summary>
        /// <param name="session">Session</param>
        /// <returns>Task</returns>
        Task Save(byte[] session);

        /// <summary>Taging session</summary>
        /// <param name="sessionTag">Tag name</param>
        void SetSessionTag(string sessionTag);
    }
}