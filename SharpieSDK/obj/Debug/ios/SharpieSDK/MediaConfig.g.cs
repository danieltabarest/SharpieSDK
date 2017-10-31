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
	[Register("MediaConfig", false)]
	[Model]
	public unsafe partial class MediaConfig : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MediaConfig (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MediaConfig (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithMediaEntry:startTime:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public MediaConfig (MediaEntry mediaEntry, global::System.Double startTime)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("configWithMediaEntry:")]
		[CompilerGenerated]
		public static MediaConfig ConfigWithMediaEntry (MediaEntry mediaEntry)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("configWithMediaEntry:startTime:")]
		[CompilerGenerated]
		public static MediaConfig ConfigWithMediaEntry (MediaEntry mediaEntry, global::System.Double startTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual string Description {
			[Export ("description")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual MediaEntry MediaEntry {
			[Export ("mediaEntry", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setMediaEntry:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double StartTime {
			[Export ("startTime")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setStartTime:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class MediaConfig */
}
