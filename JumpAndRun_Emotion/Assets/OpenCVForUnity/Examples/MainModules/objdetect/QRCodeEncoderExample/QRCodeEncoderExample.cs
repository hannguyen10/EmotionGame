using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgcodecsModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.ObjdetectModule;
using OpenCVForUnity.UnityUtils;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace OpenCVForUnityExample
{
    /// <summary>
    /// QRCode Encoder Example
    /// An example of QRCode encoding using the QRCodeEncoder class.
    /// https://docs.opencv.org/4.x/d2/dbb/classcv_1_1QRCodeEncoder.html
    /// </summary>
    public class QRCodeEncoderExample : MonoBehaviour
    {
        [Header("Output")]
        /// <summary>
        /// The RawImage for previewing the result.
        /// </summary>
        public RawImage resultPreview;

        [Space(10)]

        /// <summary>
        /// The size of the output QRCode image (px).
        /// </summary>
        public int qrCodeSize = 1000;

        /// <summary>
        /// The encoded info string.
        /// </summary>
        public string encodedInfo = "";

        /// <summary>
        /// The encoded info input field.
        /// </summary>
        public InputField encodedInfoInputField;

        /// <summary>
        /// The save path input field.
        /// </summary>
        public InputField savePathInputField;

        /// <summary>
        /// The QRcode encoder.
        /// </summary>
        QRCodeEncoder qrCodeEncoder;

        /// <summary>
        /// The QRCode img mat.
        /// </summary>
        Mat qrCodeImg;

        /// <summary>
        /// The texture.
        /// </summary>
        Texture2D texture;

        // Use this for initialization
        void Start()
        {
            qrCodeImg = new Mat(qrCodeSize, qrCodeSize, CvType.CV_8UC3);
            texture = new Texture2D(qrCodeImg.cols(), qrCodeImg.rows(), TextureFormat.RGB24, false);

            resultPreview.texture = texture;
            resultPreview.GetComponent<AspectRatioFitter>().aspectRatio = (float)texture.width / texture.height;


            encodedInfoInputField.text = encodedInfo;

            qrCodeEncoder = QRCodeEncoder.create();

            CreateQRCodeImg();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void CreateQRCodeImg()
        {
            if (qrCodeImg.cols() != qrCodeSize)
            {
                qrCodeImg.Dispose();
                qrCodeImg = new Mat(qrCodeSize, qrCodeSize, CvType.CV_8UC3);
                texture = new Texture2D(qrCodeImg.cols(), qrCodeImg.rows(), TextureFormat.RGB24, false);
            }
            else
            {
                qrCodeImg.setTo(Scalar.all(255));
            }

            // Encode QRCode.
            using (Mat qrcodeGRAY = new Mat())
            {
                qrCodeEncoder.encode(encodedInfo, qrcodeGRAY);

                if (!qrcodeGRAY.empty())
                {
                    using (Mat qrcodeRGB = new Mat(qrcodeGRAY.size(), CvType.CV_8UC3))
                    {
                        Imgproc.cvtColor(qrcodeGRAY, qrcodeRGB, Imgproc.COLOR_GRAY2RGB);
                        Imgproc.resize(qrcodeRGB, qrCodeImg, qrCodeImg.size(), 0, 0, Imgproc.INTER_NEAREST);
                    }
                }
                else
                {
                    Imgproc.putText(qrCodeImg, "Too much encoded info.", new Point(5, qrCodeImg.rows() - 30), Imgproc.FONT_HERSHEY_SIMPLEX, 2, new Scalar(0, 0, 0, 255), 2, Imgproc.LINE_AA, false);
                }
            }

            Utils.matToTexture2D(qrCodeImg, texture);
        }

        private void SaveQRCodeImg()
        {
            // save the QRCodeImg.
            string saveDirectoryPath = Path.Combine(Application.persistentDataPath, "QRCodeEncoderExample");
            string savePath = "";
#if UNITY_WEBGL && !UNITY_EDITOR
            string format = "jpg";
            MatOfInt compressionParams = new MatOfInt(Imgcodecs.IMWRITE_JPEG_QUALITY, 100);
#else
            string format = "png";
            MatOfInt compressionParams = new MatOfInt(Imgcodecs.IMWRITE_PNG_COMPRESSION, 0);
#endif

            savePath = Path.Combine(saveDirectoryPath, Uri.EscapeDataString(encodedInfo) + "." + format);

            if (!Directory.Exists(saveDirectoryPath))
            {
                Directory.CreateDirectory(saveDirectoryPath);
            }

            Imgcodecs.imwrite(savePath, qrCodeImg, compressionParams);

            savePathInputField.text = savePath;
            Debug.Log("savePath: " + savePath);
        }

        /// <summary>
        /// Raises the destroy event.
        /// </summary>
        void OnDestroy()
        {
            if (qrCodeEncoder != null)
                qrCodeEncoder.Dispose();

            if (qrCodeImg != null)
                qrCodeImg.Dispose();
        }

        /// <summary>
        /// Raises the back button click event.
        /// </summary>
        public void OnBackButtonClick()
        {
            SceneManager.LoadScene("OpenCVForUnityExample");
        }

        /// <summary>
        /// Raises the encoded info input field value changed event.
        /// </summary>
        public void OnEncodedInfoInputFieldValueChanged(string result)
        {
            encodedInfo = result;
        }

        /// <summary>
        /// Raises the create QRCode img button click event.
        /// </summary>
        public void OnCreateQRCodeImgButtonClick()
        {
            CreateQRCodeImg();
        }

        /// <summary>
        /// Raises the save QRCode img button click event.
        /// </summary>
        public void OnSaveQRCodeImgButtonClick()
        {
            SaveQRCodeImg();
        }
    }
}