﻿

#pragma checksum "C:\Users\Michelle\Documents\Visual Studio 2013\Projects\ThePhotoStore\ThePhotoStore\ThePhotoStore.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E637824C826A0E5B01AFD6E5520BB8CD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThePhotoStore
{
    partial class ThePhotoStore : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 39 "..\..\..\ThePhotoStore.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Camera_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 40 "..\..\..\ThePhotoStore.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Save_Tapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 41 "..\..\..\ThePhotoStore.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Background_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


