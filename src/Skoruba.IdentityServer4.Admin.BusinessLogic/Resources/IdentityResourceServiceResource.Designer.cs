﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skoruba.IdentityServer4.Admin.BusinessLogic.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class IdentityResourceServiceResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal IdentityResourceServiceResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Skoruba.IdentityServer4.Admin.BusinessLogic.Resources.IdentityResourceServiceReso" +
                            "urce", typeof(IdentityResourceServiceResource).Assembly);
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
        ///   Looks up a localized string similar to Identity Resource with id {0} doesn&apos;t exist.
        /// </summary>
        internal static string IdentityResourceDoesNotExist {
            get {
                return ResourceManager.GetString("IdentityResourceDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identity Resource {0} already exists.
        /// </summary>
        internal static string IdentityResourceExistsKey {
            get {
                return ResourceManager.GetString("IdentityResourceExistsKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identity Resource {0} already exists.
        /// </summary>
        internal static string IdentityResourceExistsValue {
            get {
                return ResourceManager.GetString("IdentityResourceExistsValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identity Resource Property with id {0} doesn&apos;t exist.
        /// </summary>
        internal static string IdentityResourcePropertyDoesNotExist {
            get {
                return ResourceManager.GetString("IdentityResourcePropertyDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identity Resource Property already exists.
        /// </summary>
        internal static string IdentityResourcePropertyExistsKey {
            get {
                return ResourceManager.GetString("IdentityResourcePropertyExistsKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identity Resource Property with key ({0}) already exists.
        /// </summary>
        internal static string IdentityResourcePropertyExistsValue {
            get {
                return ResourceManager.GetString("IdentityResourcePropertyExistsValue", resourceCulture);
            }
        }
    }
}
