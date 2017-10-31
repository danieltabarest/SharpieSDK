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
	[Register("PKBoundaryFactory", false)]
	[Model]
	public unsafe partial class PKBoundaryFactory : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PKBoundaryFactory (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PKBoundaryFactory (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDuration:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public PKBoundaryFactory (global::System.Double duration)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("percentageTimeBoundaryWithBoundary:")]
		[CompilerGenerated]
		public virtual PKPercentageTimeBoundary PercentageTimeBoundaryWithBoundary (global::System.nint boundary)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("timeBoundaryWithBoundaryTime:")]
		[CompilerGenerated]
		public virtual PKTimeBoundary TimeBoundaryWithBoundaryTime (global::System.Double boundaryTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PKBoundaryFactory */
}
