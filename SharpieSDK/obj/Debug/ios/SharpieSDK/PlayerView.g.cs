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
	[Protocol (Name = "PlayerView", WrapperType = typeof (PlayerViewWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddToContainer", Selector = "addToContainer:", ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CreatePlayerViewForPlayer", Selector = "createPlayerViewForPlayer:", ReturnType = typeof (SharpieSDK.PlayerView), ParameterType = new Type [] { typeof (SharpieSDK.Player) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "initWithFrame", Selector = "initWithFrame:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (CGRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "LayerClass", Selector = "layerClass", PropertyType = typeof (Class), GetterSelector = "layerClass", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IPlayerView : INativeObject, IDisposable
	{
	}
	
	public static partial class PlayerView_Extensions {
		[CompilerGenerated]
		public static void AddToContainer (this IPlayerView This, global::UIKit.UIView container)
		{
			if (container == null)
				throw new ArgumentNullException ("container");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addToContainer:"), container.Handle);
		}
		
		[DesignatedInitializer]
		[CompilerGenerated]
		public static global::System.IntPtr initWithFrame (this IPlayerView This, CGRect frame)
		{
			return global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("initWithFrame:"), frame);
		}
		
	}
	
	internal sealed class PlayerViewWrapper : BaseWrapper, IPlayerView {
		[Preserve (Conditional = true)]
		public PlayerViewWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace SharpieSDK {
	[Protocol]
	[Register("PlayerView", true)]
	public unsafe partial class PlayerView : global::UIKit.UIView, IPlayerView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PlayerView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PlayerView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PlayerView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PlayerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PlayerView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addToContainer:")]
		[CompilerGenerated]
		public virtual void AddToContainer (global::UIKit.UIView container)
		{
			if (container == null)
				throw new ArgumentNullException ("container");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addToContainer:"), container.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addToContainer:"), container.Handle);
			}
		}
		
		[Export ("createPlayerViewForPlayer:")]
		[CompilerGenerated]
		public static PlayerView CreatePlayerViewForPlayer (Player player)
		{
			if (player == null)
				throw new ArgumentNullException ("player");
			return  Runtime.GetNSObject<PlayerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("createPlayerViewForPlayer:"), player.Handle));
		}
		
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public virtual global::System.IntPtr initWithFrame (CGRect frame)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame);
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame);
			}
		}
		
		[CompilerGenerated]
		public static Class LayerClass {
			[Export ("layerClass")]
			get {
				IntPtr ret;
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("layerClass"));
				return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
			}
			
		}
		
		public partial class PlayerViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PlayerViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PlayerViewAppearance Appearance {
			get { return new PlayerViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PlayerViewAppearance GetAppearance<T> () where T: PlayerView {
			return new PlayerViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PlayerViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PlayerViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PlayerViewAppearance GetAppearance (UITraitCollection traits) {
			return new PlayerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PlayerViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PlayerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PlayerViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PlayerView {
			return new PlayerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PlayerViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PlayerView{
			return new PlayerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PlayerView */
}
