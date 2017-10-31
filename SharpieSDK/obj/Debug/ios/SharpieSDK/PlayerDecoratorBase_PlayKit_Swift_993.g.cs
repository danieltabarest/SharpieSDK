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
	public unsafe static partial class PlayerDecoratorBase_PlayKit_Swift_993  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PlayerDecoratorBase");
		
		[Export ("createPiPControllerWith:")]
		[CompilerGenerated]
		public static global::AVKit.AVPictureInPictureController CreatePiPControllerWith (this PlayerDecoratorBase This, global::AVKit.AVPictureInPictureControllerDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			return  Runtime.GetNSObject<global::AVKit.AVPictureInPictureController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("createPiPControllerWith:"), @delegate.Handle));
		}
		
	} /* class PlayerDecoratorBase_PlayKit_Swift_993 */
}
