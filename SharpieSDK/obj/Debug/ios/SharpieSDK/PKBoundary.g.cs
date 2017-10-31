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
	[Protocol (Name = "PKBoundary", WrapperType = typeof (PKBoundaryWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Time", Selector = "time", PropertyType = typeof (double), GetterSelector = "time", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IPKBoundary : INativeObject, IDisposable
	{
		[Preserve (Conditional = true)]
		global::System.Double Time {
			[Export ("time")]
			get;
		}
		
	}
	
	internal sealed class PKBoundaryWrapper : BaseWrapper, IPKBoundary {
		[Preserve (Conditional = true)]
		public PKBoundaryWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[CompilerGenerated]
		public global::System.Double Time {
			[Export ("time")]
			get {
				return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("time"));
			}
			
		}
		
	}
}
namespace SharpieSDK {
	[Protocol]
	[Register("PKBoundary", true)]
	public unsafe abstract partial class PKBoundary : NSObject, IPKBoundary {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PKBoundary");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PKBoundary () : base (NSObjectFlag.Empty)
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
		protected PKBoundary (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PKBoundary (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public abstract global::System.Double Time {
			[Export ("time")]
			get; 
		}
		
	} /* class PKBoundary */
}
