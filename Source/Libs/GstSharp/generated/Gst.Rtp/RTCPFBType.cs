// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.Rtp.RTCPFBTypeGType))]
	public enum RTCPFBType {

		FbTypeInvalid = 0,
		RtpfbTypeNack = 1,
		PsfbTypePli = 1,
		PsfbTypeSli = 2,
		RtpfbTypeTmmbr = 3,
		PsfbTypeRpsi = 3,
		RtpfbTypeTmmbn = 4,
		PsfbTypeFir = 4,
		RtpfbTypeRtcpSrReq = 5,
		PsfbTypeTstr = 5,
		PsfbTypeTstn = 6,
		PsfbTypeVbcn = 7,
		PsfbTypeAfb = 15,
	}

	internal class RTCPFBTypeGType {
		[DllImport ("gstrtp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtcpfb_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_rtcpfb_type_get_type ());
			}
		}
	}
#endregion
}