using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterTwitter : IFilter
    {
        private static int counter = 0;
        public static int Counter
        {
            get
            {
                return counter;
            }
        }
        public IPicture Filter(IPicture image)
        {
            counter++;
            var twitter = new TwitterImage();
            twitter.PublishToTwitter("This is a test", $@"LukeStep{counter}.jpg");
            return image;
        }
    }
}