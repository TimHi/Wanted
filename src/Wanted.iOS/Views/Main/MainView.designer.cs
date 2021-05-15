// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Wanted.iOS.Views.Main
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		UIKit.UILabel Description { get; set; }

		[Outlet]
		UIKit.UILabel Header { get; set; }

		[Outlet]
		UIKit.UIImageView Image { get; set; }

		[Outlet]
		UIKit.UILabel Name { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Image != null) {
				Image.Dispose ();
				Image = null;
			}

			if (Name != null) {
				Name.Dispose ();
				Name = null;
			}

			if (Header != null) {
				Header.Dispose ();
				Header = null;
			}

			if (Description != null) {
				Description.Dispose ();
				Description = null;
			}
		}
	}
}
