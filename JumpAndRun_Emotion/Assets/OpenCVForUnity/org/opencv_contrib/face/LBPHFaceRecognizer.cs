
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class LBPHFaceRecognizer


    public class LBPHFaceRecognizer : FaceRecognizer
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
                        face_LBPHFaceRecognizer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal LBPHFaceRecognizer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new LBPHFaceRecognizer __fromPtr__(IntPtr addr) { return new LBPHFaceRecognizer(addr); }

        //
        // C++:  int cv::face::LBPHFaceRecognizer::getGridX()
        //

        /// <remarks>
        ///  @see setGridX
        /// </remarks>
        public int getGridX()
        {
            ThrowIfDisposed();

            return face_LBPHFaceRecognizer_getGridX_10(nativeObj);


        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setGridX(int val)
        //

        /// <remarks>
        ///  @copybrief getGridX @see getGridX
        /// </remarks>
        public void setGridX(int val)
        {
            ThrowIfDisposed();

            face_LBPHFaceRecognizer_setGridX_10(nativeObj, val);


        }


        //
        // C++:  int cv::face::LBPHFaceRecognizer::getGridY()
        //

        /// <remarks>
        ///  @see setGridY
        /// </remarks>
        public int getGridY()
        {
            ThrowIfDisposed();

            return face_LBPHFaceRecognizer_getGridY_10(nativeObj);


        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setGridY(int val)
        //

        /// <remarks>
        ///  @copybrief getGridY @see getGridY
        /// </remarks>
        public void setGridY(int val)
        {
            ThrowIfDisposed();

            face_LBPHFaceRecognizer_setGridY_10(nativeObj, val);


        }


        //
        // C++:  int cv::face::LBPHFaceRecognizer::getRadius()
        //

        /// <remarks>
        ///  @see setRadius
        /// </remarks>
        public int getRadius()
        {
            ThrowIfDisposed();

            return face_LBPHFaceRecognizer_getRadius_10(nativeObj);


        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setRadius(int val)
        //

        /// <remarks>
        ///  @copybrief getRadius @see getRadius
        /// </remarks>
        public void setRadius(int val)
        {
            ThrowIfDisposed();

            face_LBPHFaceRecognizer_setRadius_10(nativeObj, val);


        }


        //
        // C++:  int cv::face::LBPHFaceRecognizer::getNeighbors()
        //

        /// <remarks>
        ///  @see setNeighbors
        /// </remarks>
        public int getNeighbors()
        {
            ThrowIfDisposed();

            return face_LBPHFaceRecognizer_getNeighbors_10(nativeObj);


        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setNeighbors(int val)
        //

        /// <remarks>
        ///  @copybrief getNeighbors @see getNeighbors
        /// </remarks>
        public void setNeighbors(int val)
        {
            ThrowIfDisposed();

            face_LBPHFaceRecognizer_setNeighbors_10(nativeObj, val);


        }


        //
        // C++:  double cv::face::LBPHFaceRecognizer::getThreshold()
        //

        /// <remarks>
        ///  @see setThreshold
        /// </remarks>
        public double getThreshold()
        {
            ThrowIfDisposed();

            return face_LBPHFaceRecognizer_getThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setThreshold(double val)
        //

        /// <remarks>
        ///  @copybrief getThreshold @see getThreshold
        /// </remarks>
        public void setThreshold(double val)
        {
            ThrowIfDisposed();

            face_LBPHFaceRecognizer_setThreshold_10(nativeObj, val);


        }


        //
        // C++:  vector_Mat cv::face::LBPHFaceRecognizer::getHistograms()
        //

        public List<Mat> getHistograms()
        {
            ThrowIfDisposed();
            List<Mat> retVal = new List<Mat>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(face_LBPHFaceRecognizer_getHistograms_10(nativeObj)));
            Converters.Mat_to_vector_Mat(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  Mat cv::face::LBPHFaceRecognizer::getLabels()
        //

        public Mat getLabels()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(face_LBPHFaceRecognizer_getLabels_10(nativeObj)));


        }


        //
        // C++: static Ptr_LBPHFaceRecognizer cv::face::LBPHFaceRecognizer::create(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
        //

        /// <param name="radius">
        /// The radius used for building the Circular Local Binary Pattern. The greater the
        ///      radius, the smoother the image but more spatial information you can get.
        /// </param>
        /// <param name="neighbors">
        /// The number of sample points to build a Circular Local Binary Pattern from. An
        ///      appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
        ///      the higher the computational cost.
        /// </param>
        /// <param name="grid_x">
        /// The number of cells in the horizontal direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="grid_y">
        /// The number of cells in the vertical direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="threshold">
        /// The threshold applied in the prediction. If the distance to the nearest neighbor
        ///      is larger than the threshold, this method returns -1.
        /// </param>
        /// <remarks>
        ///      ### Notes:
        ///  
        ///      -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
        ///          grayscale images, use cvtColor to convert between the color spaces.
        ///      -   This model supports updating.
        ///  
        ///      ### Model internal data:
        ///  
        ///      -   radius see LBPHFaceRecognizer::create.
        ///      -   neighbors see LBPHFaceRecognizer::create.
        ///      -   grid_x see LLBPHFaceRecognizer::create.
        ///      -   grid_y see LBPHFaceRecognizer::create.
        ///      -   threshold see LBPHFaceRecognizer::create.
        ///      -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
        ///          none was given).
        ///      -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
        /// </remarks>
        public static LBPHFaceRecognizer create(int radius, int neighbors, int grid_x, int grid_y, double threshold)
        {


            return LBPHFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_LBPHFaceRecognizer_create_10(radius, neighbors, grid_x, grid_y, threshold)));


        }

        /// <param name="radius">
        /// The radius used for building the Circular Local Binary Pattern. The greater the
        ///      radius, the smoother the image but more spatial information you can get.
        /// </param>
        /// <param name="neighbors">
        /// The number of sample points to build a Circular Local Binary Pattern from. An
        ///      appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
        ///      the higher the computational cost.
        /// </param>
        /// <param name="grid_x">
        /// The number of cells in the horizontal direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="grid_y">
        /// The number of cells in the vertical direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="threshold">
        /// The threshold applied in the prediction. If the distance to the nearest neighbor
        ///      is larger than the threshold, this method returns -1.
        /// </param>
        /// <remarks>
        ///      ### Notes:
        ///  
        ///      -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
        ///          grayscale images, use cvtColor to convert between the color spaces.
        ///      -   This model supports updating.
        ///  
        ///      ### Model internal data:
        ///  
        ///      -   radius see LBPHFaceRecognizer::create.
        ///      -   neighbors see LBPHFaceRecognizer::create.
        ///      -   grid_x see LLBPHFaceRecognizer::create.
        ///      -   grid_y see LBPHFaceRecognizer::create.
        ///      -   threshold see LBPHFaceRecognizer::create.
        ///      -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
        ///          none was given).
        ///      -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
        /// </remarks>
        public static LBPHFaceRecognizer create(int radius, int neighbors, int grid_x, int grid_y)
        {


            return LBPHFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_LBPHFaceRecognizer_create_11(radius, neighbors, grid_x, grid_y)));


        }

        /// <param name="radius">
        /// The radius used for building the Circular Local Binary Pattern. The greater the
        ///      radius, the smoother the image but more spatial information you can get.
        /// </param>
        /// <param name="neighbors">
        /// The number of sample points to build a Circular Local Binary Pattern from. An
        ///      appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
        ///      the higher the computational cost.
        /// </param>
        /// <param name="grid_x">
        /// The number of cells in the horizontal direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="grid_y">
        /// The number of cells in the vertical direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="threshold">
        /// The threshold applied in the prediction. If the distance to the nearest neighbor
        ///      is larger than the threshold, this method returns -1.
        /// </param>
        /// <remarks>
        ///      ### Notes:
        ///  
        ///      -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
        ///          grayscale images, use cvtColor to convert between the color spaces.
        ///      -   This model supports updating.
        ///  
        ///      ### Model internal data:
        ///  
        ///      -   radius see LBPHFaceRecognizer::create.
        ///      -   neighbors see LBPHFaceRecognizer::create.
        ///      -   grid_x see LLBPHFaceRecognizer::create.
        ///      -   grid_y see LBPHFaceRecognizer::create.
        ///      -   threshold see LBPHFaceRecognizer::create.
        ///      -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
        ///          none was given).
        ///      -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
        /// </remarks>
        public static LBPHFaceRecognizer create(int radius, int neighbors, int grid_x)
        {


            return LBPHFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_LBPHFaceRecognizer_create_12(radius, neighbors, grid_x)));


        }

        /// <param name="radius">
        /// The radius used for building the Circular Local Binary Pattern. The greater the
        ///      radius, the smoother the image but more spatial information you can get.
        /// </param>
        /// <param name="neighbors">
        /// The number of sample points to build a Circular Local Binary Pattern from. An
        ///      appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
        ///      the higher the computational cost.
        /// </param>
        /// <param name="grid_x">
        /// The number of cells in the horizontal direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="grid_y">
        /// The number of cells in the vertical direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="threshold">
        /// The threshold applied in the prediction. If the distance to the nearest neighbor
        ///      is larger than the threshold, this method returns -1.
        /// </param>
        /// <remarks>
        ///      ### Notes:
        ///  
        ///      -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
        ///          grayscale images, use cvtColor to convert between the color spaces.
        ///      -   This model supports updating.
        ///  
        ///      ### Model internal data:
        ///  
        ///      -   radius see LBPHFaceRecognizer::create.
        ///      -   neighbors see LBPHFaceRecognizer::create.
        ///      -   grid_x see LLBPHFaceRecognizer::create.
        ///      -   grid_y see LBPHFaceRecognizer::create.
        ///      -   threshold see LBPHFaceRecognizer::create.
        ///      -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
        ///          none was given).
        ///      -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
        /// </remarks>
        public static LBPHFaceRecognizer create(int radius, int neighbors)
        {


            return LBPHFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_LBPHFaceRecognizer_create_13(radius, neighbors)));


        }

        /// <param name="radius">
        /// The radius used for building the Circular Local Binary Pattern. The greater the
        ///      radius, the smoother the image but more spatial information you can get.
        /// </param>
        /// <param name="neighbors">
        /// The number of sample points to build a Circular Local Binary Pattern from. An
        ///      appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
        ///      the higher the computational cost.
        /// </param>
        /// <param name="grid_x">
        /// The number of cells in the horizontal direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="grid_y">
        /// The number of cells in the vertical direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="threshold">
        /// The threshold applied in the prediction. If the distance to the nearest neighbor
        ///      is larger than the threshold, this method returns -1.
        /// </param>
        /// <remarks>
        ///      ### Notes:
        ///  
        ///      -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
        ///          grayscale images, use cvtColor to convert between the color spaces.
        ///      -   This model supports updating.
        ///  
        ///      ### Model internal data:
        ///  
        ///      -   radius see LBPHFaceRecognizer::create.
        ///      -   neighbors see LBPHFaceRecognizer::create.
        ///      -   grid_x see LLBPHFaceRecognizer::create.
        ///      -   grid_y see LBPHFaceRecognizer::create.
        ///      -   threshold see LBPHFaceRecognizer::create.
        ///      -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
        ///          none was given).
        ///      -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
        /// </remarks>
        public static LBPHFaceRecognizer create(int radius)
        {


            return LBPHFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_LBPHFaceRecognizer_create_14(radius)));


        }

        /// <param name="radius">
        /// The radius used for building the Circular Local Binary Pattern. The greater the
        ///      radius, the smoother the image but more spatial information you can get.
        /// </param>
        /// <param name="neighbors">
        /// The number of sample points to build a Circular Local Binary Pattern from. An
        ///      appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
        ///      the higher the computational cost.
        /// </param>
        /// <param name="grid_x">
        /// The number of cells in the horizontal direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="grid_y">
        /// The number of cells in the vertical direction, 8 is a common value used in
        ///      publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
        ///      feature vector.
        /// </param>
        /// <param name="threshold">
        /// The threshold applied in the prediction. If the distance to the nearest neighbor
        ///      is larger than the threshold, this method returns -1.
        /// </param>
        /// <remarks>
        ///      ### Notes:
        ///  
        ///      -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
        ///          grayscale images, use cvtColor to convert between the color spaces.
        ///      -   This model supports updating.
        ///  
        ///      ### Model internal data:
        ///  
        ///      -   radius see LBPHFaceRecognizer::create.
        ///      -   neighbors see LBPHFaceRecognizer::create.
        ///      -   grid_x see LLBPHFaceRecognizer::create.
        ///      -   grid_y see LBPHFaceRecognizer::create.
        ///      -   threshold see LBPHFaceRecognizer::create.
        ///      -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
        ///          none was given).
        ///      -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
        /// </remarks>
        public static LBPHFaceRecognizer create()
        {


            return LBPHFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_LBPHFaceRecognizer_create_15()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::face::LBPHFaceRecognizer::getGridX()
        [DllImport(LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getGridX_10(IntPtr nativeObj);

        // C++:  void cv::face::LBPHFaceRecognizer::setGridX(int val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setGridX_10(IntPtr nativeObj, int val);

        // C++:  int cv::face::LBPHFaceRecognizer::getGridY()
        [DllImport(LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getGridY_10(IntPtr nativeObj);

        // C++:  void cv::face::LBPHFaceRecognizer::setGridY(int val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setGridY_10(IntPtr nativeObj, int val);

        // C++:  int cv::face::LBPHFaceRecognizer::getRadius()
        [DllImport(LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getRadius_10(IntPtr nativeObj);

        // C++:  void cv::face::LBPHFaceRecognizer::setRadius(int val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setRadius_10(IntPtr nativeObj, int val);

        // C++:  int cv::face::LBPHFaceRecognizer::getNeighbors()
        [DllImport(LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getNeighbors_10(IntPtr nativeObj);

        // C++:  void cv::face::LBPHFaceRecognizer::setNeighbors(int val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setNeighbors_10(IntPtr nativeObj, int val);

        // C++:  double cv::face::LBPHFaceRecognizer::getThreshold()
        [DllImport(LIBNAME)]
        private static extern double face_LBPHFaceRecognizer_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::face::LBPHFaceRecognizer::setThreshold(double val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setThreshold_10(IntPtr nativeObj, double val);

        // C++:  vector_Mat cv::face::LBPHFaceRecognizer::getHistograms()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_getHistograms_10(IntPtr nativeObj);

        // C++:  Mat cv::face::LBPHFaceRecognizer::getLabels()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_getLabels_10(IntPtr nativeObj);

        // C++: static Ptr_LBPHFaceRecognizer cv::face::LBPHFaceRecognizer::create(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_10(int radius, int neighbors, int grid_x, int grid_y, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_11(int radius, int neighbors, int grid_x, int grid_y);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_12(int radius, int neighbors, int grid_x);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_13(int radius, int neighbors);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_14(int radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_15();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_delete(IntPtr nativeObj);

    }
}
