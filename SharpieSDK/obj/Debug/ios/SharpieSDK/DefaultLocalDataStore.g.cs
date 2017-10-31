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
	[Register("DefaultLocalDataStore", false)]
	[Model]
	public unsafe partial class DefaultLocalDataStore : NSObject, ILocalDataStore {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected DefaultLocalDataStore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal DefaultLocalDataStore (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDirectory:error:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public DefaultLocalDataStore (NSSearchPathDirectory directory, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("loadWithKey:error:")]
		[CompilerGenerated]
		public virtual NSData LoadWithKey (string key, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removeWithKey:error:")]
		[CompilerGenerated]
		public virtual bool RemoveWithKey (string key, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("saveWithKey:value:error:")]
		[CompilerGenerated]
		public virtual bool SaveWithKey (string key, NSData value, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public static DefaultLocalDataStore DefaultDataStore {
			[Export ("defaultDataStore")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class DefaultLocalDataStore */
}
