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
	[Register("AdEvent", false)]
	[Model]
	public unsafe partial class AdEvent : PKEvent {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AdEvent () : base (NSObjectFlag.Empty)
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
		protected AdEvent (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdEvent (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("init:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public AdEvent (NSDictionary<NSString, NSObject> data)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public static Class AdBreakReady {
			[Export ("adBreakReady")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdClicked {
			[Export ("adClicked")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdComplete {
			[Export ("adComplete")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdCuePointsUpdate {
			[Export ("adCuePointsUpdate")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdDidProgressToTime {
			[Export ("adDidProgressToTime")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdDidRequestContentPause {
			[Export ("adDidRequestContentPause")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdDidRequestContentResume {
			[Export ("adDidRequestContentResume")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdFirstQuartile {
			[Export ("adFirstQuartile")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdLoaded {
			[Export ("adLoaded")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdLog {
			[Export ("adLog")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdMidpoint {
			[Export ("adMidpoint")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdPaused {
			[Export ("adPaused")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdPlaybackReady {
			[Export ("adPlaybackReady")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdResumed {
			[Export ("adResumed")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdSkipped {
			[Export ("adSkipped")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdStarted {
			[Export ("adStarted")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdStartedBuffering {
			[Export ("adStartedBuffering")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdTapped {
			[Export ("adTapped")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdThirdQuartile {
			[Export ("adThirdQuartile")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdWebOpenerDidCloseInAppBrowser {
			[Export ("adWebOpenerDidCloseInAppBrowser")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdWebOpenerDidOpenInAppBrowser {
			[Export ("adWebOpenerDidOpenInAppBrowser")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdWebOpenerWillCloseInAppBrowser {
			[Export ("adWebOpenerWillCloseInAppBrowser")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdWebOpenerWillOpenExternalBrowser {
			[Export ("adWebOpenerWillOpenExternalBrowser")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdWebOpenerWillOpenInAppBrowser {
			[Export ("adWebOpenerWillOpenInAppBrowser")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AdsRequested {
			[Export ("adsRequested")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class AllAdsCompleted {
			[Export ("allAdsCompleted")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class[] AllEventTypes {
			[Export ("allEventTypes", ArgumentSemantic.Copy)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class Error {
			[Export ("error")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class RequestTimedOut {
			[Export ("requestTimedOut")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static Class WebOpenerEvent {
			[Export ("webOpenerEvent")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class AdEvent */
}
