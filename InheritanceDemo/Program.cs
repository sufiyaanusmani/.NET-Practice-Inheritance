namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("This is my first post", true, "sufiyaanusmani");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("This is my first image post", "sufiyaanusmani", "https://sufiyaan.com", true);
            Console.WriteLine(imagePost1.ToString());
        }
    }
}
