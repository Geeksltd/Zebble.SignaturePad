namespace Zebble.Plugin
{
    using System.Reflection;
    using System.Threading.Tasks;
    using Zebble;
    using Olive;

    public partial class SignaturePad : Canvas
    {
        WebView WebView;
        Assembly Assembly => GetType().Assembly;

        public override async Task OnInitializing()
        {
            await base.OnInitializing();
            WebView = new WebView(Assembly, "Zebble").Size(100.Percent());
            await Add(WebView);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();
            WebView.Html = await Assembly.ReadEmbeddedTextFileAsync("Zebble", "Asset/Index.html");
        }
    }
}