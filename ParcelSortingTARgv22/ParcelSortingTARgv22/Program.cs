namespace ParcelSortingTARgv22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FirstParcelLine(boxSizes);
        }

        static bool FirstParcelLine(List<BoxSize> boxSizes)
        {
            bool parcelFits = false;

            foreach (BoxSize box in boxSizes)
            {
                var boxLengthInHalf = box.Length / 2;
                var halfBoxDiagonalNotSquare = (boxLengthInHalf * boxLengthInHalf) + (box.Width * box.Width);
                var halfParcelDiagonal = Math.Sqrt(halfBoxDiagonalNotSquare);


                foreach (SortingLineParam sortingLine in box.SortingLineParams)
                {

                    if (sortingLine.Size >= box.Width || sortingLine.Size >= box.Length)
                    {
                        Console.WriteLine("Parcel fits to sorting line");
                    }
                    if (sortingLine.Size >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and it fits", sortingLine.Size);
                    }
                }

                Console.WriteLine("\n");
            }

            return parcelFits;
        }


        public static readonly List<BoxSize> boxSizes = new List<BoxSize>
        {
            new BoxSize
            {
                Length = 120,
                Width = 60,
                SortingLineParams = new List<SortingLineParam> 
                {
                    new SortingLineParam
                    {
                        Size = 100
                    },
                    new SortingLineParam
                    {
                        Size = 75
                    }
                }
            },

            new BoxSize
            {
                Length = 100,
                Width = 35,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Size = 75
                    },
                    new SortingLineParam
                    {
                        Size = 50
                    },
                    new SortingLineParam
                    {
                        Size = 80
                    },
                    new SortingLineParam
                    {
                        Size = 100
                    },
                    new SortingLineParam
                    {
                        Size = 37
                    }
                }
            },

            new BoxSize
            {
                Length = 70,
                Width = 50,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Size = 60
                    },
                    new SortingLineParam
                    {
                        Size = 60
                    },
                    new SortingLineParam
                    {
                        Size = 55
                    },
                    new SortingLineParam
                    {
                        Size = 90
                    }
                }
            }
        };
    }
}