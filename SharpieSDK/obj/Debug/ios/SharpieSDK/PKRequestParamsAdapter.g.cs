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
	[Protocol (Name = "PKRequestParamsAdapter", WrapperType = typeof (PKRequestParamsAdapterWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateRequestAdapterWith", Selector = "updateRequestAdapterWith:", ParameterType = new Type [] { typeof (SharpieSDK.Player) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdaptWithRequestParams", Selector = "adaptWithRequestParams:", ReturnType = typeof (SharpieSDK.PKRequestParams), ParameterType = new Type [] { typeof (SharpieSDK.PKRequestParams) }, ParameterByRef = new bool [] { false })]
	public interface IPKRequestParamsAdapter : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("updateRequestAdapterWith:")]
		[Preserve (Conditional = true)]
		void UpdateRequestAdapterWith (Player player);
		
		[CompilerGenerated]
		[Export ("adaptWithRequestParams:")]
		[Preserve (Conditional = true)]
		PKRequestParams AdaptWithRequestParams (PKRequestParams requestParams);
		
	}
	
	internal sealed class PKRequestParamsAdapterWrapper : BaseWrapper, IPKRequestParamsAdapter {
		[Preserve (Conditional = true)]
		public PKRequestParamsAdapterWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("updateRequestAdapterWith:")]
		[CompilerGenerated]
		public void UpdateRequestAdapterWith (Player player)
		{
			if (player == null)
				throw new ArgumentNullException ("player");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("updateRequestAdapterWith:"), player.Handle);
		}
		
		[Export ("adaptWithRequestParams:")]
		[CompilerGenerated]
		public PKRequestParams AdaptWithRequestParams (PKRequestParams requestParams)
		{
			if (requestParams == null)
				throw new ArgumentNullException ("requestParams");
			return  Runtime.GetNSObject<PKRequestParams> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("adaptWithRequestParams:"), requestParams.Handle));
		}
		
	}
}
namespace SharpieSDK {
	[Protocol]
	[Register("PKRequestParamsAdapter", true)]
	public unsafe abstract partial class PKRequestParamsAdapter : NSObject, IPKRequestParamsAdapter {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PKRequestParamsAdapter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PKRequestParamsAdapter () : base (NSObjectFlag.Empty)
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
		protected PKRequestParamsAdapter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PKRequestParamsAdapter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("adaptWithRequestParams:")]
		[CompilerGenerated]
		public abstract PKRequestParams AdaptWithRequestParams (PKRequestParams requestParams);
		[Export ("updateRequestAdapterWith:")]
		[CompilerGenerated]
		public abstract void UpdateRequestAdapterWith (Player player);
	} /* class PKRequestParamsAdapter */
}
