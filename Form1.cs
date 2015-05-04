using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchImageResizer
{
    public partial class Form1 : Form
    {

        private List<String> arquivosEncontrados = new List<string>();

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionaPasta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                txtNomePasta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnLerEstrutura_Click(object sender, EventArgs e)
        {
            if (txtNomePasta.Text != null && txtNomePasta.Text.Length > 0)
            {
                lblArquivosEncontrados.Text = "";
                arquivosEncontrados.Clear();
                folderSearch(txtNomePasta.Text);
                lblArquivosEncontrados.Text = arquivosEncontrados.Count.ToString();
            }
        }

        private void folderSearch(String fileName)
        {            
            if (Directory.Exists(fileName))
            {                
                String[] arquivos = Directory.GetFiles(fileName, "*.jpg", SearchOption.AllDirectories);
                arquivosEncontrados.AddRange(arquivos);
                textBox.AppendText(arquivos.Count().ToString() + " arquivos localizados\n");                

                //foreach (String arquivo in arquivos)
                //{
                //    textBox.AppendText("file: " + arquivo);
                //    textBox.AppendText("\n");
                //        arquivosEncontrados.Add(arquivo);
            }
            //    String[] subPastas = Directory.GetDirectories(fileName);
            //    foreach (String subPasta in subPastas)
            //    {
            //        folderSearch(subPasta);
            //    }
            //}
            //else
            //{
            //    textBox.AppendText("PASTA NÃO ENCONTRADA: " + fileName);
            //    textBox.AppendText("\n");                    
            //}
        }

        private void btnIniciarReducao_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            long qtdReduzidos = 0;
            foreach (String imagem in arquivosEncontrados)
            {

                if (new System.IO.FileInfo(imagem).Length < 307200)
                {
                    continue;    
                }
                
                String imagemSemExtensao = imagem.Replace(".jpg", "");
                String nomeCopia = imagemSemExtensao + ".original.jpg";
                File.Copy(imagem, nomeCopia);
                File.Delete(imagem);

                Image image = Image.FromFile(nomeCopia);
                Image newImage = ScaleImage(image, 400, 500);
                newImage.Save(imagem, ImageFormat.Jpeg);
                image.Dispose();
                newImage.Dispose();
                File.Delete(nomeCopia);

                progressBar1.PerformStep();
                lblQtdReduzidos.Text = (++qtdReduzidos).ToString();
                
                // First load the image somehow
                // Image myImage = Image.FromFile(nomeCopia, true);
                // Save the image with a quality of 50% 
                // SaveJpeg(imagem, myImage, 50); 
            }
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        /// <summary> 
        /// Saves an image as a jpeg image, with the given quality 
        /// </summary> 
        /// <param name="path"> Path to which the image would be saved. </param> 
        /// <param name="quality"> An integer from 0 to 100, with 100 being the highest quality. </param> 
        public static void SaveJpeg(string path, Image img, int quality)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");

            // Encoder parameter for image quality 
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            // JPEG image codec 
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            img.Save(path, jpegCodec, encoderParams);
        }

        /// <summary> 
        /// Returns the image codec with the given mime type 
        /// </summary> 
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats 
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec 
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];

            return null;
        }

        private static void ajustaDPI(String arquivo, String destino) {

             using (Bitmap bitmap = (Bitmap)Image.FromFile(arquivo))
                {
                    using (Bitmap newBitmap = new Bitmap(bitmap))
                    {
                        newBitmap.SetResolution(300, 300);
                        newBitmap.Save(destino, ImageFormat.Jpeg);
                    }
                }
        }

    }
}
