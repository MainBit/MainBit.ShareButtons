using MainBit.ShareButtons.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace MainBit.ShareButtons
{
    public class Migrations : DataMigrationImpl {

        public int Create() {

            ContentDefinitionManager.AlterPartDefinition(
                typeof(ShareButtonsPart).Name, cfg => cfg.Attachable());

            ContentDefinitionManager.AlterTypeDefinition("ShareButtonsWidget", cfg => cfg
            .WithPart("ShareButtonsPart")
            .WithPart("WidgetPart")
            .WithPart("CommonPart")
            .WithSetting("Stereotype", "Widget"));

            return 1;
        }
    }
}