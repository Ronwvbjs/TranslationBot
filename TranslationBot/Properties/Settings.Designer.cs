//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TranslationBot.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SubscriptionKeyTextBoxText {
            get {
                return ((string)(this["SubscriptionKeyTextBoxText"]));
            }
            set {
                this["SubscriptionKeyTextBoxText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowSubscriptionKeyCheckBoxChecked {
            get {
                return ((bool)(this["ShowSubscriptionKeyCheckBoxChecked"]));
            }
            set {
                this["ShowSubscriptionKeyCheckBoxChecked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ToLanguageComboBoxSelectedIndex {
            get {
                return ((int)(this["ToLanguageComboBoxSelectedIndex"]));
            }
            set {
                this["ToLanguageComboBoxSelectedIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ModelTypeComboBoxSelectedIndex {
            get {
                return ((int)(this["ModelTypeComboBoxSelectedIndex"]));
            }
            set {
                this["ModelTypeComboBoxSelectedIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BotUserNameTextBoxText {
            get {
                return ((string)(this["BotUserNameTextBoxText"]));
            }
            set {
                this["BotUserNameTextBoxText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BotTokenTextBoxText {
            get {
                return ((string)(this["BotTokenTextBoxText"]));
            }
            set {
                this["BotTokenTextBoxText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowBotToekCheckBoxChecked {
            get {
                return ((bool)(this["ShowBotToekCheckBoxChecked"]));
            }
            set {
                this["ShowBotToekCheckBoxChecked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ChannelNameTextBoxText {
            get {
                return ((string)(this["ChannelNameTextBoxText"]));
            }
            set {
                this["ChannelNameTextBoxText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100, 100")]
        public global::System.Drawing.Point TranslationBotFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["TranslationBotFormLocation"]));
            }
            set {
                this["TranslationBotFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("^[{\\[] *(?i)")]
        public string BeginTagPatternTextBoxText {
            get {
                return ((string)(this["BeginTagPatternTextBoxText"]));
            }
            set {
                this["BeginTagPatternTextBoxText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(" *[}\\]]")]
        public string EndTagPatternTextBoxText {
            get {
                return ((string)(this["EndTagPatternTextBoxText"]));
            }
            set {
                this["EndTagPatternTextBoxText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ForceTranslationCheckBoxChecked {
            get {
                return ((bool)(this["ForceTranslationCheckBoxChecked"]));
            }
            set {
                this["ForceTranslationCheckBoxChecked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("translate")]
        public string CommandNameTextBoxText {
            get {
                return ((string)(this["CommandNameTextBoxText"]));
            }
            set {
                this["CommandNameTextBoxText"] = value;
            }
        }
    }
}
