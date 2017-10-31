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
	[Protocol (Name = "SessionProvider", WrapperType = typeof (SessionProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadKSWithCompletion", Selector = "loadKSWithCompletion:", ParameterType = new Type [] { typeof (global::System.Action<NSString, NSError>) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ServerURL", Selector = "serverURL", PropertyType = typeof (string), GetterSelector = "serverURL", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PartnerId", Selector = "partnerId", PropertyType = typeof (long), GetterSelector = "partnerId", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ISessionProvider : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("loadKSWithCompletion:")]
		[Preserve (Conditional = true)]
		unsafe void LoadKSWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<NSString, NSError> completion);
		
		[Preserve (Conditional = true)]
		string ServerURL {
			[Export ("serverURL")]
			get;
		}
		
		[Preserve (Conditional = true)]
		global::System.Int64 PartnerId {
			[Export ("partnerId")]
			get;
		}
		
	}
	
	internal sealed class SessionProviderWrapper : BaseWrapper, ISessionProvider {
		[Preserve (Conditional = true)]
		public SessionProviderWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("loadKSWithCompletion:")]
		[CompilerGenerated]
		public unsafe void LoadKSWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<NSString, NSError> completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDActionArity2V2.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadKSWithCompletion:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public string ServerURL {
			[Export ("serverURL")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serverURL")));
			}
			
		}
		
		[CompilerGenerated]
		public global::System.Int64 PartnerId {
			[Export ("partnerId")]
			get {
				return global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("partnerId"));
			}
			
		}
		
	}
}
namespace SharpieSDK {
	[Protocol]
	[Register("SessionProvider", false)]
	[Model]
	public unsafe abstract partial class SessionProvider : NSObject, ISessionProvider {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SessionProvider () : base (NSObjectFlag.Empty)
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
		protected SessionProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SessionProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("loadKSWithCompletion:")]
		[CompilerGenerated]
		public unsafe abstract void LoadKSWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<NSString, NSError> completion);
		[CompilerGenerated]
		public abstract global::System.Int64 PartnerId {
			[Export ("partnerId")]
			get; 
		}
		
		[CompilerGenerated]
		public abstract string ServerURL {
			[Export ("serverURL")]
			get; 
		}
		
	} /* class SessionProvider */
}
