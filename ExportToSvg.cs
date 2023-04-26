using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace PaintEditor
{
    public class ExportToSvg
    {
        private PictureBox pictureBox1;
        private Bitmap bmp;

        public ExportToSvg(PictureBox pictureBox1, Bitmap bmp)
        {
            this.pictureBox1 = pictureBox1;
            this.bmp = bmp;
        }

        public string SvgNamespace()
        {
            return "http://www.w3.org/2000/svg";
        }

        public void ExportSvg()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SVG Files|*.svg";
            saveFileDialog.Title = "Export to SVG";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(path))
                {
                    using (XmlWriter xml = new XmlTextWriter(sw))
                    {
                        xml.WriteStartDocument();
                        xml.WriteStartElement("svg", SvgNamespace());
                        xml.WriteAttributeString("width", pictureBox1.Width.ToString());
                        xml.WriteAttributeString("height", pictureBox1.Height.ToString());

                        for (int x = 0; x < pictureBox1.Width; x++)
                        {
                            for (int y = 0; y < pictureBox1.Height; y++)
                            {
                                Color pixelColor = bmp.GetPixel(x, y);
                                if (pixelColor.A != 0)
                                {
                                    xml.WriteStartElement("rect", SvgNamespace());
                                    xml.WriteAttributeString("x", x.ToString());
                                    xml.WriteAttributeString("y", y.ToString());
                                    xml.WriteAttributeString("width", "1");
                                    xml.WriteAttributeString("height", "1");
                                    xml.WriteAttributeString("fill", "#" + pixelColor.R.ToString("X2") + pixelColor.G.ToString("X2") + pixelColor.B.ToString("X2"));
                                    xml.WriteEndElement();
                                }
                            }
                        }

                        xml.WriteEndElement();
                        xml.WriteEndDocument();
                        xml.Flush();
                    }
                }

                MessageBox.Show("Image saved to SVG", "SVG Save",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
