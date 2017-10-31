//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace SharpieSDK {
	[Register("LocalAssetsManager", false)]
	[Model]
	public unsafe partial class LocalAssetsManager : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LocalAssetsManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LocalAssetsManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("assetDownloadFinishedWithLocation:mediaSource:callback:")]
		[CompilerGenerated]
		public unsafe virtual void AssetDownloadFinishedWithLocation (NSUrl location, MediaSource mediaSource, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> callback)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("createLocalMediaEntryFor:localURL:")]
		[CompilerGenerated]
		public virtual MediaEntry CreateLocalMediaEntryFor (string assetId, NSUrl localURL)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("getPreferredDownloadableMediaSourceFor:")]
		[CompilerGenerated]
		public virtual MediaSource GetPreferredDownloadableMediaSourceFor (MediaEntry mediaEntry)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("managerWithStorage:")]
		[CompilerGenerated]
		public static LocalAssetsManager ManagerWithStorage (LocalDataStore storage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("prepareForDownloadWithAsset:mediaSource:")]
		[CompilerGenerated]
		public virtual void PrepareForDownloadWithAsset (global::AVFoundation.AVUrlAsset asset, MediaSource mediaSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("renewDownloadedAssetWithLocation:mediaSource:callback:")]
		[CompilerGenerated]
		public unsafe virtual void RenewDownloadedAssetWithLocation (NSUrl location, MediaSource mediaSource, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> callback)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("unregisterAsset:callback:")]
		[CompilerGenerated]
		public unsafe virtual void UnregisterAsset (string assetUri, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> callback)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public static LocalAssetsManager Manager {
			[Export ("manager")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static LocalAssetsManager ManagerWithDefaultDataStore {
			[Export ("managerWithDefaultDataStore")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class LocalAssetsManager */
}
