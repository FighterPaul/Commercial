namespace Commercial_1.Models
{
    public class User
    {
        public int UserId { get; set; }


        public string Firstname { get; set; }


        public List<Post> Post_List { get; set; }
        public List<User_Post_Member> Attend_List { get; set; }
    }
}
