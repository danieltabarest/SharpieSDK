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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAction ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSError>))]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::SharpieSDK.PKEvent>))]
		internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::SharpieSDK.PKEvent>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<SharpieSDK.PKEvent> (obj));
			}
		} /* class SDActionArity1V1 */
		
		internal class NIDActionArity1V1 {
			IntPtr blockPtr;
			DActionArity1V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::SharpieSDK.PKEvent> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::SharpieSDK.PKEvent>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::SharpieSDK.PKEvent obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::System.Double>))]
		internal delegate void DActionArity1V2 (IntPtr block, global::System.Double obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V2 {
			static internal readonly DActionArity1V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V2))]
			static unsafe void Invoke (IntPtr block, global::System.Double obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::System.Double>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V2 */
		
		internal class NIDActionArity1V2 {
			IntPtr blockPtr;
			DActionArity1V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::System.Double> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::System.Double>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::System.Double obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSString, NSError>))]
		internal delegate void DActionArity2V2 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V2 {
			static internal readonly DActionArity2V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V2))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSString, NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSString> (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDActionArity2V2 */
		
		internal class NIDActionArity2V2 {
			IntPtr blockPtr;
			DActionArity2V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSString, NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSString, NSError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSString arg1, NSError arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::SharpieSDK.MediaEntry, NSError>))]
		internal delegate void DActionArity2V0 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::SharpieSDK.MediaEntry, NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<SharpieSDK.MediaEntry> (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDActionArity2V0 */
		
		internal class NIDActionArity2V0 {
			IntPtr blockPtr;
			DActionArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::SharpieSDK.MediaEntry, NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::SharpieSDK.MediaEntry, NSError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::SharpieSDK.MediaEntry arg1, NSError arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::System.Double, global::System.Double>))]
		internal delegate void DActionArity2V1 (IntPtr block, global::System.Double arg1, global::System.Double arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V1 {
			static internal readonly DActionArity2V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V1))]
			static unsafe void Invoke (IntPtr block, global::System.Double arg1, global::System.Double arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::System.Double, global::System.Double>) (descriptor->Target);
				if (del != null)
					del (arg1, arg2);
			}
		} /* class SDActionArity2V1 */
		
		internal class NIDActionArity2V1 {
			IntPtr blockPtr;
			DActionArity2V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::System.Double, global::System.Double> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::System.Double, global::System.Double>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::System.Double arg1, global::System.Double arg2)
			{
				invoker (blockPtr, arg1, arg2);
			}
		} /* class NIDActionArity2V1 */
	}
}
