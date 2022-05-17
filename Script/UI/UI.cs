using FontStashSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Myra;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;

public static class UI
{
    public static ImageTextButton DefaultTextButton(string txt, FontSystem font)
    {
        ImageTextButton DefaultTextButton = new ImageTextButton();
        DefaultTextButton.TextColor = Color.White;
        DefaultTextButton.Font = font.GetFont(50);
        DefaultTextButton.Text = txt;
        DefaultTextButton.TextPosition = ImageTextButton.TextPositionEnum.OverlapsImage;
        DefaultTextButton.LabelHorizontalAlignment = HorizontalAlignment.Center;
        DefaultTextButton.LabelVerticalAlignment = VerticalAlignment.Center;

        DefaultTextButton.Image = new TextureRegion(MyraEnvironment.Game.Content.Load<Texture2D>("UI/button/Normal"));
        DefaultTextButton.OverImage = new TextureRegion(MyraEnvironment.Game.Content.Load<Texture2D>("UI/button/Overed"));
        DefaultTextButton.PressedImage = new TextureRegion(MyraEnvironment.Game.Content.Load<Texture2D>("UI/button/Pressed"));
        DefaultTextButton.Background = new SolidBrush("#00000000");
        DefaultTextButton.OverBackground = new SolidBrush("#00000000");
        DefaultTextButton.PressedBackground = new SolidBrush("#00000000");

        DefaultTextButton.Width = 300;
        DefaultTextButton.Height = 60;
        DefaultTextButton.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
        DefaultTextButton.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
        return DefaultTextButton;
    }
}