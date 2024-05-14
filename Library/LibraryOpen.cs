using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using Fingerprint.Converter.Class;
using Fingerprint.Converter.Tools;
using System.IO;

namespace Fingerprint.Converter
{
    public class LibraryOpen : IDisposable
    {
        /// <summary>
        /// Variável para uso interno
        /// </summary>
        private byte[] _Image;

        ///// <summary>
        ///// Indica a qualidade da imagem BMP. Ex: Min e Max.
        ///// </summary>
        //public GriauleConstants Quality = GriauleConstants.GRWSQ_JPEG_MIN_QUALITY;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="p_ImageIn"></param>
        public LibraryOpen(byte[] p_ImageIn)
        {
            this._Image = p_ImageIn;
        }

        /// <summary>
        /// Converte o WSQ no formato desejado. Ex: BMP, JPG, PNG
        /// </summary>
        /// <param name="p_Type">Formato da conversão</param>
        /// <returns>Imagem convertida em bytes</returns>
        public byte[] Convert(enumerators.ImageType p_Type)
        {
            try
            {
                WSQ_Decoder dec = new WSQ_Decoder();
                string fileName = string.Format("{0}.{1}", new Random().Next().ToString(), p_Type.ToString());

                ImageFormat format = GetImageFormat(p_Type);
                
                Bitmap bmp = dec.Decode(this._Image);

                if (format != ImageFormat.Bmp /*|| this.Quality == GriauleConstants.GRWSQ_JPEG_MAX_QUALITY*/)
                {
                    bmp.Save(Path.Combine(Environment.CurrentDirectory, fileName), format);
                }
                else
                {
                    bmp.Save(Path.Combine(Environment.CurrentDirectory, fileName));
                }                

                this._Image = File.ReadAllBytes(Path.Combine(Environment.CurrentDirectory, fileName));
                File.Delete(Path.Combine(Environment.CurrentDirectory, fileName));

                return this._Image;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao converter WSQ para " + p_Type + ":\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Converte o WSQ no formato desejado e salva a imagem fisicamente.
        /// </summary>
        /// <param name="p_Type">Formato de conversão</param>
        /// <param name="p_FullPath">Caminho completo da imagem, com extensão</param>
        /// <returns>Caminho da imagem convertida</returns>
        public string ConvertAndSave(enumerators.ImageType p_Type)
        {
            try
            {
                WSQ_Decoder dec = new WSQ_Decoder();
                string fileName = string.Format("{0}.{1}", new Random().Next().ToString(), p_Type.ToString());

                ImageFormat format = GetImageFormat(p_Type);

                Bitmap bmp = dec.Decode(this._Image);

                if (format != ImageFormat.Bmp /*|| this.Quality == GriauleConstants.GRWSQ_JPEG_MAX_QUALITY*/)
                {
                    bmp.Save(Path.Combine(Environment.CurrentDirectory, fileName), format);
                }
                else
                {
                    bmp.Save(Path.Combine(Environment.CurrentDirectory, fileName));
                }
                
                return Path.Combine(Environment.CurrentDirectory, fileName);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao converter WSQ para " + p_Type + ":\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Converte o WSQ no formato e no local desejado
        /// </summary>
        /// <param name="p_Type">Formato de conversão</param>
        /// <param name="p_FullPath">Caminho da imagem convertida</param>
        public void ConvertAndSave(enumerators.ImageType p_Type, string p_FullPath)
        {
            try
            {
                WSQ_Decoder dec = new WSQ_Decoder();
                string fileName = string.Format("{0}.{1}", new Random().Next().ToString(), p_Type.ToString());

                if (!string.IsNullOrEmpty(p_FullPath))
                {
                    int index = p_FullPath.LastIndexOf(".");

                    if (index == -1)
                    {
                        fileName = string.Format("{0}.{1}", p_FullPath, p_Type.ToString());
                    }
                    else
                    {
                        fileName = string.Format("{0}.{1}", p_FullPath.Substring(0, index), p_Type.ToString());
                    }
                }

                ImageFormat format = GetImageFormat(p_Type);

                Bitmap bmp = dec.Decode(this._Image);

                if (format != ImageFormat.Bmp /*|| this.Quality == GriauleConstants.GRWSQ_JPEG_MAX_QUALITY*/)
                {
                    bmp.Save(Path.Combine(Environment.CurrentDirectory, fileName), format);
                }
                else
                {
                    bmp.Save(Path.Combine(Environment.CurrentDirectory, fileName));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao converter WSQ para " + p_Type + ":\n\n" + ex.Message);
            }
        }
        
        /// <summary>
        /// Auto Dispose
        /// </summary>
        public void Dispose()
        {
            this._Image = null;
        }

        /// <summary>
        /// Obter ImageFormat baseando no ImageType
        /// </summary>
        /// <param name="p_Type">ImageType</param>
        /// <returns>ImageFormat</returns>
        private ImageFormat GetImageFormat(enumerators.ImageType p_Type)
        {
            switch (p_Type)
            {
                case enumerators.ImageType.BMP:
                    return ImageFormat.Bmp;

                case enumerators.ImageType.GIF:
                    return ImageFormat.Gif;

                case enumerators.ImageType.ICO:
                    return ImageFormat.Icon;

                case enumerators.ImageType.JPG:
                    return ImageFormat.Jpeg;

                case enumerators.ImageType.PNG:
                    return ImageFormat.Png;

                case enumerators.ImageType.TIFF:
                    return ImageFormat.Tiff;

                case enumerators.ImageType.WMF:
                    return ImageFormat.Wmf;

                default:
                    throw new NotImplementedException("O tipo de arquivo informado não é implementado");
            }
        }
    }
}
