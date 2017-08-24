namespace Zebble.Plugin
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;
    using Zebble;

    public partial class SignaturePad : Canvas
    {
        WebView WebView;
        Assembly Assembly => GetType().GetAssembly();

        public override async Task OnInitializing()
        {
            await base.OnInitializing();
            WebView = new WebView(Assembly, "Zebble").Size(100.Percent());
            await Add(WebView);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();
            WebView.Html = Assembly.ReadEmbeddedTextFile("Zebble", "Asset/Index.html");
        }
    }
}