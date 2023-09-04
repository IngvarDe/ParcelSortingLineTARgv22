using ParcelSortingTARgv22;


namespace ParcelSorting.Test
{
    public class ParcelSortingTest
    {
        [Fact]
        public void When_ParcelHasNewDimenions_ThenParcelCanNotFitSortingLine()
        {
            var boxSizes = new List<BoxSize>()
            {
                new BoxSize
                {
                    Length = 20,
                    Width = 20,
                    SortingLineParams = new List<SortingLineParam>()
                    {
                        new SortingLineParam
                        {
                            Size = 50,
                        },
                        new SortingLineParam
                        {
                            Size = 50,
                        },
                    }
                }
            };

            bool result = Program.FirstParcelLine(boxSizes);


            Assert.Equal(result);
        }
    }
}
