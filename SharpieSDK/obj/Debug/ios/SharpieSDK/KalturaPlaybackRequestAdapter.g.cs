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
	[Register("KalturaPlaybackRequestAdapter", false)]
	[Model]
	public unsafe partial class KalturaPlaybackRequestAdapter : NSObject, IPKRequestParamsAdapter {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public KalturaPlaybackRequestAdapter () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected KalturaPlaybackRequestAdapter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal KalturaPlaybackRequestAdapter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("adaptWithRequestParams:")]
		[CompilerGenerated]
		public virtual PKRequestParams AdaptWithRequestParams (PKRequestParams requestParams)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("installIn:withAppName:")]
		[CompilerGenerated]
		public static void InstallIn (Player player, string appName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("updateRequestAdapterWith:")]
		[CompilerGenerated]
		public virtual void UpdateRequestAdapterWith (Player player)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class KalturaPlaybackRequestAdapter */
}