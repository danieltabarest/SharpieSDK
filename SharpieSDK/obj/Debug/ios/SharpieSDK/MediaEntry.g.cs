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
	[Protocol (Name = "MediaEntry", WrapperType = typeof (MediaEntryWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Id", Selector = "id", PropertyType = typeof (string), GetterSelector = "id", SetterSelector = "setId:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Sources", Selector = "sources", PropertyType = typeof (SharpieSDK.MediaSource[]), GetterSelector = "sources", SetterSelector = "setSources:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Duration", Selector = "duration", PropertyType = typeof (double), GetterSelector = "duration", SetterSelector = "setDuration:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaType", Selector = "mediaType", PropertyType = typeof (SharpieSDK.MediaType), GetterSelector = "mediaType", SetterSelector = "setMediaType:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Metadata", Selector = "metadata", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSString>), GetterSelector = "metadata", SetterSelector = "setMetadata:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Description", Selector = "description", PropertyType = typeof (string), GetterSelector = "description", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMediaEntry : INativeObject, IDisposable
	{
	}
	
	public static partial class MediaEntry_Extensions {
		[CompilerGenerated]
		public static string GetId (this IMediaEntry This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("id")));
		}
		
		[CompilerGenerated]
		public static void SetId (this IMediaEntry This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setId:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static MediaSource[] GetSources (this IMediaEntry This)
		{
			return NSArray.ArrayFromHandle<MediaSource>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sources")));
		}
		
		[CompilerGenerated]
		public static void SetSources (this IMediaEntry This, MediaSource[] value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsa_value = NSArray.FromNSObjects (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSources:"), nsa_value.Handle);
			nsa_value.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static global::System.Double GetDuration (this IMediaEntry This)
		{
			return global::ApiDefinition.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("duration"));
		}
		
		[CompilerGenerated]
		public static void SetDuration (this IMediaEntry This, global::System.Double value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setDuration:"), value);
		}
		
		[CompilerGenerated]
		public static MediaType GetMediaType (this IMediaEntry This)
		{
			MediaType ret;
			if (IntPtr.Size == 8) {
				ret = (MediaType) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("mediaType"));
			} else {
				ret = (MediaType) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("mediaType"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static void SetMediaType (this IMediaEntry This, MediaType value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setMediaType:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setMediaType:"), (int)value);
			}
		}
		
		[CompilerGenerated]
		public static NSDictionary<NSString, NSString> GetMetadata (this IMediaEntry This)
		{
			return  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("metadata")));
		}
		
		[CompilerGenerated]
		public static void SetMetadata (this IMediaEntry This, NSDictionary<NSString, NSString> value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMetadata:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static string GetDescription (this IMediaEntry This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("description")));
		}
		
	}
	
	internal sealed class MediaEntryWrapper : BaseWrapper, IMediaEntry {
		[Preserve (Conditional = true)]
		public MediaEntryWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace SharpieSDK {
	[Protocol]
	[Register("MediaEntry", true)]
	public unsafe partial class MediaEntry : NSObject, IMediaEntry {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MediaEntry");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MediaEntry (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MediaEntry (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("init:sources:duration:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public MediaEntry (string id, MediaSource[] sources, global::System.Double duration)
			: base (NSObjectFlag.Empty)
		{
			if (id == null)
				throw new ArgumentNullException ("id");
			if (sources == null)
				throw new ArgumentNullException ("sources");
			var nsid = NSString.CreateNative (id);
			var nsa_sources = NSArray.FromNSObjects (sources);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Double (this.Handle, Selector.GetHandle ("init:sources:duration:"), nsid, nsa_sources.Handle, duration), "init:sources:duration:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Double (this.SuperHandle, Selector.GetHandle ("init:sources:duration:"), nsid, nsa_sources.Handle, duration), "init:sources:duration:");
			}
			NSString.ReleaseNative (nsid);
			nsa_sources.Dispose ();
			
		}
		
		[Export ("initWithJson:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public MediaEntry (NSObject json)
			: base (NSObjectFlag.Empty)
		{
			if (json == null)
				throw new ArgumentNullException ("json");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithJson:"), json.Handle), "initWithJson:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithJson:"), json.Handle), "initWithJson:");
			}
		}
		
		[CompilerGenerated]
		public virtual string Description {
			[Export ("description")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("description")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("description")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Duration {
			[Export ("duration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("duration"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("duration"));
				}
			}
			
			[Export ("setDuration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setDuration:"), value);
				}
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
				if (value == null)
					throw new ArgumentNullException ("value");
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
		public virtual MediaType MediaType {
			[Export ("mediaType", ArgumentSemantic.UnsafeUnretained)]
			get {
				MediaType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MediaType) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("mediaType"));
					} else {
						ret = (MediaType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("mediaType"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MediaType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaType"));
					} else {
						ret = (MediaType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaType"));
					}
				}
				return ret;
			}
			
			[Export ("setMediaType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setMediaType:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMediaType:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setMediaType:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMediaType:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDictionary<NSString, NSString> Metadata {
			[Export ("metadata", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, NSString> ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("metadata")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("metadata")));
				}
				return ret;
			}
			
			[Export ("setMetadata:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMetadata:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMetadata:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MediaSource[] Sources {
			[Export ("sources", ArgumentSemantic.Copy)]
			get {
				MediaSource[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MediaSource>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sources")));
				} else {
					ret = NSArray.ArrayFromHandle<MediaSource>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sources")));
				}
				return ret;
			}
			
			[Export ("setSources:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSources:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSources:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
	} /* class MediaEntry */
}
