namespace ParcelSortingTARgv22
{
    public class BoxSize
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public List<SortingLineParam> SortingLineParams { get; set; } = 
            new List<SortingLineParam>();
    }

    public class SortingLineParam
    {
        public int Size { get; set; }
    }
}