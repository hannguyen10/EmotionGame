
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class MergeDebevec
    /// <summary>
    ///  The resulting HDR image is calculated as weighted average of the exposures considering exposure
    ///  values and camera response.
    /// </summary>
    /// <remarks>
    ///  For more information see @cite DM97 .
    /// </remarks>
    public class MergeDebevec : MergeExposures
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
                        photo_MergeDebevec_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MergeDebevec(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MergeDebevec __fromPtr__(IntPtr addr) { return new MergeDebevec(addr); }

        //
        // C++:  void cv::MergeDebevec::process(vector_Mat src, Mat& dst, Mat times, Mat response)
        //

        public override void process(List<Mat> src, Mat dst, Mat times, Mat response)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (times != null) times.ThrowIfDisposed();
            if (response != null) response.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            photo_MergeDebevec_process_10(nativeObj, src_mat.nativeObj, dst.nativeObj, times.nativeObj, response.nativeObj);


        }


        //
        // C++:  void cv::MergeDebevec::process(vector_Mat src, Mat& dst, Mat times)
        //

        public void process(List<Mat> src, Mat dst, Mat times)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (times != null) times.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            photo_MergeDebevec_process_11(nativeObj, src_mat.nativeObj, dst.nativeObj, times.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::MergeDebevec::process(vector_Mat src, Mat& dst, Mat times, Mat response)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeDebevec_process_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj, IntPtr times_nativeObj, IntPtr response_nativeObj);

        // C++:  void cv::MergeDebevec::process(vector_Mat src, Mat& dst, Mat times)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeDebevec_process_11(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj, IntPtr times_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_MergeDebevec_delete(IntPtr nativeObj);

    }
}
