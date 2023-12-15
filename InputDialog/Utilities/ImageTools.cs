using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace InputDialog.Utilities;
public static class ImageTools
{
    /// <summary>
    /// Resize the image to the specified width and height.
    /// </summary>
    /// <param name="image">The image to resize.</param>
    /// <param name="width">The width to resize to.</param>
    /// <param name="height">The height to resize to.</param>
    /// <returns>The resized image.</returns>
    public static Bitmap ResizeImage(this Image image, int width, int height)
    {
        var destRect = new Rectangle(0, 0, width, height);
        var destImage = new Bitmap(width, height);

        destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        using (var graphics = Graphics.FromImage(destImage))
        {
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using var wrapMode = new ImageAttributes();
            wrapMode.SetWrapMode(WrapMode.TileFlipXY);
            graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
        }
        return destImage;
    }

    public static Size CalcFitSize(this Image image, int maxWidth, int maxHeight)
    {
        ImageOrientation orientation = ImageOrientation.Square;
        if (image.Width > image.Height)
            orientation = ImageOrientation.Landscape;
        else if (image.Height > image.Width)
        {
            orientation = ImageOrientation.Portrait;
        }
        float portraitProportion = (float)maxHeight / image.Height;
        float landscapeProportion = (float)maxWidth / image.Width;
        float resizeBy = orientation switch
        {
            ImageOrientation.Portrait => portraitProportion,
            ImageOrientation.Landscape => landscapeProportion,
            _ => 1
        };
        var tempNewSize = new Size((int)(image.Width * resizeBy), (int)(image.Height * resizeBy));
        if (orientation == ImageOrientation.Landscape && tempNewSize.Height > maxHeight)
        {
            resizeBy = portraitProportion;
        }
        else if (orientation == ImageOrientation.Portrait && tempNewSize.Width > maxWidth)
        {
            resizeBy = landscapeProportion;
        }
        return new Size((int)(image.Width * resizeBy), (int)(image.Height * resizeBy));
    }
}

public enum ImageOrientation
{
    Portrait,
    Landscape,
    Square
}

