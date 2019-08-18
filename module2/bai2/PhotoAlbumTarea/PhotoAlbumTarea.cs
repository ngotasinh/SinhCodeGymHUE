using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoAlbumTarea
{
    class PhotoAlbum
    {
        protected int NumberOfPages;

        public PhotoAlbum()
        {
            NumberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }
    }

    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum() 
        {
            NumberOfPages = 64;
        }
    }

    class AlbumTest
    {
        static void Main()
        {
            var myAlbum1 = new PhotoAlbum();
            Console.WriteLine(myAlbum1.GetNumberOfPages());

            var myAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myAlbum2.GetNumberOfPages());

            var myBigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberOfPages());
            Console.ReadKey();
        }
    }
}
