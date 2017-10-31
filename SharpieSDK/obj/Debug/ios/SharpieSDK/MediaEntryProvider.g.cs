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
	[Protocol (Name = "MediaEntryProvider", WrapperType = typeof (MediaEntryProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadMediaWithCallback", Selector = "loadMediaWithCallback:", ParameterType = new Type [] { typeof (global::System.Action<global::SharpieSDK.MediaEntry, NSError>) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Cancel", Selector = "cancel")]
	public interface IMediaEntryProvider : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("loadMediaWithCallback:")]
		[Preserve (Conditional = true)]
		unsafe void LoadMediaWithCallback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<MediaEntry, NSError> callback);
		
		[CompilerGenerated]
		[Export ("cancel")]
		[Preserve (Conditional = true)]
		void Cancel ();
		
	}
	
	internal sealed class MediaEntryProviderWrapper : BaseWrapper, IMediaEntryProvider {
		[Preserve (Conditional = true)]
		public MediaEntryProviderWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("loadMediaWithCallback:")]
		[CompilerGenerated]
		public unsafe void LoadMediaWithCallback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<MediaEntry, NSError> callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDActionArity2V0.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadMediaWithCallback:"), (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("cancel")]
		[CompilerGenerated]
		public void Cancel ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancel"));
		}
		
	}
}
