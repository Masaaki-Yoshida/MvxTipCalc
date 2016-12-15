// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MvxTipCalc.iOS.Views
{
    [Register ("TipView")]
    partial class TipView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider slider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField subTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tip { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (slider != null) {
                slider.Dispose ();
                slider = null;
            }

            if (subTotal != null) {
                subTotal.Dispose ();
                subTotal = null;
            }

            if (tip != null) {
                tip.Dispose ();
                tip = null;
            }
        }
    }
}