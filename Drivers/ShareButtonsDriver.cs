using MainBit.ShareButtons.Models;
using Orchard;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.UI.Resources;
using Orchard.Utility.Extensions;

namespace MainBit.ShareButtons.Drivers
{
    public class ShareButtonsDriver : ContentPartDriver<ShareButtonsPart>
    {
        private readonly IWorkContextAccessor _wca;

        public ShareButtonsDriver(
            IWorkContextAccessor workContextAccessor)
        {
            _wca = workContextAccessor;
        }

        protected override DriverResult Display(ShareButtonsPart part, string displayType, dynamic shapeHelper)
        {
            if (displayType != "Detail") {
                return null;
            }

            //var autoroutePart = part.ContentItem.As<Orchard.Autoroute.Models.AutoroutePart>();
            //if (autoroutePart == null || string.IsNullOrEmpty(autoroutePart.Path)) {
            //    return null;
            //}

            var request = _wca.GetContext().HttpContext.Request;
            string url = request.ToApplicationRootUrlString() + request.Url.AbsolutePath;

            return ContentShape("Parts_ShareButtons_AddThis",
                () => shapeHelper.Parts_ShareButtons_AddThis(Url: url, Prefix: Prefix));
            
            //return ContentShape("Parts_ShareButtons",
            //                            () => shapeHelper.DisplayTemplate(
            //                                TemplateName: "Parts/AddThis",
            //                                Model: url,
            //                                Prefix: Prefix));
        }
    }
}