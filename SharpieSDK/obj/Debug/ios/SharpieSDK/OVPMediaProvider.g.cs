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
	[Register("OVPMediaProvider", false)]
	[Model]
	public unsafe partial class OVPMediaProvider : NSObject, IMediaEntryProvider {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public OVPMediaProvider () : base (NSObjectFlag.Empty)
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
		protected OVPMediaProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal OVPMediaProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("init:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public OVPMediaProvider (SessionProvider sessionProvider)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cancel")]
		[CompilerGenerated]
		public virtual void Cancel ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("loadMediaWithCallback:")]
		[CompilerGenerated]
		public unsafe virtual void LoadMediaWithCallback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<MediaEntry, NSError> callback)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual string EntryId {
			[Export ("entryId")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setEntryId:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual string Referrer {
			[Export ("referrer")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setReferrer:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual SessionProvider SessionProvider {
			[Export ("sessionProvider", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setSessionProvider:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual NSNumber UiconfId {
			[Export ("uiconfId", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setUiconfId:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class OVPMediaProvider */
}
