﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18331
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sporacid.Simplets.Webapp.Services.Resources.Exceptions {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sporacid.Simplets.Webapp.Services.Resources.Exceptions.ExceptionStrings", typeof(ExceptionStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authorization headers required..
        /// </summary>
        internal static string Services_Security_AuthHeaderRequired {
            get {
                return ResourceManager.GetString("Services_Security_AuthHeaderRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Credentials for scheme &quot;{0}&quot; cannot be extracted..
        /// </summary>
        internal static string Services_Security_CannotExtractScheme {
            get {
                return ResourceManager.GetString("Services_Security_CannotExtractScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Club &quot;{0}&quot; already exists and duplicates are not allowed..
        /// </summary>
        internal static string Services_Security_ClubDuplicate {
            get {
                return ResourceManager.GetString("Services_Security_ClubDuplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Credentials are in an invalid format..
        /// </summary>
        internal static string Services_Security_InvalidCredentialsFormat {
            get {
                return ResourceManager.GetString("Services_Security_InvalidCredentialsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contextual action has no context. Cannot authorize..
        /// </summary>
        internal static string Services_Security_NoContextualActionCOntext {
            get {
                return ResourceManager.GetString("Services_Security_NoContextualActionCOntext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action is not configured. Cannot authorize..
        /// </summary>
        internal static string Services_Security_NotConfiguredAction {
            get {
                return ResourceManager.GetString("Services_Security_NotConfiguredAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheme &quot;{0}&quot; is not supported..
        /// </summary>
        internal static string Services_Security_UnsupportedScheme {
            get {
                return ResourceManager.GetString("Services_Security_UnsupportedScheme", resourceCulture);
            }
        }
    }
}
