using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Zebble;

namespace Zebble.Plugin
{
	public partial class SignaturePad : Canvas
	{
		public WebView webView;
		public float Width { get; set; }
		public float Height { get; set; }


		public override async Task OnInitializing()
		{
			await base.OnInitializing();
			webView = new WebView(GetType().GetTypeInfo().Assembly);
			webView.Height(Height);
			webView.Width(Width);
			await Add(webView);
		}

		public override async Task OnPreRender()
		{
			await base.OnPreRender();

			var stream = GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Zebble.Plugin.index.html");

			var streamReader = new StreamReader(stream);
			var html = await streamReader.ReadToEndAsync();
			webView.Html = html;
		}
	}
}
