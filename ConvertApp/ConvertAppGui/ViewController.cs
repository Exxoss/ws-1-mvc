using System;

using AppKit;
using Foundation;

namespace ConvertAppGui
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ErrorLabel.StringValue = String.Empty;
            ResultLabel.StringValue = String.Empty;
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void PushConvertButton(NSObject sender)
        {
            ErrorLabel.StringValue = String.Empty;
            ResultLabel.StringValue = String.Empty;

            String input = InputTextField.StringValue;
            if (input.Length >= 8)
            {
                ErrorLabel.StringValue = "La phrase doit contenir moins de 8 caractères.";
                return;
            }
            ResultLabel.StringValue = InputTextField.StringValue.ToUpper();
        }
    }
}
