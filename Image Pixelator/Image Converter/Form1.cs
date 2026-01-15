using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Image_Converter
{
    public partial class mainWindow : Form
    {
        Bitmap originalImage;
        Bitmap pixelImage;
        bool fileLoaded = false;

        public mainWindow()
        {
            InitializeComponent();
            // Limit the types of files that can be opened
            openFileDialog.Filter = "Images Files (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
        }

        /// <summary>
        /// Opens the openFileDialog so the user can select an image file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            // Open the file dialog and wait for the OK signal
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                // Attempt to load the file into a Bitmap. If successful, update pixelate button active state and draw the original image to the upper split box
                if (LoadBitmap(openFileDialog.FileName)) {
                    fileLoaded = true;
                    logListBox.Items.Add($"Loaded Image: {openFileDialog.SafeFileName}");
                    pixelateButton.Enabled = true;
                    DrawOriginalImage();
                }
            }
        }

        /// <summary>
        /// Loads the selected image file into a bitmap
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool LoadBitmap(string fileName) {
            // Attempt to load the selected image file into a Bitmap
            try {
                originalImage = new Bitmap(fileName);
                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Triggers the image rescale and image draws
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pixelateButton_Click(object sender, EventArgs e)
        {
            if (fileLoaded) {
                LoadBitmap(openFileDialog.FileName);
                RescaleImage();
                DrawImages();
            }
        }

        /// <summary>
        /// Rescales the image by shrinking it by the scaler factor, then brings it back to full size
        /// </summary>
        private void RescaleImage() {
            logListBox.Items.Add("Rescaling...");

            int scaler = 1;
            int minDimension = 1;

            try {
                // Get the scaler value
                scaler = (int)numericBox.Value;
                minDimension = (int)minimumDimensionBox.Value;
            } catch (Exception ex) {
                logListBox.Items.Add(ex.Message);
            }
            
            // Calculate new size
            int targetWidth = originalImage.Width / scaler;
            int targetHeight = originalImage.Height / scaler;

            // Clamp the target size to be at least the set minimum (avoids returning a blank image on high scaler settings)
            if (targetWidth < minDimension) {targetWidth = minDimension;}
            if (targetHeight < minDimension) {targetHeight = minDimension;}

            Bitmap downscaled = null;
            Graphics graphics = null;

            try {
                // Downscale image
                downscaled = new Bitmap(targetWidth, targetHeight);
                graphics = Graphics.FromImage(downscaled);
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.DrawImage(originalImage, new Rectangle(0, 0, targetWidth, targetHeight));
            } catch (Exception ex) { 
                logListBox.Items.Add("Error while downscaling image: " + ex.Message); 
            }
                  
            if (downscaled != null && graphics != null) {
                try {
                    // Upsize image
                    pixelImage = new Bitmap(originalImage.Width, originalImage.Height);
                    graphics = Graphics.FromImage(pixelImage);
                    graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                    graphics.DrawImage(downscaled, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
                } catch (Exception ex) {
                    logListBox.Items.Add("Error while upscaling image: " + ex.Message); 
                }
            }

            logListBox.Items.Add("Complete");

            saveMenuItem.Enabled = true;
        }

        /// <summary>
        /// Updates the view state between the dual and single image views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showOriginalImageMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // Update button active states
            if (showOriginalImageMenuItem.Checked) {
                RescaledPictureBox.Visible = false;
                SplitOriginalPictureBox.Visible = true;
                SplitRescaledPictureBox.Visible = true;
                logListBox.Items.Add("Switched to split image view");
            } else {
                RescaledPictureBox.Visible = true;
                SplitOriginalPictureBox.Visible = false;
                SplitRescaledPictureBox.Visible = false;
                logListBox.Items.Add("Switched to single image view");
            }
        }

        /// <summary>
        /// Draws only the original image when the view is in split mode
        /// </summary>
        private void DrawOriginalImage() {
            SplitOriginalPictureBox.BackgroundImage = originalImage;
        }

        /// <summary>
        /// Draws the images to the display boxes
        /// </summary>
        /// <param name="pixelImage"></param>
        private void DrawImages() {
            // Draw the original and rescaled images to the appropriate pictureBoxes based on the view state
            SplitOriginalPictureBox.Image = originalImage;
            SplitRescaledPictureBox.Image = pixelImage;
            RescaledPictureBox.Image = pixelImage;
            logListBox.Items.Add("Images redrawn");
        }

        /// <summary>
        /// Saves the file as a jpeg at the same location where the original file came from
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            string originalPath = openFileDialog.FileName;
            string[] parts = originalPath.Split('\\'); // Split original path into its parts seperated by backslashes
            parts[parts.Length - 1] = "Rescaled.jpeg"; // Modify filename to be "Rescaled.jpeg"
            string savePath = string.Join("\\\\", parts); // Rejoin the path into one string
            pixelImage.Save(savePath, ImageFormat.Jpeg); // Save file to same location as original file
            logListBox.Items.Add("Saved to: " + savePath);
        }

        /// <summary>
        /// Updates the visibility state of the log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showLogMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (showLogMenuItem.Checked) {
                logListBox.Visible = true;
                logLabel.Visible = true;
            } else {
                logListBox.Visible = false;
                logLabel.Visible = false;
            }
        }
    }
}
