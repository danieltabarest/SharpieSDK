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
	public unsafe static partial class NSTimer_PlayKit_Swift_1154  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSTimer");
		
		[Export ("after::")]
		[CompilerGenerated]
		public unsafe static NSTimer After (this NSTimer This, global::System.Double interval, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDAction.Handler, block);
			
			NSTimer ret;
			ret =  Runtime.GetNSObject<NSTimer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Double_IntPtr (class_ptr, Selector.GetHandle ("after::"), interval, (IntPtr) block_ptr_block));
			block_ptr_block->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("every::")]
		[CompilerGenerated]
		public unsafe static NSTimer Every (this NSTimer This, global::System.Double interval, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDAction.Handler, block);
			
			NSTimer ret;
			ret =  Runtime.GetNSObject<NSTimer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Double_IntPtr (class_ptr, Selector.GetHandle ("every::"), interval, (IntPtr) block_ptr_block));
			block_ptr_block->CleanupBlock ();
			
			return ret;
		}
		
	} /* class NSTimer_PlayKit_Swift_1154 */
}
