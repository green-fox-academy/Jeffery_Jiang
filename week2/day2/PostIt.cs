using System;

namespace someexersice
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            PostIt t1=new PostIt("orange","Idea 1","blue");

            PostIt t2=new PostIt("pink","Awesome","black");

            PostIt t3=new PostIt("yello","Superb!","green");
        }


    }
    class PostIt
    {
        public string BackGroundColor;
        public string Text;
        public string TextColor;

        public PostIt(string BackGroundColor, string Text, string TextColor)
        {
            this.Text = Text;
            this.BackGroundColor = BackGroundColor;
            this.TextColor = TextColor;
        }
    }
}