using System;
using System.Windows.Forms;
using Gecko.DOM;

namespace Gecko.Utils
{
    /// <summary>
    ///  Utility to save ImageElement To Png and To Clipboard
    /// </summary> 
    public class SaveImageElement
    {
        internal static GeckoCanvasElement CreateCanvasOfImageElement(GeckoWebBrowser browser, GeckoHtmlElement element, float xOffset,
                                                           float yOffset, float width, float height)
        {
            if (width == 0)
                throw new ArgumentException("width");

            if (height == 0)
                throw new ArgumentException("height");

            // Some opertations fail without a proper JSContext.
            using (var jsContext = new AutoJSContext())
            {
                GeckoCanvasElement canvas = (GeckoCanvasElement)browser.Document.CreateElement("canvas");
                canvas.Width = (uint)width;
                canvas.Height = (uint)height;

                nsIDOMHTMLCanvasElement canvasPtr = (nsIDOMHTMLCanvasElement)canvas.DomObject;
                nsIDOMCanvasRenderingContext2D context;
                using (var str = new nsAString("2d"))
                {
                    context = (nsIDOMCanvasRenderingContext2D)canvasPtr.MozGetIPCContext(str);
                }

                context.DrawImage((nsIDOMElement)element.DomObject, xOffset, yOffset, width, height, xOffset, yOffset,
                                  width, height, 6);

                return canvas;
            }
        }

        /// <summary>
        /// Need the GeckoWebBrowser , ImageElement , X-OffSet , Y-Offset (put 0.0F if you want offset), Width , height) 
        /// Return the png image in data bytes[] 
        /// </summary>
        public static byte[] ConvertGeckoImageElementToPng(GeckoWebBrowser browser, GeckoHtmlElement element, float xOffset,
                                                           float yOffset, float width, float height)
        {
            GeckoCanvasElement canvas = CreateCanvasOfImageElement(browser, element, xOffset, yOffset, width, height);

            string data = canvas.toDataURL("image/png");
            byte[] bytes = Convert.FromBase64String(data.Substring("data:image/png;base64,".Length));
            return bytes;
        }

        /// <summary>
        /// Need the GeckoWebBrowser , ImageElement , X-OffSet , Y-Offset (put 0.0F if you want offset), Width , height)
        /// Return true if the image was copied in the ClipBoard
        /// </summary>
        public bool CopyGeckoImageElementToPng(GeckoWebBrowser browser, GeckoHtmlElement element, float xOffset,
                                                      float yOffset, float width, float height)
        {
            GeckoCanvasElement canvas = CreateCanvasOfImageElement(browser, element, xOffset, yOffset, width, height);

            string data = canvas.toDataURL("image/png");
            byte[] bytes = Convert.FromBase64String(data.Substring("data:image/png;base64,".Length));
            Clipboard.SetImage(System.Drawing.Image.FromStream(new System.IO.MemoryStream(bytes)));
            return Clipboard.ContainsImage();
        }
    }
}
