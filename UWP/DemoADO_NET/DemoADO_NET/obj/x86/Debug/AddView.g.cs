﻿#pragma checksum "E:\FPT Aptech\UWP\T2104E\Demo\DemoADO_NET\DemoADO_NET\AddView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "05AF3240F877B2617EFCA33F914FCF7589B737AD072E7AAB6C96FF7CBEABAD2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoADO_NET
{
    partial class AddView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // AddView.xaml line 13
                {
                    this.txtName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // AddView.xaml line 17
                {
                    this.txtType = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // AddView.xaml line 21
                {
                    this.txtPrice = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // AddView.xaml line 25
                {
                    this.Save = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Save).Click += this.Save_OnClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
