using Foundation;
using Plugin.StoreReview.Abstractions;

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using UIKit;
using StoreKit;

namespace Plugin.StoreReview
{
	/// <summary>
	/// Implementation for StoreReview
	/// </summary>
	[Preserve(AllMembers = true)]
	public class StoreReviewImplementation : IStoreReview
    {
        /// <summary>
        /// Opens the store listing.
        /// </summary>
        /// <param name="appId">App identifier.</param>
        public void OpenStoreListing(string appId)
        {
#if __IOS__
			var url = $"itms-apps://itunes.apple.com/app/id{appId}";
#elif __TVOS__
			var url = $"com.apple.TVAppStore://itunes.apple.com/app/id{appId}";
#elif __MACOS__
			var url = $"macappstore://apps.apple.com/app/id{appId}";
#endif
            try
            {
                UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to launch app store: " + ex.Message);
            }
        }

        /// <summary>
        /// Opens the store review page.
        /// </summary>
        /// <param name="appId">App identifier.</param>
        public void OpenStoreReviewPage(string appId)
        {
#if __IOS__
            var url = $"itms-apps://itunes.apple.com/app/id{appId}?action=write-review";
#elif __TVOS__
			var url = $"com.apple.TVAppStore://itunes.apple.com/app/id{appId}?action=write-review";
#elif __MACOS__
			var url = $"macappstore://apps.apple.com/app/id{appId}?action=write-review";
#endif
            try
            {
                UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to launch app store: " + ex.Message);
            }
        }

        /// <summary>
        /// Requests an app review.
        /// </summary>
        public void RequestReview()
        {
#if __IOS__
            var isiOS103 = UIDevice.CurrentDevice.CheckSystemVersion(10, 3);
            if (isiOS103)
            {
                SKStoreReviewController.RequestReview();
            }
#elif __MACOS__
            var ismacOS1014 = UIDevice.CurrentDevice.CheckSystemVersion(10, 14);
            if (ismacOS1014)
            {
                SKStoreReviewController.RequestReview();
            }
#endif
        }
    }
}
