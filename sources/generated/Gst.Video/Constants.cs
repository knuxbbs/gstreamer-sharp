// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Constants {

		public const string BUFFER_POOL_OPTION_VIDEO_AFFINE_TRANSFORMATION_META = @"GstBufferPoolOptionVideoAffineTransformation";
		public const string BUFFER_POOL_OPTION_VIDEO_ALIGNMENT = @"GstBufferPoolOptionVideoAlignment";
		public const string BUFFER_POOL_OPTION_VIDEO_GL_TEXTURE_UPLOAD_META = @"GstBufferPoolOptionVideoGLTextureUploadMeta";
		public const string BUFFER_POOL_OPTION_VIDEO_META = @"GstBufferPoolOptionVideoMeta";
		public const string CAPS_FEATURE_META_GST_VIDEO_AFFINE_TRANSFORMATION_META = @"meta:GstVideoAffineTransformation";
		public const string CAPS_FEATURE_META_GST_VIDEO_GL_TEXTURE_UPLOAD_META = @"meta:GstVideoGLTextureUploadMeta";
		public const string CAPS_FEATURE_META_GST_VIDEO_META = @"meta:GstVideoMeta";
		public const string CAPS_FEATURE_META_GST_VIDEO_OVERLAY_COMPOSITION = @"meta:GstVideoOverlayComposition";
		public const string META_TAG_VIDEO_COLORSPACE_STR = @"colorspace";
		public const string META_TAG_VIDEO_ORIENTATION_STR = @"orientation";
		public const string META_TAG_VIDEO_SIZE_STR = @"size";
		public const string META_TAG_VIDEO_STR = @"video";
		public const string VIDEO_COLORIMETRY_BT2020 = @"bt2020";
		public const string VIDEO_COLORIMETRY_BT601 = @"bt601";
		public const string VIDEO_COLORIMETRY_BT709 = @"bt709";
		public const string VIDEO_COLORIMETRY_SMPTE240M = @"smpte240m";
		public const string VIDEO_COLORIMETRY_SRGB = @"sRGB";
		public const int VIDEO_COMP_A = 3;
		public const int VIDEO_COMP_B = 2;
		public const int VIDEO_COMP_G = 1;
		public const int VIDEO_COMP_INDEX = 0;
		public const int VIDEO_COMP_PALETTE = 1;
		public const int VIDEO_COMP_R = 0;
		public const int VIDEO_COMP_U = 1;
		public const int VIDEO_COMP_V = 2;
		public const int VIDEO_COMP_Y = 0;
		public const string VIDEO_CONVERTER_OPT_ALPHA_MODE = @"GstVideoConverter.alpha-mode";
		public const string VIDEO_CONVERTER_OPT_ALPHA_VALUE = @"GstVideoConverter.alpha-value";
		public const string VIDEO_CONVERTER_OPT_BORDER_ARGB = @"GstVideoConverter.border-argb";
		public const string VIDEO_CONVERTER_OPT_CHROMA_MODE = @"GstVideoConverter.chroma-mode";
		public const string VIDEO_CONVERTER_OPT_CHROMA_RESAMPLER_METHOD = @"GstVideoConverter.chroma-resampler-method";
		public const string VIDEO_CONVERTER_OPT_DEST_HEIGHT = @"GstVideoConverter.dest-height";
		public const string VIDEO_CONVERTER_OPT_DEST_WIDTH = @"GstVideoConverter.dest-width";
		public const string VIDEO_CONVERTER_OPT_DEST_X = @"GstVideoConverter.dest-x";
		public const string VIDEO_CONVERTER_OPT_DEST_Y = @"GstVideoConverter.dest-y";
		public const string VIDEO_CONVERTER_OPT_DITHER_METHOD = @"GstVideoConverter.dither-method";
		public const string VIDEO_CONVERTER_OPT_DITHER_QUANTIZATION = @"GstVideoConverter.dither-quantization";
		public const string VIDEO_CONVERTER_OPT_FILL_BORDER = @"GstVideoConverter.fill-border";
		public const string VIDEO_CONVERTER_OPT_GAMMA_MODE = @"GstVideoConverter.gamma-mode";
		public const string VIDEO_CONVERTER_OPT_MATRIX_MODE = @"GstVideoConverter.matrix-mode";
		public const string VIDEO_CONVERTER_OPT_PRIMARIES_MODE = @"GstVideoConverter.primaries-mode";
		public const string VIDEO_CONVERTER_OPT_RESAMPLER_METHOD = @"GstVideoConverter.resampler-method";
		public const string VIDEO_CONVERTER_OPT_RESAMPLER_TAPS = @"GstVideoConverter.resampler-taps";
		public const string VIDEO_CONVERTER_OPT_SRC_HEIGHT = @"GstVideoConverter.src-height";
		public const string VIDEO_CONVERTER_OPT_SRC_WIDTH = @"GstVideoConverter.src-width";
		public const string VIDEO_CONVERTER_OPT_SRC_X = @"GstVideoConverter.src-x";
		public const string VIDEO_CONVERTER_OPT_SRC_Y = @"GstVideoConverter.src-y";
		public const string VIDEO_CONVERTER_OPT_THREADS = @"GstVideoConverter.threads";
		public const int VIDEO_DECODER_MAX_ERRORS = 10;
		public const string VIDEO_DECODER_SINK_NAME = @"sink";
		public const string VIDEO_DECODER_SRC_NAME = @"src";
		public const string VIDEO_ENCODER_SINK_NAME = @"sink";
		public const string VIDEO_ENCODER_SRC_NAME = @"src";
		public const string VIDEO_FORMATS_ALL = @"{ I420, YV12, YUY2, UYVY, AYUV, RGBx, BGRx, xRGB, xBGR, RGBA, BGRA, ARGB, ABGR, RGB, BGR, Y41B, Y42B, YVYU, Y444, v210, v216, NV12, NV21, GRAY8, GRAY16_BE, GRAY16_LE, v308, RGB16, BGR16, RGB15, BGR15, UYVP, A420, RGB8P, YUV9, YVU9, IYU1, ARGB64, AYUV64, r210, I420_10BE, I420_10LE, I422_10BE, I422_10LE, Y444_10BE, Y444_10LE, GBR, GBR_10BE, GBR_10LE, NV16, NV24, NV12_64Z32, A420_10BE, A420_10LE, A422_10BE, A422_10LE, A444_10BE, A444_10LE, NV61, P010_10BE, P010_10LE, IYU2, VYUY, GBRA, GBRA_10BE, GBRA_10LE, GBR_12BE, GBR_12LE, GBRA_12BE, GBRA_12LE, I420_12BE, I420_12LE, I422_12BE, I422_12LE, Y444_12BE, Y444_12LE, GRAY10_LE32, NV12_10LE32, NV16_10LE32 }";
		public const string VIDEO_FPS_RANGE = @"(fraction) [ 0, max ]";
		public const int VIDEO_MAX_COMPONENTS = 4;
		public const int VIDEO_MAX_PLANES = 4;
		public const string VIDEO_OVERLAY_COMPOSITION_BLEND_FORMATS = @"{ BGRx, RGBx, xRGB, xBGR, RGBA, BGRA, ARGB, ABGR, RGB, BGR, I420, YV12, AYUV, YUY2, UYVY, v308, Y41B, Y42B, Y444, NV12, NV21, A420, YUV9, YVU9, IYU1, GRAY8 }";
		public const string VIDEO_RESAMPLER_OPT_CUBIC_B = @"GstVideoResampler.cubic-b";
		public const string VIDEO_RESAMPLER_OPT_CUBIC_C = @"GstVideoResampler.cubic-c";
		public const string VIDEO_RESAMPLER_OPT_ENVELOPE = @"GstVideoResampler.envelope";
		public const string VIDEO_RESAMPLER_OPT_MAX_TAPS = @"GstVideoResampler.max-taps";
		public const string VIDEO_RESAMPLER_OPT_SHARPEN = @"GstVideoResampler.sharpen";
		public const string VIDEO_RESAMPLER_OPT_SHARPNESS = @"GstVideoResampler.sharpness";
		public const string VIDEO_SCALER_OPT_DITHER_METHOD = @"GstVideoScaler.dither-method";
		public const string VIDEO_SIZE_RANGE = @"(int) [ 1, max ]";
		public const int VIDEO_TILE_TYPE_MASK = 0;
		public const int VIDEO_TILE_TYPE_SHIFT = 16;
		public const int VIDEO_TILE_X_TILES_MASK = 0;
		public const int VIDEO_TILE_Y_TILES_SHIFT = 16;
#endregion
	}
}