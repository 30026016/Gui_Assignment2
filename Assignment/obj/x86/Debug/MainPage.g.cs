﻿#pragma checksum "C:\Users\Akshay\Desktop\Assignment\Assignment\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D7AC5A24184FB1FE1354148BB0A5BFA7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 21
                {
                    this.LayoutRoot = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // MainPage.xaml line 27
                {
                    global::Assignment.SectionView element4 = (global::Assignment.SectionView)(target);
                    ((global::Assignment.SectionView)element4).NewsSelected += this.SectionView_NewsSelected;
                }
                break;
            case 5: // MainPage.xaml line 56
                {
                    this.HeadlinesHub = (global::Windows.UI.Xaml.Controls.Hub)(target);
                }
                break;
            case 6: // MainPage.xaml line 58
                {
                    this.HeadlinesHubSection = (global::Windows.UI.Xaml.Controls.HubSection)(target);
                }
                break;
            case 7: // MainPage.xaml line 64
                {
                    this.WorldNewsHubSection = (global::Windows.UI.Xaml.Controls.HubSection)(target);
                }
                break;
            case 8: // MainPage.xaml line 70
                {
                    this.TechnologyHubSection = (global::Windows.UI.Xaml.Controls.HubSection)(target);
                }
                break;
            case 9: // MainPage.xaml line 76
                {
                    this.EntertainmentHubSection = (global::Windows.UI.Xaml.Controls.HubSection)(target);
                }
                break;
            case 10: // MainPage.xaml line 82
                {
                    this.SportsHubSection = (global::Windows.UI.Xaml.Controls.HubSection)(target);
                }
                break;
            case 11: // MainPage.xaml line 53
                {
                    this.signIn = (global::Windows.UI.Xaml.Controls.Button)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

