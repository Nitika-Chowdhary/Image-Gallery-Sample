using System;

namespace Gallery
{
    abstract class Image
    {
        public abstract void View();
    }

    class Jpeg: Image
    {
        public override void View()
        {
            Console.WriteLine("Viewing image of JPEG type");
        }
    }

    class Png: Image
    {
        
        public override void View()
        {
            Console.WriteLine("Viewing image of PNG type");
        }
    }

    class Gif: Image
    {
        public override void View()
        {
            Console.WriteLine("Viewing image of GIF type");
        }
    }
    
    class Gallery
    {
        private int current;
        private Image[] images;
        public Gallery(Image[] images)
        {
            this.images = images;
            this.current = 0;
            this.images[0].View();
        }

        public void Next() {
            this.current++;
            int noOfImages = this.images.Length;
            if (this.current == noOfImages)
            {
                this.current = 0;
            }
            this.images[this.current].View();
        }

        public void previous()
        {
            this.current--;
            int noOfImages = this.images.Length;
            if (this.current == -1)
            {
                this.current = noOfImages - 1;
            }
            this.images[this.current].View();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Image[] img = new Image[3];
            img[0] = new Jpeg();
            img[1] = new Png();
            img[2] = new Gif();
            Gallery gallery = new Gallery(img);
           
            gallery.Next();
            gallery.previous();
            gallery.previous();
            gallery.previous();
            gallery.previous();
            gallery.previous();
            gallery.previous();
            gallery.Next();
            gallery.Next();
            gallery.Next();
            gallery.Next();
            gallery.Next();
            gallery.Next();
        }
    }
}
