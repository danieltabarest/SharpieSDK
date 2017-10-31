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
	[Protocol (Name = "MediaSource", WrapperType = typeof (MediaSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Id", Selector = "id", PropertyType = typeof (string), GetterSelector = "id", SetterSelector = "setId:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ContentUrl", Selector = "contentUrl", PropertyType = typeof (NSUrl), GetterSelector = "contentUrl", SetterSelector = "setContentUrl:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MimeType", Selector = "mimeType", PropertyType = typeof (string), GetterSelector = "mimeType", SetterSelector = "setMimeType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DrmData", Selector = "drmData", PropertyType = typeof (SharpieSDK.DRMParams[]), GetterSelector = "drmData", SetterSelector = "setDrmData:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaFormat", Selector = "mediaFormat", PropertyType = typeof (SharpieSDK.MediaFormat), GetterSelector = "mediaFormat", SetterSelector = "setMediaFormat:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "FileExt", Selector = "fileExt", PropertyType = typeof (string), GetterSelector = "fileExt", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Description", Selector = "description", PropertyType = typeof (string), GetterSelector = "description", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMediaSource : INativeObject, IDisposable
	{
	}
	
	public static partial class MediaSource_Extensions {
		[CompilerGenerated]
		public static string GetId (this IMediaSource This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("id")));
		}
		
		[CompilerGenerated]
		public static void SetId (this IMediaSource This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setId:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static NSUrl GetContentUrl (this IMediaSource This)
		{
			return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("contentUrl")));
		}
		
		[CompilerGenerated]
		public static void SetContentUrl (this IMediaSource This, NSUrl value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setContentUrl:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static string GetMimeType (this IMediaSource This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mimeType")));
		}
		
		[CompilerGenerated]
		public static void SetMimeType (this IMediaSource This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMimeType:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static DRMParams[] GetDrmData (this IMediaSource This)
		{
			return NSArray.ArrayFromHandle<DRMParams>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("drmData")));
		}
		
		[CompilerGenerated]
		public static void SetDrmData (this IMediaSource This, DRMParams[] value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsa_value = NSArray.FromNSObjects (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDrmData:"), nsa_value.Handle);
			nsa_value.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static MediaFormat GetMediaFormat (this IMediaSource This)
		{
			MediaFormat ret;
			if (IntPtr.Size == 8) {
				ret = (MediaFormat) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("mediaFormat"));
			} else {
				ret = (MediaFormat) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("mediaFormat"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static void SetMediaFormat (this IMediaSource This, MediaFormat value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setMediaFormat:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setMediaFormat:"), (int)value);
			}
		}
		
		[CompilerGenerated]
		public static string GetFileExt (this IMediaSource This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("fileExt")));
		}
		
		[CompilerGenerated]
		public static string GetDescription (this IMediaSource This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("description")));
		}
		
	}
	
	internal sealed class MediaSourceWrapper : BaseWrapper, IMediaSource {
		[Preserve (Conditional = true)]
		public MediaSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace SharpieSDK {
	[Protocol]
	[Register("MediaSource", true)]
	public unsafe partial class MediaSource : NSObject, IMediaSource {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MediaSource");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MediaSource () : base (NSObjectFlag.Empty)
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
		protected MediaSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MediaSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithId:")]
		[CompilerGenerated]
		public MediaSource (string id)
			: base (NSObjectFlag.Empty)
		{
			if (id == null)
				throw new ArgumentNullException ("id");
			var nsid = NSString.CreateNative (id);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithId:"), nsid), "initWithId:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithId:"), nsid), "initWithId:");
			}
			NSString.ReleaseNative (nsid);
			
		}
		
		[Export ("init:contentUrl:mimeType:drmData:mediaFormat:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public MediaSource (string id, NSUrl contentUrl, string mimeType, DRMParams[] drmData, MediaFormat mediaFormat)
			: base (NSObjectFlag.Empty)
		{
			if (id == null)
				throw new ArgumentNullException ("id");
			var nsid = NSString.CreateNative (id);
			var nsmimeType = NSString.CreateNative (mimeType);
			var nsa_drmData = drmData == null ? null : NSArray.FromNSObjects (drmData);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_Int64 (this.Handle, Selector.GetHandle ("init:contentUrl:mimeType:drmData:mediaFormat:"), nsid, contentUrl == null ? IntPtr.Zero : contentUrl.Handle, nsmimeType, nsa_drmData == null ? IntPtr.Zero : nsa_drmData.Handle, (Int64)mediaFormat), "init:contentUrl:mimeType:drmData:mediaFormat:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_int (this.Handle, Selector.GetHandle ("init:contentUrl:mimeType:drmData:mediaFormat:"), nsid, contentUrl == null ? IntPtr.Zero : contentUrl.Handle, nsmimeType, nsa_drmData == null ? IntPtr.Zero : nsa_drmData.Handle, (int)mediaFormat), "init:contentUrl:mimeType:drmData:mediaFormat:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_Int64 (this.SuperHandle, Selector.GetHandle ("init:contentUrl:mimeType:drmData:mediaFormat:"), nsid, contentUrl == null ? IntPtr.Zero : contentUrl.Handle, nsmimeType, nsa_drmData == null ? IntPtr.Zero : nsa_drmData.Handle, (Int64)mediaFormat), "init:contentUrl:mimeType:drmData:mediaFormat:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_int (this.SuperHandle, Selector.GetHandle ("init:contentUrl:mimeType:drmData:mediaFormat:"), nsid, contentUrl == null ? IntPtr.Zero : contentUrl.Handle, nsmimeType, nsa_drmData == null ? IntPtr.Zero : nsa_drmData.Handle, (int)mediaFormat), "init:contentUrl:mimeType:drmData:mediaFormat:");
				}
			}
			NSString.ReleaseNative (nsid);
			NSString.ReleaseNative (nsmimeType);
			if (nsa_drmData != null)
				nsa_drmData.Dispose ();
			
		}
		
		[Export ("initWithJson:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public MediaSource (NSObject json)
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
		public virtual NSUrl ContentUrl {
			[Export ("contentUrl", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentUrl")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentUrl")));
				}
				return ret;
			}
			
			[Export ("setContentUrl:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContentUrl:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setContentUrl:"), value == null ? IntPtr.Zero : value.Handle);
				}
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
		public virtual DRMParams[] DrmData {
			[Export ("drmData", ArgumentSemantic.Copy)]
			get {
				DRMParams[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<DRMParams>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("drmData")));
				} else {
					ret = NSArray.ArrayFromHandle<DRMParams>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("drmData")));
				}
				return ret;
			}
			
			[Export ("setDrmData:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDrmData:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDrmData:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string FileExt {
			[Export ("fileExt")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileExt")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileExt")));
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
		public virtual MediaFormat MediaFormat {
			[Export ("mediaFormat", ArgumentSemantic.UnsafeUnretained)]
			get {
				MediaFormat ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MediaFormat) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("mediaFormat"));
					} else {
						ret = (MediaFormat) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("mediaFormat"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MediaFormat) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaFormat"));
					} else {
						ret = (MediaFormat) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaFormat"));
					}
				}
				return ret;
			}
			
			[Export ("setMediaFormat:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setMediaFormat:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMediaFormat:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setMediaFormat:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMediaFormat:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string MimeType {
			[Export ("mimeType")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mimeType")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mimeType")));
				}
			}
			
			[Export ("setMimeType:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMimeType:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMimeType:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class MediaSource */
}
