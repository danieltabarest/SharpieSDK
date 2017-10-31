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
	[Register("PlayerDecoratorBase", false)]
	[Model]
	public unsafe partial class PlayerDecoratorBase : NSObject, IPlayer {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PlayerDecoratorBase () : base (NSObjectFlag.Empty)
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
		protected PlayerDecoratorBase (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PlayerDecoratorBase (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addBoundaryObserverWithBoundaries:observeOn:using:")]
		[CompilerGenerated]
		public unsafe virtual NSUuid AddBoundaryObserverWithBoundaries (PKBoundary[] boundaries, global::CoreFoundation.DispatchQueue dispatchQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<global::System.Double, global::System.Double> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("addObserver:event:block:")]
		[CompilerGenerated]
		public unsafe virtual void AddObserver (NSObject observer, Class @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("addObserver:events:block:")]
		[CompilerGenerated]
		public unsafe virtual void AddObserver (NSObject observer, Class[] events, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("addPeriodicObserverWithInterval:observeOn:using:")]
		[CompilerGenerated]
		public unsafe virtual NSUuid AddPeriodicObserverWithInterval (global::System.Double interval, global::CoreFoundation.DispatchQueue dispatchQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::System.Double> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("createPiPControllerWith:")]
		[CompilerGenerated]
		public virtual global::AVKit.AVPictureInPictureController CreatePiPControllerWith (global::AVKit.AVPictureInPictureControllerDelegate @delegate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("destroy")]
		[CompilerGenerated]
		public virtual void Destroy ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pause")]
		[CompilerGenerated]
		public virtual void Pause ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("play")]
		[CompilerGenerated]
		public virtual void Play ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("prepare:")]
		[CompilerGenerated]
		public virtual void Prepare (MediaConfig config)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removeBoundaryObserver:")]
		[CompilerGenerated]
		public virtual void RemoveBoundaryObserver (NSUuid token)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removeObserver:event:")]
		[CompilerGenerated]
		public virtual void RemoveObserver (NSObject observer, Class @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removeObserver:events:")]
		[CompilerGenerated]
		public virtual void RemoveObserver (NSObject observer, Class[] events)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removePeriodicObserver:")]
		[CompilerGenerated]
		public virtual void RemovePeriodicObserver (NSUuid token)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("resume")]
		[CompilerGenerated]
		public virtual void Resume ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("seekTo:")]
		[CompilerGenerated]
		public virtual void SeekTo (global::CoreMedia.CMTime time)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("selectTrackWithTrackId:")]
		[CompilerGenerated]
		public virtual void SelectTrackWithTrackId (string trackId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setPlayer:")]
		[CompilerGenerated]
		public virtual void SetPlayer (Player player)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("stop")]
		[CompilerGenerated]
		public virtual void Stop ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("updatePluginConfigWithPluginName:config:")]
		[CompilerGenerated]
		public virtual void UpdatePluginConfigWithPluginName (string pluginName, NSObject config)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual string CurrentAudioTrack {
			[Export ("currentAudioTrack")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual PlayerState CurrentState {
			[Export ("currentState")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CurrentTextTrack {
			[Export ("currentTextTrack")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double CurrentTime {
			[Export ("currentTime")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setCurrentTime:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public PlayerDelegate Delegate {
			get {
				return WeakDelegate as PlayerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Duration {
			[Export ("duration")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsPlaying {
			[Export ("isPlaying")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual PKTimeRange[] LoadedTimeRanges {
			[Export ("loadedTimeRanges", ArgumentSemantic.Copy)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual MediaEntry MediaEntry {
			[Export ("mediaEntry", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual Player Player {
			[Export ("getPlayer")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual float Rate {
			[Export ("rate")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SessionId {
			[Export ("sessionId")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual PKPlayerSettings Settings {
			[Export ("settings", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual PlayerView View {
			[Export ("view", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setView:", ArgumentSemantic.Weak)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class PlayerDecoratorBase */
}
