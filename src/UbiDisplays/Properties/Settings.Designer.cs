﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UbiDisplays.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RenderDisplaysTopmost {
            get {
                return ((bool)(this["RenderDisplaysTopmost"]));
            }
            set {
                this["RenderDisplaysTopmost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LogFileName {
            get {
                return ((string)(this["LogFileName"]));
            }
            set {
                this["LogFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoSelectKinect {
            get {
                return ((bool)(this["AutoSelectKinect"]));
            }
            set {
                this["AutoSelectKinect"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoStartCalibrateOnSelection {
            get {
                return ((bool)(this["AutoStartCalibrateOnSelection"]));
            }
            set {
                this["AutoStartCalibrateOnSelection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowProjectorWindowInTaskbar {
            get {
                return ((bool)(this["ShowProjectorWindowInTaskbar"]));
            }
            set {
                this["ShowProjectorWindowInTaskbar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9222")]
        public int RemoteDebuggingPort {
            get {
                return ((int)(this["RemoteDebuggingPort"]));
            }
            set {
                this["RemoteDebuggingPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%AppData%\\..\\Local\\Google\\Chrome\\Application\\chrome.exe")]
        public string ChromePath {
            get {
                return ((string)(this["ChromePath"]));
            }
            set {
                this["ChromePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableWebGL {
            get {
                return ((bool)(this["EnableWebGL"]));
            }
            set {
                this["EnableWebGL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableGPUAcceleration {
            get {
                return ((bool)(this["EnableGPUAcceleration"]));
            }
            set {
                this["EnableGPUAcceleration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableWebSecurity {
            get {
                return ((bool)(this["EnableWebSecurity"]));
            }
            set {
                this["EnableWebSecurity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableWebDatabases {
            get {
                return ((bool)(this["EnableWebDatabases"]));
            }
            set {
                this["EnableWebDatabases"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableWebFileAccessFromFileURL {
            get {
                return ((bool)(this["EnableWebFileAccessFromFileURL"]));
            }
            set {
                this["EnableWebFileAccessFromFileURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HoverMonitorPreview {
            get {
                return ((bool)(this["HoverMonitorPreview"]));
            }
            set {
                this["HoverMonitorPreview"] = value;
            }
        }
    }
}
