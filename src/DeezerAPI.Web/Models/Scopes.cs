using System;
using System.Collections.Generic;
using System.Text;

namespace DeezerAPI.Web.Models
{
    /// <summary>
    /// List of available permissions
    /// </summary>
    /// <remarks>
    /// https://developers.deezer.com/api/permissions
    /// </remarks>
    public static class Scopes
    {
        /// <summary>
        /// Access users basic information
        /// </summary>
        /// <remarks>
        /// Incl. name, firstname, profile picture only
        /// </remarks>
        public const string BasicAccess = "basic_access";

        /// <summary>
        /// Get the user's email
        /// </summary>
        public const string Email = "email";

        /// <summary>
        /// Access user data any time
        /// </summary>
        /// <remarks>
        /// Application may access user data at any time
        /// </remarks>
        public const string OfflineAccess = "offline_access";

        /// <summary>
        /// Manage users' library
        /// </summary>
        /// <remarks>
        /// Add/rename a playlist. Add/order songs in the playlist
        /// </remarks>
        public const string ManageLibrary = "manage_library";

        /// <summary>
        /// Manage users' friends
        /// </summary>
        /// <remarks>
        /// Add/remove a following/follower
        /// </remarks>
        public const string ManageCommunity = "manage_community";

        /// <summary>
        /// Delete library items
        /// </summary>
        /// <remarks>
        /// Allow the application to delete items in the user's library
        /// </remarks>
        public const string DeleteLibrary = "delete_library";

        /// <summary>
        /// Allow the application to access the user's listening history
        /// </summary>
        public const string ListeningHistory = "listening_history";
    }
}
