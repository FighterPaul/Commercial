namespace Commercial_1.Models
{
    public class User_Post_Member
    {
        public int User_Post_MemberId { get; set; }








        public int UserId { get; set; }
        public User User { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
