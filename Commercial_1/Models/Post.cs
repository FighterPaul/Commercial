﻿namespace Commercial_1.Models
{
    public class Post
    {



        public int PostId { get; set; }

        public string Title { get; set; }

        public User Creator { get; set; }

        public string Description { get; set; }

        public string Detail { get; set; }


        public string Number { get; set; }


        public string NumberNumber_2 { get; set; }





        public List<User_Post_Member> Member_List { get; set; }


    }
}
