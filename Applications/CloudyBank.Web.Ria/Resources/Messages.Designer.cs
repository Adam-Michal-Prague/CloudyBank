//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudyBank.Web.Ria.Resources {
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
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CloudyBank.Web.Ria.Resources.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to There has been an error while saving the partner.
        /// </summary>
        internal static string ESavingPartner {
            get {
                return ResourceManager.GetString("ESavingPartner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There has been an error while saving the payment.
        /// </summary>
        internal static string ESavingPayment {
            get {
                return ResourceManager.GetString("ESavingPayment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There has been an error while tagging the payment.
        /// </summary>
        internal static string ETagPayment {
            get {
                return ResourceManager.GetString("ETagPayment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction done.
        /// </summary>
        internal static string ITransactionOK {
            get {
                return ResourceManager.GetString("ITransactionOK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transfer in progress.
        /// </summary>
        internal static string ITransferInProgress {
            get {
                return ResourceManager.GetString("ITransferInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name cannot be empty.
        /// </summary>
        internal static string VNameEmpty {
            get {
                return ResourceManager.GetString("VNameEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name cannot be longer than : {0}.
        /// </summary>
        internal static string VNameLength {
            get {
                return ResourceManager.GetString("VNameLength", resourceCulture);
            }
        }
    }
}