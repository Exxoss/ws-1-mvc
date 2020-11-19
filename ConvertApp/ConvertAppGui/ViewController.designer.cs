// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ConvertAppGui
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ErrorLabel { get; set; }

		[Outlet]
		AppKit.NSTextField InputTextField { get; set; }

		[Outlet]
		AppKit.NSTextField ResultLabel { get; set; }

		[Action ("PushConvertButton:")]
		partial void PushConvertButton (Foundation.NSObject sender);

		[Action ("TypeInputTextField:")]
		partial void TypeInputTextField (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (InputTextField != null) {
				InputTextField.Dispose ();
				InputTextField = null;
			}

			if (ErrorLabel != null) {
				ErrorLabel.Dispose ();
				ErrorLabel = null;
			}

			if (ResultLabel != null) {
				ResultLabel.Dispose ();
				ResultLabel = null;
			}
		}
	}
}
