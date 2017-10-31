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
	[Protocol (Name = "LocalDataStore", WrapperType = typeof (LocalDataStoreWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SaveWithKey", Selector = "saveWithKey:value:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (NSData), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadWithKey", Selector = "loadWithKey:error:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveWithKey", Selector = "removeWithKey:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	public interface ILocalDataStore : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("saveWithKey:value:error:")]
		[Preserve (Conditional = true)]
		bool SaveWithKey (string key, NSData value, out NSError error);
		
		[CompilerGenerated]
		[Export ("loadWithKey:error:")]
		[Preserve (Conditional = true)]
		NSData LoadWithKey (string key, out NSError error);
		
		[CompilerGenerated]
		[Export ("removeWithKey:error:")]
		[Preserve (Conditional = true)]
		bool RemoveWithKey (string key, out NSError error);
		
	}
	
	internal sealed class LocalDataStoreWrapper : BaseWrapper, ILocalDataStore {
		[Preserve (Conditional = true)]
		public LocalDataStoreWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("saveWithKey:value:error:")]
		[CompilerGenerated]
		public bool SaveWithKey (string key, NSData value, out NSError error)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (value == null)
				throw new ArgumentNullException ("value");
			IntPtr errorValue = IntPtr.Zero;
			
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("saveWithKey:value:error:"), nskey, value.Handle, ref errorValue);
			NSString.ReleaseNative (nskey);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("loadWithKey:error:")]
		[CompilerGenerated]
		public NSData LoadWithKey (string key, out NSError error)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			IntPtr errorValue = IntPtr.Zero;
			
			var nskey = NSString.CreateNative (key);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("loadWithKey:error:"), nskey, ref errorValue));
			NSString.ReleaseNative (nskey);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("removeWithKey:error:")]
		[CompilerGenerated]
		public bool RemoveWithKey (string key, out NSError error)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			IntPtr errorValue = IntPtr.Zero;
			
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("removeWithKey:error:"), nskey, ref errorValue);
			NSString.ReleaseNative (nskey);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
	}
}
namespace SharpieSDK {
	[Protocol]
	[Register("LocalDataStore", false)]
	[Model]
	public unsafe abstract partial class LocalDataStore : NSObject, ILocalDataStore {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected LocalDataStore () : base (NSObjectFlag.Empty)
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
		protected LocalDataStore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LocalDataStore (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("loadWithKey:error:")]
		[CompilerGenerated]
		public abstract NSData LoadWithKey (string key, out NSError error);
		[Export ("removeWithKey:error:")]
		[CompilerGenerated]
		public abstract bool RemoveWithKey (string key, out NSError error);
		[Export ("saveWithKey:value:error:")]
		[CompilerGenerated]
		public abstract bool SaveWithKey (string key, NSData value, out NSError error);
	} /* class LocalDataStore */
}
