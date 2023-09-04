using System;

namespace ParcelSortingTARgv22
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FirstParcelLine(boxSizes);
        }

        public static bool FirstParcelLine(List<BoxSize> boxSizes)
        {
            bool parcelFits = false;

            foreach (BoxSize box in boxSizes)
            {
                var boxLengthInHalf = box.Length / 2;
                var halfBoxDiagonalNotSquare = (boxLengthInHalf * boxLengthInHalf) + (box.Width * box.Width);
                var halfParcelDiagonal = Math.Sqrt(halfBoxDiagonalNotSquare);

                var lineWidth = 0;

                foreach (SortingLineParam sortingLine in box.SortingLineParams)
                {

                    var cornerDiagonal = Math.Sqrt((sortingLine.Size * sortingLine.Size) + (lineWidth * lineWidth));

                    var maxHeight = Math.Sqrt((lineWidth * lineWidth) - (box.Width * box.Width));
                    var smallHeight = box.Length - maxHeight;
                    var smallDiagonal = Math.Sqrt((smallHeight * smallHeight) + (box.Width * box.Width));

                    if (sortingLine.Size >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and fits", sortingLine.Size);
                    }

                    else if (sortingLine.Size <= halfParcelDiagonal && lineWidth >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and fits", sortingLine.Size);
                    }
                    else if (sortingLine.Size >= smallDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and fits", sortingLine.Size);
                    }
                    else if (sortingLine.Size <= halfParcelDiagonal && sortingLine.Size >= cornerDiagonal)
                    {
                        parcelFits = sortingLine.Size <= halfParcelDiagonal && sortingLine.Size >= cornerDiagonal;

                        var result = parcelFits
                            ? "Sorting line width is " + sortingLine.Size + " and it fits" :
                            "It dosent fit to the sorting line and needs to be wider";
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("It dosent fit to the sorting line and needs to be wider");
                    }

                    lineWidth = sortingLine.Size;
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