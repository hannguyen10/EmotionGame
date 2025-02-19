#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class TextDetectionModel_DB
    /// <summary>
    ///  This class represents high-level API for text detection DL networks compatible with DB model.
    /// </summary>
    /// <remarks>
    ///     Related publications: @cite liao2020real
    ///     Paper: https://arxiv.org/abs/1911.08947
    ///     For more information about the hyper-parameters setting, please refer to https://github.com/MhLiao/DB
    ///    
    ///     Configurable parameters:
    ///     - (float) binaryThreshold - The threshold of the binary map. It is usually set to 0.3.
    ///     - (float) polygonThreshold - The threshold of text polygons. It is usually set to 0.5, 0.6, and 0.7. Default is 0.5f
    ///     - (double) unclipRatio - The unclip ratio of the detected text region, which determines the output size. It is usually set to 2.0.
    ///     - (int) maxCandidates - The max number of the output results.
    /// </remarks>
    public class TextDetectionModel_DB : TextDetectionModel
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
                        dnn_TextDetectionModel_1DB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TextDetectionModel_DB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TextDetectionModel_DB __fromPtr__(IntPtr addr) { return new TextDetectionModel_DB(addr); }

        //
        // C++:   cv::dnn::TextDetectionModel_DB::TextDetectionModel_DB(Net network)
        //

        /// <summary>
        ///  Create text detection algorithm from deep learning network.
        /// </summary>
        public TextDetectionModel_DB(Net network) :
                    base(DisposableObject.ThrowIfNullIntPtr(dnn_TextDetectionModel_1DB_TextDetectionModel_1DB_10(network.nativeObj)))
        {



        }


        //
        // C++:   cv::dnn::TextDetectionModel_DB::TextDetectionModel_DB(string model, string config = "")
        //

        /// <summary>
        ///  Create text detection model from network represented in one of the supported formats.
        ///         An order of @p model and @p config arguments does not matter.
        /// </summary>
        public TextDetectionModel_DB(string model, string config) :
                    base(DisposableObject.ThrowIfNullIntPtr(dnn_TextDetectionModel_1DB_TextDetectionModel_1DB_11(model, config)))
        {



        }

        /// <summary>
        ///  Create text detection model from network represented in one of the supported formats.
        ///         An order of @p model and @p config arguments does not matter.
        /// </summary>
        public TextDetectionModel_DB(string model) :
                    base(DisposableObject.ThrowIfNullIntPtr(dnn_TextDetectionModel_1DB_TextDetectionModel_1DB_12(model)))
        {



        }


        //
        // C++:  TextDetectionModel_DB cv::dnn::TextDetectionModel_DB::setBinaryThreshold(float binaryThreshold)
        //

        public TextDetectionModel_DB setBinaryThreshold(float binaryThreshold)
        {
            ThrowIfDisposed();

            return new TextDetectionModel_DB(DisposableObject.ThrowIfNullIntPtr(dnn_TextDetectionModel_1DB_setBinaryThreshold_10(nativeObj, binaryThreshold)));


        }


        //
        // C++:  float cv::dnn::TextDetectionModel_DB::getBinaryThreshold()
        //

        public float getBinaryThreshold()
        {
            ThrowIfDisposed();

            return dnn_TextDetectionModel_1DB_getBinaryThreshold_10(nativeObj);


        }


        //
        // C++:  TextDetectionModel_DB cv::dnn::TextDetectionModel_DB::setPolygonThreshold(float polygonThreshold)
        //

        public TextDetectionModel_DB setPolygonThreshold(float polygonThreshold)
        {
            ThrowIfDisposed();

            return new TextDetectionModel_DB(DisposableObject.ThrowIfNullIntPtr(dnn_TextDetectionModel_1DB_setPolygonThreshold_10(nativeObj, polygonThreshold)));


        }


        //
        // C++:  float cv::dnn::TextDetectionModel_DB::getPolygonThreshold()
        //

        public float getPolygonThreshold()
        {
            ThrowIfDisposed();

            return dnn_TextDetectionModel_1DB_getPolygonThreshold_10(nativeObj);


        }


        //
        // C++:  TextDetectionModel_DB cv::dnn::TextDetectionModel_DB::setUnclipRatio(double unclipRatio)
        //

        public TextDetectionModel_DB setUnclipRatio(double unclipRatio)
        {
            ThrowIfDisposed();

            return new TextDetectionModel_DB(DisposableObject.ThrowIfNullIntPtr(dnn_TextDetectionModel_1DB_setUnclipRatio_10(nativeObj, unclipRatio)));


        }


        //
        // C++:  double cv::dnn::TextDetectionModel_DB::getUnclipRatio()
        //

        public double getUnclipRatio()
        {
            ThrowIfDisposed();

            return dnn_TextDetectionModel_1DB_getUnclipRatio_10(nativeObj);


        }


        //
        // C++:  TextDetectionModel_DB cv::dnn::TextDetectionModel_DB::setMaxCandidates(int maxCandidates)
        //

        public TextDetectionModel_DB setMaxCandidates(int maxCandidates)
        {
            ThrowIfDisposed();

            return new TextDetectionModel_DB(DisposableObject.ThrowIfNullIntPtr(dnn_TextDetectionModel_1DB_setMaxCandidates_10(nativeObj, maxCandidates)));


        }


        //
        // C++:  int cv::dnn::TextDetectionModel_DB::getMaxCandidates()
        //

        public int getMaxCandidates()
        {
            ThrowIfDisposed();

            return dnn_TextDetectionModel_1DB_getMaxCandidates_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::TextDetectionModel_DB::TextDetectionModel_DB(Net network)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextDetectionModel_1DB_TextDetectionModel_1DB_10(IntPtr network_nativeObj);

        // C++:   cv::dnn::TextDetectionModel_DB::TextDetectionModel_DB(string model, string config = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextDetectionModel_1DB_TextDetectionModel_1DB_11(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextDetectionModel_1DB_TextDetectionModel_1DB_12(string model);

        // C++:  TextDetectionModel_DB cv::dnn::TextDetectionModel_DB::setBinaryThreshold(float binaryThreshold)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextDetectionModel_1DB_setBinaryThreshold_10(IntPtr nativeObj, float binaryThreshold);

        // C++:  float cv::dnn::TextDetectionModel_DB::getBinaryThreshold()
        [DllImport(LIBNAME)]
        private static extern float dnn_TextDetectionModel_1DB_getBinaryThreshold_10(IntPtr nativeObj);

        // C++:  TextDetectionModel_DB cv::dnn::TextDetectionModel_DB::setPolygonThreshold(float polygonThreshold)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextDetectionModel_1DB_setPolygonThreshold_10(IntPtr nativeObj, float polygonThreshold);

        // C++:  float cv::dnn::TextDetectionModel_DB::getPolygonThreshold()
        [DllImport(LIBNAME)]
        private static extern float dnn_TextDetectionModel_1DB_getPolygonThreshold_10(IntPtr nativeObj);

        // C++:  TextDetectionModel_DB cv::dnn::TextDetectionModel_DB::setUnclipRatio(double unclipRatio)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextDetectionModel_1DB_setUnclipRatio_10(IntPtr nativeObj, double unclipRatio);

        // C++:  double cv::dnn::TextDetectionModel_DB::getUnclipRatio()
        [DllImport(LIBNAME)]
        private static extern double dnn_TextDetectionModel_1DB_getUnclipRatio_10(IntPtr nativeObj);

        // C++:  TextDetectionModel_DB cv::dnn::TextDetectionModel_DB::setMaxCandidates(int maxCandidates)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextDetectionModel_1DB_setMaxCandidates_10(IntPtr nativeObj, int maxCandidates);

        // C++:  int cv::dnn::TextDetectionModel_DB::getMaxCandidates()
        [DllImport(LIBNAME)]
        private static extern int dnn_TextDetectionModel_1DB_getMaxCandidates_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_TextDetectionModel_1DB_delete(IntPtr nativeObj);

    }
}

#endif