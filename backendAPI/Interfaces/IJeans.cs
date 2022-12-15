namespace backendAPI.Interfaces
{
    public interface IJeans : IProductModel
    {
        public bool IsStretched { get; set; }

        public string Size { get; set; }
    }
}
