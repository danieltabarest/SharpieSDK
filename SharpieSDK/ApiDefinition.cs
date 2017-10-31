using System;
using AVFoundation;
using AVKit;
using CoreFoundation;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using UIKit;
using Foundation;



namespace SharpieSDK
{
    [Static]
    
    partial interface Constants
    {
        //// extern double PlayKitVersionNumber;
        //[Field("PlayKitVersionNumber", "__Internal")]
        //double PlayKitVersionNumber { get; }

        //// extern const unsigned char [] PlayKitVersionString;
        //[Field("PlayKitVersionString", "__Internal")]
        //IntPtr PlayKitVersionString { get; }

        //// extern double KalturaNetKitVersionNumber;
        //[Field("KalturaNetKitVersionNumber", "__Internal")]
        //double KalturaNetKitVersionNumber { get; }

        //// extern const unsigned char [] KalturaNetKitVersionString;
        //[Field("KalturaNetKitVersionString", "__Internal")]
        //IntPtr KalturaNetKitVersionString { get; }
    }

    // @interface PKEvent : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKEvent
    {
        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable data;
        [NullAllowed, Export("data", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Data { get; }

        // -(instancetype _Nonnull)init:(NSDictionary<NSString *,id> * _Nullable)data __attribute__((objc_designated_initializer));
        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSDictionary<NSString, NSObject> data);
    }

    // @interface AdEvent : PKEvent
    [BaseType(typeof(PKEvent))]
    [Model]
    interface AdEvent
    {
        // @property (readonly, copy, nonatomic, class) NSArray<Class> * _Nonnull allEventTypes;
        [Static]
        [Export("allEventTypes", ArgumentSemantic.Copy)]
        Class[] AllEventTypes { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adBreakReady;
        [Static]
        [Export("adBreakReady")]
        Class AdBreakReady { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull allAdsCompleted;
        [Static]
        [Export("allAdsCompleted")]
        Class AllAdsCompleted { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adComplete;
        [Static]
        [Export("adComplete")]
        Class AdComplete { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adClicked;
        [Static]
        [Export("adClicked")]
        Class AdClicked { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adFirstQuartile;
        [Static]
        [Export("adFirstQuartile")]
        Class AdFirstQuartile { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adLoaded;
        [Static]
        [Export("adLoaded")]
        Class AdLoaded { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adLog;
        [Static]
        [Export("adLog")]
        Class AdLog { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adMidpoint;
        [Static]
        [Export("adMidpoint")]
        Class AdMidpoint { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adPaused;
        [Static]
        [Export("adPaused")]
        Class AdPaused { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adResumed;
        [Static]
        [Export("adResumed")]
        Class AdResumed { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adSkipped;
        [Static]
        [Export("adSkipped")]
        Class AdSkipped { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adStarted;
        [Static]
        [Export("adStarted")]
        Class AdStarted { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adTapped;
        [Static]
        [Export("adTapped")]
        Class AdTapped { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adThirdQuartile;
        [Static]
        [Export("adThirdQuartile")]
        Class AdThirdQuartile { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adDidProgressToTime;
        [Static]
        [Export("adDidProgressToTime")]
        Class AdDidProgressToTime { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adDidRequestContentPause;
        [Static]
        [Export("adDidRequestContentPause")]
        Class AdDidRequestContentPause { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adDidRequestContentResume;
        [Static]
        [Export("adDidRequestContentResume")]
        Class AdDidRequestContentResume { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull webOpenerEvent;
        [Static]
        [Export("webOpenerEvent")]
        Class WebOpenerEvent { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adWebOpenerWillOpenExternalBrowser;
        [Static]
        [Export("adWebOpenerWillOpenExternalBrowser")]
        Class AdWebOpenerWillOpenExternalBrowser { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adWebOpenerWillOpenInAppBrowser;
        [Static]
        [Export("adWebOpenerWillOpenInAppBrowser")]
        Class AdWebOpenerWillOpenInAppBrowser { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adWebOpenerDidOpenInAppBrowser;
        [Static]
        [Export("adWebOpenerDidOpenInAppBrowser")]
        Class AdWebOpenerDidOpenInAppBrowser { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adWebOpenerWillCloseInAppBrowser;
        [Static]
        [Export("adWebOpenerWillCloseInAppBrowser")]
        Class AdWebOpenerWillCloseInAppBrowser { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adWebOpenerDidCloseInAppBrowser;
        [Static]
        [Export("adWebOpenerDidCloseInAppBrowser")]
        Class AdWebOpenerDidCloseInAppBrowser { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adCuePointsUpdate;
        [Static]
        [Export("adCuePointsUpdate")]
        Class AdCuePointsUpdate { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adStartedBuffering;
        [Static]
        [Export("adStartedBuffering")]
        Class AdStartedBuffering { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adPlaybackReady;
        [Static]
        [Export("adPlaybackReady")]
        Class AdPlaybackReady { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull requestTimedOut;
        [Static]
        [Export("requestTimedOut")]
        Class RequestTimedOut { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull adsRequested;
        [Static]
        [Export("adsRequested")]
        Class AdsRequested { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull error;
        [Static]
        [Export("error")]
        Class Error { get; }

        // -(instancetype _Nonnull)init:(NSDictionary<NSString *,id> * _Nullable)data __attribute__((objc_designated_initializer));
        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSDictionary<NSString, NSObject> data);
    }

    // @interface AdEventDataKeys : NSObject
    [BaseType(typeof(NSObject))]
    [Model]
    interface AdEventDataKeys
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull mediaTime;
        [Static]
        [Export("mediaTime")]
        string MediaTime { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull totalTime;
        [Static]
        [Export("totalTime")]
        string TotalTime { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull webOpener;
        [Static]
        [Export("webOpener")]
        string WebOpener { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull error;
        [Static]
        [Export("error")]
        string Error { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull adCuePoints;
        [Static]
        [Export("adCuePoints")]
        string AdCuePoints { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull adInfo;
        [Static]
        [Export("adInfo")]
        string AdInfo { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull adTagUrl;
        [Static]
        [Export("adTagUrl")]
        string AdTagUrl { get; }
    }

    // @interface BasePlugin : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Model]
    interface BasePlugin
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull pluginName;
        [Static]
        [Export("pluginName")]
        string PluginName { get; }

        // @property (nonatomic, weak) id<Player> _Nullable player;
        [NullAllowed, Export("player", ArgumentSemantic.Weak)]
        Player Player { get; set; }

        // @property (nonatomic, weak) MessageBus * _Nullable messageBus;
        [NullAllowed, Export("messageBus", ArgumentSemantic.Weak)]
        MessageBus MessageBus { get; set; }

        // -(instancetype _Nullable)initWithPlayer:(id<Player> _Nonnull)player pluginConfig:(id _Nullable)pluginConfig messageBus:(MessageBus * _Nonnull)messageBus error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
        [Export("initWithPlayer:pluginConfig:messageBus:error:")]
        [DesignatedInitializer]
        IntPtr Constructor(Player player, [NullAllowed] NSObject pluginConfig, MessageBus messageBus, [NullAllowed] out NSError error);

        // -(void)onUpdateMediaWithMediaConfig:(MediaConfig * _Nonnull)mediaConfig;
        [Export("onUpdateMediaWithMediaConfig:")]
        void OnUpdateMediaWithMediaConfig(MediaConfig mediaConfig);

        // -(void)onUpdateConfigWithPluginConfig:(id _Nonnull)pluginConfig;
        [Export("onUpdateConfigWithPluginConfig:")]
        void OnUpdateConfigWithPluginConfig(NSObject pluginConfig);

        // -(void)destroy;
        [Export("destroy")]
        void Destroy();
    }

    // @interface DRMParams : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Model]
    interface DRMParams
    {
        // +(DRMParams * _Nullable)fromJSON:(id _Nonnull)json __attribute__((warn_unused_result));
        [Static]
        [Export("fromJSON:")]
        [return: NullAllowed]
        DRMParams FromJSON(NSObject json);
    }

    // @protocol LocalDataStore
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface LocalDataStore
    {
        // @required -(BOOL)saveWithKey:(NSString * _Nonnull)key value:(NSData * _Nonnull)value error:(NSError * _Nullable * _Nullable)error;
        [Abstract]
        [Export("saveWithKey:value:error:")]
        bool SaveWithKey(string key, NSData value, [NullAllowed] out NSError error);

        // @required -(NSData * _Nullable)loadWithKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
        [Abstract]
        [Export("loadWithKey:error:")]
        [return: NullAllowed]
        NSData LoadWithKey(string key, [NullAllowed] out NSError error);

        // @required -(BOOL)removeWithKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
        [Abstract]
        [Export("removeWithKey:error:")]
        bool RemoveWithKey(string key, [NullAllowed] out NSError error);
    }

    // @interface DefaultLocalDataStore : NSObject <LocalDataStore>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Model]
    interface DefaultLocalDataStore : LocalDataStore
    {
        // +(DefaultLocalDataStore * _Nullable)defaultDataStore __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("defaultDataStore")]
        
        DefaultLocalDataStore DefaultDataStore { get; }

        // -(instancetype _Nullable)initWithDirectory:(NSSearchPathDirectory)directory error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
        [Export("initWithDirectory:error:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSSearchPathDirectory directory, [NullAllowed] out NSError error);

        // -(BOOL)saveWithKey:(NSString * _Nonnull)key value:(NSData * _Nonnull)value error:(NSError * _Nullable * _Nullable)error;
        [Export("saveWithKey:value:error:")]
        bool SaveWithKey(string key, NSData value, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)loadWithKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
        [Export("loadWithKey:error:")]
        [return: NullAllowed]
        NSData LoadWithKey(string key, [NullAllowed] out NSError error);

        // -(BOOL)removeWithKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
        [Export("removeWithKey:error:")]
        bool RemoveWithKey(string key, [NullAllowed] out NSError error);
    }

    // @interface FairPlayDRMParams : DRMParams
    [BaseType(typeof(DRMParams))]
    [Model]
    interface FairPlayDRMParams
    {
    }

    // @protocol PKRequestParamsAdapter
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface PKRequestParamsAdapter
    {
        // @required -(void)updateRequestAdapterWith:(id<Player> _Nonnull)player;
        [Abstract]
        [Export("updateRequestAdapterWith:")]
        void UpdateRequestAdapterWith(Player player);

        // @required -(PKRequestParams * _Nonnull)adaptWithRequestParams:(PKRequestParams * _Nonnull)requestParams __attribute__((warn_unused_result));
        [Abstract]
        [Export("adaptWithRequestParams:")]
        PKRequestParams AdaptWithRequestParams(PKRequestParams requestParams);
    }

    // @interface KalturaPlaybackRequestAdapter : NSObject <PKRequestParamsAdapter>
    [BaseType(typeof(NSObject))]
    [Model]
    interface KalturaPlaybackRequestAdapter : PKRequestParamsAdapter
    {
        // +(void)installIn:(id<Player> _Nonnull)player withAppName:(NSString * _Nonnull)appName;
        [Static]
        [Export("installIn:withAppName:")]
        void InstallIn(Player player, string appName);

        // -(void)updateRequestAdapterWith:(id<Player> _Nonnull)player;
        [Export("updateRequestAdapterWith:")]
        void UpdateRequestAdapterWith(Player player);

        // -(PKRequestParams * _Nonnull)adaptWithRequestParams:(PKRequestParams * _Nonnull)requestParams __attribute__((warn_unused_result));
        [Export("adaptWithRequestParams:")]
        PKRequestParams AdaptWithRequestParams(PKRequestParams requestParams);
    }

    // @interface LocalAssetsManager : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface LocalAssetsManager
    {
        // +(LocalAssetsManager * _Nonnull)managerWithDefaultDataStore __attribute__((warn_unused_result));
        [Static]
        [Export("managerWithDefaultDataStore")]
        
        LocalAssetsManager ManagerWithDefaultDataStore { get; }

        // +(LocalAssetsManager * _Nonnull)managerWithStorage:(id<LocalDataStore> _Nonnull)storage __attribute__((warn_unused_result));
        [Static]
        [Export("managerWithStorage:")]
        LocalAssetsManager ManagerWithStorage(LocalDataStore storage);

        // +(LocalAssetsManager * _Nonnull)manager __attribute__((warn_unused_result));
        [Static]
        [Export("manager")]
        
        LocalAssetsManager Manager { get; }

        // -(void)prepareForDownloadWithAsset:(AVURLAsset * _Nonnull)asset mediaSource:(MediaSource * _Nonnull)mediaSource;
        [Export("prepareForDownloadWithAsset:mediaSource:")]
        void PrepareForDownloadWithAsset(AVUrlAsset asset, MediaSource mediaSource);

        // -(MediaEntry * _Nonnull)createLocalMediaEntryFor:(NSString * _Nonnull)assetId localURL:(NSURL * _Nonnull)localURL __attribute__((warn_unused_result));
        [Export("createLocalMediaEntryFor:localURL:")]
        MediaEntry CreateLocalMediaEntryFor(string assetId, NSUrl localURL);

        // -(MediaSource * _Nullable)getPreferredDownloadableMediaSourceFor:(MediaEntry * _Nonnull)mediaEntry __attribute__((warn_unused_result));
        [Export("getPreferredDownloadableMediaSourceFor:")]
        [return: NullAllowed]
        MediaSource GetPreferredDownloadableMediaSourceFor(MediaEntry mediaEntry);

        // -(void)assetDownloadFinishedWithLocation:(NSURL * _Nonnull)location mediaSource:(MediaSource * _Nonnull)mediaSource callback:(void (^ _Nonnull)(NSError * _Nullable))callback;
        [Export("assetDownloadFinishedWithLocation:mediaSource:callback:")]
        void AssetDownloadFinishedWithLocation(NSUrl location, MediaSource mediaSource, Action<NSError> callback);

        // -(void)renewDownloadedAssetWithLocation:(NSURL * _Nonnull)location mediaSource:(MediaSource * _Nonnull)mediaSource callback:(void (^ _Nonnull)(NSError * _Nullable))callback;
        [Export("renewDownloadedAssetWithLocation:mediaSource:callback:")]
        void RenewDownloadedAssetWithLocation(NSUrl location, MediaSource mediaSource, Action<NSError> callback);

        // -(void)unregisterAsset:(NSString * _Null_unspecified)assetUri callback:(void (^ _Nonnull)(NSError * _Nullable))callback;
        [Export("unregisterAsset:callback:")]
        void UnregisterAsset(string assetUri, Action<NSError> callback);
    }

    // @interface MediaConfig : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface MediaConfig
    {
        // @property (nonatomic, strong) MediaEntry * _Nonnull mediaEntry;
        [Export("mediaEntry", ArgumentSemantic.Strong)]
        MediaEntry MediaEntry { get; set; }

        // @property (nonatomic) NSTimeInterval startTime;
        [Export("startTime")]
        double StartTime { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(instancetype _Nonnull)initWithMediaEntry:(MediaEntry * _Nonnull)mediaEntry startTime:(NSTimeInterval)startTime __attribute__((objc_designated_initializer));
        [Export("initWithMediaEntry:startTime:")]
        [DesignatedInitializer]
        IntPtr Constructor(MediaEntry mediaEntry, double startTime);

        // +(MediaConfig * _Nonnull)configWithMediaEntry:(MediaEntry * _Nonnull)mediaEntry __attribute__((warn_unused_result));
        [Static]
        [Export("configWithMediaEntry:")]
        MediaConfig ConfigWithMediaEntry(MediaEntry mediaEntry);

        // +(MediaConfig * _Nonnull)configWithMediaEntry:(MediaEntry * _Nonnull)mediaEntry startTime:(NSTimeInterval)startTime __attribute__((warn_unused_result));
        [Static]
        [Export("configWithMediaEntry:startTime:")]
        MediaConfig ConfigWithMediaEntry(MediaEntry mediaEntry, double startTime);
    }

    // @interface PlayKit_Swift_444 (MediaConfig) <NSCopying>
    [Category]
    [BaseType(typeof(MediaConfig))]
    interface MediaConfig_PlayKit_Swift_444 //: INSCopying
    {
        //[Static]
        ////-(id _Nonnull) copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result));
        //[Export("copyWithZone:")]
        //unsafe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
    }

    // @interface MediaEntry : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Protocol]
    interface MediaEntry
    {
        // @property (copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; set; }

        // @property (copy, nonatomic) NSArray<MediaSource *> * _Nullable sources;
        [NullAllowed, Export("sources", ArgumentSemantic.Copy)]
        MediaSource[] Sources { get; set; }

        // @property (nonatomic) NSTimeInterval duration;
        [Export("duration")]
        double Duration { get; set; }

        // @property (nonatomic) enum MediaType mediaType;
        [Export("mediaType", ArgumentSemantic.Assign)]
        MediaType MediaType { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Metadata { get; set; }

        // -(instancetype _Nonnull)init:(NSString * _Nonnull)id sources:(NSArray<MediaSource *> * _Nonnull)sources duration:(NSTimeInterval)duration __attribute__((objc_designated_initializer));
        [Export("init:sources:duration:")]
        [DesignatedInitializer]
        IntPtr Constructor(string id, MediaSource[] sources, double duration);

        // -(instancetype _Nonnull)initWithJson:(id _Nonnull)json __attribute__((objc_designated_initializer));
        [Export("initWithJson:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSObject json);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @protocol MediaEntryProvider
    [Protocol, Model]
    interface MediaEntryProvider
    {
        // @required -(void)loadMediaWithCallback:(void (^ _Nonnull)(MediaEntry * _Nullable, NSError * _Nullable))callback;
        [Abstract]
        [Export("loadMediaWithCallback:")]
        void LoadMediaWithCallback(Action<MediaEntry, NSError> callback);

        // @required -(void)cancel;
        [Abstract]
        [Export("cancel")]
        void Cancel();
    }

    // @interface MediaSource : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface MediaSource
    {
        // @property (copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; set; }

        // @property (copy, nonatomic) NSURL * _Nullable contentUrl;
        [NullAllowed, Export("contentUrl", ArgumentSemantic.Copy)]
        NSUrl ContentUrl { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable mimeType;
        [NullAllowed, Export("mimeType")]
        string MimeType { get; set; }

        // @property (copy, nonatomic) NSArray<DRMParams *> * _Nullable drmData;
        [NullAllowed, Export("drmData", ArgumentSemantic.Copy)]
        DRMParams[] DrmData { get; set; }

        // @property (nonatomic) enum MediaFormat mediaFormat;
        [Export("mediaFormat", ArgumentSemantic.Assign)]
        MediaFormat MediaFormat { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull fileExt;
        [Export("fileExt")]
        string FileExt { get; }

        // -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
        [Export("initWithId:")]
        IntPtr Constructor(string id);

        // -(instancetype _Nonnull)init:(NSString * _Nonnull)id contentUrl:(NSURL * _Nullable)contentUrl mimeType:(NSString * _Nullable)mimeType drmData:(NSArray<DRMParams *> * _Nullable)drmData mediaFormat:(enum MediaFormat)mediaFormat __attribute__((objc_designated_initializer));
        [Export("init:contentUrl:mimeType:drmData:mediaFormat:")]
        [DesignatedInitializer]
        IntPtr Constructor(string id, [NullAllowed] NSUrl contentUrl, [NullAllowed] string mimeType, [NullAllowed] DRMParams[] drmData, MediaFormat mediaFormat);

        // -(instancetype _Nonnull)initWithJson:(id _Nonnull)json __attribute__((objc_designated_initializer));
        [Export("initWithJson:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSObject json);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @interface MessageBus : NSObject
    [BaseType(typeof(NSObject))]
    [Model]
    interface MessageBus
    {
        // -(void)addObserver:(id _Nonnull)observer events:(NSArray<Class> * _Nonnull)events block:(void (^ _Nonnull)(PKEvent * _Nonnull))block;
        [Export("addObserver:events:block:")]
        void AddObserver(NSObject observer, Class[] events, Action<PKEvent> block);

        // -(void)addObserver:(id _Nonnull)observer events:(NSArray<Class> * _Nonnull)events observeOn:(dispatch_queue_t _Nonnull)dispatchQueue block:(void (^ _Nonnull)(PKEvent * _Nonnull))block;
        [Export("addObserver:events:observeOn:block:")]
        void AddObserver(NSObject observer, Class[] events, DispatchQueue dispatchQueue, Action<PKEvent> block);

        // -(void)removeObserver:(id _Nonnull)observer events:(NSArray<Class> * _Nonnull)events;
        [Export("removeObserver:events:")]
        void RemoveObserver(NSObject observer, Class[] events);

        // -(void)post:(PKEvent * _Nonnull)event;
        [Export("post:")]
        void Post(PKEvent @event);
    }

    // @interface MockMediaEntryProvider : NSObject <MediaEntryProvider>
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface MockMediaEntryProvider : MediaEntryProvider
    {
        // @property (copy, nonatomic) NSString * _Nullable id;
        [NullAllowed, Export("id")]
        string Id { get; set; }

        // @property (copy, nonatomic) NSURL * _Nullable url;
        [NullAllowed, Export("url", ArgumentSemantic.Copy)]
        NSUrl Url { get; set; }

        // @property (nonatomic) id _Nullable content;
        [NullAllowed, Export("content", ArgumentSemantic.Assign)]
        NSObject Content { get; set; }

        // -(void)loadMediaWithCallback:(void (^ _Nonnull)(MediaEntry * _Nullable, NSError * _Nullable))callback;
        [Export("loadMediaWithCallback:")]
        void LoadMediaWithCallback(Action<MediaEntry, NSError> callback);

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();
    }

    // @interface OVPMediaProvider : NSObject <MediaEntryProvider>
    [BaseType(typeof(NSObject))]
    [Model]
    interface OVPMediaProvider : MediaEntryProvider
    {
        // @property (nonatomic, strong) id<SessionProvider> _Nullable sessionProvider;
        [NullAllowed, Export("sessionProvider", ArgumentSemantic.Strong)]
        SessionProvider SessionProvider { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable entryId;
        [NullAllowed, Export("entryId")]
        string EntryId { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable uiconfId;
        [NullAllowed, Export("uiconfId", ArgumentSemantic.Strong)]
        NSNumber UiconfId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable referrer;
        [NullAllowed, Export("referrer")]
        string Referrer { get; set; }

        // -(instancetype _Nonnull)init:(id<SessionProvider> _Nonnull)sessionProvider __attribute__((objc_designated_initializer));
        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor(SessionProvider sessionProvider);

        // -(void)loadMediaWithCallback:(void (^ _Nonnull)(MediaEntry * _Nullable, NSError * _Nullable))callback;
        [Export("loadMediaWithCallback:")]
        void LoadMediaWithCallback(Action<MediaEntry, NSError> callback);

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();
    }

    // @interface PKAdCuePoints : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKAdCuePoints
    {
        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull cuePoints;
        [Export("cuePoints", ArgumentSemantic.Copy)]
        NSNumber[] CuePoints { get; }

        // -(instancetype _Nonnull)initWithCuePoints:(NSArray<NSNumber *> * _Nonnull)cuePoints __attribute__((objc_designated_initializer));
        [Export("initWithCuePoints:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSNumber[] cuePoints);

        // @property (readonly, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; }

        // @property (readonly, nonatomic) BOOL hasPreRoll;
        [Export("hasPreRoll")]
        bool HasPreRoll { get; }

        // @property (readonly, nonatomic) BOOL hasMidRoll;
        [Export("hasMidRoll")]
        bool HasMidRoll { get; }

        // @property (readonly, nonatomic) BOOL hasPostRoll;
        [Export("hasPostRoll")]
        bool HasPostRoll { get; }
    }

    // @interface PKAdInfo : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKAdInfo
    {
        // @property (nonatomic) NSTimeInterval duration;
        [Export("duration")]
        double Duration { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; set; }

        // @property (nonatomic) NSTimeInterval timeOffset;
        [Export("timeOffset")]
        double TimeOffset { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull adDescription;
        [Export("adDescription")]
        string AdDescription { get; set; }

        // @property (nonatomic) BOOL isSkippable;
        [Export("isSkippable")]
        bool IsSkippable { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull contentType;
        [Export("contentType")]
        string ContentType { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull adId;
        [Export("adId")]
        string AdId { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull adSystem;
        [Export("adSystem")]
        string AdSystem { get; set; }

        // @property (nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; set; }

        // @property (nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; set; }

        // @property (nonatomic) NSInteger totalAds;
        [Export("totalAds")]
        nint TotalAds { get; set; }

        // @property (nonatomic) NSInteger adPosition;
        [Export("adPosition")]
        nint AdPosition { get; set; }

        // @property (nonatomic) BOOL isBumper;
        [Export("isBumper")]
        bool IsBumper { get; set; }

        // @property (nonatomic) NSInteger podIndex;
        [Export("podIndex")]
        nint PodIndex { get; set; }

        // @property (readonly, nonatomic) enum AdPositionType positionType;
        [Export("positionType")]
        AdPositionType PositionType { get; }

        // -(instancetype _Nonnull)initWithAdDescription:(NSString * _Nonnull)adDescription adDuration:(NSTimeInterval)adDuration title:(NSString * _Nonnull)title isSkippable:(BOOL)isSkippable contentType:(NSString * _Nonnull)contentType adId:(NSString * _Nonnull)adId adSystem:(NSString * _Nonnull)adSystem height:(NSInteger)height width:(NSInteger)width totalAds:(NSInteger)totalAds adPosition:(NSInteger)adPosition timeOffset:(NSTimeInterval)timeOffset isBumper:(BOOL)isBumper podIndex:(NSInteger)podIndex __attribute__((objc_designated_initializer));
        [Export("initWithAdDescription:adDuration:title:isSkippable:contentType:adId:adSystem:height:width:totalAds:adPosition:timeOffset:isBumper:podIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor(string adDescription, double adDuration, string title, bool isSkippable, string contentType, string adId, string adSystem, nint height, nint width, nint totalAds, nint adPosition, double timeOffset, bool isBumper, nint podIndex);
    }

    // @protocol PKBoundary
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface PKBoundary
    {
        // @required @property (readonly, nonatomic) NSTimeInterval time;
        [Abstract]
        [Export("time")]
        double Time { get; }
    }

    // @interface PKBoundaryFactory : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKBoundaryFactory
    {
        // -(instancetype _Nonnull)initWithDuration:(NSTimeInterval)duration __attribute__((objc_designated_initializer));
        [Export("initWithDuration:")]
        [DesignatedInitializer]
        IntPtr Constructor(double duration);

        // -(PKPercentageTimeBoundary * _Nonnull)percentageTimeBoundaryWithBoundary:(NSInteger)boundary __attribute__((warn_unused_result));
        [Export("percentageTimeBoundaryWithBoundary:")]
        PKPercentageTimeBoundary PercentageTimeBoundaryWithBoundary(nint boundary);

        // -(PKTimeBoundary * _Nonnull)timeBoundaryWithBoundaryTime:(NSTimeInterval)boundaryTime __attribute__((warn_unused_result));
        [Export("timeBoundaryWithBoundaryTime:")]
        PKTimeBoundary TimeBoundaryWithBoundaryTime(double boundaryTime);
    }

    // @interface PKErrorCode : NSObject
    [BaseType(typeof(NSObject))]
    [Model]
    interface PKErrorCode
    {
        // @property (readonly, nonatomic, class) NSInteger FailedToLoadAssetFromKeys;
        [Static]
        [Export("FailedToLoadAssetFromKeys")]
        nint FailedToLoadAssetFromKeys { get; }

        // @property (readonly, nonatomic, class) NSInteger AssetNotPlayable;
        [Static]
        [Export("AssetNotPlayable")]
        nint AssetNotPlayable { get; }

        // @property (readonly, nonatomic, class) NSInteger PlayerItemFailed;
        [Static]
        [Export("PlayerItemFailed")]
        nint PlayerItemFailed { get; }

        // @property (readonly, nonatomic, class) NSInteger PlayerFailed;
        [Static]
        [Export("PlayerFailed")]
        nint PlayerFailed { get; }

        // @property (readonly, nonatomic, class) NSInteger PlayerItemErrorLogEvent;
        [Static]
        [Export("PlayerItemErrorLogEvent")]
        nint PlayerItemErrorLogEvent { get; }

        // @property (readonly, nonatomic, class) NSInteger FailedToCreatePlugin;
        [Static]
        [Export("FailedToCreatePlugin")]
        nint FailedToCreatePlugin { get; }

        // @property (readonly, nonatomic, class) NSInteger MissingPluginConfig;
        [Static]
        [Export("MissingPluginConfig")]
        nint MissingPluginConfig { get; }
    }

    // @interface PKErrorDomain : NSObject
    [BaseType(typeof(NSObject))][Model]
    interface PKErrorDomain
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull Plugin;
        [Static]
        [Export("Plugin")]
        string Plugin { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull Player;
        [Static]
        [Export("Player")]
        string Player { get; }
    }

    // @interface PlayKit_Swift_658 (PKEvent)
    //[Category]
    [BaseType(typeof(PKEvent))]
    [Model]
    interface PKEvent_PlayKit_Swift_658
    {
        // @property (readonly, nonatomic, strong) NSNumber * _Nullable adMediaTime;
        [NullAllowed, Export("adMediaTime", ArgumentSemantic.Strong)]
        NSNumber AdMediaTime { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nullable adTotalTime;
        [NullAllowed, Export("adTotalTime", ArgumentSemantic.Strong)]
        NSNumber AdTotalTime { get; }

        // @property (readonly, nonatomic, strong) NSObject * _Nullable adWebOpener;
        [NullAllowed, Export("adWebOpener", ArgumentSemantic.Strong)]
        NSObject AdWebOpener { get; }

        // @property (readonly, nonatomic, strong) NSError * _Nullable adError;
        [NullAllowed, Export("adError", ArgumentSemantic.Strong)]
        NSError AdError { get; }

        // @property (readonly, nonatomic, strong) PKAdCuePoints * _Nullable adCuePoints;
        [NullAllowed, Export("adCuePoints", ArgumentSemantic.Strong)]
        PKAdCuePoints AdCuePoints { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable adTagUrl;
        [NullAllowed, Export("adTagUrl")]
        string AdTagUrl { get; }

        // @property (readonly, nonatomic, strong) PKAdInfo * _Nullable adInfo;
        [NullAllowed, Export("adInfo", ArgumentSemantic.Strong)]
        PKAdInfo AdInfo { get; }
    }

    // @interface PlayKit_Swift_681 (PKEvent)
    //[Category]
    [BaseType(typeof(PKEvent))]
    [Model]
    interface PKEvent_PlayKit_Swift_681
    {
        // @property (readonly, nonatomic, strong) NSNumber * _Nullable duration;
        [NullAllowed, Export("duration", ArgumentSemantic.Strong)]
        NSNumber Duration { get; }

        // @property (readonly, nonatomic, strong) PKTracks * _Nullable tracks;
        [NullAllowed, Export("tracks", ArgumentSemantic.Strong)]
        PKTracks Tracks { get; }

        // @property (readonly, nonatomic, strong) PKPlaybackInfo * _Nullable playbackInfo;
        [NullAllowed, Export("playbackInfo", ArgumentSemantic.Strong)]
        PKPlaybackInfo PlaybackInfo { get; }

        // @property (readonly, nonatomic) enum PlayerState oldState;
        [Export("oldState")]
        PlayerState OldState { get; }

        // @property (readonly, nonatomic) enum PlayerState newState;
        [Export("newState")]
        PlayerState NewState { get; }

        // @property (readonly, nonatomic, strong) NSError * _Nullable error;
        [NullAllowed, Export("error", ArgumentSemantic.Strong)]
        NSError Error { get; }

        // @property (readonly, copy, nonatomic) NSArray<AVMetadataItem *> * _Nullable timedMetadata;
        [NullAllowed, Export("timedMetadata", ArgumentSemantic.Copy)]
        AVMetadataItem[] TimedMetadata { get; }

        // @property (readonly, nonatomic, strong) MediaSource * _Nullable mediaSource;
        [NullAllowed, Export("mediaSource", ArgumentSemantic.Strong)]
        MediaSource MediaSource { get; }

        // @property (readonly, copy, nonatomic) NSArray<PKTimeRange *> * _Nullable timeRanges;
        [NullAllowed, Export("timeRanges", ArgumentSemantic.Copy)]
        PKTimeRange[] TimeRanges { get; }
    }

    // @interface PKNetworkSettings : NSObject
    [BaseType(typeof(NSObject))][Model]
    interface PKNetworkSettings
    {
        // @property (nonatomic) double preferredPeakBitRate;
        [Export("preferredPeakBitRate")]
        double PreferredPeakBitRate { get; set; }
    }

    // @interface PKPercentageTimeBoundary : NSObject <PKBoundary>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKPercentageTimeBoundary : PKBoundary
    {
        // @property (readonly, nonatomic) NSTimeInterval time;
        [Export("time")]
        double Time { get; }

        // -(instancetype _Nonnull)initWithBoundary:(NSInteger)boundary duration:(NSTimeInterval)duration __attribute__((objc_designated_initializer));
        [Export("initWithBoundary:duration:")]
        [DesignatedInitializer]
        IntPtr Constructor(nint boundary, double duration);
    }

    // @interface PKPlaybackInfo : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKPlaybackInfo
    {
        // @property (readonly, nonatomic) double bitrate;
        [Export("bitrate")]
        double Bitrate { get; }

        // @property (readonly, nonatomic) double indicatedBitrate;
        [Export("indicatedBitrate")]
        double IndicatedBitrate { get; }

        // @property (readonly, nonatomic) double observedBitrate;
        [Export("observedBitrate")]
        double ObservedBitrate { get; }
    }

    // @interface PKPlayerSettings : NSObject
    [BaseType(typeof(NSObject))][Model]
    interface PKPlayerSettings
    {
        // @property (nonatomic, strong) PKNetworkSettings * _Nonnull network;
        [Export("network", ArgumentSemantic.Strong)]
        PKNetworkSettings Network { get; set; }

        // @property (nonatomic, strong) id<PKRequestParamsAdapter> _Nullable contentRequestAdapter;
        [NullAllowed, Export("contentRequestAdapter", ArgumentSemantic.Strong)]
        PKRequestParamsAdapter ContentRequestAdapter { get; set; }

        // -(PKPlayerSettings * _Nonnull)createCopy __attribute__((warn_unused_result));
        [Export("createCopy")]
        
        PKPlayerSettings CreateCopy { get; }
    }

    // @interface PlayKit_Swift_754 (PKPlayerSettings) <NSCopying>
    [Category]
    [BaseType(typeof(PKPlayerSettings))]
    interface PKPlayerSettings_PlayKit_Swift_754 //: INSCopying
    {
        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result));
        //[Export("copyWithZone:")]
        //unsafe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
    }

    // @interface PKRequestParams : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKRequestParams
    {
        // @property (readonly, copy, nonatomic) NSURL * _Nonnull url;
        [Export("url", ArgumentSemantic.Copy)]
        NSUrl Url { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable headers;
        [NullAllowed, Export("headers", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Headers { get; }
    }

    // @interface PKTimeBoundary : NSObject <PKBoundary>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKTimeBoundary : PKBoundary
    {
        // @property (readonly, nonatomic) NSTimeInterval time;
        [Export("time")]
        double Time { get; }

        // -(instancetype _Nonnull)initWithBoundaryTime:(NSTimeInterval)boundaryTime duration:(NSTimeInterval)duration __attribute__((objc_designated_initializer));
        [Export("initWithBoundaryTime:duration:")]
        [DesignatedInitializer]
        IntPtr Constructor(double boundaryTime, double duration);
    }

    // @interface PKTimeRange : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKTimeRange
    {
        // @property (readonly, nonatomic) NSTimeInterval start;
        [Export("start")]
        double Start { get; }

        // @property (readonly, nonatomic) NSTimeInterval end;
        [Export("end")]
        double End { get; }

        // @property (readonly, nonatomic) NSTimeInterval duration;
        [Export("duration")]
        double Duration { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @interface PKTracks : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PKTracks
    {
        // @property (copy, nonatomic) NSArray<Track *> * _Nullable audioTracks;
        [NullAllowed, Export("audioTracks", ArgumentSemantic.Copy)]
        Track[] AudioTracks { get; set; }

        // @property (copy, nonatomic) NSArray<Track *> * _Nullable textTracks;
        [NullAllowed, Export("textTracks", ArgumentSemantic.Copy)]
        Track[] TextTracks { get; set; }
    }

    // @interface PhoenixMediaProvider : NSObject <MediaEntryProvider>
    [BaseType(typeof(NSObject))][Model]
    interface PhoenixMediaProvider : MediaEntryProvider
    {
        // @property (nonatomic, strong) id<SessionProvider> _Nullable sessionProvider;
        [NullAllowed, Export("sessionProvider", ArgumentSemantic.Strong)]
        SessionProvider SessionProvider { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable assetId;
        [NullAllowed, Export("assetId")]
        string AssetId { get; set; }

        // @property (nonatomic) enum AssetType type;
        [Export("type", ArgumentSemantic.Assign)]
        AssetType Type { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nullable formats;
        [NullAllowed, Export("formats", ArgumentSemantic.Copy)]
        string[] Formats { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nullable fileIds;
        [NullAllowed, Export("fileIds", ArgumentSemantic.Copy)]
        string[] FileIds { get; set; }

        // @property (nonatomic) enum PlaybackContextType playbackContextType;
        [Export("playbackContextType", ArgumentSemantic.Assign)]
        PlaybackContextType PlaybackContextType { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable networkProtocol;
        [NullAllowed, Export("networkProtocol")]
        string NetworkProtocol { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable referrer;
        [NullAllowed, Export("referrer")]
        string Referrer { get; set; }

        // -(void)loadMediaWithCallback:(void (^ _Nonnull)(MediaEntry * _Nullable, NSError * _Nullable))callback;
        [Export("loadMediaWithCallback:")]
        void LoadMediaWithCallback(Action<MediaEntry, NSError> callback);

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();
    }

    // @interface PlayKitManager : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PlayKitManager
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull versionString;
        [Static]
        [Export("versionString")]
        string VersionString { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull clientTag;
        [Static]
        [Export("clientTag")]
        string ClientTag { get; }

        // @property (readonly, nonatomic, strong, class) PlayKitManager * _Nonnull sharedInstance;
        [Static]
        [Export("sharedInstance", ArgumentSemantic.Strong)]
        PlayKitManager SharedInstance { get; }

        // -(id<Player> _Nullable)loadPlayerWithPluginConfig:(PluginConfig * _Nullable)pluginConfig error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
        [Export("loadPlayerWithPluginConfig:error:")]
        [return: NullAllowed]
        Player LoadPlayerWithPluginConfig([NullAllowed] PluginConfig pluginConfig, [NullAllowed] out NSError error);

        // -(void)registerPlugin:(Class _Nonnull)pluginClass;
        [Export("registerPlugin:")]
        void RegisterPlugin(Class pluginClass);

        // @property (nonatomic, class) enum PKLogLevel logLevel;
        [Static]
        [Export("logLevel", ArgumentSemantic.Assign)]
        PKLogLevel LogLevel { get; set; }
    }

    // @protocol Player
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface Player
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        PlayerDelegate Delegate { get; set; }

        // @required @property (nonatomic, weak) id<PlayerDelegate> _Nullable delegate;
        [Abstract]
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @required @property (readonly, nonatomic, weak) MediaEntry * _Nullable mediaEntry;
        [Abstract]
        [NullAllowed, Export("mediaEntry", ArgumentSemantic.Weak)]
        MediaEntry MediaEntry { get; }

        // @required @property (readonly, nonatomic, strong) PKPlayerSettings * _Nonnull settings;
        [Abstract]
        [Export("settings", ArgumentSemantic.Strong)]
        PKPlayerSettings Settings { get; }

        //@required @property(nonatomic, weak) PlayerView* _Nullable view;
        [Abstract]
        [NullAllowed, Export("view", ArgumentSemantic.Weak)]
        PlayerView View { get; set; }

        // @required @property (nonatomic) NSTimeInterval currentTime;
        [Abstract]
        [Export("currentTime")]
        double CurrentTime { get; set; }

        // @required @property (readonly, nonatomic) enum PlayerState currentState;
        [Abstract]
        [Export("currentState")]
        PlayerState CurrentState { get; }

        // @required @property (readonly, nonatomic) BOOL isPlaying;
        [Abstract]
        [Export("isPlaying")]
        bool IsPlaying { get; }

        // @required @property (readonly, nonatomic) NSTimeInterval duration;
        [Abstract]
        [Export("duration")]
        double Duration { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable currentAudioTrack;
        [Abstract]
        [NullAllowed, Export("currentAudioTrack")]
        string CurrentAudioTrack { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable currentTextTrack;
        [Abstract]
        [NullAllowed, Export("currentTextTrack")]
        string CurrentTextTrack { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull sessionId;
        [Abstract]
        [Export("sessionId")]
        string SessionId { get; }

        // @required @property (readonly, nonatomic) float rate;
        [Abstract]
        [Export("rate")]
        float Rate { get; }

        // @required @property (readonly, copy, nonatomic) NSArray<PKTimeRange *> * _Nullable loadedTimeRanges;
        [Abstract]
        [NullAllowed, Export("loadedTimeRanges", ArgumentSemantic.Copy)]
        PKTimeRange[] LoadedTimeRanges { get; }

        // @required -(void)prepare:(MediaConfig * _Nonnull)config;
        [Abstract]
        [Export("prepare:")]
        void Prepare(MediaConfig config);

        // @required -(void)play;
        [Abstract]
        [Export("play")]
        void Play();

        // @required -(void)pause;
        [Abstract]
        [Export("pause")]
        void Pause();

        // @required -(void)resume;
        [Abstract]
        [Export("resume")]
        void Resume();

        // @required -(void)stop;
        [Abstract]
        [Export("stop")]
        void Stop();

        // @required -(void)seekTo:(CMTime)time;
        [Abstract]
        [Export("seekTo:")]
        void SeekTo(CMTime time);

        // @required -(void)destroy;
        [Abstract]
        [Export("destroy")]
        void Destroy();

        // @required -(void)addObserver:(id _Nonnull)observer event:(Class _Nonnull)event block:(void (^ _Nonnull)(PKEvent * _Nonnull))block;
        [Abstract]
        [Export("addObserver:event:block:")]
        void AddObserver(NSObject observer, Class @event, Action<PKEvent> block);

        // @required -(void)addObserver:(id _Nonnull)observer events:(NSArray<Class> * _Nonnull)events block:(void (^ _Nonnull)(PKEvent * _Nonnull))block;
        [Abstract]
        [Export("addObserver:events:block:")]
        void AddObserver(NSObject observer, Class[] events, Action<PKEvent> block);

        // @required -(void)removeObserver:(id _Nonnull)observer event:(Class _Nonnull)event;
        [Abstract]
        [Export("removeObserver:event:")]
        void RemoveObserver(NSObject observer, Class @event);

        // @required -(void)removeObserver:(id _Nonnull)observer events:(NSArray<Class> * _Nonnull)events;
        [Abstract]
        [Export("removeObserver:events:")]
        void RemoveObserver(NSObject observer, Class[] events);

        // @required -(void)selectTrackWithTrackId:(NSString * _Nonnull)trackId;
        [Abstract]
        [Export("selectTrackWithTrackId:")]
        void SelectTrackWithTrackId(string trackId);

        // @required -(void)updatePluginConfigWithPluginName:(NSString * _Nonnull)pluginName config:(id _Nonnull)config;
        [Abstract]
        [Export("updatePluginConfigWithPluginName:config:")]
        void UpdatePluginConfigWithPluginName(string pluginName, NSObject config);

        // @required -(AVPictureInPictureController * _Nullable)createPiPControllerWith:(id<AVPictureInPictureControllerDelegate> _Nonnull)delegate __attribute__((availability(ios, introduced=9.0))) __attribute__((warn_unused_result));
        [Abstract]
        [Export("createPiPControllerWith:")]
        [return: NullAllowed]
        AVPictureInPictureController CreatePiPControllerWith(AVPictureInPictureControllerDelegate @delegate);

        // @required -(NSUUID * _Nonnull)addPeriodicObserverWithInterval:(NSTimeInterval)interval observeOn:(dispatch_queue_t _Nullable)dispatchQueue using:(void (^ _Nonnull)(NSTimeInterval))block __attribute__((warn_unused_result));
        [Abstract]
        [Export("addPeriodicObserverWithInterval:observeOn:using:")]
        NSUuid AddPeriodicObserverWithInterval(double interval, [NullAllowed] DispatchQueue dispatchQueue, Action<double> block);

        // @required -(NSUUID * _Nonnull)addBoundaryObserverWithBoundaries:(NSArray<id<PKBoundary>> * _Nonnull)boundaries observeOn:(dispatch_queue_t _Nullable)dispatchQueue using:(void (^ _Nonnull)(NSTimeInterval, double))block __attribute__((warn_unused_result));
        [Abstract]
        [Export("addBoundaryObserverWithBoundaries:observeOn:using:")]
        NSUuid AddBoundaryObserverWithBoundaries(PKBoundary[] boundaries, [NullAllowed] DispatchQueue dispatchQueue, Action<double, double> block);

        // @required -(void)removePeriodicObserver:(NSUUID * _Nonnull)token;
        [Abstract]
        [Export("removePeriodicObserver:")]
        void RemovePeriodicObserver(NSUuid token);

        // @required -(void)removeBoundaryObserver:(NSUUID * _Nonnull)token;
        [Abstract]
        [Export("removeBoundaryObserver:")]
        void RemoveBoundaryObserver(NSUuid token);
    }

    // @interface PlayerDecoratorBase : NSObject <Player>
    [BaseType(typeof(NSObject))][Model]
    interface PlayerDecoratorBase : Player
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        PlayerDelegate Delegate { get; set; }

        // @property (nonatomic, strong) id<PlayerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, weak) MediaEntry * _Nullable mediaEntry;
        [NullAllowed, Export("mediaEntry", ArgumentSemantic.Weak)]
        MediaEntry MediaEntry { get; }

        // @property (readonly, nonatomic, strong) PKPlayerSettings * _Nonnull settings;
        [Export("settings", ArgumentSemantic.Strong)]
        PKPlayerSettings Settings { get; }

        // @property (nonatomic) NSTimeInterval currentTime;
        [Export("currentTime")]
        double CurrentTime { get; set; }

        // @property (readonly, nonatomic) double duration;
        [Export("duration")]
        double Duration { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable currentAudioTrack;
        [NullAllowed, Export("currentAudioTrack")]
        string CurrentAudioTrack { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable currentTextTrack;
        [NullAllowed, Export("currentTextTrack")]
        string CurrentTextTrack { get; }

        // @property (readonly, nonatomic) enum PlayerState currentState;
        [Export("currentState")]
        PlayerState CurrentState { get; }

        // @property (readonly, nonatomic) BOOL isPlaying;
        [Export("isPlaying")]
        bool IsPlaying { get; }

        // @property (nonatomic, weak) PlayerView * _Nullable view;
        [NullAllowed, Export("view", ArgumentSemantic.Weak)]
        PlayerView View { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull sessionId;
        [Export("sessionId")]
        string SessionId { get; }

        // @property (readonly, nonatomic) float rate;
        [Export("rate")]
        float Rate { get; }

        // @property (readonly, copy, nonatomic) NSArray<PKTimeRange *> * _Nullable loadedTimeRanges;
        [NullAllowed, Export("loadedTimeRanges", ArgumentSemantic.Copy)]
        PKTimeRange[] LoadedTimeRanges { get; }

        // -(void)prepare:(MediaConfig * _Nonnull)config;
        [Export("prepare:")]
        void Prepare(MediaConfig config);

        // -(void)setPlayer:(id<Player> _Null_unspecified)player;
        [Export("setPlayer:")]
        void SetPlayer(Player player);

        // -(id<Player> _Nonnull)getPlayer __attribute__((warn_unused_result));
        [Export("getPlayer")]
        
        Player Player { get; }

        // -(void)destroy;
        [Export("destroy")]
        void Destroy();

        // -(void)play;
        [Export("play")]
        void Play();

        // -(void)pause;
        [Export("pause")]
        void Pause();

        // -(void)seekTo:(CMTime)time;
        [Export("seekTo:")]
        void SeekTo(CMTime time);

        // -(void)resume;
        [Export("resume")]
        void Resume();

        // -(void)stop;
        [Export("stop")]
        void Stop();

        // -(void)updatePluginConfigWithPluginName:(NSString * _Nonnull)pluginName config:(id _Nonnull)config;
        [Export("updatePluginConfigWithPluginName:config:")]
        void UpdatePluginConfigWithPluginName(string pluginName, NSObject config);

        // -(void)addObserver:(id _Nonnull)observer event:(Class _Nonnull)event block:(void (^ _Nonnull)(PKEvent * _Nonnull))block;
        [Export("addObserver:event:block:")]
        void AddObserver(NSObject observer, Class @event, Action<PKEvent> block);

        // -(void)addObserver:(id _Nonnull)observer events:(NSArray<Class> * _Nonnull)events block:(void (^ _Nonnull)(PKEvent * _Nonnull))block;
        [Export("addObserver:events:block:")]
        void AddObserver(NSObject observer, Class[] events, Action<PKEvent> block);

        // -(void)removeObserver:(id _Nonnull)observer event:(Class _Nonnull)event;
        [Export("removeObserver:event:")]
        void RemoveObserver(NSObject observer, Class @event);

        // -(void)removeObserver:(id _Nonnull)observer events:(NSArray<Class> * _Nonnull)events;
        [Export("removeObserver:events:")]
        void RemoveObserver(NSObject observer, Class[] events);

        // -(void)selectTrackWithTrackId:(NSString * _Nonnull)trackId;
        [Export("selectTrackWithTrackId:")]
        void SelectTrackWithTrackId(string trackId);

        // -(NSUUID * _Nonnull)addPeriodicObserverWithInterval:(NSTimeInterval)interval observeOn:(dispatch_queue_t _Nullable)dispatchQueue using:(void (^ _Nonnull)(NSTimeInterval))block __attribute__((warn_unused_result));
        [Export("addPeriodicObserverWithInterval:observeOn:using:")]
        NSUuid AddPeriodicObserverWithInterval(double interval, [NullAllowed] DispatchQueue dispatchQueue, Action<double> block);

        // -(NSUUID * _Nonnull)addBoundaryObserverWithBoundaries:(NSArray<id<PKBoundary>> * _Nonnull)boundaries observeOn:(dispatch_queue_t _Nullable)dispatchQueue using:(void (^ _Nonnull)(NSTimeInterval, double))block __attribute__((warn_unused_result));
        [Export("addBoundaryObserverWithBoundaries:observeOn:using:")]
        NSUuid AddBoundaryObserverWithBoundaries(PKBoundary[] boundaries, [NullAllowed] DispatchQueue dispatchQueue, Action<double, double> block);

        // -(void)removePeriodicObserver:(NSUUID * _Nonnull)token;
        [Export("removePeriodicObserver:")]
        void RemovePeriodicObserver(NSUuid token);

        // -(void)removeBoundaryObserver:(NSUUID * _Nonnull)token;
        [Export("removeBoundaryObserver:")]
        void RemoveBoundaryObserver(NSUuid token);
    }

    // @interface PlayKit_Swift_993 (PlayerDecoratorBase)
    [Category]
    [BaseType(typeof(PlayerDecoratorBase))]
    interface PlayerDecoratorBase_PlayKit_Swift_993
    {
        // -(AVPictureInPictureController * _Nullable)createPiPControllerWith:(id<AVPictureInPictureControllerDelegate> _Nonnull)delegate __attribute__((availability(ios, introduced=9.0))) __attribute__((warn_unused_result));
       
        [Export("createPiPControllerWith:")]
        [return: NullAllowed]
        AVPictureInPictureController CreatePiPControllerWith(AVPictureInPictureControllerDelegate @delegate);
    }

    // @protocol PlayerDelegate
    //[Protocol, Model]
    [Model]
    [BaseType(typeof(NSObject))]
    interface PlayerDelegate
    {
        // @required -(BOOL)playerShouldPlayAd:(id<Player> _Nonnull)player __attribute__((warn_unused_result));
        [Abstract]
        [Export("playerShouldPlayAd:")]
        bool PlayerShouldPlayAd(Player player);
    }

    // @interface PlayerEvent : PKEvent
    [BaseType(typeof(PKEvent))]
    [Model]
    interface PlayerEvent
    {
        // @property (readonly, copy, nonatomic, class) NSArray<Class> * _Nonnull allEventTypes;
        [Static]
        [Export("allEventTypes", ArgumentSemantic.Copy)]
        Class[] AllEventTypes { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull canPlay;
        [Static]
        [Export("canPlay")]
        Class CanPlay { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull durationChanged;
        [Static]
        [Export("durationChanged")]
        Class DurationChanged { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull stopped;
        [Static]
        [Export("stopped")]
        Class Stopped { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull ended;
        [Static]
        [Export("ended")]
        Class Ended { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull loadedMetadata;
        [Static]
        [Export("loadedMetadata")]
        Class LoadedMetadata { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull play;
        [Static]
        [Export("play")]
        Class Play { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull pause;
        [Static]
        [Export("pause")]
        Class Pause { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull playing;
        [Static]
        [Export("playing")]
        Class Playing { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull seeking;
        [Static]
        [Export("seeking")]
        Class Seeking { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull seeked;
        [Static]
        [Export("seeked")]
        Class Seeked { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull tracksAvailable;
        [Static]
        [Export("tracksAvailable")]
        Class TracksAvailable { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull playbackInfo;
        [Static]
        [Export("playbackInfo")]
        Class PlaybackInfo { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull stateChanged;
        [Static]
        [Export("stateChanged")]
        Class StateChanged { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull timedMetadata;
        [Static]
        [Export("timedMetadata")]
        Class TimedMetadata { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull sourceSelected;
        [Static]
        [Export("sourceSelected")]
        Class SourceSelected { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull loadedTimeRanges;
        [Static]
        [Export("loadedTimeRanges")]
        Class LoadedTimeRanges { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull error;
        [Static]
        [Export("error")]
        Class Error { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull pluginError;
        [Static]
        [Export("pluginError")]
        Class PluginError { get; }

        // @property (readonly, nonatomic, class) Class _Nonnull errorLog;
        [Static]
        [Export("errorLog")]
        Class ErrorLog { get; }

        // -(instancetype _Nonnull)init:(NSDictionary<NSString *,id> * _Nullable)data __attribute__((objc_designated_initializer));
        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSDictionary<NSString, NSObject> data);
    }

    // @interface PlayerView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface PlayerView
    {
        // @property (readonly, nonatomic, class) Class _Nonnull layerClass;
        [Static]
        [Export("layerClass")]
        Class LayerClass { get; }

        // -(void)addToContainer:(UIView * _Nonnull)container;
        [Export("addToContainer:")]
        void AddToContainer(UIView container);

        // +(PlayerView * _Nonnull)createPlayerViewForPlayer:(id<Player> _Nonnull)player __attribute__((warn_unused_result));
        [Static]
        [Export("createPlayerViewForPlayer:")]
        PlayerView CreatePlayerViewForPlayer(Player player);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr initWithFrame(CGRect frame);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr initWithCoder(NSCoder aDecoder);
    }

    // @interface PluginConfig : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface PluginConfig
    {
        // @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull config;
        [Export("config", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Config { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(instancetype _Nonnull)initWithConfig:(NSDictionary<NSString *,id> * _Nonnull)config __attribute__((objc_designated_initializer));
        [Export("initWithConfig:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> config);
    }

    // @interface PlayKit_Swift_1118 (PluginConfig) <NSCopying>
    [Category]
    [BaseType(typeof(PluginConfig))]
    interface PluginConfig_PlayKit_Swift_1118 //: INSCopying
    {
        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result));
        //[Export("copyWithZone:")]
        //unsafe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
    }

    // @interface SimpleOVPSessionProvider : NSObject <SessionProvider>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface SimpleOVPSessionProvider : SessionProvider
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull serverURL;
        [Export("serverURL")]
        string ServerURL { get; }

        // @property (readonly, nonatomic) int64_t partnerId;
        [Export("partnerId")]
        long PartnerId { get; }

        // @property (copy, nonatomic) NSString * _Nullable ks;
        [NullAllowed, Export("ks")]
        string Ks { get; set; }

        // -(instancetype _Nonnull)initWithServerURL:(NSString * _Nonnull)serverURL partnerId:(int64_t)partnerId ks:(NSString * _Nullable)ks __attribute__((objc_designated_initializer));
        [Export("initWithServerURL:partnerId:ks:")]
        [DesignatedInitializer]
        IntPtr Constructor(string serverURL, long partnerId, [NullAllowed] string ks);

        // -(void)loadKSWithCompletion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("loadKSWithCompletion:")]
        void LoadKSWithCompletion(Action<NSString, NSError> completion);
    }

    // @interface PlayKit_Swift_1154 (NSTimer)
    [Category]
    [BaseType(typeof(NSTimer))]
    interface NSTimer_PlayKit_Swift_1154
    {
        // +(NSTimer * _Nonnull)after:(NSTimeInterval)interval :(void (^ _Nonnull)(void))block __attribute__((warn_unused_result));
        [Static]
        [Export("after::")]
        NSTimer After(double interval, Action block);

        // +(NSTimer * _Nonnull)every:(NSTimeInterval)interval :(void (^ _Nonnull)(void))block __attribute__((warn_unused_result));
        [Static]
        [Export("every::")]
        NSTimer Every(double interval, Action block);
    }

    // @interface Track : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface Track
    {
        // @property (copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable language;
        [NullAllowed, Export("language")]
        string Language { get; set; }
    }

  
    // @interface RequestBuilder : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor][Model]
    interface RequestBuilder
    {
        // @property (copy, nonatomic) NSString * _Nonnull requestId;
        [Export("requestId")]
        string RequestId { get; set; }

        // @property (copy, nonatomic) NSURL * _Nonnull url;
        [Export("url", ArgumentSemantic.Copy)]
        NSUrl Url { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable headers;
        [NullAllowed, Export("headers", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Headers { get; set; }

        // @property (nonatomic) double timeout;
        [Export("timeout")]
        double Timeout { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable urlParams;
        [NullAllowed, Export("urlParams", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> UrlParams { get; set; }

        // -(instancetype _Nullable)initWithUrl:(NSString * _Nonnull)url __attribute__((objc_designated_initializer));
        [Export("initWithUrl:")]
        [DesignatedInitializer]
        IntPtr Constructor(string url);

        // -(instancetype _Nonnull)setWithUrl:(NSURL * _Nonnull)url;
        [Export("setWithUrl:")]
        RequestBuilder SetWithUrl(NSUrl url);

        // -(instancetype _Nonnull)setWithHeaders:(NSDictionary<NSString *,NSString *> * _Nullable)headers;
        [Export("setWithHeaders:")]
        RequestBuilder SetWithHeaders([NullAllowed] NSDictionary<NSString, NSString> headers);

        // -(instancetype _Nonnull)addWithHeaderKey:(NSString * _Nonnull)headerKey headerValue:(NSString * _Nonnull)headerValue;
        [Export("addWithHeaderKey:headerValue:")]
        RequestBuilder AddWithHeaderKey(string headerKey, string headerValue);

        // -(instancetype _Nonnull)setParamWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
        [Export("setParamWithKey:value:")]
        RequestBuilder SetParamWithKey(string key, string value);
    }

    // @interface KalturaRequestBuilder : RequestBuilder
    [BaseType(typeof(RequestBuilder))]
    [Model]
    interface KalturaRequestBuilder
    {
        // @property (copy, nonatomic) NSString * _Nullable service;
        [NullAllowed, Export("service")]
        string Service { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable action;
        [NullAllowed, Export("action")]
        string Action { get; set; }

        // -(instancetype _Nullable)initWithUrl:(NSString * _Nullable)url service:(NSString * _Nullable)service action:(NSString * _Nullable)action __attribute__((objc_designated_initializer));
        [Export("initWithUrl:service:action:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string url, [NullAllowed] string service, [NullAllowed] string action);
    }

    // @interface KalturaMultiRequestBuilder : KalturaRequestBuilder
    [BaseType(typeof(KalturaRequestBuilder))]
    [Model]
    interface KalturaMultiRequestBuilder
    {
        // -(instancetype _Nullable)initWithUrl:(NSString * _Nonnull)url __attribute__((objc_designated_initializer));
        [Export("initWithUrl:")]
        [DesignatedInitializer]
        IntPtr Constructor(string url);

        // -(instancetype _Nonnull)addWithRequest:(KalturaRequestBuilder * _Nonnull)request;
        [Export("addWithRequest:")]
        KalturaMultiRequestBuilder AddWithRequest(KalturaRequestBuilder request);
    }

    // @protocol SessionProvider
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface SessionProvider
    {
        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull serverURL;
        [Abstract]
        [Export("serverURL")]
        string ServerURL { get; }

        // @required @property (readonly, nonatomic) int64_t partnerId;
        [Abstract]
        [Export("partnerId")]
        long PartnerId { get; }

        // @required -(void)loadKSWithCompletion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("loadKSWithCompletion:")]
        void LoadKSWithCompletion(Action<NSString, NSError> completion);
    }

    // @interface USRExecutor : NSObject <NSURLSessionDelegate>
    [BaseType(typeof(NSObject))]
    [Model]
    interface USRExecutor : INSUrlSessionDelegate
    {
        // @property (readonly, nonatomic, strong, class) USRExecutor * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        USRExecutor Shared { get; }

        // -(void)clean;
        [Export("clean")]
        void Clean();

        // -(void)URLSession:(NSURLSession * _Nonnull)session didBecomeInvalidWithError:(NSError * _Nullable)error;
        [Export("URLSession:didBecomeInvalidWithError:")]
        void URLSession(NSUrlSession session, [NullAllowed] NSError error);

        // -(void)URLSession:(NSURLSession * _Nonnull)session didReceiveChallenge:(NSURLAuthenticationChallenge * _Nonnull)challenge completionHandler:(void (^ _Nonnull)(enum NSURLSessionAuthChallengeDisposition, NSURLCredential * _Nullable))completionHandler;
        //[Export("URLSession:didReceiveChallenge:completionHandler:")]
        //void URLSession(NSUrlSession session, NSUrlAuthenticationChallenge challenge, Action<NSURLSessionAuthChallengeDisposition, NSURLCredential> completionHandler);

        // -(void)URLSessionDidFinishEventsForBackgroundURLSession:(NSURLSession * _Nonnull)session;
        [Export("URLSessionDidFinishEventsForBackgroundURLSession:")]
        void URLSessionDidFinishEventsForBackgroundURLSession(NSUrlSession session);
    }


}

