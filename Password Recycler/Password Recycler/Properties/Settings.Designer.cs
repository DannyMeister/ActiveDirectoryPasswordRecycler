﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasswordRecycler.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\r\n          <ArrayOfSettingsMap xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-insta" +
            "nce\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n            <SettingsMap />\r" +
            "\n          </ArrayOfSettingsMap>\r\n        ")]
        public global::SettingsMap.SettingsMapCollection Connections {
            get {
                return ((global::SettingsMap.SettingsMapCollection)(this["Connections"]));
            }
            set {
                this["Connections"] = value;
            }
        }
    }
}
