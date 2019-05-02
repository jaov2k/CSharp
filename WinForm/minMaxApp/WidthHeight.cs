/// <summary>
/// Specifies a Width / Height pairs.
/// </summary>
/// 
namespace minMaxApp
{
    class WidthHeight
    {
        public decimal Width { get; set;}
        public decimal Height { get; set;}

        public WidthHeight(){
        }

        public WidthHeight(decimal Wdth, decimal Hght)
        {
            this.Width = Wdth;
            this.Height = Hght;
        }
    }
}
