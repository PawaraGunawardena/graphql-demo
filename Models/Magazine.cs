public class Magazine:  IReadingMaterial, IThings {
    public int IssueNo { get; set; }
    public string Name { get; set; }
    public BookGenre Genre {get; set;}
}