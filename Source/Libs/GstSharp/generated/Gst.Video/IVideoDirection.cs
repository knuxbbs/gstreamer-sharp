// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;

#region Autogenerated code
	public partial interface IVideoDirection : GLib.IWrapper {

		Gst.Video.VideoOrientationMethod VideoDirection {
			get; set;
		}
	}

	[GLib.GInterface (typeof (VideoDirectionAdapter))]
	public partial interface IVideoDirectionImplementor : GLib.IWrapper {

		[GLib.Property ("video-direction")]
		Gst.Video.VideoOrientationMethod VideoDirection {
			get; set;
		}
	}
#endregion
}
