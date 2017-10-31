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
	[Register("SimpleOVPSessionProvider", false)]
	[Model]
	public unsafe partial class SimpleOVPSessionProvider : NSObject, ISessionProvider {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SimpleOVPSessionProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SimpleOVPSessionProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithServerURL:partnerId:ks:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public SimpleOVPSessionProvider (string serverURL, global::System.Int64 partnerId, string ks)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("loadKSWithCompletion:")]
		[CompilerGenerated]
		public unsafe virtual void LoadKSWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<NSString, NSError> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual string Ks {
			[Export ("ks")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setKs:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Int64 PartnerId {
			[Export ("partnerId")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ServerURL {
			[Export ("serverURL")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class SimpleOVPSessionProvider */
}
