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
	[Register("PKAdInfo", false)]
	[Model]
	public unsafe partial class PKAdInfo : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PKAdInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PKAdInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAdDescription:adDuration:title:isSkippable:contentType:adId:adSystem:height:width:totalAds:adPosition:timeOffset:isBumper:podIndex:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public PKAdInfo (string adDescription, global::System.Double adDuration, string title, bool isSkippable, string contentType, string adId, string adSystem, global::System.nint height, global::System.nint width, global::System.nint totalAds, global::System.nint adPosition, global::System.Double timeOffset, bool isBumper, global::System.nint podIndex)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual string AdDescription {
			[Export ("adDescription")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setAdDescription:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual string AdId {
			[Export ("adId")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setAdId:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint AdPosition {
			[Export ("adPosition")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setAdPosition:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual string AdSystem {
			[Export ("adSystem")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setAdSystem:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual string ContentType {
			[Export ("contentType")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setContentType:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Duration {
			[Export ("duration")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setDuration:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Height {
			[Export ("height")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setHeight:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsBumper {
			[Export ("isBumper")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setIsBumper:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsSkippable {
			[Export ("isSkippable")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setIsSkippable:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint PodIndex {
			[Export ("podIndex")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setPodIndex:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual AdPositionType PositionType {
			[Export ("positionType")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double TimeOffset {
			[Export ("timeOffset")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setTimeOffset:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setTitle:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint TotalAds {
			[Export ("totalAds")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setTotalAds:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Width {
			[Export ("width")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setWidth:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class PKAdInfo */
}
