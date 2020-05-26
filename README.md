## Store Review Plugin for Xamarin

**Platform Support**

|Platform|Version|
| ------------------- | :------------------: |
|UWP|API 10+|
|Xamarin.Android|API 10+|
|Xamarin.iOS|iOS 7+|
|Xamarin.Mac|macOS 10.14+|
|Xamarin.tvOS|All|


### Build Status
![](https://jamesmontemagno.visualstudio.com/_apis/public/build/definitions/6b79a378-ddd6-4e31-98ac-a12fcd68644c/12/badge)

### NuGet
https://www.nuget.org/packages/Plugin.StoreReview/

### API

#### Open store listing
This will open the related app store for your app identifier.
iOS: This is found on your iTunes connect page for your app
Android: This is your package Id from your Android Manifest.
UWP:  This is the Store ID: You can find the link to your app's Store listing on the App identity page, in the App management section of each app in your dashboard.

```csharp
/// <summary>
/// Opens the store listing.
/// </summary>
/// <param name="appId">App identifier.</param>
void OpenStoreListing(string appId);
```

#### Open to Review Page
Launches app directly to Review Page if possible

```csharp
/// <summary>
/// Opens the store review page.
/// </summary>
/// <param name="appId">App identifier.</param>
void OpenStoreReviewPage(string appId);
```

#### Request Review
UWP (all versions), iOS and macOS only to prompt for the user to review the app:
Read: https://blog.xamarin.com/requesting-reviews-ios-10-3s-skstorereviewcontroller/

```csharp
/// <summary>
/// Requests the review.
/// </summary>
void RequestReview();
```

#### License
Under MIT, see LICENSE file.

