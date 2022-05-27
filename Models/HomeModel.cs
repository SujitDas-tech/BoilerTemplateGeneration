namespace BoilerTemplateGeneration.Models
{
    public class HomeModel
    {
        public IEnumerable<TblBackEnd> TblBackEnd { get; set; }
        public IEnumerable<TblFront> TblFronts { get; set; }
        public int FrontId { get; set; }
        public int BackId { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }

    }
}
