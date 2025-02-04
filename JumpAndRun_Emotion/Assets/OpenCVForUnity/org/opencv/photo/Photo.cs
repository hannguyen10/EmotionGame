
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{
    // C++: class Photo


    public partial class Photo
    {

        // C++: enum <unnamed>
        public const int INPAINT_NS = 0;
        public const int INPAINT_TELEA = 1;
        public const int LDR_SIZE = 256;
        public const int NORMAL_CLONE = 1;
        public const int MIXED_CLONE = 2;
        public const int MONOCHROME_TRANSFER = 3;
        public const int RECURS_FILTER = 1;
        public const int NORMCONV_FILTER = 2;
        //
        // C++:  void cv::inpaint(Mat src, Mat inpaintMask, Mat& dst, double inpaintRadius, int flags)
        //

        /// <summary>
        ///  Restores the selected region in an image using the region neighborhood.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit, 16-bit unsigned or 32-bit float 1-channel or 8-bit 3-channel image.
        /// </param>
        /// <param name="inpaintMask">
        /// Inpainting mask, 8-bit 1-channel image. Non-zero pixels indicate the area that
        ///  needs to be inpainted.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="inpaintRadius">
        /// Radius of a circular neighborhood of each point inpainted that is considered
        ///  by the algorithm.
        /// </param>
        /// <param name="flags">
        /// Inpainting method that could be cv::INPAINT_NS or cv::INPAINT_TELEA
        /// </param>
        /// <remarks>
        ///  The function reconstructs the selected image area from the pixel near the area boundary. The
        ///  function may be used to remove dust and scratches from a scanned photo, or to remove undesirable
        ///  objects from still images or video. See &lt;http://en.wikipedia.org/wiki/Inpainting&gt; for more details.
        ///  
        ///  @note
        ///     -   An example using the inpainting technique can be found at
        ///          opencv_source_code/samples/cpp/inpaint.cpp
        ///     -   (Python) An example using the inpainting technique can be found at
        ///          opencv_source_code/samples/python/inpaint.py
        /// </remarks>
        public static void inpaint(Mat src, Mat inpaintMask, Mat dst, double inpaintRadius, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (inpaintMask != null) inpaintMask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_inpaint_10(src.nativeObj, inpaintMask.nativeObj, dst.nativeObj, inpaintRadius, flags);


        }


        //
        // C++:  void cv::fastNlMeansDenoising(Mat src, Mat& dst, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        /// <summary>
        ///  Perform image denoising using Non-local Means Denoising algorithm
        ///  &lt;http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/&gt; with several computational
        ///  optimizations. Noise expected to be a gaussian white noise
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 1-channel, 2-channel, 3-channel or 4-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength. Big h value perfectly removes noise but also
        ///  removes image details, smaller h value preserves details but also preserves some noise
        /// </param>
        /// <remarks>
        ///  This function expected to be applied to grayscale images. For colored images look at
        ///  fastNlMeansDenoisingColored. Advanced usage of this functions can be manual denoising of colored
        ///  image in different colorspaces. Such approach is used in fastNlMeansDenoisingColored by converting
        ///  image to CIELAB colorspace and then separately denoise L and AB components with different h
        ///  parameter.
        /// </remarks>
        public static void fastNlMeansDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_fastNlMeansDenoising_10(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize);


        }

        /// <summary>
        ///  Perform image denoising using Non-local Means Denoising algorithm
        ///  &lt;http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/&gt; with several computational
        ///  optimizations. Noise expected to be a gaussian white noise
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 1-channel, 2-channel, 3-channel or 4-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength. Big h value perfectly removes noise but also
        ///  removes image details, smaller h value preserves details but also preserves some noise
        /// </param>
        /// <remarks>
        ///  This function expected to be applied to grayscale images. For colored images look at
        ///  fastNlMeansDenoisingColored. Advanced usage of this functions can be manual denoising of colored
        ///  image in different colorspaces. Such approach is used in fastNlMeansDenoisingColored by converting
        ///  image to CIELAB colorspace and then separately denoise L and AB components with different h
        ///  parameter.
        /// </remarks>
        public static void fastNlMeansDenoising(Mat src, Mat dst, float h, int templateWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_fastNlMeansDenoising_11(src.nativeObj, dst.nativeObj, h, templateWindowSize);


        }

        /// <summary>
        ///  Perform image denoising using Non-local Means Denoising algorithm
        ///  &lt;http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/&gt; with several computational
        ///  optimizations. Noise expected to be a gaussian white noise
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 1-channel, 2-channel, 3-channel or 4-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength. Big h value perfectly removes noise but also
        ///  removes image details, smaller h value preserves details but also preserves some noise
        /// </param>
        /// <remarks>
        ///  This function expected to be applied to grayscale images. For colored images look at
        ///  fastNlMeansDenoisingColored. Advanced usage of this functions can be manual denoising of colored
        ///  image in different colorspaces. Such approach is used in fastNlMeansDenoisingColored by converting
        ///  image to CIELAB colorspace and then separately denoise L and AB components with different h
        ///  parameter.
        /// </remarks>
        public static void fastNlMeansDenoising(Mat src, Mat dst, float h)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_fastNlMeansDenoising_12(src.nativeObj, dst.nativeObj, h);


        }

        /// <summary>
        ///  Perform image denoising using Non-local Means Denoising algorithm
        ///  &lt;http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/&gt; with several computational
        ///  optimizations. Noise expected to be a gaussian white noise
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 1-channel, 2-channel, 3-channel or 4-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength. Big h value perfectly removes noise but also
        ///  removes image details, smaller h value preserves details but also preserves some noise
        /// </param>
        /// <remarks>
        ///  This function expected to be applied to grayscale images. For colored images look at
        ///  fastNlMeansDenoisingColored. Advanced usage of this functions can be manual denoising of colored
        ///  image in different colorspaces. Such approach is used in fastNlMeansDenoisingColored by converting
        ///  image to CIELAB colorspace and then separately denoise L and AB components with different h
        ///  parameter.
        /// </remarks>
        public static void fastNlMeansDenoising(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_fastNlMeansDenoising_13(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::fastNlMeansDenoising(Mat src, Mat& dst, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        //

        /// <summary>
        ///  Perform image denoising using Non-local Means Denoising algorithm
        ///  &lt;http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/&gt; with several computational
        ///  optimizations. Noise expected to be a gaussian white noise
        /// </summary>
        /// <param name="src">
        /// Input 8-bit or 16-bit (only with NORM_L1) 1-channel,
        ///  2-channel, 3-channel or 4-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Array of parameters regulating filter strength, either one
        ///  parameter applied to all channels or one per channel in dst. Big h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        /// <param name="normType">
        /// Type of norm used for weight calculation. Can be either NORM_L2 or NORM_L1
        /// </param>
        /// <remarks>
        ///  This function expected to be applied to grayscale images. For colored images look at
        ///  fastNlMeansDenoisingColored. Advanced usage of this functions can be manual denoising of colored
        ///  image in different colorspaces. Such approach is used in fastNlMeansDenoisingColored by converting
        ///  image to CIELAB colorspace and then separately denoise L and AB components with different h
        ///  parameter.
        /// </remarks>
        public static void fastNlMeansDenoising(Mat src, Mat dst, MatOfFloat h, int templateWindowSize, int searchWindowSize, int normType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
            Mat h_mat = h;
            photo_Photo_fastNlMeansDenoising_14(src.nativeObj, dst.nativeObj, h_mat.nativeObj, templateWindowSize, searchWindowSize, normType);


        }

        /// <summary>
        ///  Perform image denoising using Non-local Means Denoising algorithm
        ///  &lt;http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/&gt; with several computational
        ///  optimizations. Noise expected to be a gaussian white noise
        /// </summary>
        /// <param name="src">
        /// Input 8-bit or 16-bit (only with NORM_L1) 1-channel,
        ///  2-channel, 3-channel or 4-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Array of parameters regulating filter strength, either one
        ///  parameter applied to all channels or one per channel in dst. Big h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        /// <param name="normType">
        /// Type of norm used for weight calculation. Can be either NORM_L2 or NORM_L1
        /// </param>
        /// <remarks>
        ///  This function expected to be applied to grayscale images. For colored images look at
        ///  fastNlMeansDenoisingColored. Advanced usage of this functions can be manual denoising of colored
        ///  image in different colorspaces. Such approach is used in fastNlMeansDenoisingColored by converting
        ///  image to CIELAB colorspace and then separately denoise L and AB components with different h
        ///  parameter.
        /// </remarks>
        public static void fastNlMeansDenoising(Mat src, Mat dst, MatOfFloat h, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
            Mat h_mat = h;
            photo_Photo_fastNlMeansDenoising_15(src.nativeObj, dst.nativeObj, h_mat.nativeObj, templateWindowSize, searchWindowSize);


        }

        /// <summary>
        ///  Perform image denoising using Non-local Means Denoising algorithm
        ///  &lt;http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/&gt; with several computational
        ///  optimizations. Noise expected to be a gaussian white noise
        /// </summary>
        /// <param name="src">
        /// Input 8-bit or 16-bit (only with NORM_L1) 1-channel,
        ///  2-channel, 3-channel or 4-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Array of parameters regulating filter strength, either one
        ///  parameter applied to all channels or one per channel in dst. Big h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        /// <param name="normType">
        /// Type of norm used for weight calculation. Can be either NORM_L2 or NORM_L1
        /// </param>
        /// <remarks>
        ///  This function expected to be applied to grayscale images. For colored images look at
        ///  fastNlMeansDenoisingColored. Advanced usage of this functions can be manual denoising of colored
        ///  image in different colorspaces. Such approach is used in fastNlMeansDenoisingColored by converting
        ///  image to CIELAB colorspace and then separately denoise L and AB components with different h
        ///  parameter.
        /// </remarks>
        public static void fastNlMeansDenoising(Mat src, Mat dst, MatOfFloat h, int templateWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
            Mat h_mat = h;
            photo_Photo_fastNlMeansDenoising_16(src.nativeObj, dst.nativeObj, h_mat.nativeObj, templateWindowSize);


        }

        /// <summary>
        ///  Perform image denoising using Non-local Means Denoising algorithm
        ///  &lt;http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/&gt; with several computational
        ///  optimizations. Noise expected to be a gaussian white noise
        /// </summary>
        /// <param name="src">
        /// Input 8-bit or 16-bit (only with NORM_L1) 1-channel,
        ///  2-channel, 3-channel or 4-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Array of parameters regulating filter strength, either one
        ///  parameter applied to all channels or one per channel in dst. Big h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        /// <param name="normType">
        /// Type of norm used for weight calculation. Can be either NORM_L2 or NORM_L1
        /// </param>
        /// <remarks>
        ///  This function expected to be applied to grayscale images. For colored images look at
        ///  fastNlMeansDenoisingColored. Advanced usage of this functions can be manual denoising of colored
        ///  image in different colorspaces. Such approach is used in fastNlMeansDenoisingColored by converting
        ///  image to CIELAB colorspace and then separately denoise L and AB components with different h
        ///  parameter.
        /// </remarks>
        public static void fastNlMeansDenoising(Mat src, Mat dst, MatOfFloat h)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
            Mat h_mat = h;
            photo_Photo_fastNlMeansDenoising_17(src.nativeObj, dst.nativeObj, h_mat.nativeObj);


        }


        //
        // C++:  void cv::fastNlMeansDenoisingColored(Mat src, Mat& dst, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for colored images
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components. For most images value equals 10
        ///  will be enough to remove colored noise and do not distort colors
        /// </param>
        /// <remarks>
        ///  The function converts image to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoising function.
        /// </remarks>
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst, float h, float hColor, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_fastNlMeansDenoisingColored_10(src.nativeObj, dst.nativeObj, h, hColor, templateWindowSize, searchWindowSize);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for colored images
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components. For most images value equals 10
        ///  will be enough to remove colored noise and do not distort colors
        /// </param>
        /// <remarks>
        ///  The function converts image to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoising function.
        /// </remarks>
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst, float h, float hColor, int templateWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_fastNlMeansDenoisingColored_11(src.nativeObj, dst.nativeObj, h, hColor, templateWindowSize);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for colored images
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components. For most images value equals 10
        ///  will be enough to remove colored noise and do not distort colors
        /// </param>
        /// <remarks>
        ///  The function converts image to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoising function.
        /// </remarks>
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst, float h, float hColor)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_fastNlMeansDenoisingColored_12(src.nativeObj, dst.nativeObj, h, hColor);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for colored images
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components. For most images value equals 10
        ///  will be enough to remove colored noise and do not distort colors
        /// </param>
        /// <remarks>
        ///  The function converts image to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoising function.
        /// </remarks>
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst, float h)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_fastNlMeansDenoisingColored_13(src.nativeObj, dst.nativeObj, h);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for colored images
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components. For most images value equals 10
        ///  will be enough to remove colored noise and do not distort colors
        /// </param>
        /// <remarks>
        ///  The function converts image to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoising function.
        /// </remarks>
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_fastNlMeansDenoisingColored_14(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for images sequence where consecutive images have been
        ///  captured in small period of time. For example video. This version of the function is for grayscale
        ///  images or for manual manipulation with colorspaces. See @cite Buades2005DenoisingIS for more details
        ///  (open access [here](https://static.aminer.org/pdf/PDF/000/317/196/spatio_temporal_wiener_filtering_of_image_sequences_using_a_parametric.pdf)).
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit 1-channel, 2-channel, 3-channel or
        ///  4-channel images sequence. All images should have the same type and
        ///  size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength. Bigger h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            photo_Photo_fastNlMeansDenoisingMulti_10(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize, searchWindowSize);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for images sequence where consecutive images have been
        ///  captured in small period of time. For example video. This version of the function is for grayscale
        ///  images or for manual manipulation with colorspaces. See @cite Buades2005DenoisingIS for more details
        ///  (open access [here](https://static.aminer.org/pdf/PDF/000/317/196/spatio_temporal_wiener_filtering_of_image_sequences_using_a_parametric.pdf)).
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit 1-channel, 2-channel, 3-channel or
        ///  4-channel images sequence. All images should have the same type and
        ///  size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength. Bigger h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            photo_Photo_fastNlMeansDenoisingMulti_11(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for images sequence where consecutive images have been
        ///  captured in small period of time. For example video. This version of the function is for grayscale
        ///  images or for manual manipulation with colorspaces. See @cite Buades2005DenoisingIS for more details
        ///  (open access [here](https://static.aminer.org/pdf/PDF/000/317/196/spatio_temporal_wiener_filtering_of_image_sequences_using_a_parametric.pdf)).
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit 1-channel, 2-channel, 3-channel or
        ///  4-channel images sequence. All images should have the same type and
        ///  size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength. Bigger h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            photo_Photo_fastNlMeansDenoisingMulti_12(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for images sequence where consecutive images have been
        ///  captured in small period of time. For example video. This version of the function is for grayscale
        ///  images or for manual manipulation with colorspaces. See @cite Buades2005DenoisingIS for more details
        ///  (open access [here](https://static.aminer.org/pdf/PDF/000/317/196/spatio_temporal_wiener_filtering_of_image_sequences_using_a_parametric.pdf)).
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit 1-channel, 2-channel, 3-channel or
        ///  4-channel images sequence. All images should have the same type and
        ///  size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength. Bigger h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            photo_Photo_fastNlMeansDenoisingMulti_13(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize);


        }


        //
        // C++:  void cv::fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        //

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for images sequence where consecutive images have been
        ///  captured in small period of time. For example video. This version of the function is for grayscale
        ///  images or for manual manipulation with colorspaces. See @cite Buades2005DenoisingIS for more details
        ///  (open access [here](https://static.aminer.org/pdf/PDF/000/317/196/spatio_temporal_wiener_filtering_of_image_sequences_using_a_parametric.pdf)).
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit or 16-bit (only with NORM_L1) 1-channel,
        ///  2-channel, 3-channel or 4-channel images sequence. All images should
        ///  have the same type and size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Array of parameters regulating filter strength, either one
        ///  parameter applied to all channels or one per channel in dst. Big h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        /// <param name="normType">
        /// Type of norm used for weight calculation. Can be either NORM_L2 or NORM_L1
        /// </param>
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h, int templateWindowSize, int searchWindowSize, int normType)
        {
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            Mat h_mat = h;
            photo_Photo_fastNlMeansDenoisingMulti_14(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj, templateWindowSize, searchWindowSize, normType);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for images sequence where consecutive images have been
        ///  captured in small period of time. For example video. This version of the function is for grayscale
        ///  images or for manual manipulation with colorspaces. See @cite Buades2005DenoisingIS for more details
        ///  (open access [here](https://static.aminer.org/pdf/PDF/000/317/196/spatio_temporal_wiener_filtering_of_image_sequences_using_a_parametric.pdf)).
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit or 16-bit (only with NORM_L1) 1-channel,
        ///  2-channel, 3-channel or 4-channel images sequence. All images should
        ///  have the same type and size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Array of parameters regulating filter strength, either one
        ///  parameter applied to all channels or one per channel in dst. Big h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        /// <param name="normType">
        /// Type of norm used for weight calculation. Can be either NORM_L2 or NORM_L1
        /// </param>
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            Mat h_mat = h;
            photo_Photo_fastNlMeansDenoisingMulti_15(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj, templateWindowSize, searchWindowSize);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for images sequence where consecutive images have been
        ///  captured in small period of time. For example video. This version of the function is for grayscale
        ///  images or for manual manipulation with colorspaces. See @cite Buades2005DenoisingIS for more details
        ///  (open access [here](https://static.aminer.org/pdf/PDF/000/317/196/spatio_temporal_wiener_filtering_of_image_sequences_using_a_parametric.pdf)).
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit or 16-bit (only with NORM_L1) 1-channel,
        ///  2-channel, 3-channel or 4-channel images sequence. All images should
        ///  have the same type and size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Array of parameters regulating filter strength, either one
        ///  parameter applied to all channels or one per channel in dst. Big h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        /// <param name="normType">
        /// Type of norm used for weight calculation. Can be either NORM_L2 or NORM_L1
        /// </param>
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h, int templateWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            Mat h_mat = h;
            photo_Photo_fastNlMeansDenoisingMulti_16(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj, templateWindowSize);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoising function for images sequence where consecutive images have been
        ///  captured in small period of time. For example video. This version of the function is for grayscale
        ///  images or for manual manipulation with colorspaces. See @cite Buades2005DenoisingIS for more details
        ///  (open access [here](https://static.aminer.org/pdf/PDF/000/317/196/spatio_temporal_wiener_filtering_of_image_sequences_using_a_parametric.pdf)).
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit or 16-bit (only with NORM_L1) 1-channel,
        ///  2-channel, 3-channel or 4-channel images sequence. All images should
        ///  have the same type and size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Array of parameters regulating filter strength, either one
        ///  parameter applied to all channels or one per channel in dst. Big h value
        ///  perfectly removes noise but also removes image details, smaller h
        ///  value preserves details but also preserves some noise
        /// </param>
        /// <param name="normType">
        /// Type of norm used for weight calculation. Can be either NORM_L2 or NORM_L1
        /// </param>
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h)
        {
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            Mat h_mat = h;
            photo_Photo_fastNlMeansDenoisingMulti_17(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj);


        }


        //
        // C++:  void cv::fastNlMeansDenoisingColoredMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        /// <summary>
        ///  Modification of fastNlMeansDenoisingMulti function for colored images sequences
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit 3-channel images sequence. All images should have the same type and
        ///  size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise.
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components.
        /// </param>
        /// <remarks>
        ///  The function converts images to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoisingMulti function.
        /// </remarks>
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            photo_Photo_fastNlMeansDenoisingColoredMulti_10(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, hColor, templateWindowSize, searchWindowSize);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoisingMulti function for colored images sequences
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit 3-channel images sequence. All images should have the same type and
        ///  size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise.
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components.
        /// </param>
        /// <remarks>
        ///  The function converts images to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoisingMulti function.
        /// </remarks>
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            photo_Photo_fastNlMeansDenoisingColoredMulti_11(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, hColor, templateWindowSize);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoisingMulti function for colored images sequences
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit 3-channel images sequence. All images should have the same type and
        ///  size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise.
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components.
        /// </param>
        /// <remarks>
        ///  The function converts images to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoisingMulti function.
        /// </remarks>
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            photo_Photo_fastNlMeansDenoisingColoredMulti_12(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, hColor);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoisingMulti function for colored images sequences
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit 3-channel images sequence. All images should have the same type and
        ///  size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise.
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components.
        /// </param>
        /// <remarks>
        ///  The function converts images to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoisingMulti function.
        /// </remarks>
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            photo_Photo_fastNlMeansDenoisingColoredMulti_13(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h);


        }

        /// <summary>
        ///  Modification of fastNlMeansDenoisingMulti function for colored images sequences
        /// </summary>
        /// <param name="srcImgs">
        /// Input 8-bit 3-channel images sequence. All images should have the same type and
        ///  size.
        /// </param>
        /// <param name="imgToDenoiseIndex">
        /// Target image to denoise index in srcImgs sequence
        /// </param>
        /// <param name="temporalWindowSize">
        /// Number of surrounding images to use for target image denoising. Should
        ///  be odd. Images from imgToDenoiseIndex - temporalWindowSize / 2 to
        ///  imgToDenoiseIndex - temporalWindowSize / 2 from srcImgs will be used to denoise
        ///  srcImgs[imgToDenoiseIndex] image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as srcImgs images.
        /// </param>
        /// <param name="templateWindowSize">
        /// Size in pixels of the template patch that is used to compute weights.
        ///  Should be odd. Recommended value 7 pixels
        /// </param>
        /// <param name="searchWindowSize">
        /// Size in pixels of the window that is used to compute weighted average for
        ///  given pixel. Should be odd. Affect performance linearly: greater searchWindowsSize - greater
        ///  denoising time. Recommended value 21 pixels
        /// </param>
        /// <param name="h">
        /// Parameter regulating filter strength for luminance component. Bigger h value perfectly
        ///  removes noise but also removes image details, smaller h value preserves details but also preserves
        ///  some noise.
        /// </param>
        /// <param name="hColor">
        /// The same as h but for color components.
        /// </param>
        /// <remarks>
        ///  The function converts images to CIELAB colorspace and then separately denoise L and AB components
        ///  with given h parameters using fastNlMeansDenoisingMulti function.
        /// </remarks>
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            photo_Photo_fastNlMeansDenoisingColoredMulti_14(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize);


        }


        //
        // C++:  void cv::denoise_TVL1(vector_Mat observations, Mat result, double lambda = 1.0, int niters = 30)
        //

        /// <summary>
        ///  Primal-dual algorithm is an algorithm for solving special types of variational problems (that is,
        ///  finding a function to minimize some functional). As the image denoising, in particular, may be seen
        ///  as the variational problem, primal-dual algorithm then can be used to perform denoising and this is
        ///  exactly what is implemented.
        /// </summary>
        /// <remarks>
        ///  It should be noted, that this implementation was taken from the July 2013 blog entry
        ///  @cite MA13 , which also contained (slightly more general) ready-to-use source code on Python.
        ///  Subsequently, that code was rewritten on C++ with the usage of openCV by Vadim Pisarevsky at the end
        ///  of July 2013 and finally it was slightly adapted by later authors.
        ///  
        ///  Although the thorough discussion and justification of the algorithm involved may be found in
        ///  @cite ChambolleEtAl, it might make sense to skim over it here, following @cite MA13 . To begin
        ///  with, we consider the 1-byte gray-level images as the functions from the rectangular domain of
        ///  pixels (it may be seen as set
        ///  \f$\left\{(x,y)\in\mathbb{N}\times\mathbb{N}\mid 1\leq x\leq n,\;1\leq y\leq m\right\}\f$ for some
        ///  \f$m,\;n\in\mathbb{N}\f$) into \f$\{0,1,\dots,255\}\f$. We shall denote the noised images as \f$f_i\f$ and with
        ///  this view, given some image \f$x\f$ of the same size, we may measure how bad it is by the formula
        ///  
        ///  \f[\left\|\left\|\nabla x\right\|\right\| + \lambda\sum_i\left\|\left\|x-f_i\right\|\right\|\f]
        ///  
        ///  \f$\|\|\cdot\|\|\f$ here denotes \f$L_2\f$-norm and as you see, the first addend states that we want our
        ///  image to be smooth (ideally, having zero gradient, thus being constant) and the second states that
        ///  we want our result to be close to the observations we've got. If we treat \f$x\f$ as a function, this is
        ///  exactly the functional what we seek to minimize and here the Primal-Dual algorithm comes into play.
        /// </remarks>
        /// <param name="observations">
        /// This array should contain one or more noised versions of the image that is to
        ///  be restored.
        /// </param>
        /// <param name="result">
        /// Here the denoised image will be stored. There is no need to do pre-allocation of
        ///  storage space, as it will be automatically allocated, if necessary.
        /// </param>
        /// <param name="lambda">
        /// Corresponds to \f$\lambda\f$ in the formulas above. As it is enlarged, the smooth
        ///  (blurred) images are treated more favorably than detailed (but maybe more noised) ones. Roughly
        ///  speaking, as it becomes smaller, the result will be more blur but more sever outliers will be
        ///  removed.
        /// </param>
        /// <param name="niters">
        /// Number of iterations that the algorithm will run. Of course, as more iterations as
        ///  better, but it is hard to quantitatively refine this statement, so just use the default and
        ///  increase it if the results are poor.
        /// </param>
        public static void denoise_TVL1(List<Mat> observations, Mat result, double lambda, int niters)
        {
            if (result != null) result.ThrowIfDisposed();
            Mat observations_mat = Converters.vector_Mat_to_Mat(observations);
            photo_Photo_denoise_1TVL1_10(observations_mat.nativeObj, result.nativeObj, lambda, niters);


        }

        /// <summary>
        ///  Primal-dual algorithm is an algorithm for solving special types of variational problems (that is,
        ///  finding a function to minimize some functional). As the image denoising, in particular, may be seen
        ///  as the variational problem, primal-dual algorithm then can be used to perform denoising and this is
        ///  exactly what is implemented.
        /// </summary>
        /// <remarks>
        ///  It should be noted, that this implementation was taken from the July 2013 blog entry
        ///  @cite MA13 , which also contained (slightly more general) ready-to-use source code on Python.
        ///  Subsequently, that code was rewritten on C++ with the usage of openCV by Vadim Pisarevsky at the end
        ///  of July 2013 and finally it was slightly adapted by later authors.
        ///  
        ///  Although the thorough discussion and justification of the algorithm involved may be found in
        ///  @cite ChambolleEtAl, it might make sense to skim over it here, following @cite MA13 . To begin
        ///  with, we consider the 1-byte gray-level images as the functions from the rectangular domain of
        ///  pixels (it may be seen as set
        ///  \f$\left\{(x,y)\in\mathbb{N}\times\mathbb{N}\mid 1\leq x\leq n,\;1\leq y\leq m\right\}\f$ for some
        ///  \f$m,\;n\in\mathbb{N}\f$) into \f$\{0,1,\dots,255\}\f$. We shall denote the noised images as \f$f_i\f$ and with
        ///  this view, given some image \f$x\f$ of the same size, we may measure how bad it is by the formula
        ///  
        ///  \f[\left\|\left\|\nabla x\right\|\right\| + \lambda\sum_i\left\|\left\|x-f_i\right\|\right\|\f]
        ///  
        ///  \f$\|\|\cdot\|\|\f$ here denotes \f$L_2\f$-norm and as you see, the first addend states that we want our
        ///  image to be smooth (ideally, having zero gradient, thus being constant) and the second states that
        ///  we want our result to be close to the observations we've got. If we treat \f$x\f$ as a function, this is
        ///  exactly the functional what we seek to minimize and here the Primal-Dual algorithm comes into play.
        /// </remarks>
        /// <param name="observations">
        /// This array should contain one or more noised versions of the image that is to
        ///  be restored.
        /// </param>
        /// <param name="result">
        /// Here the denoised image will be stored. There is no need to do pre-allocation of
        ///  storage space, as it will be automatically allocated, if necessary.
        /// </param>
        /// <param name="lambda">
        /// Corresponds to \f$\lambda\f$ in the formulas above. As it is enlarged, the smooth
        ///  (blurred) images are treated more favorably than detailed (but maybe more noised) ones. Roughly
        ///  speaking, as it becomes smaller, the result will be more blur but more sever outliers will be
        ///  removed.
        /// </param>
        /// <param name="niters">
        /// Number of iterations that the algorithm will run. Of course, as more iterations as
        ///  better, but it is hard to quantitatively refine this statement, so just use the default and
        ///  increase it if the results are poor.
        /// </param>
        public static void denoise_TVL1(List<Mat> observations, Mat result, double lambda)
        {
            if (result != null) result.ThrowIfDisposed();
            Mat observations_mat = Converters.vector_Mat_to_Mat(observations);
            photo_Photo_denoise_1TVL1_11(observations_mat.nativeObj, result.nativeObj, lambda);


        }

        /// <summary>
        ///  Primal-dual algorithm is an algorithm for solving special types of variational problems (that is,
        ///  finding a function to minimize some functional). As the image denoising, in particular, may be seen
        ///  as the variational problem, primal-dual algorithm then can be used to perform denoising and this is
        ///  exactly what is implemented.
        /// </summary>
        /// <remarks>
        ///  It should be noted, that this implementation was taken from the July 2013 blog entry
        ///  @cite MA13 , which also contained (slightly more general) ready-to-use source code on Python.
        ///  Subsequently, that code was rewritten on C++ with the usage of openCV by Vadim Pisarevsky at the end
        ///  of July 2013 and finally it was slightly adapted by later authors.
        ///  
        ///  Although the thorough discussion and justification of the algorithm involved may be found in
        ///  @cite ChambolleEtAl, it might make sense to skim over it here, following @cite MA13 . To begin
        ///  with, we consider the 1-byte gray-level images as the functions from the rectangular domain of
        ///  pixels (it may be seen as set
        ///  \f$\left\{(x,y)\in\mathbb{N}\times\mathbb{N}\mid 1\leq x\leq n,\;1\leq y\leq m\right\}\f$ for some
        ///  \f$m,\;n\in\mathbb{N}\f$) into \f$\{0,1,\dots,255\}\f$. We shall denote the noised images as \f$f_i\f$ and with
        ///  this view, given some image \f$x\f$ of the same size, we may measure how bad it is by the formula
        ///  
        ///  \f[\left\|\left\|\nabla x\right\|\right\| + \lambda\sum_i\left\|\left\|x-f_i\right\|\right\|\f]
        ///  
        ///  \f$\|\|\cdot\|\|\f$ here denotes \f$L_2\f$-norm and as you see, the first addend states that we want our
        ///  image to be smooth (ideally, having zero gradient, thus being constant) and the second states that
        ///  we want our result to be close to the observations we've got. If we treat \f$x\f$ as a function, this is
        ///  exactly the functional what we seek to minimize and here the Primal-Dual algorithm comes into play.
        /// </remarks>
        /// <param name="observations">
        /// This array should contain one or more noised versions of the image that is to
        ///  be restored.
        /// </param>
        /// <param name="result">
        /// Here the denoised image will be stored. There is no need to do pre-allocation of
        ///  storage space, as it will be automatically allocated, if necessary.
        /// </param>
        /// <param name="lambda">
        /// Corresponds to \f$\lambda\f$ in the formulas above. As it is enlarged, the smooth
        ///  (blurred) images are treated more favorably than detailed (but maybe more noised) ones. Roughly
        ///  speaking, as it becomes smaller, the result will be more blur but more sever outliers will be
        ///  removed.
        /// </param>
        /// <param name="niters">
        /// Number of iterations that the algorithm will run. Of course, as more iterations as
        ///  better, but it is hard to quantitatively refine this statement, so just use the default and
        ///  increase it if the results are poor.
        /// </param>
        public static void denoise_TVL1(List<Mat> observations, Mat result)
        {
            if (result != null) result.ThrowIfDisposed();
            Mat observations_mat = Converters.vector_Mat_to_Mat(observations);
            photo_Photo_denoise_1TVL1_12(observations_mat.nativeObj, result.nativeObj);


        }


        //
        // C++:  Ptr_Tonemap cv::createTonemap(float gamma = 1.0f)
        //

        /// <summary>
        ///  Creates simple linear mapper with gamma correction
        /// </summary>
        /// <param name="gamma">
        /// positive value for gamma correction. Gamma value of 1.0 implies no correction, gamma
        ///  equal to 2.2f is suitable for most displays.
        ///  Generally gamma &gt; 1 brightens the image and gamma &lt; 1 darkens it.
        /// </param>
        public static Tonemap createTonemap(float gamma)
        {


            return Tonemap.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemap_10(gamma)));


        }

        /// <summary>
        ///  Creates simple linear mapper with gamma correction
        /// </summary>
        /// <param name="gamma">
        /// positive value for gamma correction. Gamma value of 1.0 implies no correction, gamma
        ///  equal to 2.2f is suitable for most displays.
        ///  Generally gamma &gt; 1 brightens the image and gamma &lt; 1 darkens it.
        /// </param>
        public static Tonemap createTonemap()
        {


            return Tonemap.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemap_11()));


        }


        //
        // C++:  Ptr_TonemapDrago cv::createTonemapDrago(float gamma = 1.0f, float saturation = 1.0f, float bias = 0.85f)
        //

        /// <summary>
        ///  Creates TonemapDrago object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="saturation">
        /// positive saturation enhancement value. 1.0 preserves saturation, values greater
        ///  than 1 increase saturation and values less than 1 decrease it.
        /// </param>
        /// <param name="bias">
        /// value for bias function in [0, 1] range. Values from 0.7 to 0.9 usually give best
        ///  results, default value is 0.85.
        /// </param>
        public static TonemapDrago createTonemapDrago(float gamma, float saturation, float bias)
        {


            return TonemapDrago.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapDrago_10(gamma, saturation, bias)));


        }

        /// <summary>
        ///  Creates TonemapDrago object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="saturation">
        /// positive saturation enhancement value. 1.0 preserves saturation, values greater
        ///  than 1 increase saturation and values less than 1 decrease it.
        /// </param>
        /// <param name="bias">
        /// value for bias function in [0, 1] range. Values from 0.7 to 0.9 usually give best
        ///  results, default value is 0.85.
        /// </param>
        public static TonemapDrago createTonemapDrago(float gamma, float saturation)
        {


            return TonemapDrago.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapDrago_11(gamma, saturation)));


        }

        /// <summary>
        ///  Creates TonemapDrago object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="saturation">
        /// positive saturation enhancement value. 1.0 preserves saturation, values greater
        ///  than 1 increase saturation and values less than 1 decrease it.
        /// </param>
        /// <param name="bias">
        /// value for bias function in [0, 1] range. Values from 0.7 to 0.9 usually give best
        ///  results, default value is 0.85.
        /// </param>
        public static TonemapDrago createTonemapDrago(float gamma)
        {


            return TonemapDrago.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapDrago_12(gamma)));


        }

        /// <summary>
        ///  Creates TonemapDrago object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="saturation">
        /// positive saturation enhancement value. 1.0 preserves saturation, values greater
        ///  than 1 increase saturation and values less than 1 decrease it.
        /// </param>
        /// <param name="bias">
        /// value for bias function in [0, 1] range. Values from 0.7 to 0.9 usually give best
        ///  results, default value is 0.85.
        /// </param>
        public static TonemapDrago createTonemapDrago()
        {


            return TonemapDrago.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapDrago_13()));


        }


        //
        // C++:  Ptr_TonemapReinhard cv::createTonemapReinhard(float gamma = 1.0f, float intensity = 0.0f, float light_adapt = 1.0f, float color_adapt = 0.0f)
        //

        /// <summary>
        ///  Creates TonemapReinhard object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="intensity">
        /// result intensity in [-8, 8] range. Greater intensity produces brighter results.
        /// </param>
        /// <param name="light_adapt">
        /// light adaptation in [0, 1] range. If 1 adaptation is based only on pixel
        ///  value, if 0 it's global, otherwise it's a weighted mean of this two cases.
        /// </param>
        /// <param name="color_adapt">
        /// chromatic adaptation in [0, 1] range. If 1 channels are treated independently,
        ///  if 0 adaptation level is the same for each channel.
        /// </param>
        public static TonemapReinhard createTonemapReinhard(float gamma, float intensity, float light_adapt, float color_adapt)
        {


            return TonemapReinhard.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapReinhard_10(gamma, intensity, light_adapt, color_adapt)));


        }

        /// <summary>
        ///  Creates TonemapReinhard object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="intensity">
        /// result intensity in [-8, 8] range. Greater intensity produces brighter results.
        /// </param>
        /// <param name="light_adapt">
        /// light adaptation in [0, 1] range. If 1 adaptation is based only on pixel
        ///  value, if 0 it's global, otherwise it's a weighted mean of this two cases.
        /// </param>
        /// <param name="color_adapt">
        /// chromatic adaptation in [0, 1] range. If 1 channels are treated independently,
        ///  if 0 adaptation level is the same for each channel.
        /// </param>
        public static TonemapReinhard createTonemapReinhard(float gamma, float intensity, float light_adapt)
        {


            return TonemapReinhard.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapReinhard_11(gamma, intensity, light_adapt)));


        }

        /// <summary>
        ///  Creates TonemapReinhard object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="intensity">
        /// result intensity in [-8, 8] range. Greater intensity produces brighter results.
        /// </param>
        /// <param name="light_adapt">
        /// light adaptation in [0, 1] range. If 1 adaptation is based only on pixel
        ///  value, if 0 it's global, otherwise it's a weighted mean of this two cases.
        /// </param>
        /// <param name="color_adapt">
        /// chromatic adaptation in [0, 1] range. If 1 channels are treated independently,
        ///  if 0 adaptation level is the same for each channel.
        /// </param>
        public static TonemapReinhard createTonemapReinhard(float gamma, float intensity)
        {


            return TonemapReinhard.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapReinhard_12(gamma, intensity)));


        }

        /// <summary>
        ///  Creates TonemapReinhard object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="intensity">
        /// result intensity in [-8, 8] range. Greater intensity produces brighter results.
        /// </param>
        /// <param name="light_adapt">
        /// light adaptation in [0, 1] range. If 1 adaptation is based only on pixel
        ///  value, if 0 it's global, otherwise it's a weighted mean of this two cases.
        /// </param>
        /// <param name="color_adapt">
        /// chromatic adaptation in [0, 1] range. If 1 channels are treated independently,
        ///  if 0 adaptation level is the same for each channel.
        /// </param>
        public static TonemapReinhard createTonemapReinhard(float gamma)
        {


            return TonemapReinhard.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapReinhard_13(gamma)));


        }

        /// <summary>
        ///  Creates TonemapReinhard object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="intensity">
        /// result intensity in [-8, 8] range. Greater intensity produces brighter results.
        /// </param>
        /// <param name="light_adapt">
        /// light adaptation in [0, 1] range. If 1 adaptation is based only on pixel
        ///  value, if 0 it's global, otherwise it's a weighted mean of this two cases.
        /// </param>
        /// <param name="color_adapt">
        /// chromatic adaptation in [0, 1] range. If 1 channels are treated independently,
        ///  if 0 adaptation level is the same for each channel.
        /// </param>
        public static TonemapReinhard createTonemapReinhard()
        {


            return TonemapReinhard.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapReinhard_14()));


        }


        //
        // C++:  Ptr_TonemapMantiuk cv::createTonemapMantiuk(float gamma = 1.0f, float scale = 0.7f, float saturation = 1.0f)
        //

        /// <summary>
        ///  Creates TonemapMantiuk object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="scale">
        /// contrast scale factor. HVS response is multiplied by this parameter, thus compressing
        ///  dynamic range. Values from 0.6 to 0.9 produce best results.
        /// </param>
        /// <param name="saturation">
        /// saturation enhancement value. See createTonemapDrago
        /// </param>
        public static TonemapMantiuk createTonemapMantiuk(float gamma, float scale, float saturation)
        {


            return TonemapMantiuk.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapMantiuk_10(gamma, scale, saturation)));


        }

        /// <summary>
        ///  Creates TonemapMantiuk object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="scale">
        /// contrast scale factor. HVS response is multiplied by this parameter, thus compressing
        ///  dynamic range. Values from 0.6 to 0.9 produce best results.
        /// </param>
        /// <param name="saturation">
        /// saturation enhancement value. See createTonemapDrago
        /// </param>
        public static TonemapMantiuk createTonemapMantiuk(float gamma, float scale)
        {


            return TonemapMantiuk.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapMantiuk_11(gamma, scale)));


        }

        /// <summary>
        ///  Creates TonemapMantiuk object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="scale">
        /// contrast scale factor. HVS response is multiplied by this parameter, thus compressing
        ///  dynamic range. Values from 0.6 to 0.9 produce best results.
        /// </param>
        /// <param name="saturation">
        /// saturation enhancement value. See createTonemapDrago
        /// </param>
        public static TonemapMantiuk createTonemapMantiuk(float gamma)
        {


            return TonemapMantiuk.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapMantiuk_12(gamma)));


        }

        /// <summary>
        ///  Creates TonemapMantiuk object
        /// </summary>
        /// <param name="gamma">
        /// gamma value for gamma correction. See createTonemap
        /// </param>
        /// <param name="scale">
        /// contrast scale factor. HVS response is multiplied by this parameter, thus compressing
        ///  dynamic range. Values from 0.6 to 0.9 produce best results.
        /// </param>
        /// <param name="saturation">
        /// saturation enhancement value. See createTonemapDrago
        /// </param>
        public static TonemapMantiuk createTonemapMantiuk()
        {


            return TonemapMantiuk.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createTonemapMantiuk_13()));


        }


        //
        // C++:  Ptr_AlignMTB cv::createAlignMTB(int max_bits = 6, int exclude_range = 4, bool cut = true)
        //

        /// <summary>
        ///  Creates AlignMTB object
        /// </summary>
        /// <param name="max_bits">
        /// logarithm to the base 2 of maximal shift in each dimension. Values of 5 and 6 are
        ///  usually good enough (31 and 63 pixels shift respectively).
        /// </param>
        /// <param name="exclude_range">
        /// range for exclusion bitmap that is constructed to suppress noise around the
        ///  median value.
        /// </param>
        /// <param name="cut">
        /// if true cuts images, otherwise fills the new regions with zeros.
        /// </param>
        public static AlignMTB createAlignMTB(int max_bits, int exclude_range, bool cut)
        {


            return AlignMTB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createAlignMTB_10(max_bits, exclude_range, cut)));


        }

        /// <summary>
        ///  Creates AlignMTB object
        /// </summary>
        /// <param name="max_bits">
        /// logarithm to the base 2 of maximal shift in each dimension. Values of 5 and 6 are
        ///  usually good enough (31 and 63 pixels shift respectively).
        /// </param>
        /// <param name="exclude_range">
        /// range for exclusion bitmap that is constructed to suppress noise around the
        ///  median value.
        /// </param>
        /// <param name="cut">
        /// if true cuts images, otherwise fills the new regions with zeros.
        /// </param>
        public static AlignMTB createAlignMTB(int max_bits, int exclude_range)
        {


            return AlignMTB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createAlignMTB_11(max_bits, exclude_range)));


        }

        /// <summary>
        ///  Creates AlignMTB object
        /// </summary>
        /// <param name="max_bits">
        /// logarithm to the base 2 of maximal shift in each dimension. Values of 5 and 6 are
        ///  usually good enough (31 and 63 pixels shift respectively).
        /// </param>
        /// <param name="exclude_range">
        /// range for exclusion bitmap that is constructed to suppress noise around the
        ///  median value.
        /// </param>
        /// <param name="cut">
        /// if true cuts images, otherwise fills the new regions with zeros.
        /// </param>
        public static AlignMTB createAlignMTB(int max_bits)
        {


            return AlignMTB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createAlignMTB_12(max_bits)));


        }

        /// <summary>
        ///  Creates AlignMTB object
        /// </summary>
        /// <param name="max_bits">
        /// logarithm to the base 2 of maximal shift in each dimension. Values of 5 and 6 are
        ///  usually good enough (31 and 63 pixels shift respectively).
        /// </param>
        /// <param name="exclude_range">
        /// range for exclusion bitmap that is constructed to suppress noise around the
        ///  median value.
        /// </param>
        /// <param name="cut">
        /// if true cuts images, otherwise fills the new regions with zeros.
        /// </param>
        public static AlignMTB createAlignMTB()
        {


            return AlignMTB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createAlignMTB_13()));


        }


        //
        // C++:  Ptr_CalibrateDebevec cv::createCalibrateDebevec(int samples = 70, float lambda = 10.0f, bool random = false)
        //

        /// <summary>
        ///  Creates CalibrateDebevec object
        /// </summary>
        /// <param name="samples">
        /// number of pixel locations to use
        /// </param>
        /// <param name="lambda">
        /// smoothness term weight. Greater values produce smoother results, but can alter the
        ///  response.
        /// </param>
        /// <param name="random">
        /// if true sample pixel locations are chosen at random, otherwise they form a
        ///  rectangular grid.
        /// </param>
        public static CalibrateDebevec createCalibrateDebevec(int samples, float lambda, bool random)
        {


            return CalibrateDebevec.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createCalibrateDebevec_10(samples, lambda, random)));


        }

        /// <summary>
        ///  Creates CalibrateDebevec object
        /// </summary>
        /// <param name="samples">
        /// number of pixel locations to use
        /// </param>
        /// <param name="lambda">
        /// smoothness term weight. Greater values produce smoother results, but can alter the
        ///  response.
        /// </param>
        /// <param name="random">
        /// if true sample pixel locations are chosen at random, otherwise they form a
        ///  rectangular grid.
        /// </param>
        public static CalibrateDebevec createCalibrateDebevec(int samples, float lambda)
        {


            return CalibrateDebevec.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createCalibrateDebevec_11(samples, lambda)));


        }

        /// <summary>
        ///  Creates CalibrateDebevec object
        /// </summary>
        /// <param name="samples">
        /// number of pixel locations to use
        /// </param>
        /// <param name="lambda">
        /// smoothness term weight. Greater values produce smoother results, but can alter the
        ///  response.
        /// </param>
        /// <param name="random">
        /// if true sample pixel locations are chosen at random, otherwise they form a
        ///  rectangular grid.
        /// </param>
        public static CalibrateDebevec createCalibrateDebevec(int samples)
        {


            return CalibrateDebevec.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createCalibrateDebevec_12(samples)));


        }

        /// <summary>
        ///  Creates CalibrateDebevec object
        /// </summary>
        /// <param name="samples">
        /// number of pixel locations to use
        /// </param>
        /// <param name="lambda">
        /// smoothness term weight. Greater values produce smoother results, but can alter the
        ///  response.
        /// </param>
        /// <param name="random">
        /// if true sample pixel locations are chosen at random, otherwise they form a
        ///  rectangular grid.
        /// </param>
        public static CalibrateDebevec createCalibrateDebevec()
        {


            return CalibrateDebevec.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createCalibrateDebevec_13()));


        }


        //
        // C++:  Ptr_CalibrateRobertson cv::createCalibrateRobertson(int max_iter = 30, float threshold = 0.01f)
        //

        /// <summary>
        ///  Creates CalibrateRobertson object
        /// </summary>
        /// <param name="max_iter">
        /// maximal number of Gauss-Seidel solver iterations.
        /// </param>
        /// <param name="threshold">
        /// target difference between results of two successive steps of the minimization.
        /// </param>
        public static CalibrateRobertson createCalibrateRobertson(int max_iter, float threshold)
        {


            return CalibrateRobertson.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createCalibrateRobertson_10(max_iter, threshold)));


        }

        /// <summary>
        ///  Creates CalibrateRobertson object
        /// </summary>
        /// <param name="max_iter">
        /// maximal number of Gauss-Seidel solver iterations.
        /// </param>
        /// <param name="threshold">
        /// target difference between results of two successive steps of the minimization.
        /// </param>
        public static CalibrateRobertson createCalibrateRobertson(int max_iter)
        {


            return CalibrateRobertson.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createCalibrateRobertson_11(max_iter)));


        }

        /// <summary>
        ///  Creates CalibrateRobertson object
        /// </summary>
        /// <param name="max_iter">
        /// maximal number of Gauss-Seidel solver iterations.
        /// </param>
        /// <param name="threshold">
        /// target difference between results of two successive steps of the minimization.
        /// </param>
        public static CalibrateRobertson createCalibrateRobertson()
        {


            return CalibrateRobertson.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createCalibrateRobertson_12()));


        }


        //
        // C++:  Ptr_MergeDebevec cv::createMergeDebevec()
        //

        /// <summary>
        ///  Creates MergeDebevec object
        /// </summary>
        public static MergeDebevec createMergeDebevec()
        {


            return MergeDebevec.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createMergeDebevec_10()));


        }


        //
        // C++:  Ptr_MergeMertens cv::createMergeMertens(float contrast_weight = 1.0f, float saturation_weight = 1.0f, float exposure_weight = 0.0f)
        //

        /// <summary>
        ///  Creates MergeMertens object
        /// </summary>
        /// <param name="contrast_weight">
        /// contrast measure weight. See MergeMertens.
        /// </param>
        /// <param name="saturation_weight">
        /// saturation measure weight
        /// </param>
        /// <param name="exposure_weight">
        /// well-exposedness measure weight
        /// </param>
        public static MergeMertens createMergeMertens(float contrast_weight, float saturation_weight, float exposure_weight)
        {


            return MergeMertens.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createMergeMertens_10(contrast_weight, saturation_weight, exposure_weight)));


        }

        /// <summary>
        ///  Creates MergeMertens object
        /// </summary>
        /// <param name="contrast_weight">
        /// contrast measure weight. See MergeMertens.
        /// </param>
        /// <param name="saturation_weight">
        /// saturation measure weight
        /// </param>
        /// <param name="exposure_weight">
        /// well-exposedness measure weight
        /// </param>
        public static MergeMertens createMergeMertens(float contrast_weight, float saturation_weight)
        {


            return MergeMertens.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createMergeMertens_11(contrast_weight, saturation_weight)));


        }

        /// <summary>
        ///  Creates MergeMertens object
        /// </summary>
        /// <param name="contrast_weight">
        /// contrast measure weight. See MergeMertens.
        /// </param>
        /// <param name="saturation_weight">
        /// saturation measure weight
        /// </param>
        /// <param name="exposure_weight">
        /// well-exposedness measure weight
        /// </param>
        public static MergeMertens createMergeMertens(float contrast_weight)
        {


            return MergeMertens.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createMergeMertens_12(contrast_weight)));


        }

        /// <summary>
        ///  Creates MergeMertens object
        /// </summary>
        /// <param name="contrast_weight">
        /// contrast measure weight. See MergeMertens.
        /// </param>
        /// <param name="saturation_weight">
        /// saturation measure weight
        /// </param>
        /// <param name="exposure_weight">
        /// well-exposedness measure weight
        /// </param>
        public static MergeMertens createMergeMertens()
        {


            return MergeMertens.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createMergeMertens_13()));


        }


        //
        // C++:  Ptr_MergeRobertson cv::createMergeRobertson()
        //

        /// <summary>
        ///  Creates MergeRobertson object
        /// </summary>
        public static MergeRobertson createMergeRobertson()
        {


            return MergeRobertson.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(photo_Photo_createMergeRobertson_10()));


        }


        //
        // C++:  void cv::decolor(Mat src, Mat& grayscale, Mat& color_boost)
        //

        /// <summary>
        ///  Transforms a color image to a grayscale image. It is a basic tool in digital printing, stylized
        ///  black-and-white photograph rendering, and in many single channel image processing applications
        ///  @cite CL12 .
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="grayscale">
        /// Output 8-bit 1-channel image.
        /// </param>
        /// <param name="color_boost">
        /// Output 8-bit 3-channel image.
        /// </param>
        /// <remarks>
        ///  This function is to be applied on color images.
        /// </remarks>
        public static void decolor(Mat src, Mat grayscale, Mat color_boost)
        {
            if (src != null) src.ThrowIfDisposed();
            if (grayscale != null) grayscale.ThrowIfDisposed();
            if (color_boost != null) color_boost.ThrowIfDisposed();

            photo_Photo_decolor_10(src.nativeObj, grayscale.nativeObj, color_boost.nativeObj);


        }


        //
        // C++:  void cv::seamlessClone(Mat src, Mat dst, Mat mask, Point p, Mat& blend, int flags)
        //

        /// <summary>
        ///  Image editing tasks concern either global changes (color/intensity corrections, filters,
        ///  deformations) or local changes concerned to a selection. Here we are interested in achieving local
        ///  changes, ones that are restricted to a region manually selected (ROI), in a seamless and effortless
        ///  manner. The extent of the changes ranges from slight distortions to complete replacement by novel
        ///  content @cite PM03 .
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="p">
        /// Point in dst image where object is placed.
        /// </param>
        /// <param name="blend">
        /// Output image with the same size and type as dst.
        /// </param>
        /// <param name="flags">
        /// Cloning method that could be cv::NORMAL_CLONE, cv::MIXED_CLONE or cv::MONOCHROME_TRANSFER
        /// </param>
        public static void seamlessClone(Mat src, Mat dst, Mat mask, Point p, Mat blend, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (blend != null) blend.ThrowIfDisposed();

            photo_Photo_seamlessClone_10(src.nativeObj, dst.nativeObj, mask.nativeObj, p.x, p.y, blend.nativeObj, flags);


        }


        //
        // C++:  void cv::colorChange(Mat src, Mat mask, Mat& dst, float red_mul = 1.0f, float green_mul = 1.0f, float blue_mul = 1.0f)
        //

        /// <summary>
        ///  Given an original color image, two differently colored versions of this image can be mixed
        ///  seamlessly.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="red_mul">
        /// R-channel multiply factor.
        /// </param>
        /// <param name="green_mul">
        /// G-channel multiply factor.
        /// </param>
        /// <param name="blue_mul">
        /// B-channel multiply factor.
        /// </param>
        /// <remarks>
        ///  Multiplication factor is between .5 to 2.5.
        /// </remarks>
        public static void colorChange(Mat src, Mat mask, Mat dst, float red_mul, float green_mul, float blue_mul)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_colorChange_10(src.nativeObj, mask.nativeObj, dst.nativeObj, red_mul, green_mul, blue_mul);


        }

        /// <summary>
        ///  Given an original color image, two differently colored versions of this image can be mixed
        ///  seamlessly.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="red_mul">
        /// R-channel multiply factor.
        /// </param>
        /// <param name="green_mul">
        /// G-channel multiply factor.
        /// </param>
        /// <param name="blue_mul">
        /// B-channel multiply factor.
        /// </param>
        /// <remarks>
        ///  Multiplication factor is between .5 to 2.5.
        /// </remarks>
        public static void colorChange(Mat src, Mat mask, Mat dst, float red_mul, float green_mul)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_colorChange_11(src.nativeObj, mask.nativeObj, dst.nativeObj, red_mul, green_mul);


        }

        /// <summary>
        ///  Given an original color image, two differently colored versions of this image can be mixed
        ///  seamlessly.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="red_mul">
        /// R-channel multiply factor.
        /// </param>
        /// <param name="green_mul">
        /// G-channel multiply factor.
        /// </param>
        /// <param name="blue_mul">
        /// B-channel multiply factor.
        /// </param>
        /// <remarks>
        ///  Multiplication factor is between .5 to 2.5.
        /// </remarks>
        public static void colorChange(Mat src, Mat mask, Mat dst, float red_mul)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_colorChange_12(src.nativeObj, mask.nativeObj, dst.nativeObj, red_mul);


        }

        /// <summary>
        ///  Given an original color image, two differently colored versions of this image can be mixed
        ///  seamlessly.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src .
        /// </param>
        /// <param name="red_mul">
        /// R-channel multiply factor.
        /// </param>
        /// <param name="green_mul">
        /// G-channel multiply factor.
        /// </param>
        /// <param name="blue_mul">
        /// B-channel multiply factor.
        /// </param>
        /// <remarks>
        ///  Multiplication factor is between .5 to 2.5.
        /// </remarks>
        public static void colorChange(Mat src, Mat mask, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_colorChange_13(src.nativeObj, mask.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::illuminationChange(Mat src, Mat mask, Mat& dst, float alpha = 0.2f, float beta = 0.4f)
        //

        /// <summary>
        ///  Applying an appropriate non-linear transformation to the gradient field inside the selection and
        ///  then integrating back with a Poisson solver, modifies locally the apparent illumination of an image.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="alpha">
        /// Value ranges between 0-2.
        /// </param>
        /// <param name="beta">
        /// Value ranges between 0-2.
        /// </param>
        /// <remarks>
        ///  This is useful to highlight under-exposed foreground objects or to reduce specular reflections.
        /// </remarks>
        public static void illuminationChange(Mat src, Mat mask, Mat dst, float alpha, float beta)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_illuminationChange_10(src.nativeObj, mask.nativeObj, dst.nativeObj, alpha, beta);


        }

        /// <summary>
        ///  Applying an appropriate non-linear transformation to the gradient field inside the selection and
        ///  then integrating back with a Poisson solver, modifies locally the apparent illumination of an image.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="alpha">
        /// Value ranges between 0-2.
        /// </param>
        /// <param name="beta">
        /// Value ranges between 0-2.
        /// </param>
        /// <remarks>
        ///  This is useful to highlight under-exposed foreground objects or to reduce specular reflections.
        /// </remarks>
        public static void illuminationChange(Mat src, Mat mask, Mat dst, float alpha)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_illuminationChange_11(src.nativeObj, mask.nativeObj, dst.nativeObj, alpha);


        }

        /// <summary>
        ///  Applying an appropriate non-linear transformation to the gradient field inside the selection and
        ///  then integrating back with a Poisson solver, modifies locally the apparent illumination of an image.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="alpha">
        /// Value ranges between 0-2.
        /// </param>
        /// <param name="beta">
        /// Value ranges between 0-2.
        /// </param>
        /// <remarks>
        ///  This is useful to highlight under-exposed foreground objects or to reduce specular reflections.
        /// </remarks>
        public static void illuminationChange(Mat src, Mat mask, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_illuminationChange_12(src.nativeObj, mask.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::textureFlattening(Mat src, Mat mask, Mat& dst, float low_threshold = 30, float high_threshold = 45, int kernel_size = 3)
        //

        /// <summary>
        ///  By retaining only the gradients at edge locations, before integrating with the Poisson solver, one
        ///  washes out the texture of the selected region, giving its contents a flat aspect. Here Canny Edge %Detector is used.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="low_threshold">
        /// %Range from 0 to 100.
        /// </param>
        /// <param name="high_threshold">
        /// Value &gt; 100.
        /// </param>
        /// <param name="kernel_size">
        /// The size of the Sobel kernel to be used.
        /// </param>
        /// <remarks>
        ///  @note
        ///  The algorithm assumes that the color of the source image is close to that of the destination. This
        ///  assumption means that when the colors don't match, the source image color gets tinted toward the
        ///  color of the destination image.
        /// </remarks>
        public static void textureFlattening(Mat src, Mat mask, Mat dst, float low_threshold, float high_threshold, int kernel_size)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_textureFlattening_10(src.nativeObj, mask.nativeObj, dst.nativeObj, low_threshold, high_threshold, kernel_size);


        }

        /// <summary>
        ///  By retaining only the gradients at edge locations, before integrating with the Poisson solver, one
        ///  washes out the texture of the selected region, giving its contents a flat aspect. Here Canny Edge %Detector is used.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="low_threshold">
        /// %Range from 0 to 100.
        /// </param>
        /// <param name="high_threshold">
        /// Value &gt; 100.
        /// </param>
        /// <param name="kernel_size">
        /// The size of the Sobel kernel to be used.
        /// </param>
        /// <remarks>
        ///  @note
        ///  The algorithm assumes that the color of the source image is close to that of the destination. This
        ///  assumption means that when the colors don't match, the source image color gets tinted toward the
        ///  color of the destination image.
        /// </remarks>
        public static void textureFlattening(Mat src, Mat mask, Mat dst, float low_threshold, float high_threshold)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_textureFlattening_11(src.nativeObj, mask.nativeObj, dst.nativeObj, low_threshold, high_threshold);


        }

        /// <summary>
        ///  By retaining only the gradients at edge locations, before integrating with the Poisson solver, one
        ///  washes out the texture of the selected region, giving its contents a flat aspect. Here Canny Edge %Detector is used.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="low_threshold">
        /// %Range from 0 to 100.
        /// </param>
        /// <param name="high_threshold">
        /// Value &gt; 100.
        /// </param>
        /// <param name="kernel_size">
        /// The size of the Sobel kernel to be used.
        /// </param>
        /// <remarks>
        ///  @note
        ///  The algorithm assumes that the color of the source image is close to that of the destination. This
        ///  assumption means that when the colors don't match, the source image color gets tinted toward the
        ///  color of the destination image.
        /// </remarks>
        public static void textureFlattening(Mat src, Mat mask, Mat dst, float low_threshold)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_textureFlattening_12(src.nativeObj, mask.nativeObj, dst.nativeObj, low_threshold);


        }

        /// <summary>
        ///  By retaining only the gradients at edge locations, before integrating with the Poisson solver, one
        ///  washes out the texture of the selected region, giving its contents a flat aspect. Here Canny Edge %Detector is used.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="mask">
        /// Input 8-bit 1 or 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="low_threshold">
        /// %Range from 0 to 100.
        /// </param>
        /// <param name="high_threshold">
        /// Value &gt; 100.
        /// </param>
        /// <param name="kernel_size">
        /// The size of the Sobel kernel to be used.
        /// </param>
        /// <remarks>
        ///  @note
        ///  The algorithm assumes that the color of the source image is close to that of the destination. This
        ///  assumption means that when the colors don't match, the source image color gets tinted toward the
        ///  color of the destination image.
        /// </remarks>
        public static void textureFlattening(Mat src, Mat mask, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_textureFlattening_13(src.nativeObj, mask.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::edgePreservingFilter(Mat src, Mat& dst, int flags = 1, float sigma_s = 60, float sigma_r = 0.4f)
        //

        /// <summary>
        ///  Filtering is the fundamental operation in image and video processing. Edge-preserving smoothing
        ///  filters are used in many different applications @cite EM11 .
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output 8-bit 3-channel image.
        /// </param>
        /// <param name="flags">
        /// Edge preserving filters: cv::RECURS_FILTER or cv::NORMCONV_FILTER
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void edgePreservingFilter(Mat src, Mat dst, int flags, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_edgePreservingFilter_10(src.nativeObj, dst.nativeObj, flags, sigma_s, sigma_r);


        }

        /// <summary>
        ///  Filtering is the fundamental operation in image and video processing. Edge-preserving smoothing
        ///  filters are used in many different applications @cite EM11 .
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output 8-bit 3-channel image.
        /// </param>
        /// <param name="flags">
        /// Edge preserving filters: cv::RECURS_FILTER or cv::NORMCONV_FILTER
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void edgePreservingFilter(Mat src, Mat dst, int flags, float sigma_s)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_edgePreservingFilter_11(src.nativeObj, dst.nativeObj, flags, sigma_s);


        }

        /// <summary>
        ///  Filtering is the fundamental operation in image and video processing. Edge-preserving smoothing
        ///  filters are used in many different applications @cite EM11 .
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output 8-bit 3-channel image.
        /// </param>
        /// <param name="flags">
        /// Edge preserving filters: cv::RECURS_FILTER or cv::NORMCONV_FILTER
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void edgePreservingFilter(Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_edgePreservingFilter_12(src.nativeObj, dst.nativeObj, flags);


        }

        /// <summary>
        ///  Filtering is the fundamental operation in image and video processing. Edge-preserving smoothing
        ///  filters are used in many different applications @cite EM11 .
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output 8-bit 3-channel image.
        /// </param>
        /// <param name="flags">
        /// Edge preserving filters: cv::RECURS_FILTER or cv::NORMCONV_FILTER
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void edgePreservingFilter(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_edgePreservingFilter_13(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::detailEnhance(Mat src, Mat& dst, float sigma_s = 10, float sigma_r = 0.15f)
        //

        /// <summary>
        ///  This filter enhances the details of a particular image.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void detailEnhance(Mat src, Mat dst, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_detailEnhance_10(src.nativeObj, dst.nativeObj, sigma_s, sigma_r);


        }

        /// <summary>
        ///  This filter enhances the details of a particular image.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void detailEnhance(Mat src, Mat dst, float sigma_s)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_detailEnhance_11(src.nativeObj, dst.nativeObj, sigma_s);


        }

        /// <summary>
        ///  This filter enhances the details of a particular image.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void detailEnhance(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_detailEnhance_12(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::pencilSketch(Mat src, Mat& dst1, Mat& dst2, float sigma_s = 60, float sigma_r = 0.07f, float shade_factor = 0.02f)
        //

        /// <summary>
        ///  Pencil-like non-photorealistic line drawing
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst1">
        /// Output 8-bit 1-channel image.
        /// </param>
        /// <param name="dst2">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        /// <param name="shade_factor">
        /// %Range between 0 to 0.1.
        /// </param>
        public static void pencilSketch(Mat src, Mat dst1, Mat dst2, float sigma_s, float sigma_r, float shade_factor)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst1 != null) dst1.ThrowIfDisposed();
            if (dst2 != null) dst2.ThrowIfDisposed();

            photo_Photo_pencilSketch_10(src.nativeObj, dst1.nativeObj, dst2.nativeObj, sigma_s, sigma_r, shade_factor);


        }

        /// <summary>
        ///  Pencil-like non-photorealistic line drawing
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst1">
        /// Output 8-bit 1-channel image.
        /// </param>
        /// <param name="dst2">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        /// <param name="shade_factor">
        /// %Range between 0 to 0.1.
        /// </param>
        public static void pencilSketch(Mat src, Mat dst1, Mat dst2, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst1 != null) dst1.ThrowIfDisposed();
            if (dst2 != null) dst2.ThrowIfDisposed();

            photo_Photo_pencilSketch_11(src.nativeObj, dst1.nativeObj, dst2.nativeObj, sigma_s, sigma_r);


        }

        /// <summary>
        ///  Pencil-like non-photorealistic line drawing
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst1">
        /// Output 8-bit 1-channel image.
        /// </param>
        /// <param name="dst2">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        /// <param name="shade_factor">
        /// %Range between 0 to 0.1.
        /// </param>
        public static void pencilSketch(Mat src, Mat dst1, Mat dst2, float sigma_s)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst1 != null) dst1.ThrowIfDisposed();
            if (dst2 != null) dst2.ThrowIfDisposed();

            photo_Photo_pencilSketch_12(src.nativeObj, dst1.nativeObj, dst2.nativeObj, sigma_s);


        }

        /// <summary>
        ///  Pencil-like non-photorealistic line drawing
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst1">
        /// Output 8-bit 1-channel image.
        /// </param>
        /// <param name="dst2">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        /// <param name="shade_factor">
        /// %Range between 0 to 0.1.
        /// </param>
        public static void pencilSketch(Mat src, Mat dst1, Mat dst2)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst1 != null) dst1.ThrowIfDisposed();
            if (dst2 != null) dst2.ThrowIfDisposed();

            photo_Photo_pencilSketch_13(src.nativeObj, dst1.nativeObj, dst2.nativeObj);


        }


        //
        // C++:  void cv::stylization(Mat src, Mat& dst, float sigma_s = 60, float sigma_r = 0.45f)
        //

        /// <summary>
        ///  Stylization aims to produce digital imagery with a wide variety of effects not focused on
        ///  photorealism. Edge-aware filters are ideal for stylization, as they can abstract regions of low
        ///  contrast while preserving, or enhancing, high-contrast features.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void stylization(Mat src, Mat dst, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_stylization_10(src.nativeObj, dst.nativeObj, sigma_s, sigma_r);


        }

        /// <summary>
        ///  Stylization aims to produce digital imagery with a wide variety of effects not focused on
        ///  photorealism. Edge-aware filters are ideal for stylization, as they can abstract regions of low
        ///  contrast while preserving, or enhancing, high-contrast features.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void stylization(Mat src, Mat dst, float sigma_s)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_stylization_11(src.nativeObj, dst.nativeObj, sigma_s);


        }

        /// <summary>
        ///  Stylization aims to produce digital imagery with a wide variety of effects not focused on
        ///  photorealism. Edge-aware filters are ideal for stylization, as they can abstract regions of low
        ///  contrast while preserving, or enhancing, high-contrast features.
        /// </summary>
        /// <param name="src">
        /// Input 8-bit 3-channel image.
        /// </param>
        /// <param name="dst">
        /// Output image with the same size and type as src.
        /// </param>
        /// <param name="sigma_s">
        /// %Range between 0 to 200.
        /// </param>
        /// <param name="sigma_r">
        /// %Range between 0 to 1.
        /// </param>
        public static void stylization(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_Photo_stylization_12(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::cuda::nonLocalMeans(GpuMat src, GpuMat& dst, float h, int search_window = 21, int block_size = 7, int borderMode = BORDER_DEFAULT, Stream stream = Stream::Null())
        //

        // Unknown type 'GpuMat' (I), skipping the function


        //
        // C++:  void cv::cuda::fastNlMeansDenoising(GpuMat src, GpuMat& dst, float h, int search_window = 21, int block_size = 7, Stream stream = Stream::Null())
        //

        // Unknown type 'GpuMat' (I), skipping the function


        //
        // C++:  void cv::cuda::fastNlMeansDenoisingColored(GpuMat src, GpuMat& dst, float h_luminance, float photo_render, int search_window = 21, int block_size = 7, Stream stream = Stream::Null())
        //

        // Unknown type 'GpuMat' (I), skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::inpaint(Mat src, Mat inpaintMask, Mat& dst, double inpaintRadius, int flags)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_inpaint_10(IntPtr src_nativeObj, IntPtr inpaintMask_nativeObj, IntPtr dst_nativeObj, double inpaintRadius, int flags);

        // C++:  void cv::fastNlMeansDenoising(Mat src, Mat& dst, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_13(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::fastNlMeansDenoising(Mat src, Mat& dst, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_14(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize, int normType);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_15(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_16(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_17(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj);

        // C++:  void cv::fastNlMeansDenoisingColored(Mat src, Mat& dst, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, float hColor, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, float hColor, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, float hColor);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_14(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_10(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_11(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_12(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_13(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize);

        // C++:  void cv::fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_14(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize, int normType);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_15(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_16(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_17(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj);

        // C++:  void cv::fastNlMeansDenoisingColoredMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_10(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_11(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_12(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_13(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_14(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize);

        // C++:  void cv::denoise_TVL1(vector_Mat observations, Mat result, double lambda = 1.0, int niters = 30)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_denoise_1TVL1_10(IntPtr observations_mat_nativeObj, IntPtr result_nativeObj, double lambda, int niters);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_denoise_1TVL1_11(IntPtr observations_mat_nativeObj, IntPtr result_nativeObj, double lambda);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_denoise_1TVL1_12(IntPtr observations_mat_nativeObj, IntPtr result_nativeObj);

        // C++:  Ptr_Tonemap cv::createTonemap(float gamma = 1.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemap_10(float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemap_11();

        // C++:  Ptr_TonemapDrago cv::createTonemapDrago(float gamma = 1.0f, float saturation = 1.0f, float bias = 0.85f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_10(float gamma, float saturation, float bias);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_11(float gamma, float saturation);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_12(float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_13();

        // C++:  Ptr_TonemapReinhard cv::createTonemapReinhard(float gamma = 1.0f, float intensity = 0.0f, float light_adapt = 1.0f, float color_adapt = 0.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_10(float gamma, float intensity, float light_adapt, float color_adapt);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_11(float gamma, float intensity, float light_adapt);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_12(float gamma, float intensity);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_13(float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_14();

        // C++:  Ptr_TonemapMantiuk cv::createTonemapMantiuk(float gamma = 1.0f, float scale = 0.7f, float saturation = 1.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_10(float gamma, float scale, float saturation);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_11(float gamma, float scale);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_12(float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_13();

        // C++:  Ptr_AlignMTB cv::createAlignMTB(int max_bits = 6, int exclude_range = 4, bool cut = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_10(int max_bits, int exclude_range, [MarshalAs(UnmanagedType.U1)] bool cut);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_11(int max_bits, int exclude_range);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_12(int max_bits);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_13();

        // C++:  Ptr_CalibrateDebevec cv::createCalibrateDebevec(int samples = 70, float lambda = 10.0f, bool random = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_10(int samples, float lambda, [MarshalAs(UnmanagedType.U1)] bool random);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_11(int samples, float lambda);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_12(int samples);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_13();

        // C++:  Ptr_CalibrateRobertson cv::createCalibrateRobertson(int max_iter = 30, float threshold = 0.01f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateRobertson_10(int max_iter, float threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateRobertson_11(int max_iter);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateRobertson_12();

        // C++:  Ptr_MergeDebevec cv::createMergeDebevec()
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeDebevec_10();

        // C++:  Ptr_MergeMertens cv::createMergeMertens(float contrast_weight = 1.0f, float saturation_weight = 1.0f, float exposure_weight = 0.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_10(float contrast_weight, float saturation_weight, float exposure_weight);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_11(float contrast_weight, float saturation_weight);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_12(float contrast_weight);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_13();

        // C++:  Ptr_MergeRobertson cv::createMergeRobertson()
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeRobertson_10();

        // C++:  void cv::decolor(Mat src, Mat& grayscale, Mat& color_boost)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_decolor_10(IntPtr src_nativeObj, IntPtr grayscale_nativeObj, IntPtr color_boost_nativeObj);

        // C++:  void cv::seamlessClone(Mat src, Mat dst, Mat mask, Point p, Mat& blend, int flags)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_seamlessClone_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj, double p_x, double p_y, IntPtr blend_nativeObj, int flags);

        // C++:  void cv::colorChange(Mat src, Mat mask, Mat& dst, float red_mul = 1.0f, float green_mul = 1.0f, float blue_mul = 1.0f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_colorChange_10(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float red_mul, float green_mul, float blue_mul);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_colorChange_11(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float red_mul, float green_mul);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_colorChange_12(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float red_mul);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_colorChange_13(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::illuminationChange(Mat src, Mat mask, Mat& dst, float alpha = 0.2f, float beta = 0.4f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_illuminationChange_10(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float alpha, float beta);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_illuminationChange_11(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float alpha);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_illuminationChange_12(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::textureFlattening(Mat src, Mat mask, Mat& dst, float low_threshold = 30, float high_threshold = 45, int kernel_size = 3)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_textureFlattening_10(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float low_threshold, float high_threshold, int kernel_size);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_textureFlattening_11(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float low_threshold, float high_threshold);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_textureFlattening_12(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float low_threshold);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_textureFlattening_13(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::edgePreservingFilter(Mat src, Mat& dst, int flags = 1, float sigma_s = 60, float sigma_r = 0.4f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags, float sigma_s, float sigma_r);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags, float sigma_s);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_13(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::detailEnhance(Mat src, Mat& dst, float sigma_s = 10, float sigma_r = 0.15f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_detailEnhance_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s, float sigma_r);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_detailEnhance_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_detailEnhance_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::pencilSketch(Mat src, Mat& dst1, Mat& dst2, float sigma_s = 60, float sigma_r = 0.07f, float shade_factor = 0.02f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_pencilSketch_10(IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj, float sigma_s, float sigma_r, float shade_factor);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_pencilSketch_11(IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj, float sigma_s, float sigma_r);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_pencilSketch_12(IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj, float sigma_s);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_pencilSketch_13(IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj);

        // C++:  void cv::stylization(Mat src, Mat& dst, float sigma_s = 60, float sigma_r = 0.45f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_stylization_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s, float sigma_r);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_stylization_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_stylization_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

    }
}
