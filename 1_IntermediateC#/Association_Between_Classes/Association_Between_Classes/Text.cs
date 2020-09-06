namespace Association_Between_Classes
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            System.Console.WriteLine("Adding hyperlink to TEXT class");
        }
    }
}
