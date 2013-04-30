//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudyBank.Services.Strings {
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
    public class StringResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CloudyBank.Services.Strings.StringResources", typeof(StringResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account overview.
        /// </summary>
        public static string AccountOverview {
            get {
                return ResourceManager.GetString("AccountOverview", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accounts.
        /// </summary>
        public static string AccountsScope {
            get {
                return ResourceManager.GetString("AccountsScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consumer application has the rights to access your accounts overview, including the balance and name and account numner of each of your accounts..
        /// </summary>
        public static string AccountsScopeDescription {
            get {
                return ResourceManager.GetString("AccountsScopeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debit or credit account is null.
        /// </summary>
        public static string ErrorDebtOrCredAccountNull {
            get {
                return ResourceManager.GetString("ErrorDebtOrCredAccountNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not enough money in the debit account.
        /// </summary>
        public static string ErrorNotEnoughtMoney {
            get {
                return ResourceManager.GetString("ErrorNotEnoughtMoney", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transactions.
        /// </summary>
        public static string OperationsScope {
            get {
                return ResourceManager.GetString("OperationsScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consumer application has the right to access all operations inside all your accounts, including the description, amount and date of the operation..
        /// </summary>
        public static string OperationsScopeDescription {
            get {
                return ResourceManager.GetString("OperationsScopeDescription", resourceCulture);
            }
        }
    }
}