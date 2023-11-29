namespace FA.JustBlog.Core.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle {  get; set; }
        public string PostContent {  get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
