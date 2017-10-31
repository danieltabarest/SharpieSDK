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
	[Register("RequestBuilder", false)]
	[Model]
	public unsafe partial class RequestBuilder : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected RequestBuilder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RequestBuilder (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithUrl:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public RequestBuilder (string url)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("addWithHeaderKey:headerValue:")]
		[CompilerGenerated]
		public virtual RequestBuilder AddWithHeaderKey (string headerKey, string headerValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setParamWithKey:value:")]
		[CompilerGenerated]
		public virtual RequestBuilder SetParamWithKey (string key, string value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setWithHeaders:")]
		[CompilerGenerated]
		public virtual RequestBuilder SetWithHeaders (NSDictionary<NSString, NSString> headers)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setWithUrl:")]
		[CompilerGenerated]
		public virtual RequestBuilder SetWithUrl (NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual NSDictionary<NSString, NSString> Headers {
			[Export ("headers", ArgumentSemantic.Copy)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setHeaders:", ArgumentSemantic.Copy)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual string RequestId {
			[Export ("requestId")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setRequestId:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Timeout {
			[Export ("timeout")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setTimeout:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual NSUrl Url {
			[Export ("url", ArgumentSemantic.Copy)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setUrl:", ArgumentSemantic.Copy)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual NSDictionary<NSString, NSString> UrlParams {
			[Export ("urlParams", ArgumentSemantic.Copy)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setUrlParams:", ArgumentSemantic.Copy)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class RequestBuilder */
}
