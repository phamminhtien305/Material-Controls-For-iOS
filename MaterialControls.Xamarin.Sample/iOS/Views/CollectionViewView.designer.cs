// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MaterialControls.Xamarin.Sample.iOS.Views
{
	[Register ("CollectionViewView")]
	partial class CollectionViewView
	{
		[Outlet]
		UIKit.UICollectionView CollectionView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CollectionView != null) {
				CollectionView.Dispose ();
				CollectionView = null;
			}
		}
	}
}