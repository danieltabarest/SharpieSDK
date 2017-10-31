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
	[Register("PlayKitManager", false)]
	[Model]
	public unsafe partial class PlayKitManager : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PlayKitManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PlayKitManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("loadPlayerWithPluginConfig:error:")]
		[CompilerGenerated]
		public virtual Player LoadPlayerWithPluginConfig (PluginConfig pluginConfig, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("registerPlugin:")]
		[CompilerGenerated]
		public virtual void RegisterPlugin (Class pluginClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public static string ClientTag {
			[Export ("clientTag")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static PKLogLevel LogLevel {
			[Export ("logLevel", ArgumentSemantic.UnsafeUnretained)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setLogLevel:", ArgumentSemantic.UnsafeUnretained)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public static PlayKitManager SharedInstance {
			[Export ("sharedInstance", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public static string VersionString {
			[Export ("versionString")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class PlayKitManager */
}
