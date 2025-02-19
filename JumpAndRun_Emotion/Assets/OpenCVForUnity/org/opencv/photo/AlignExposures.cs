
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class AlignExposures
    /// <summary>
    ///  The base class for algorithms that align images of the same scene with different exposures
    /// </summary>
    public class AlignExposures : Algorithm
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        photo_AlignExposures_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AlignExposures(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AlignExposures __fromPtr__(IntPtr addr) { return new AlignExposures(addr); }

        //
        // C++:  void cv::AlignExposures::process(vector_Mat src, vector_Mat dst, Mat times, Mat response)
        //

        /// <summary>
        ///  Aligns images
        /// </summary>
        /// <param name="src">
        /// vector of input images
        /// </param>
        /// <param name="dst">
        /// vector of aligned images
        /// </param>
        /// <param name="times">
        /// vector of exposure time values for each image
        /// </param>
        /// <param name="response">
        /// 256x1 matrix with inverse camera response function for each pixel value, it should
        ///      have the same number of channels as images.
        /// </param>
        public virtual void process(List<Mat> src, List<Mat> dst, Mat times, Mat response)
        {
            ThrowIfDisposed();
            if (times != null) times.ThrowIfDisposed();
            if (response != null) response.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            Mat dst_mat = Converters.vector_Mat_to_Mat(dst);
            photo_AlignExposures_process_10(nativeObj, src_mat.nativeObj, dst_mat.nativeObj, times.nativeObj, response.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::AlignExposures::process(vector_Mat src, vector_Mat dst, Mat times, Mat response)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignExposures_process_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr times_nativeObj, IntPtr response_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_AlignExposures_delete(IntPtr nativeObj);

    }
}
