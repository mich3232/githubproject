﻿

#pragma checksum "C:\Users\Michelle\Documents\Visual Studio 2013\Projects\ThePhotoStore\ThePhotoStore\Camera.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7C2629B6949D8D77453A98087BD9E851"
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
    partial class Camera : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 36 "..\..\..\Camera.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Camera_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 37 "..\..\..\Camera.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SavePhoto_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


