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
	[Protocol (Name = "Player", WrapperType = typeof (PlayerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Prepare", Selector = "prepare:", ParameterType = new Type [] { typeof (SharpieSDK.MediaConfig) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Play", Selector = "play")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Pause", Selector = "pause")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Resume", Selector = "resume")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Stop", Selector = "stop")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SeekTo", Selector = "seekTo:", ParameterType = new Type [] { typeof (CMTime) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Destroy", Selector = "destroy")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddObserver", Selector = "addObserver:event:block:", ParameterType = new Type [] { typeof (NSObject), typeof (Class), typeof (global::System.Action<global::SharpieSDK.PKEvent>) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddObserver", Selector = "addObserver:events:block:", ParameterType = new Type [] { typeof (NSObject), typeof (Class[]), typeof (global::System.Action<global::SharpieSDK.PKEvent>) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveObserver", Selector = "removeObserver:event:", ParameterType = new Type [] { typeof (NSObject), typeof (Class) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveObserver", Selector = "removeObserver:events:", ParameterType = new Type [] { typeof (NSObject), typeof (Class[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectTrackWithTrackId", Selector = "selectTrackWithTrackId:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdatePluginConfigWithPluginName", Selector = "updatePluginConfigWithPluginName:config:", ParameterType = new Type [] { typeof (string), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreatePiPControllerWith", Selector = "createPiPControllerWith:", ReturnType = typeof (AVKit.AVPictureInPictureController), ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureControllerDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddPeriodicObserverWithInterval", Selector = "addPeriodicObserverWithInterval:observeOn:using:", ReturnType = typeof (NSUuid), ParameterType = new Type [] { typeof (double), typeof (DispatchQueue), typeof (global::System.Action<global::System.Double>) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddBoundaryObserverWithBoundaries", Selector = "addBoundaryObserverWithBoundaries:observeOn:using:", ReturnType = typeof (NSUuid), ParameterType = new Type [] { typeof (SharpieSDK.PKBoundary[]), typeof (DispatchQueue), typeof (global::System.Action<global::System.Double, global::System.Double>) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemovePeriodicObserver", Selector = "removePeriodicObserver:", ParameterType = new Type [] { typeof (NSUuid) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveBoundaryObserver", Selector = "removeBoundaryObserver:", ParameterType = new Type [] { typeof (NSUuid) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakDelegate", Selector = "delegate", PropertyType = typeof (NSObject), GetterSelector = "delegate", SetterSelector = "setDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MediaEntry", Selector = "mediaEntry", PropertyType = typeof (SharpieSDK.MediaEntry), GetterSelector = "mediaEntry", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Settings", Selector = "settings", PropertyType = typeof (SharpieSDK.PKPlayerSettings), GetterSelector = "settings", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "View", Selector = "view", PropertyType = typeof (SharpieSDK.PlayerView), GetterSelector = "view", SetterSelector = "setView:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentTime", Selector = "currentTime", PropertyType = typeof (double), GetterSelector = "currentTime", SetterSelector = "setCurrentTime:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentState", Selector = "currentState", PropertyType = typeof (SharpieSDK.PlayerState), GetterSelector = "currentState", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsPlaying", Selector = "isPlaying", PropertyType = typeof (bool), GetterSelector = "isPlaying", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Duration", Selector = "duration", PropertyType = typeof (double), GetterSelector = "duration", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentAudioTrack", Selector = "currentAudioTrack", PropertyType = typeof (string), GetterSelector = "currentAudioTrack", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentTextTrack", Selector = "currentTextTrack", PropertyType = typeof (string), GetterSelector = "currentTextTrack", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SessionId", Selector = "sessionId", PropertyType = typeof (string), GetterSelector = "sessionId", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Rate", Selector = "rate", PropertyType = typeof (float), GetterSelector = "rate", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LoadedTimeRanges", Selector = "loadedTimeRanges", PropertyType = typeof (SharpieSDK.PKTimeRange[]), GetterSelector = "loadedTimeRanges", ArgumentSemantic = ArgumentSemantic.Copy)]
	public interface IPlayer : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("prepare:")]
		[Preserve (Conditional = true)]
		void Prepare (MediaConfig config);
		
		[CompilerGenerated]
		[Export ("play")]
		[Preserve (Conditional = true)]
		void Play ();
		
		[CompilerGenerated]
		[Export ("pause")]
		[Preserve (Conditional = true)]
		void Pause ();
		
		[CompilerGenerated]
		[Export ("resume")]
		[Preserve (Conditional = true)]
		void Resume ();
		
		[CompilerGenerated]
		[Export ("stop")]
		[Preserve (Conditional = true)]
		void Stop ();
		
		[CompilerGenerated]
		[Export ("seekTo:")]
		[Preserve (Conditional = true)]
		void SeekTo (global::CoreMedia.CMTime time);
		
		[CompilerGenerated]
		[Export ("destroy")]
		[Preserve (Conditional = true)]
		void Destroy ();
		
		[CompilerGenerated]
		[Export ("addObserver:event:block:")]
		[Preserve (Conditional = true)]
		unsafe void AddObserver (NSObject observer, Class @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block);
		
		[CompilerGenerated]
		[Export ("addObserver:events:block:")]
		[Preserve (Conditional = true)]
		unsafe void AddObserver (NSObject observer, Class[] events, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block);
		
		[CompilerGenerated]
		[Export ("removeObserver:event:")]
		[Preserve (Conditional = true)]
		void RemoveObserver (NSObject observer, Class @event);
		
		[CompilerGenerated]
		[Export ("removeObserver:events:")]
		[Preserve (Conditional = true)]
		void RemoveObserver (NSObject observer, Class[] events);
		
		[CompilerGenerated]
		[Export ("selectTrackWithTrackId:")]
		[Preserve (Conditional = true)]
		void SelectTrackWithTrackId (string trackId);
		
		[CompilerGenerated]
		[Export ("updatePluginConfigWithPluginName:config:")]
		[Preserve (Conditional = true)]
		void UpdatePluginConfigWithPluginName (string pluginName, NSObject config);
		
		[CompilerGenerated]
		[Export ("createPiPControllerWith:")]
		[Preserve (Conditional = true)]
		global::AVKit.AVPictureInPictureController CreatePiPControllerWith (global::AVKit.AVPictureInPictureControllerDelegate @delegate);
		
		[CompilerGenerated]
		[Export ("addPeriodicObserverWithInterval:observeOn:using:")]
		[Preserve (Conditional = true)]
		unsafe NSUuid AddPeriodicObserverWithInterval (global::System.Double interval, global::CoreFoundation.DispatchQueue dispatchQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::System.Double> block);
		
		[CompilerGenerated]
		[Export ("addBoundaryObserverWithBoundaries:observeOn:using:")]
		[Preserve (Conditional = true)]
		unsafe NSUuid AddBoundaryObserverWithBoundaries (PKBoundary[] boundaries, global::CoreFoundation.DispatchQueue dispatchQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<global::System.Double, global::System.Double> block);
		
		[CompilerGenerated]
		[Export ("removePeriodicObserver:")]
		[Preserve (Conditional = true)]
		void RemovePeriodicObserver (NSUuid token);
		
		[CompilerGenerated]
		[Export ("removeBoundaryObserver:")]
		[Preserve (Conditional = true)]
		void RemoveBoundaryObserver (NSUuid token);
		
		[Preserve (Conditional = true)]
		NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get;
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set;
		}
		
		[Preserve (Conditional = true)]
		MediaEntry MediaEntry {
			[Export ("mediaEntry", ArgumentSemantic.Weak)]
			get;
		}
		
		[Preserve (Conditional = true)]
		PKPlayerSettings Settings {
			[Export ("settings", ArgumentSemantic.Retain)]
			get;
		}
		
		[Preserve (Conditional = true)]
		PlayerView View {
			[Export ("view", ArgumentSemantic.Weak)]
			get;
			[Export ("setView:", ArgumentSemantic.Weak)]
			set;
		}
		
		[Preserve (Conditional = true)]
		global::System.Double CurrentTime {
			[Export ("currentTime")]
			get;
			[Export ("setCurrentTime:")]
			set;
		}
		
		[Preserve (Conditional = true)]
		PlayerState CurrentState {
			[Export ("currentState")]
			get;
		}
		
		[Preserve (Conditional = true)]
		bool IsPlaying {
			[Export ("isPlaying")]
			get;
		}
		
		[Preserve (Conditional = true)]
		global::System.Double Duration {
			[Export ("duration")]
			get;
		}
		
		[Preserve (Conditional = true)]
		string CurrentAudioTrack {
			[Export ("currentAudioTrack")]
			get;
		}
		
		[Preserve (Conditional = true)]
		string CurrentTextTrack {
			[Export ("currentTextTrack")]
			get;
		}
		
		[Preserve (Conditional = true)]
		string SessionId {
			[Export ("sessionId")]
			get;
		}
		
		[Preserve (Conditional = true)]
		float Rate {
			[Export ("rate")]
			get;
		}
		
		[Preserve (Conditional = true)]
		PKTimeRange[] LoadedTimeRanges {
			[Export ("loadedTimeRanges", ArgumentSemantic.Copy)]
			get;
		}
		
	}
	
	internal sealed class PlayerWrapper : BaseWrapper, IPlayer {
		[Preserve (Conditional = true)]
		public PlayerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("prepare:")]
		[CompilerGenerated]
		public void Prepare (MediaConfig config)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("prepare:"), config.Handle);
		}
		
		[Export ("play")]
		[CompilerGenerated]
		public void Play ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("play"));
		}
		
		[Export ("pause")]
		[CompilerGenerated]
		public void Pause ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pause"));
		}
		
		[Export ("resume")]
		[CompilerGenerated]
		public void Resume ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resume"));
		}
		
		[Export ("stop")]
		[CompilerGenerated]
		public void Stop ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stop"));
		}
		
		[Export ("seekTo:")]
		[CompilerGenerated]
		public void SeekTo (global::CoreMedia.CMTime time)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_CMTime (this.Handle, Selector.GetHandle ("seekTo:"), time);
		}
		
		[Export ("destroy")]
		[CompilerGenerated]
		public void Destroy ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("destroy"));
		}
		
		[Export ("addObserver:event:block:")]
		[CompilerGenerated]
		public unsafe void AddObserver (NSObject observer, Class @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block)
		{
			if (observer == null)
				throw new ArgumentNullException ("observer");
			if (@event == null)
				throw new ArgumentNullException ("@event");
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDActionArity1V1.Handler, block);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addObserver:event:block:"), observer.Handle, @event.Handle, (IntPtr) block_ptr_block);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("addObserver:events:block:")]
		[CompilerGenerated]
		public unsafe void AddObserver (NSObject observer, Class[] events, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block)
		{
			if (observer == null)
				throw new ArgumentNullException ("observer");
			if (events == null)
				throw new ArgumentNullException ("events");
			if (block == null)
				throw new ArgumentNullException ("block");
			var nsa_events = NSArray.FromNSObjects (events);
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDActionArity1V1.Handler, block);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addObserver:events:block:"), observer.Handle, nsa_events.Handle, (IntPtr) block_ptr_block);
			nsa_events.Dispose ();
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("removeObserver:event:")]
		[CompilerGenerated]
		public void RemoveObserver (NSObject observer, Class @event)
		{
			if (observer == null)
				throw new ArgumentNullException ("observer");
			if (@event == null)
				throw new ArgumentNullException ("@event");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeObserver:event:"), observer.Handle, @event.Handle);
		}
		
		[Export ("removeObserver:events:")]
		[CompilerGenerated]
		public void RemoveObserver (NSObject observer, Class[] events)
		{
			if (observer == null)
				throw new ArgumentNullException ("observer");
			if (events == null)
				throw new ArgumentNullException ("events");
			var nsa_events = NSArray.FromNSObjects (events);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeObserver:events:"), observer.Handle, nsa_events.Handle);
			nsa_events.Dispose ();
			
		}
		
		[Export ("selectTrackWithTrackId:")]
		[CompilerGenerated]
		public void SelectTrackWithTrackId (string trackId)
		{
			if (trackId == null)
				throw new ArgumentNullException ("trackId");
			var nstrackId = NSString.CreateNative (trackId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("selectTrackWithTrackId:"), nstrackId);
			NSString.ReleaseNative (nstrackId);
			
		}
		
		[Export ("updatePluginConfigWithPluginName:config:")]
		[CompilerGenerated]
		public void UpdatePluginConfigWithPluginName (string pluginName, NSObject config)
		{
			if (pluginName == null)
				throw new ArgumentNullException ("pluginName");
			if (config == null)
				throw new ArgumentNullException ("config");
			var nspluginName = NSString.CreateNative (pluginName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updatePluginConfigWithPluginName:config:"), nspluginName, config.Handle);
			NSString.ReleaseNative (nspluginName);
			
		}
		
		[Export ("createPiPControllerWith:")]
		[CompilerGenerated]
		public global::AVKit.AVPictureInPictureController CreatePiPControllerWith (global::AVKit.AVPictureInPictureControllerDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			return  Runtime.GetNSObject<global::AVKit.AVPictureInPictureController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("createPiPControllerWith:"), @delegate.Handle));
		}
		
		[Export ("addPeriodicObserverWithInterval:observeOn:using:")]
		[CompilerGenerated]
		public unsafe NSUuid AddPeriodicObserverWithInterval (global::System.Double interval, global::CoreFoundation.DispatchQueue dispatchQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::System.Double> block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDActionArity1V2.Handler, block);
			
			NSUuid ret;
			ret =  Runtime.GetNSObject<NSUuid> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Double_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addPeriodicObserverWithInterval:observeOn:using:"), interval, dispatchQueue == null ? IntPtr.Zero : dispatchQueue.Handle, (IntPtr) block_ptr_block));
			block_ptr_block->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addBoundaryObserverWithBoundaries:observeOn:using:")]
		[CompilerGenerated]
		public unsafe NSUuid AddBoundaryObserverWithBoundaries (PKBoundary[] boundaries, global::CoreFoundation.DispatchQueue dispatchQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<global::System.Double, global::System.Double> block)
		{
			if (boundaries == null)
				throw new ArgumentNullException ("boundaries");
			if (block == null)
				throw new ArgumentNullException ("block");
			var nsa_boundaries = NSArray.FromNSObjects (boundaries);
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDActionArity2V1.Handler, block);
			
			NSUuid ret;
			ret =  Runtime.GetNSObject<NSUuid> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addBoundaryObserverWithBoundaries:observeOn:using:"), nsa_boundaries.Handle, dispatchQueue == null ? IntPtr.Zero : dispatchQueue.Handle, (IntPtr) block_ptr_block));
			nsa_boundaries.Dispose ();
			block_ptr_block->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("removePeriodicObserver:")]
		[CompilerGenerated]
		public void RemovePeriodicObserver (NSUuid token)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removePeriodicObserver:"), token.Handle);
		}
		
		[Export ("removeBoundaryObserver:")]
		[CompilerGenerated]
		public void RemoveBoundaryObserver (NSUuid token)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeBoundaryObserver:"), token.Handle);
		}
		
		[CompilerGenerated]
		public NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
			}
		}
		
		[CompilerGenerated]
		public MediaEntry MediaEntry {
			[Export ("mediaEntry", ArgumentSemantic.Weak)]
			get {
				return  Runtime.GetNSObject<MediaEntry> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mediaEntry")));
			}
			
		}
		
		[CompilerGenerated]
		public PKPlayerSettings Settings {
			[Export ("settings", ArgumentSemantic.Retain)]
			get {
				return  Runtime.GetNSObject<PKPlayerSettings> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("settings")));
			}
			
		}
		
		[CompilerGenerated]
		public PlayerView View {
			[Export ("view", ArgumentSemantic.Weak)]
			get {
				return  Runtime.GetNSObject<PlayerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("view")));
			}
			
			[Export ("setView:", ArgumentSemantic.Weak)]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setView:"), value == null ? IntPtr.Zero : value.Handle);
			}
		}
		
		[CompilerGenerated]
		public global::System.Double CurrentTime {
			[Export ("currentTime")]
			get {
				return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("currentTime"));
			}
			
			[Export ("setCurrentTime:")]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setCurrentTime:"), value);
			}
		}
		
		[CompilerGenerated]
		public PlayerState CurrentState {
			[Export ("currentState")]
			get {
				PlayerState ret;
				if (IntPtr.Size == 8) {
					ret = (PlayerState) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("currentState"));
				} else {
					ret = (PlayerState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("currentState"));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public bool IsPlaying {
			[Export ("isPlaying")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPlaying"));
			}
			
		}
		
		[CompilerGenerated]
		public global::System.Double Duration {
			[Export ("duration")]
			get {
				return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("duration"));
			}
			
		}
		
		[CompilerGenerated]
		public string CurrentAudioTrack {
			[Export ("currentAudioTrack")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentAudioTrack")));
			}
			
		}
		
		[CompilerGenerated]
		public string CurrentTextTrack {
			[Export ("currentTextTrack")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentTextTrack")));
			}
			
		}
		
		[CompilerGenerated]
		public string SessionId {
			[Export ("sessionId")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sessionId")));
			}
			
		}
		
		[CompilerGenerated]
		public float Rate {
			[Export ("rate")]
			get {
				return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("rate"));
			}
			
		}
		
		[CompilerGenerated]
		public PKTimeRange[] LoadedTimeRanges {
			[Export ("loadedTimeRanges", ArgumentSemantic.Copy)]
			get {
				return NSArray.ArrayFromHandle<PKTimeRange>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("loadedTimeRanges")));
			}
			
		}
		
	}
}
namespace SharpieSDK {
	[Protocol]
	[Register("Player", false)]
	[Model]
	public unsafe abstract partial class Player : NSObject, IPlayer {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected Player () : base (NSObjectFlag.Empty)
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
		protected Player (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Player (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addBoundaryObserverWithBoundaries:observeOn:using:")]
		[CompilerGenerated]
		public unsafe abstract NSUuid AddBoundaryObserverWithBoundaries (PKBoundary[] boundaries, global::CoreFoundation.DispatchQueue dispatchQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<global::System.Double, global::System.Double> block);
		[Export ("addObserver:event:block:")]
		[CompilerGenerated]
		public unsafe abstract void AddObserver (NSObject observer, Class @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block);
		[Export ("addObserver:events:block:")]
		[CompilerGenerated]
		public unsafe abstract void AddObserver (NSObject observer, Class[] events, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<PKEvent> block);
		[Export ("addPeriodicObserverWithInterval:observeOn:using:")]
		[CompilerGenerated]
		public unsafe abstract NSUuid AddPeriodicObserverWithInterval (global::System.Double interval, global::CoreFoundation.DispatchQueue dispatchQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::System.Double> block);
		[Export ("createPiPControllerWith:")]
		[CompilerGenerated]
		public abstract global::AVKit.AVPictureInPictureController CreatePiPControllerWith (global::AVKit.AVPictureInPictureControllerDelegate @delegate);
		[Export ("destroy")]
		[CompilerGenerated]
		public abstract void Destroy ();
		[Export ("pause")]
		[CompilerGenerated]
		public abstract void Pause ();
		[Export ("play")]
		[CompilerGenerated]
		public abstract void Play ();
		[Export ("prepare:")]
		[CompilerGenerated]
		public abstract void Prepare (MediaConfig config);
		[Export ("removeBoundaryObserver:")]
		[CompilerGenerated]
		public abstract void RemoveBoundaryObserver (NSUuid token);
		[Export ("removeObserver:event:")]
		[CompilerGenerated]
		public abstract void RemoveObserver (NSObject observer, Class @event);
		[Export ("removeObserver:events:")]
		[CompilerGenerated]
		public abstract void RemoveObserver (NSObject observer, Class[] events);
		[Export ("removePeriodicObserver:")]
		[CompilerGenerated]
		public abstract void RemovePeriodicObserver (NSUuid token);
		[Export ("resume")]
		[CompilerGenerated]
		public abstract void Resume ();
		[Export ("seekTo:")]
		[CompilerGenerated]
		public abstract void SeekTo (global::CoreMedia.CMTime time);
		[Export ("selectTrackWithTrackId:")]
		[CompilerGenerated]
		public abstract void SelectTrackWithTrackId (string trackId);
		[Export ("stop")]
		[CompilerGenerated]
		public abstract void Stop ();
		[Export ("updatePluginConfigWithPluginName:config:")]
		[CompilerGenerated]
		public abstract void UpdatePluginConfigWithPluginName (string pluginName, NSObject config);
		[CompilerGenerated]
		public abstract string CurrentAudioTrack {
			[Export ("currentAudioTrack")]
			get; 
		}
		
		[CompilerGenerated]
		public abstract PlayerState CurrentState {
			[Export ("currentState")]
			get; 
		}
		
		[CompilerGenerated]
		public abstract string CurrentTextTrack {
			[Export ("currentTextTrack")]
			get; 
		}
		
		[CompilerGenerated]
		public abstract global::System.Double CurrentTime {
			[Export ("currentTime")]
			get; 
			[Export ("setCurrentTime:")]
			set; 
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
		public abstract global::System.Double Duration {
			[Export ("duration")]
			get; 
		}
		
		[CompilerGenerated]
		public abstract bool IsPlaying {
			[Export ("isPlaying")]
			get; 
		}
		
		[CompilerGenerated]
		public abstract PKTimeRange[] LoadedTimeRanges {
			[Export ("loadedTimeRanges", ArgumentSemantic.Copy)]
			get; 
		}
		
		[CompilerGenerated]
		public abstract MediaEntry MediaEntry {
			[Export ("mediaEntry", ArgumentSemantic.Weak)]
			get; 
		}
		
		[CompilerGenerated]
		public abstract float Rate {
			[Export ("rate")]
			get; 
		}
		
		[CompilerGenerated]
		public abstract string SessionId {
			[Export ("sessionId")]
			get; 
		}
		
		[CompilerGenerated]
		public abstract PKPlayerSettings Settings {
			[Export ("settings", ArgumentSemantic.Retain)]
			get; 
		}
		
		[CompilerGenerated]
		public abstract PlayerView View {
			[Export ("view", ArgumentSemantic.Weak)]
			get; 
			[Export ("setView:", ArgumentSemantic.Weak)]
			set; 
		}
		
		[CompilerGenerated]
		public abstract NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get; 
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set; 
		}
		
	} /* class Player */
}
