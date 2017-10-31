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
	[Register("MessageBus", false)]
	[Model]
	public unsafe partial class MessageBus : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MessageBus () : base (NSObjectFlag.Empty)
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
		protected MessageBus (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MessageBus (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addObserver:events:block:")]
		[CompilerGenerated]
		public unsafe virtual void AddObserver (NSObject observer, Class[] events, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("addObserver:events:observeOn:block:")]
		[CompilerGenerated]
		public unsafe virtual void AddObserver (NSObject observer, Class[] events, global::CoreFoundation.DispatchQueue dispatchQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("post:")]
		[CompilerGenerated]
		public virtual void Post (PKEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removeObserver:events:")]
		[CompilerGenerated]
		public virtual void RemoveObserver (NSObject observer, Class[] events)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MessageBus */
}
