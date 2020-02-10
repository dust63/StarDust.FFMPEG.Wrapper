using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace StarDust.FFMPEG.ClassGenerator
{
    public static class VideoEncoders {

 
        ///<summary>
        /// Multicolor charset for Commodore 64 (encoders: a64multi )
        ///</summary>
        [Display(Name = "a64 multi")]
        [Description("Multicolor charset for Commodore 64 (encoders: a64multi )")]
        public static string a64_multi = "a64_multi";

 
        ///<summary>
        /// Multicolor charset for Commodore 64, extended with 5th color (colram) (encoders: a64multi5 )
        ///</summary>
        [Display(Name = "a64 multi5")]
        [Description("Multicolor charset for Commodore 64, extended with 5th color (colram) (encoders: a64multi5 )")]
        public static string a64_multi5 = "a64_multi5";

 
        ///<summary>
        /// Alias/Wavefront PIX image
        ///</summary>
        [Display(Name = "alias pix")]
        [Description("Alias/Wavefront PIX image")]
        public static string alias_pix = "alias_pix";

 
        ///<summary>
        /// AMV Video
        ///</summary>
        [Display(Name = "amv")]
        [Description("AMV Video")]
        public static string amv = "amv";

 
        ///<summary>
        /// APNG (Animated Portable Network Graphics) image
        ///</summary>
        [Display(Name = "apng")]
        [Description("APNG (Animated Portable Network Graphics) image")]
        public static string apng = "apng";

 
        ///<summary>
        /// ASUS V1
        ///</summary>
        [Display(Name = "asv1")]
        [Description("ASUS V1")]
        public static string asv1 = "asv1";

 
        ///<summary>
        /// ASUS V2
        ///</summary>
        [Display(Name = "asv2")]
        [Description("ASUS V2")]
        public static string asv2 = "asv2";

 
        ///<summary>
        /// Alliance for Open Media AV1 (decoders: libaom-av1 libdav1d ) (encoders: libaom-av1 )
        ///</summary>
        [Display(Name = "av1")]
        [Description("Alliance for Open Media AV1 (decoders: libaom-av1 libdav1d ) (encoders: libaom-av1 )")]
        public static string av1 = "av1";

 
        ///<summary>
        /// Avid 1:1 10-bit RGB Packer
        ///</summary>
        [Display(Name = "avrp")]
        [Description("Avid 1:1 10-bit RGB Packer")]
        public static string avrp = "avrp";

 
        ///<summary>
        /// Avid Meridien Uncompressed
        ///</summary>
        [Display(Name = "avui")]
        [Description("Avid Meridien Uncompressed")]
        public static string avui = "avui";

 
        ///<summary>
        /// Uncompressed packed MS 4:4:4:4
        ///</summary>
        [Display(Name = "ayuv")]
        [Description("Uncompressed packed MS 4:4:4:4")]
        public static string ayuv = "ayuv";

 
        ///<summary>
        /// BMP (Windows and OS/2 bitmap)
        ///</summary>
        [Display(Name = "bmp")]
        [Description("BMP (Windows and OS/2 bitmap)")]
        public static string bmp = "bmp";

 
        ///<summary>
        /// Cinepak
        ///</summary>
        [Display(Name = "cinepak")]
        [Description("Cinepak")]
        public static string cinepak = "cinepak";

 
        ///<summary>
        /// Cirrus Logic AccuPak
        ///</summary>
        [Display(Name = "cljr")]
        [Description("Cirrus Logic AccuPak")]
        public static string cljr = "cljr";

 
        ///<summary>
        /// Dirac (encoders: vc2 )
        ///</summary>
        [Display(Name = "dirac")]
        [Description("Dirac (encoders: vc2 )")]
        public static string dirac = "dirac";

 
        ///<summary>
        /// VC3/DNxHD
        ///</summary>
        [Display(Name = "dnxhd")]
        [Description("VC3/DNxHD")]
        public static string dnxhd = "dnxhd";

 
        ///<summary>
        /// DPX (Digital Picture Exchange) image
        ///</summary>
        [Display(Name = "dpx")]
        [Description("DPX (Digital Picture Exchange) image")]
        public static string dpx = "dpx";

 
        ///<summary>
        /// DV (Digital Video)
        ///</summary>
        [Display(Name = "dvvideo")]
        [Description("DV (Digital Video)")]
        public static string dvvideo = "dvvideo";

 
        ///<summary>
        /// FFmpeg video codec #1
        ///</summary>
        [Display(Name = "ffv1")]
        [Description("FFmpeg video codec #1")]
        public static string ffv1 = "ffv1";

 
        ///<summary>
        /// Huffyuv FFmpeg variant
        ///</summary>
        [Display(Name = "ffvhuff")]
        [Description("Huffyuv FFmpeg variant")]
        public static string ffvhuff = "ffvhuff";

 
        ///<summary>
        /// FITS (Flexible Image Transport System)
        ///</summary>
        [Display(Name = "fits")]
        [Description("FITS (Flexible Image Transport System)")]
        public static string fits = "fits";

 
        ///<summary>
        /// Flash Screen Video v1
        ///</summary>
        [Display(Name = "flashsv")]
        [Description("Flash Screen Video v1")]
        public static string flashsv = "flashsv";

 
        ///<summary>
        /// Flash Screen Video v2
        ///</summary>
        [Display(Name = "flashsv2")]
        [Description("Flash Screen Video v2")]
        public static string flashsv2 = "flashsv2";

 
        ///<summary>
        /// FLV / Sorenson Spark / Sorenson H.263 (Flash Video) (decoders: flv ) (encoders: flv )
        ///</summary>
        [Display(Name = "flv1")]
        [Description("FLV / Sorenson Spark / Sorenson H.263 (Flash Video) (decoders: flv ) (encoders: flv )")]
        public static string flv1 = "flv1";

 
        ///<summary>
        /// CompuServe GIF (Graphics Interchange Format)
        ///</summary>
        [Display(Name = "gif")]
        [Description("CompuServe GIF (Graphics Interchange Format)")]
        public static string gif = "gif";

 
        ///<summary>
        /// H.261
        ///</summary>
        [Display(Name = "h261")]
        [Description("H.261")]
        public static string h261 = "h261";

 
        ///<summary>
        /// H.263 / H.263-1996, H.263+ / H.263-1998 / H.263 version 2
        ///</summary>
        [Display(Name = "h263")]
        [Description("H.263 / H.263-1996, H.263+ / H.263-1998 / H.263 version 2")]
        public static string h263 = "h263";

 
        ///<summary>
        /// H.263+ / H.263-1998 / H.263 version 2
        ///</summary>
        [Display(Name = "h263p")]
        [Description("H.263+ / H.263-1998 / H.263 version 2")]
        public static string h263p = "h263p";

 
        ///<summary>
        /// H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10 (decoders: h264 h264_qsv h264_cuvid ) (encoders: libx264 libx264rgb h264_amf h264_nvenc h264_qsv nvenc nvenc_h264 )
        ///</summary>
        [Display(Name = "h264")]
        [Description("H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10 (decoders: h264 h264_qsv h264_cuvid ) (encoders: libx264 libx264rgb h264_amf h264_nvenc h264_qsv nvenc nvenc_h264 )")]
        public static string h264 = "h264";

 
        ///<summary>
        /// Vidvox Hap
        ///</summary>
        [Display(Name = "hap")]
        [Description("Vidvox Hap")]
        public static string hap = "hap";

 
        ///<summary>
        /// H.265 / HEVC (High Efficiency Video Coding) (decoders: hevc hevc_qsv hevc_cuvid ) (encoders: libx265 nvenc_hevc hevc_amf hevc_nvenc hevc_qsv )
        ///</summary>
        [Display(Name = "hevc")]
        [Description("H.265 / HEVC (High Efficiency Video Coding) (decoders: hevc hevc_qsv hevc_cuvid ) (encoders: libx265 nvenc_hevc hevc_amf hevc_nvenc hevc_qsv )")]
        public static string hevc = "hevc";

 
        ///<summary>
        /// HuffYUV
        ///</summary>
        [Display(Name = "huffyuv")]
        [Description("HuffYUV")]
        public static string huffyuv = "huffyuv";

 
        ///<summary>
        /// JPEG 2000 (decoders: jpeg2000 libopenjpeg ) (encoders: jpeg2000 libopenjpeg )
        ///</summary>
        [Display(Name = "jpeg2000")]
        [Description("JPEG 2000 (decoders: jpeg2000 libopenjpeg ) (encoders: jpeg2000 libopenjpeg )")]
        public static string jpeg2000 = "jpeg2000";

 
        ///<summary>
        /// JPEG-LS
        ///</summary>
        [Display(Name = "jpegls")]
        [Description("JPEG-LS")]
        public static string jpegls = "jpegls";

 
        ///<summary>
        /// Lossless JPEG
        ///</summary>
        [Display(Name = "ljpeg")]
        [Description("Lossless JPEG")]
        public static string ljpeg = "ljpeg";

 
        ///<summary>
        /// MagicYUV video
        ///</summary>
        [Display(Name = "magicyuv")]
        [Description("MagicYUV video")]
        public static string magicyuv = "magicyuv";

 
        ///<summary>
        /// Motion JPEG (decoders: mjpeg mjpeg_cuvid ) (encoders: mjpeg mjpeg_qsv )
        ///</summary>
        [Display(Name = "mjpeg")]
        [Description("Motion JPEG (decoders: mjpeg mjpeg_cuvid ) (encoders: mjpeg mjpeg_qsv )")]
        public static string mjpeg = "mjpeg";

 
        ///<summary>
        /// MPEG-1 video (decoders: mpeg1video mpeg1_cuvid )
        ///</summary>
        [Display(Name = "mpeg1video")]
        [Description("MPEG-1 video (decoders: mpeg1video mpeg1_cuvid )")]
        public static string mpeg1video = "mpeg1video";

 
        ///<summary>
        /// MPEG-2 video (decoders: mpeg2video mpegvideo mpeg2_qsv mpeg2_cuvid ) (encoders: mpeg2video mpeg2_qsv )
        ///</summary>
        [Display(Name = "mpeg2video")]
        [Description("MPEG-2 video (decoders: mpeg2video mpegvideo mpeg2_qsv mpeg2_cuvid ) (encoders: mpeg2video mpeg2_qsv )")]
        public static string mpeg2video = "mpeg2video";

 
        ///<summary>
        /// MPEG-4 part 2 (decoders: mpeg4 mpeg4_cuvid ) (encoders: mpeg4 libxvid )
        ///</summary>
        [Display(Name = "mpeg4")]
        [Description("MPEG-4 part 2 (decoders: mpeg4 mpeg4_cuvid ) (encoders: mpeg4 libxvid )")]
        public static string mpeg4 = "mpeg4";

 
        ///<summary>
        /// MPEG-4 part 2 Microsoft variant version 2
        ///</summary>
        [Display(Name = "msmpeg4v2")]
        [Description("MPEG-4 part 2 Microsoft variant version 2")]
        public static string msmpeg4v2 = "msmpeg4v2";

 
        ///<summary>
        /// MPEG-4 part 2 Microsoft variant version 3 (decoders: msmpeg4 ) (encoders: msmpeg4 )
        ///</summary>
        [Display(Name = "msmpeg4v3")]
        [Description("MPEG-4 part 2 Microsoft variant version 3 (decoders: msmpeg4 ) (encoders: msmpeg4 )")]
        public static string msmpeg4v3 = "msmpeg4v3";

 
        ///<summary>
        /// Microsoft Video 1
        ///</summary>
        [Display(Name = "msvideo1")]
        [Description("Microsoft Video 1")]
        public static string msvideo1 = "msvideo1";

 
        ///<summary>
        /// PAM (Portable AnyMap) image
        ///</summary>
        [Display(Name = "pam")]
        [Description("PAM (Portable AnyMap) image")]
        public static string pam = "pam";

 
        ///<summary>
        /// PBM (Portable BitMap) image
        ///</summary>
        [Display(Name = "pbm")]
        [Description("PBM (Portable BitMap) image")]
        public static string pbm = "pbm";

 
        ///<summary>
        /// PC Paintbrush PCX image
        ///</summary>
        [Display(Name = "pcx")]
        [Description("PC Paintbrush PCX image")]
        public static string pcx = "pcx";

 
        ///<summary>
        /// PGM (Portable GrayMap) image
        ///</summary>
        [Display(Name = "pgm")]
        [Description("PGM (Portable GrayMap) image")]
        public static string pgm = "pgm";

 
        ///<summary>
        /// PGMYUV (Portable GrayMap YUV) image
        ///</summary>
        [Display(Name = "pgmyuv")]
        [Description("PGMYUV (Portable GrayMap YUV) image")]
        public static string pgmyuv = "pgmyuv";

 
        ///<summary>
        /// PNG (Portable Network Graphics) image
        ///</summary>
        [Display(Name = "png")]
        [Description("PNG (Portable Network Graphics) image")]
        public static string png = "png";

 
        ///<summary>
        /// PPM (Portable PixelMap) image
        ///</summary>
        [Display(Name = "ppm")]
        [Description("PPM (Portable PixelMap) image")]
        public static string ppm = "ppm";

 
        ///<summary>
        /// Apple ProRes (iCodec Pro) (encoders: prores prores_aw prores_ks )
        ///</summary>
        [Display(Name = "prores")]
        [Description("Apple ProRes (iCodec Pro) (encoders: prores prores_aw prores_ks )")]
        public static string prores = "prores";

 
        ///<summary>
        /// QuickTime Animation (RLE) video
        ///</summary>
        [Display(Name = "qtrle")]
        [Description("QuickTime Animation (RLE) video")]
        public static string qtrle = "qtrle";

 
        ///<summary>
        /// AJA Kona 10-bit RGB Codec
        ///</summary>
        [Display(Name = "r10k")]
        [Description("AJA Kona 10-bit RGB Codec")]
        public static string r10k = "r10k";

 
        ///<summary>
        /// Uncompressed RGB 10-bit
        ///</summary>
        [Display(Name = "r210")]
        [Description("Uncompressed RGB 10-bit")]
        public static string r210 = "r210";

 
        ///<summary>
        /// raw video
        ///</summary>
        [Display(Name = "rawvideo")]
        [Description("raw video")]
        public static string rawvideo = "rawvideo";

 
        ///<summary>
        /// id RoQ video (decoders: roqvideo ) (encoders: roqvideo )
        ///</summary>
        [Display(Name = "roq")]
        [Description("id RoQ video (decoders: roqvideo ) (encoders: roqvideo )")]
        public static string roq = "roq";

 
        ///<summary>
        /// RealVideo 1.0
        ///</summary>
        [Display(Name = "rv10")]
        [Description("RealVideo 1.0")]
        public static string rv10 = "rv10";

 
        ///<summary>
        /// RealVideo 2.0
        ///</summary>
        [Display(Name = "rv20")]
        [Description("RealVideo 2.0")]
        public static string rv20 = "rv20";

 
        ///<summary>
        /// SGI image
        ///</summary>
        [Display(Name = "sgi")]
        [Description("SGI image")]
        public static string sgi = "sgi";

 
        ///<summary>
        /// Snow
        ///</summary>
        [Display(Name = "snow")]
        [Description("Snow")]
        public static string snow = "snow";

 
        ///<summary>
        /// Sun Rasterfile image
        ///</summary>
        [Display(Name = "sunrast")]
        [Description("Sun Rasterfile image")]
        public static string sunrast = "sunrast";

 
        ///<summary>
        /// Sorenson Vector Quantizer 1 / Sorenson Video 1 / SVQ1
        ///</summary>
        [Display(Name = "svq1")]
        [Description("Sorenson Vector Quantizer 1 / Sorenson Video 1 / SVQ1")]
        public static string svq1 = "svq1";

 
        ///<summary>
        /// Truevision Targa image
        ///</summary>
        [Display(Name = "targa")]
        [Description("Truevision Targa image")]
        public static string targa = "targa";

 
        ///<summary>
        /// Theora (encoders: libtheora )
        ///</summary>
        [Display(Name = "theora")]
        [Description("Theora (encoders: libtheora )")]
        public static string theora = "theora";

 
        ///<summary>
        /// TIFF image
        ///</summary>
        [Display(Name = "tiff")]
        [Description("TIFF image")]
        public static string tiff = "tiff";

 
        ///<summary>
        /// Ut Video
        ///</summary>
        [Display(Name = "utvideo")]
        [Description("Ut Video")]
        public static string utvideo = "utvideo";

 
        ///<summary>
        /// Uncompressed 4:2:2 10-bit
        ///</summary>
        [Display(Name = "v210")]
        [Description("Uncompressed 4:2:2 10-bit")]
        public static string v210 = "v210";

 
        ///<summary>
        /// Uncompressed packed 4:4:4
        ///</summary>
        [Display(Name = "v308")]
        [Description("Uncompressed packed 4:4:4")]
        public static string v308 = "v308";

 
        ///<summary>
        /// Uncompressed packed QT 4:4:4:4
        ///</summary>
        [Display(Name = "v408")]
        [Description("Uncompressed packed QT 4:4:4:4")]
        public static string v408 = "v408";

 
        ///<summary>
        /// Uncompressed 4:4:4 10-bit
        ///</summary>
        [Display(Name = "v410")]
        [Description("Uncompressed 4:4:4 10-bit")]
        public static string v410 = "v410";

 
        ///<summary>
        /// On2 VP8 (decoders: vp8 libvpx vp8_cuvid vp8_qsv ) (encoders: libvpx )
        ///</summary>
        [Display(Name = "vp8")]
        [Description("On2 VP8 (decoders: vp8 libvpx vp8_cuvid vp8_qsv ) (encoders: libvpx )")]
        public static string vp8 = "vp8";

 
        ///<summary>
        /// Google VP9 (decoders: vp9 libvpx-vp9 vp9_cuvid ) (encoders: libvpx-vp9 )
        ///</summary>
        [Display(Name = "vp9")]
        [Description("Google VP9 (decoders: vp9 libvpx-vp9 vp9_cuvid ) (encoders: libvpx-vp9 )")]
        public static string vp9 = "vp9";

 
        ///<summary>
        /// WebP (encoders: libwebp_anim libwebp )
        ///</summary>
        [Display(Name = "webp")]
        [Description("WebP (encoders: libwebp_anim libwebp )")]
        public static string webp = "webp";

 
        ///<summary>
        /// Windows Media Video 7
        ///</summary>
        [Display(Name = "wmv1")]
        [Description("Windows Media Video 7")]
        public static string wmv1 = "wmv1";

 
        ///<summary>
        /// Windows Media Video 8
        ///</summary>
        [Display(Name = "wmv2")]
        [Description("Windows Media Video 8")]
        public static string wmv2 = "wmv2";

 
        ///<summary>
        /// AVFrame to AVPacket passthrough
        ///</summary>
        [Display(Name = "wrapped avframe")]
        [Description("AVFrame to AVPacket passthrough")]
        public static string wrapped_avframe = "wrapped_avframe";

 
        ///<summary>
        /// XBM (X BitMap) image
        ///</summary>
        [Display(Name = "xbm")]
        [Description("XBM (X BitMap) image")]
        public static string xbm = "xbm";

 
        ///<summary>
        /// X-face image
        ///</summary>
        [Display(Name = "xface")]
        [Description("X-face image")]
        public static string xface = "xface";

 
        ///<summary>
        /// XWD (X Window Dump) image
        ///</summary>
        [Display(Name = "xwd")]
        [Description("XWD (X Window Dump) image")]
        public static string xwd = "xwd";

 
        ///<summary>
        /// Uncompressed YUV 4:1:1 12-bit
        ///</summary>
        [Display(Name = "y41p")]
        [Description("Uncompressed YUV 4:1:1 12-bit")]
        public static string y41p = "y41p";

 
        ///<summary>
        /// Uncompressed packed 4:2:0
        ///</summary>
        [Display(Name = "yuv4")]
        [Description("Uncompressed packed 4:2:0")]
        public static string yuv4 = "yuv4";

 
        ///<summary>
        /// LCL (LossLess Codec Library) ZLIB
        ///</summary>
        [Display(Name = "zlib")]
        [Description("LCL (LossLess Codec Library) ZLIB")]
        public static string zlib = "zlib";

 
        ///<summary>
        /// Zip Motion Blocks Video
        ///</summary>
        [Display(Name = "zmbv")]
        [Description("Zip Motion Blocks Video")]
        public static string zmbv = "zmbv";


        public static IDictionary<string,string> GetDisplayValues()
        {
            return ReflectionHelpers.GetDisplayValues<string>(typeof(VideoEncoders));
        }

}

    public static class AudioEncoders {

 
        ///<summary>
        ///AAC (Advanced Audio Coding) (decoders: aac aac_fixed )
        ///</summary>
        [Display(Name = "aac")]
        [Description("AAC (Advanced Audio Coding) (decoders: aac aac_fixed )")]
        public static string aac = "aac";

 
        ///<summary>
        ///ATSC A/52A (AC-3) (decoders: ac3 ac3_fixed ) (encoders: ac3 ac3_fixed )
        ///</summary>
        [Display(Name = "ac3")]
        [Description("ATSC A/52A (AC-3) (decoders: ac3 ac3_fixed ) (encoders: ac3 ac3_fixed )")]
        public static string ac3 = "ac3";

 
        ///<summary>
        ///SEGA CRI ADX ADPCM
        ///</summary>
        [Display(Name = "adpcm adx")]
        [Description("SEGA CRI ADX ADPCM")]
        public static string adpcm_adx = "adpcm_adx";

 
        ///<summary>
        ///G.722 ADPCM (decoders: g722 ) (encoders: g722 )
        ///</summary>
        [Display(Name = "adpcm g722")]
        [Description("G.722 ADPCM (decoders: g722 ) (encoders: g722 )")]
        public static string adpcm_g722 = "adpcm_g722";

 
        ///<summary>
        ///G.726 ADPCM (decoders: g726 ) (encoders: g726 )
        ///</summary>
        [Display(Name = "adpcm g726")]
        [Description("G.726 ADPCM (decoders: g726 ) (encoders: g726 )")]
        public static string adpcm_g726 = "adpcm_g726";

 
        ///<summary>
        ///G.726 ADPCM little-endian (decoders: g726le ) (encoders: g726le )
        ///</summary>
        [Display(Name = "adpcm g726le")]
        [Description("G.726 ADPCM little-endian (decoders: g726le ) (encoders: g726le )")]
        public static string adpcm_g726le = "adpcm_g726le";

 
        ///<summary>
        ///ADPCM IMA QuickTime
        ///</summary>
        [Display(Name = "adpcm ima qt")]
        [Description("ADPCM IMA QuickTime")]
        public static string adpcm_ima_qt = "adpcm_ima_qt";

 
        ///<summary>
        ///ADPCM IMA WAV
        ///</summary>
        [Display(Name = "adpcm ima wav")]
        [Description("ADPCM IMA WAV")]
        public static string adpcm_ima_wav = "adpcm_ima_wav";

 
        ///<summary>
        ///ADPCM Microsoft
        ///</summary>
        [Display(Name = "adpcm ms")]
        [Description("ADPCM Microsoft")]
        public static string adpcm_ms = "adpcm_ms";

 
        ///<summary>
        ///ADPCM Shockwave Flash
        ///</summary>
        [Display(Name = "adpcm swf")]
        [Description("ADPCM Shockwave Flash")]
        public static string adpcm_swf = "adpcm_swf";

 
        ///<summary>
        ///ADPCM Yamaha
        ///</summary>
        [Display(Name = "adpcm yamaha")]
        [Description("ADPCM Yamaha")]
        public static string adpcm_yamaha = "adpcm_yamaha";

 
        ///<summary>
        ///ALAC (Apple Lossless Audio Codec)
        ///</summary>
        [Display(Name = "alac")]
        [Description("ALAC (Apple Lossless Audio Codec)")]
        public static string alac = "alac";

 
        ///<summary>
        ///AMR-NB (Adaptive Multi-Rate NarrowBand) (decoders: amrnb libopencore_amrnb ) (encoders: libopencore_amrnb )
        ///</summary>
        [Display(Name = "amr nb")]
        [Description("AMR-NB (Adaptive Multi-Rate NarrowBand) (decoders: amrnb libopencore_amrnb ) (encoders: libopencore_amrnb )")]
        public static string amr_nb = "amr_nb";

 
        ///<summary>
        ///AMR-WB (Adaptive Multi-Rate WideBand) (decoders: amrwb libopencore_amrwb ) (encoders: libvo_amrwbenc )
        ///</summary>
        [Display(Name = "amr wb")]
        [Description("AMR-WB (Adaptive Multi-Rate WideBand) (decoders: amrwb libopencore_amrwb ) (encoders: libvo_amrwbenc )")]
        public static string amr_wb = "amr_wb";

 
        ///<summary>
        ///aptX (Audio Processing Technology for Bluetooth)
        ///</summary>
        [Display(Name = "aptx")]
        [Description("aptX (Audio Processing Technology for Bluetooth)")]
        public static string aptx = "aptx";

 
        ///<summary>
        ///aptX HD (Audio Processing Technology for Bluetooth)
        ///</summary>
        [Display(Name = "aptx hd")]
        [Description("aptX HD (Audio Processing Technology for Bluetooth)")]
        public static string aptx_hd = "aptx_hd";

 
        ///<summary>
        ///RFC 3389 Comfort Noise
        ///</summary>
        [Display(Name = "comfortnoise")]
        [Description("RFC 3389 Comfort Noise")]
        public static string comfortnoise = "comfortnoise";

 
        ///<summary>
        ///DCA (DTS Coherent Acoustics) (decoders: dca ) (encoders: dca )
        ///</summary>
        [Display(Name = "dts")]
        [Description("DCA (DTS Coherent Acoustics) (decoders: dca ) (encoders: dca )")]
        public static string dts = "dts";

 
        ///<summary>
        ///ATSC A/52B (AC-3, E-AC-3)
        ///</summary>
        [Display(Name = "eac3")]
        [Description("ATSC A/52B (AC-3, E-AC-3)")]
        public static string eac3 = "eac3";

 
        ///<summary>
        ///FLAC (Free Lossless Audio Codec)
        ///</summary>
        [Display(Name = "flac")]
        [Description("FLAC (Free Lossless Audio Codec)")]
        public static string flac = "flac";

 
        ///<summary>
        ///G.723.1
        ///</summary>
        [Display(Name = "g723 1")]
        [Description("G.723.1")]
        public static string g723_1 = "g723_1";

 
        ///<summary>
        ///MLP (Meridian Lossless Packing)
        ///</summary>
        [Display(Name = "mlp")]
        [Description("MLP (Meridian Lossless Packing)")]
        public static string mlp = "mlp";

 
        ///<summary>
        ///MP2 (MPEG audio layer 2) (decoders: mp2 mp2float ) (encoders: mp2 mp2fixed libtwolame )
        ///</summary>
        [Display(Name = "mp2")]
        [Description("MP2 (MPEG audio layer 2) (decoders: mp2 mp2float ) (encoders: mp2 mp2fixed libtwolame )")]
        public static string mp2 = "mp2";

 
        ///<summary>
        ///MP3 (MPEG audio layer 3) (decoders: mp3float mp3 ) (encoders: libmp3lame libshine )
        ///</summary>
        [Display(Name = "mp3")]
        [Description("MP3 (MPEG audio layer 3) (decoders: mp3float mp3 ) (encoders: libmp3lame libshine )")]
        public static string mp3 = "mp3";

 
        ///<summary>
        ///Nellymoser Asao
        ///</summary>
        [Display(Name = "nellymoser")]
        [Description("Nellymoser Asao")]
        public static string nellymoser = "nellymoser";

 
        ///<summary>
        ///Opus (Opus Interactive Audio Codec) (decoders: opus libopus ) (encoders: opus libopus )
        ///</summary>
        [Display(Name = "opus")]
        [Description("Opus (Opus Interactive Audio Codec) (decoders: opus libopus ) (encoders: opus libopus )")]
        public static string opus = "opus";

 
        ///<summary>
        ///PCM A-law / G.711 A-law
        ///</summary>
        [Display(Name = "pcm alaw")]
        [Description("PCM A-law / G.711 A-law")]
        public static string pcm_alaw = "pcm_alaw";

 
        ///<summary>
        ///PCM signed 20|24-bit big-endian
        ///</summary>
        [Display(Name = "pcm dvd")]
        [Description("PCM signed 20|24-bit big-endian")]
        public static string pcm_dvd = "pcm_dvd";

 
        ///<summary>
        ///PCM 32-bit floating point big-endian
        ///</summary>
        [Display(Name = "pcm f32be")]
        [Description("PCM 32-bit floating point big-endian")]
        public static string pcm_f32be = "pcm_f32be";

 
        ///<summary>
        ///PCM 32-bit floating point little-endian
        ///</summary>
        [Display(Name = "pcm f32le")]
        [Description("PCM 32-bit floating point little-endian")]
        public static string pcm_f32le = "pcm_f32le";

 
        ///<summary>
        ///PCM 64-bit floating point big-endian
        ///</summary>
        [Display(Name = "pcm f64be")]
        [Description("PCM 64-bit floating point big-endian")]
        public static string pcm_f64be = "pcm_f64be";

 
        ///<summary>
        ///PCM 64-bit floating point little-endian
        ///</summary>
        [Display(Name = "pcm f64le")]
        [Description("PCM 64-bit floating point little-endian")]
        public static string pcm_f64le = "pcm_f64le";

 
        ///<summary>
        ///PCM mu-law / G.711 mu-law
        ///</summary>
        [Display(Name = "pcm mulaw")]
        [Description("PCM mu-law / G.711 mu-law")]
        public static string pcm_mulaw = "pcm_mulaw";

 
        ///<summary>
        ///PCM signed 16-bit big-endian
        ///</summary>
        [Display(Name = "pcm s16be")]
        [Description("PCM signed 16-bit big-endian")]
        public static string pcm_s16be = "pcm_s16be";

 
        ///<summary>
        ///PCM signed 16-bit big-endian planar
        ///</summary>
        [Display(Name = "pcm s16be planar")]
        [Description("PCM signed 16-bit big-endian planar")]
        public static string pcm_s16be_planar = "pcm_s16be_planar";

 
        ///<summary>
        ///PCM signed 16-bit little-endian
        ///</summary>
        [Display(Name = "pcm s16le")]
        [Description("PCM signed 16-bit little-endian")]
        public static string pcm_s16le = "pcm_s16le";

 
        ///<summary>
        ///PCM signed 16-bit little-endian planar
        ///</summary>
        [Display(Name = "pcm s16le planar")]
        [Description("PCM signed 16-bit little-endian planar")]
        public static string pcm_s16le_planar = "pcm_s16le_planar";

 
        ///<summary>
        ///PCM signed 24-bit big-endian
        ///</summary>
        [Display(Name = "pcm s24be")]
        [Description("PCM signed 24-bit big-endian")]
        public static string pcm_s24be = "pcm_s24be";

 
        ///<summary>
        ///PCM D-Cinema audio signed 24-bit
        ///</summary>
        [Display(Name = "pcm s24daud")]
        [Description("PCM D-Cinema audio signed 24-bit")]
        public static string pcm_s24daud = "pcm_s24daud";

 
        ///<summary>
        ///PCM signed 24-bit little-endian
        ///</summary>
        [Display(Name = "pcm s24le")]
        [Description("PCM signed 24-bit little-endian")]
        public static string pcm_s24le = "pcm_s24le";

 
        ///<summary>
        ///PCM signed 24-bit little-endian planar
        ///</summary>
        [Display(Name = "pcm s24le planar")]
        [Description("PCM signed 24-bit little-endian planar")]
        public static string pcm_s24le_planar = "pcm_s24le_planar";

 
        ///<summary>
        ///PCM signed 32-bit big-endian
        ///</summary>
        [Display(Name = "pcm s32be")]
        [Description("PCM signed 32-bit big-endian")]
        public static string pcm_s32be = "pcm_s32be";

 
        ///<summary>
        ///PCM signed 32-bit little-endian
        ///</summary>
        [Display(Name = "pcm s32le")]
        [Description("PCM signed 32-bit little-endian")]
        public static string pcm_s32le = "pcm_s32le";

 
        ///<summary>
        ///PCM signed 32-bit little-endian planar
        ///</summary>
        [Display(Name = "pcm s32le planar")]
        [Description("PCM signed 32-bit little-endian planar")]
        public static string pcm_s32le_planar = "pcm_s32le_planar";

 
        ///<summary>
        ///PCM signed 64-bit big-endian
        ///</summary>
        [Display(Name = "pcm s64be")]
        [Description("PCM signed 64-bit big-endian")]
        public static string pcm_s64be = "pcm_s64be";

 
        ///<summary>
        ///PCM signed 64-bit little-endian
        ///</summary>
        [Display(Name = "pcm s64le")]
        [Description("PCM signed 64-bit little-endian")]
        public static string pcm_s64le = "pcm_s64le";

 
        ///<summary>
        ///PCM signed 8-bit
        ///</summary>
        [Display(Name = "pcm s8")]
        [Description("PCM signed 8-bit")]
        public static string pcm_s8 = "pcm_s8";

 
        ///<summary>
        ///PCM signed 8-bit planar
        ///</summary>
        [Display(Name = "pcm s8 planar")]
        [Description("PCM signed 8-bit planar")]
        public static string pcm_s8_planar = "pcm_s8_planar";

 
        ///<summary>
        ///PCM unsigned 16-bit big-endian
        ///</summary>
        [Display(Name = "pcm u16be")]
        [Description("PCM unsigned 16-bit big-endian")]
        public static string pcm_u16be = "pcm_u16be";

 
        ///<summary>
        ///PCM unsigned 16-bit little-endian
        ///</summary>
        [Display(Name = "pcm u16le")]
        [Description("PCM unsigned 16-bit little-endian")]
        public static string pcm_u16le = "pcm_u16le";

 
        ///<summary>
        ///PCM unsigned 24-bit big-endian
        ///</summary>
        [Display(Name = "pcm u24be")]
        [Description("PCM unsigned 24-bit big-endian")]
        public static string pcm_u24be = "pcm_u24be";

 
        ///<summary>
        ///PCM unsigned 24-bit little-endian
        ///</summary>
        [Display(Name = "pcm u24le")]
        [Description("PCM unsigned 24-bit little-endian")]
        public static string pcm_u24le = "pcm_u24le";

 
        ///<summary>
        ///PCM unsigned 32-bit big-endian
        ///</summary>
        [Display(Name = "pcm u32be")]
        [Description("PCM unsigned 32-bit big-endian")]
        public static string pcm_u32be = "pcm_u32be";

 
        ///<summary>
        ///PCM unsigned 32-bit little-endian
        ///</summary>
        [Display(Name = "pcm u32le")]
        [Description("PCM unsigned 32-bit little-endian")]
        public static string pcm_u32le = "pcm_u32le";

 
        ///<summary>
        ///PCM unsigned 8-bit
        ///</summary>
        [Display(Name = "pcm u8")]
        [Description("PCM unsigned 8-bit")]
        public static string pcm_u8 = "pcm_u8";

 
        ///<summary>
        ///PCM Archimedes VIDC
        ///</summary>
        [Display(Name = "pcm vidc")]
        [Description("PCM Archimedes VIDC")]
        public static string pcm_vidc = "pcm_vidc";

 
        ///<summary>
        ///RealAudio 1.0 (14.4K) (decoders: real_144 ) (encoders: real_144 )
        ///</summary>
        [Display(Name = "ra 144")]
        [Description("RealAudio 1.0 (14.4K) (decoders: real_144 ) (encoders: real_144 )")]
        public static string ra_144 = "ra_144";

 
        ///<summary>
        ///DPCM id RoQ
        ///</summary>
        [Display(Name = "roq dpcm")]
        [Description("DPCM id RoQ")]
        public static string roq_dpcm = "roq_dpcm";

 
        ///<summary>
        ///SMPTE 302M
        ///</summary>
        [Display(Name = "s302m")]
        [Description("SMPTE 302M")]
        public static string s302m = "s302m";

 
        ///<summary>
        ///SBC (low-complexity subband codec)
        ///</summary>
        [Display(Name = "sbc")]
        [Description("SBC (low-complexity subband codec)")]
        public static string sbc = "sbc";

 
        ///<summary>
        ///Sonic
        ///</summary>
        [Display(Name = "sonic")]
        [Description("Sonic")]
        public static string sonic = "sonic";

 
        ///<summary>
        ///Sonic lossless
        ///</summary>
        [Display(Name = "sonicls")]
        [Description("Sonic lossless")]
        public static string sonicls = "sonicls";

 
        ///<summary>
        ///Speex (decoders: libspeex ) (encoders: libspeex )
        ///</summary>
        [Display(Name = "speex")]
        [Description("Speex (decoders: libspeex ) (encoders: libspeex )")]
        public static string speex = "speex";

 
        ///<summary>
        ///TrueHD
        ///</summary>
        [Display(Name = "truehd")]
        [Description("TrueHD")]
        public static string truehd = "truehd";

 
        ///<summary>
        ///TTA (True Audio)
        ///</summary>
        [Display(Name = "tta")]
        [Description("TTA (True Audio)")]
        public static string tta = "tta";

 
        ///<summary>
        ///Vorbis (decoders: vorbis libvorbis ) (encoders: vorbis libvorbis )
        ///</summary>
        [Display(Name = "vorbis")]
        [Description("Vorbis (decoders: vorbis libvorbis ) (encoders: vorbis libvorbis )")]
        public static string vorbis = "vorbis";

 
        ///<summary>
        ///WavPack (encoders: wavpack libwavpack )
        ///</summary>
        [Display(Name = "wavpack")]
        [Description("WavPack (encoders: wavpack libwavpack )")]
        public static string wavpack = "wavpack";

 
        ///<summary>
        ///Windows Media Audio 1
        ///</summary>
        [Display(Name = "wmav1")]
        [Description("Windows Media Audio 1")]
        public static string wmav1 = "wmav1";

 
        ///<summary>
        ///Windows Media Audio 2
        ///</summary>
        [Display(Name = "wmav2")]
        [Description("Windows Media Audio 2")]
        public static string wmav2 = "wmav2";


        public static IDictionary<string,string> GetDisplayValues()
        {
            return ReflectionHelpers.GetDisplayValues<string>(typeof(AudioEncoders));
        }

}


    public static class SubtitleEncoders {

 
        ///<summary>
        ///ASS (Advanced SSA) subtitle (decoders: ssa ass ) (encoders: ssa ass )
        ///</summary>
        [Display(Name = "ass")]
        [Description("ASS (Advanced SSA) subtitle (decoders: ssa ass ) (encoders: ssa ass )")]
        public static string ass = "ass";

 
        ///<summary>
        ///DVB subtitles (decoders: dvbsub ) (encoders: dvbsub )
        ///</summary>
        [Display(Name = "dvb subtitle")]
        [Description("DVB subtitles (decoders: dvbsub ) (encoders: dvbsub )")]
        public static string dvb_subtitle = "dvb_subtitle";

 
        ///<summary>
        ///DVD subtitles (decoders: dvdsub ) (encoders: dvdsub )
        ///</summary>
        [Display(Name = "dvd subtitle")]
        [Description("DVD subtitles (decoders: dvdsub ) (encoders: dvdsub )")]
        public static string dvd_subtitle = "dvd_subtitle";

 
        ///<summary>
        ///MOV text
        ///</summary>
        [Display(Name = "mov text")]
        [Description("MOV text")]
        public static string mov_text = "mov_text";

 
        ///<summary>
        ///SubRip subtitle (decoders: srt subrip ) (encoders: srt subrip )
        ///</summary>
        [Display(Name = "subrip")]
        [Description("SubRip subtitle (decoders: srt subrip ) (encoders: srt subrip )")]
        public static string subrip = "subrip";

 
        ///<summary>
        ///raw UTF-8 text
        ///</summary>
        [Display(Name = "text")]
        [Description("raw UTF-8 text")]
        public static string text = "text";

 
        ///<summary>
        ///WebVTT subtitle
        ///</summary>
        [Display(Name = "webvtt")]
        [Description("WebVTT subtitle")]
        public static string webvtt = "webvtt";

 
        ///<summary>
        ///XSUB
        ///</summary>
        [Display(Name = "xsub")]
        [Description("XSUB")]
        public static string xsub = "xsub";


        public static IDictionary<string,string> GetDisplayValues()
        {
            return ReflectionHelpers.GetDisplayValues<string>(typeof(SubtitleEncoders));
        }

    }
}

