using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace XHVersion
{
    // @interface XHAppInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface XHAppInfo
    {
        // @property (copy, nonatomic) NSString * version;
        [Export("version")]
        string Version { get; set; }

        // @property (copy, nonatomic) NSString * releaseNotes;
        [Export("releaseNotes")]
        string ReleaseNotes { get; set; }

        // @property (copy, nonatomic) NSString * currentVersionReleaseDate;
        [Export("currentVersionReleaseDate")]
        string CurrentVersionReleaseDate { get; set; }

        // @property (copy, nonatomic) NSString * trackId;
        [Export("trackId")]
        string TrackId { get; set; }

        // @property (copy, nonatomic) NSString * bundleId;
        [Export("bundleId")]
        string BundleId { get; set; }

        // @property (copy, nonatomic) NSString * trackViewUrl;
        [Export("trackViewUrl")]
        string TrackViewUrl { get; set; }

        // @property (copy, nonatomic) NSString * appDescription;
        [Export("appDescription")]
        string AppDescription { get; set; }

        // @property (copy, nonatomic) NSString * sellerName;
        [Export("sellerName")]
        string SellerName { get; set; }

        // @property (copy, nonatomic) NSString * fileSizeBytes;
        [Export("fileSizeBytes")]
        string FileSizeBytes { get; set; }

        // @property (nonatomic, strong) NSArray * screenshotUrls;
        [Export("screenshotUrls", ArgumentSemantic.Strong)]
        NSObject[] ScreenshotUrls { get; set; }

        // -(instancetype)initWithResult:(NSDictionary *)result;
        [Export("initWithResult:")]
        IntPtr Constructor(NSDictionary result);
    }

    // @interface XHUpdateAlert : UIView
    [BaseType(typeof(UIView))]
    interface XHUpdateAlert
    {
        // +(void)showUpdateAlertWithVersion:(NSString *)version Descriptions:(NSArray *)descriptions;
        [Static]
        [Export("showUpdateAlertWithVersion:Descriptions:")]
        void ShowUpdateAlertWithVersion(string version, NSObject[] descriptions);

        // +(void)showUpdateAlertWithVersion:(NSString *)version Description:(NSString *)description;
        [Static]
        [Export("showUpdateAlertWithVersion:Description:")]
        void ShowUpdateAlertWithVersion(string version, string description);
    }

    // @interface XHVersion : NSObject
    [BaseType(typeof(NSObject))]
    interface XHVersion
    {
        // +(void)checkNewVersion;
        [Static]
        [Export("checkNewVersion")]
        void CheckNewVersion();

        // +(void)checkNewVersionAndCustomAlert:(NewVersionBlock)newVersion;
        [Static]
        [Export("checkNewVersionAndCustomAlert:")]
        void CheckNewVersionAndCustomAlert(Action<XHAppInfo> newVersion);
    }
}

