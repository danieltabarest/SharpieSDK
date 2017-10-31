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
	[Register("AdEventDataKeys", false)]
	[Model]
	public unsafe partial class AdEventDataKeys : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AdEventDataKeys () : base (NSObjectFlag.Empty)
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
		protected AdEventDataKeys (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdEventDataKeys (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public static string AdCuePoints {
			[Export ("adCuePoints")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static string AdInfo {
			[Export ("adInfo")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static string AdTagUrl {
			[Export ("adTagUrl")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static string Error {
			[Export ("error")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static string MediaTime {
			[Export ("mediaTime")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static string TotalTime {
			[Export ("totalTime")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static string WebOpener {
			[Export ("webOpener")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class AdEventDataKeys */
}
