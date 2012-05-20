// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace OpenEarsTest
{
	[Register ("OpenEarsTestViewController")]
	partial class OpenEarsTestViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextView statusTextView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView heardTextView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton startListeningButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton stopListeningButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton suspendRecognitionButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton resumeRecognitionButton { get; set; }

		[Action ("startListeningButtonTouched:")]
		partial void startListeningButtonTouched (MonoTouch.Foundation.NSObject sender);

		[Action ("stopListeningButtonTouched:")]
		partial void stopListeningButtonTouched (MonoTouch.Foundation.NSObject sender);

		[Action ("suspendRecognitionButtonTapped:")]
		partial void suspendRecognitionButtonTapped (MonoTouch.Foundation.NSObject sender);

		[Action ("resumeRecognitionButtonTapped:")]
		partial void resumeRecognitionButtonTapped (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (statusTextView != null) {
				statusTextView.Dispose ();
				statusTextView = null;
			}

			if (heardTextView != null) {
				heardTextView.Dispose ();
				heardTextView = null;
			}

			if (startListeningButton != null) {
				startListeningButton.Dispose ();
				startListeningButton = null;
			}

			if (stopListeningButton != null) {
				stopListeningButton.Dispose ();
				stopListeningButton = null;
			}

			if (suspendRecognitionButton != null) {
				suspendRecognitionButton.Dispose ();
				suspendRecognitionButton = null;
			}

			if (resumeRecognitionButton != null) {
				resumeRecognitionButton.Dispose ();
				resumeRecognitionButton = null;
			}
		}
	}
}
