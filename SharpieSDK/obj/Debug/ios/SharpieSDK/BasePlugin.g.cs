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
	[Register("BasePlugin", false)]
	[Model]
	public unsafe partial class BasePlugin : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected BasePlugin (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BasePlugin (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPlayer:pluginConfig:messageBus:error:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public BasePlugin (Player player, NSObject pluginConfig, MessageBus messageBus, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("destroy")]
		[CompilerGenerated]
		public virtual void Destroy ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onUpdateConfigWithPluginConfig:")]
		[CompilerGenerated]
		public virtual void OnUpdateConfigWithPluginConfig (NSObject pluginConfig)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onUpdateMediaWithMediaConfig:")]
		[CompilerGenerated]
		public virtual void OnUpdateMediaWithMediaConfig (MediaConfig mediaConfig)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual MessageBus MessageBus {
			[Export ("messageBus", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setMessageBus:", ArgumentSemantic.Weak)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual Player Player {
			[Export ("player", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setPlayer:", ArgumentSemantic.Weak)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public static string PluginName {
			[Export ("pluginName")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class BasePlugin */
}
