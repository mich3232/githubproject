﻿

#pragma checksum "C:\Users\Michelle\Desktop\MelbourneGetaway (1)\MelbourneGetaway\MelbourneGetaway\MapPageDirections.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4FFCC78909A193BBD6D11EB1B99C1561"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MelbourneGetaway
{
    partial class MapPageDirections : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 17 "..\..\..\MapPageDirections.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.ShowDirectionsPanel_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 31 "..\..\..\MapPageDirections.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.MapTapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 51 "..\..\..\MapPageDirections.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.CloseDirections_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


