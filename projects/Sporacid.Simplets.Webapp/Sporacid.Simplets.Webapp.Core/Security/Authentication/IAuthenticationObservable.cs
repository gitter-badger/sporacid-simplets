﻿namespace Sporacid.Simplets.Webapp.Core.Security.Authentication
{
    /// <authors>Simon Turcotte-Langevin, Patrick Lavallée, Jean Bernier-Vibert</authors>
    /// <version>1.9.0</version>
    public interface IAuthenticationObservable
    {
        /// <summary>
        /// Add an observer to the list of authentication observers.
        /// </summary>
        /// <param name="observer">The observer to add.</param>
        void AddObserver(IAuthenticationObserver observer);

        /// <summary>
        /// Removes an observer from the list of authentication observers.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>
        void RemoveObserver(IAuthenticationObserver observer);

        /// <summary>
        /// Notify all observers of an authentication.
        /// </summary>
        /// <param name="tokenAndPrincipal">The token and principals of the newly authenticated user.</param>
        void NotifyAuthentication(ITokenAndPrincipal tokenAndPrincipal);
    }
}