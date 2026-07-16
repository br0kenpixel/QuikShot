namespace QuikShot
{
    public class ScreenCapture
    {
        public static Bitmap Capture()
        {
            // Get primary screen dimensions
            var bounds = Screen.PrimaryScreen!.Bounds;
            var bitmap = new Bitmap(bounds.Width, bounds.Height);

            using (var g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }

            return bitmap;
        }
    }
}
