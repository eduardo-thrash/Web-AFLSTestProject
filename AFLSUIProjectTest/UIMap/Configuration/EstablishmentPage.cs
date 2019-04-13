using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configurationonfiguration.MenuConfiguration
{
    public class EstablishmentPage
    {
        //ListContent

        public string EstablishmentModule = "establishment";

        public string EstablishmentView = "//div[@class='establishment']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //Xpath
        public string TextEstablishmentView = "Establishment view";

        //DetailContent


        public string EstablishmentInputName = ".container-app .container-module .admin .content.col.module .establishment .details .tabContent.svGeneral input[name='Name']";
        public string TextEstablishmentInputName = "Name";
                     
        public string EstablishmentInputId = ".container-app .container-module .admin .content.col.module .establishment .details .tabContent.svGeneral input[name='Code']";
        public string TextEstablishmentInputId = "Identificación";

        public string EstablishmentInputAddress = ".container-app .container-module .admin .content.col.module .establishment .details .tabContent.svGeneral input[name='Address']";
        public string TextEstablishmentInputAddress = "Dirección";
             
        public string EstablishmentSubmit = "div.establishment > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";
        public string TextEstablishmentSubmit = "Save Button";

        public string EstablishmentCancel = "div.establishment > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";
        public string TextEstablishmentCancel = "Cancel Button";
    }
}
