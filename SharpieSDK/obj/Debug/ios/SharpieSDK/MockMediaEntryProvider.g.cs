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
	[Protocol (Name = "MockMediaEntryProvider", WrapperType = typeof (MockMediaEntryProviderWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadMediaWithCallback", Selector = "loadMediaWithCallback:", ParameterType = new Type [] { typeof (global::System.Action<global::SharpieSDK.MediaEntry, NSError>) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Cancel", Selector = "cancel")]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Id", Selector = "id", PropertyType = typeof (string), GetterSelector = "id", SetterSelector = "setId:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Url", Selector = "url", PropertyType = typeof (NSUrl), GetterSelector = "url", SetterSelector = "setUrl:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Content", Selector = "content", PropertyType = typeof (NSObject), GetterSelector = "content", SetterSelector = "setContent:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	public interface IMockMediaEntryProvider : INativeObject, IDisposable, 
		SharpieSDK.IMediaEntryProvider
		
	{
	}
	
	public static partial class MockMediaEntryProvider_Extensions {
		[CompilerGenerated]
		public unsafe static void LoadMediaWithCallback (this IMockMediaEntryProvider This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<MediaEntry, NSError> callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDActionArity2V0.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("loadMediaWithCallback:"), (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public static void Cancel (this IMockMediaEntryProvider This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("cancel"));
		}
		
		[CompilerGenerated]
		public static string GetId (this IMockMediaEntryProvider This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("id")));
		}
		
		[CompilerGenerated]
		public static void SetId (this IMockMediaEntryProvider This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setId:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static NSUrl GetUrl (this IMockMediaEntryProvider This)
		{
			return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("url")));
		}
		
		[CompilerGenerated]
		public static void SetUrl (this IMockMediaEntryProvider This, NSUrl value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setUrl:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static NSObject GetContent (this IMockMediaEntryProvider This)
		{
			return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("content")));
		}
		
		[CompilerGenerated]
		public static void SetContent (this IMockMediaEntryProvider This, NSObject value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setContent:"), value.Handle);
		}
		
	}
	
	internal sealed class MockMediaEntryProviderWrapper : BaseWrapper, IMockMediaEntryProvider {
		[Preserve (Conditional = true)]
		public MockMediaEntryProviderWrapper (IntPtr handle, bool owns)
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
namespace SharpieSDK {
	[Protocol]
	[Register("MockMediaEntryProvider", true)]
	public unsafe partial class MockMediaEntryProvider : NSObject, IMockMediaEntryProvider, IMediaEntryProvider {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MockMediaEntryProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MockMediaEntryProvider () : base (NSObjectFlag.Empty)
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
		protected MockMediaEntryProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MockMediaEntryProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancel")]
		[CompilerGenerated]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancel"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancel"));
			}
		}
		
		[Export ("loadMediaWithCallback:")]
		[CompilerGenerated]
		public unsafe virtual void LoadMediaWithCallback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<MediaEntry, NSError> callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDActionArity2V0.Handler, callback);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadMediaWithCallback:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadMediaWithCallback:"), (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_Content_var;
		[CompilerGenerated]
		public virtual NSObject Content {
			[Export ("content", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("content")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("content")));
				}
				MarkDirty ();
				__mt_Content_var = ret;
				return ret;
			}
			
			[Export ("setContent:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContent:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setContent:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Content_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Id {
			[Export ("id")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("id")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("id")));
				}
			}
			
			[Export ("setId:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setId:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setId:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSUrl Url {
			[Export ("url", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("url")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("url")));
				}
				return ret;
			}
			
			[Export ("setUrl:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUrl:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUrl:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Content_var = null;
			}
		}
	} /* class MockMediaEntryProvider */
}
