namespace backendAPI.Interfaces
{
    public interface ISweater : IProductModel
    {
        /* - Interface Segregation Principle -
         Detta interface ärver ifrån IProductModel som gör det möjligt att skapa flera produkter med samma bas egenskaper
        utan att ändra orginalet */
        public string Size { get; set; }

        public bool HasZipper { get; set; }

    }
}
