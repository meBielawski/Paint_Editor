

using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using NUnit.Framework;
using PaintEditor;

namespace PaintEditorTests
{
    [TestFixture]
    public class ExportToSvgTests
    {
        private ExportToSvg _exportToSvg;
        private PictureBox _pictureBox;
        private Bitmap _bitmap;

        [SetUp]
        public void Setup()
        {
            _pictureBox = new PictureBox
            {
                Width = 2,
                Height = 2
            };

            _bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            _bitmap.SetPixel(0, 0, Color.FromArgb(255, 255, 0, 0));
            _bitmap.SetPixel(1, 0, Color.FromArgb(255, 0, 255, 0));
            _bitmap.SetPixel(0, 1, Color.FromArgb(255, 0, 0, 255));
            _bitmap.SetPixel(1, 1, Color.FromArgb(0, 0, 0, 0));

            _exportToSvg = new ExportToSvg(_pictureBox, _bitmap);
        }

        [Test]
        public void TestSvgNamespace()
        {
            Assert.AreEqual("http://www.w3.org/2000/svg", _exportToSvg.SvgNamespace());
        }

        [Test]
        public void TestShapeDetails()
        {
           
            var expectedX = 10f;
            var expectedY = 20f;
            var expectedWidth = 30f;
            var expectedHeight = 40f;
            var expectedStrokeColor = Color.Black;
            var expectedFillColor = Color.Red;
            var expectedFilled = true;
            var expectedStrokeThickness = 2f;
            var expectedType = ShapeType.Rectangle;

         
            var shapeDetails = new ShapeDetails()
            {
                X = expectedX,
                Y = expectedY,
                Width = expectedWidth,
                Height = expectedHeight,
                StrokeColor = expectedStrokeColor,
                FillColor = expectedFillColor,
                Filled = expectedFilled,
                StrokeThickness = expectedStrokeThickness,
                Type = expectedType
            };

           
            Assert.AreEqual(expectedX, shapeDetails.X);
            Assert.AreEqual(expectedY, shapeDetails.Y);
            Assert.AreEqual(expectedWidth, shapeDetails.Width);
            Assert.AreEqual(expectedHeight, shapeDetails.Height);
            Assert.AreEqual(expectedStrokeColor, shapeDetails.StrokeColor);
            Assert.AreEqual(expectedFillColor, shapeDetails.FillColor);
            Assert.AreEqual(expectedFilled, shapeDetails.Filled);
            Assert.AreEqual(expectedStrokeThickness, shapeDetails.StrokeThickness);
            Assert.AreEqual(expectedType, shapeDetails.Type);
        }

    }
}