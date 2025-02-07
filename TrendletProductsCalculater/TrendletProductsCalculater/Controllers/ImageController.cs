using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using TrendletProductsCalculater.Helper;

public class ImageController : Controller
{
    private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#A7A7A7"); // Adjust this to match your image


    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ImageGenerator([FromBody] ImageGenerationModel model)
    {
        var tempFolder = Path.Combine(Path.GetTempPath(), "GeneratedImages");
        if (!Directory.Exists(tempFolder))
        {
            Directory.CreateDirectory(tempFolder);
        }

        List<string> generatedFiles = new List<string>();

        for (int i = 0; i < model.Contents.Count; i++)
        {
            string text = model.Contents[i];
            string fileName = $"Image_{i + 1}.png";
            string filePath = Path.Combine(tempFolder, fileName);

            GenerateImage(text, model.ImageHeight, model.ImageWidth, filePath);
            generatedFiles.Add(filePath);
        }

        string zipPath = Path.Combine(tempFolder, "GeneratedImages.zip");
        if (System.IO.File.Exists(zipPath))
        {
            System.IO.File.Delete(zipPath);
        }

        using (var zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
        {
            foreach (var file in generatedFiles)
            {
                zipArchive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
        }

        return PhysicalFile(zipPath, "application/zip", "GeneratedImages.zip");
    }

    private void GenerateImage(string text, int width, int height, string filePath)
    {
        using (var bitmap = new Bitmap(width, height))
        using (var graphics = Graphics.FromImage(bitmap))
        {
            graphics.Clear(BackgroundColor);
            graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            var font = new Font("Arial", 40, FontStyle.Bold);
            var textColor = Brushes.Black;

            // Format text for Arabic alignment
            var format = new StringFormat
            {
                Alignment = StringAlignment.Center, // Center text horizontally
                LineAlignment = StringAlignment.Center, // Center text vertically
                FormatFlags = StringFormatFlags.DirectionRightToLeft // Ensure Arabic text direction
            };

            // Split text into lines
            string[] lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Measure text height dynamically
            float lineHeight = graphics.MeasureString("Sample", font).Height;
            float totalTextHeight = lineHeight * lines.Length;

            // Adjust vertical centering with padding
            float paddingOffset = 20; // Adjust to prevent first-line cropping
            float yStart = (height - totalTextHeight) / 2 + paddingOffset;

            // Center text horizontally
            float xCenter = width / 2;

            // Draw each line properly aligned
            for (int i = 0; i < lines.Length; i++)
            {
                var textSize = graphics.MeasureString(lines[i], font);
                var textPosition = new PointF(xCenter, yStart + (i * lineHeight));

                graphics.DrawString(lines[i], font, textColor, textPosition, format);
            }

            bitmap.Save(filePath, ImageFormat.Png);
        }
    }





}
