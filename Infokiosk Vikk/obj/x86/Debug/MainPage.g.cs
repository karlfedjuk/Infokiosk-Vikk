﻿#pragma checksum "c:\users\karl.fedjuk\documents\visual studio 2015\Projects\Infokiosk Vikk\Infokiosk Vikk\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E653A408821459600C8552D1736FC15B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infokiosk_Vikk
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.IconsListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 42 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.IconsListBox).SelectionChanged += this.IconsListBox_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.UudisedBoxitem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 4:
                {
                    this.TunniplaaniBoxitem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5:
                {
                    this.KontaktidBoxitem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6:
                {
                    this.hamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.hamburgerButton).Click += this.hamburgerButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

