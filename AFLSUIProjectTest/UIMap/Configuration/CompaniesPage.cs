namespace AFLSUIProjectTest.UIMap
{
    //public class nativeOBject {
    //    public string viewName { set; get; }
    //    public string textViewName { set; get; }

    //    public internalName

    //}

    public class CompaniesPage
    {
        //List<nativeOBject> listadoObjetos = new List<nativeOBject>();

        //public ElementsCompanies() {
        //    this.listadoObjetos.Where(w => w.textViewName == "abc").ToList();

        //    this.listadoObjetos.Add(new nativeOBject()
        //    {
        //        viewName = "body > div.frameworks > div > div.base.container - module.bottom.row > div > div.content.col.module > div.companies #content > div.center.header.row > div > div.searchBox #inputSearch",
        //        textViewName = "Field Search""
        //    });

        //    this.listadoObjetos.Add(new nativeOBject()
        //    {
        //        viewName = "body > div.frameworks > div > div.base.container - module.bottom.row > div > div.content.col.module > div.companies #content > div.center.header.row > div > div.searchBox #inputSearch",
        //        textViewName = "Field Search""
        //    });
        //    this.listadoObjetos.Add(new nativeOBject()
        //    {
        //        viewName = "body > div.frameworks > div > div.base.container - module.bottom.row > div > div.content.col.module > div.companies #content > div.center.header.row > div > div.searchBox #inputSearch",
        //        textViewName = "Field Search""

        //    });

        //    this.listadoObjetos.Add(new nativeOBject()
        //    {
        //        viewName = "body > div.frameworks > div > div.base.container - module.bottom.row > div > div.content.col.module > div.companies #content > div.center.header.row > div > div.searchBox #inputSearch",
        //        textViewName = "Field Search""
        //    });

        //    this.listadoObjetos.Add(new nativeOBject()
        //    {
        //        viewName = "body > div.frameworks > div > div.base.container - module.bottom.row > div > div.content.col.module > div.companies #content > div.center.header.row > div > div.searchBox #inputSearch",
        //        textViewName = "Field Search""
        //    });
        //}

        public string CompanyModule = "Companies";

        public string CompanyFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.companies #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextCompanyFieldSearch = "Field Search";

        public string CompanyButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.companies #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextCompanyButtonSearch = "Button Search";

        public string CompanyButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.companies #content > div.center.header.row > div > div.btnSearch #commonNewItem";

        public string CompanyView = "//div[@class='companies']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextCompanyView = "companies element view";

        public string CompanyIconRemoved = "//div[@class='companies']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextCompanyIconRemoved = "Delete companies icon";

        /*Tab Company*/
        public string CompanyTabCompany = "span.ui-icon.icon-general.icons_Cm";
        public string CompanyName = ".container-app .container-module .admin .content.col.module .companies .details .tabContent.svGeneral input[name= 'Name']";
        public string CompanyUniqueReference = ".container-app .container-module .admin .content.col.module .companies .details .tabContent.svGeneral input[name= 'UniqueReference']";
        public string CompanyContactName = ".container-app .container-module .admin .content.col.module .companies .details .tabContent.svGeneral input[name= 'ContactName']";
        public string CompanyPhone = ".container-app .container-module .admin .content.col.module .companies .details .tabContent.svGeneral input[name= 'ContactPhone']";
        public string CompanyAddress = ".container-app .container-module .admin .content.col.module .companies .details .tabContent.svGeneral input[name= 'Address']";
        public string CompanyEmail = ".container-app .container-module .admin .content.col.module .companies .details .tabContent.svGeneral input[name= 'ContactEmail']";

        public string TextCompanyTabCompany = "Company tab";
        public string TextCompanyName = "Name";

        public string TextCompanyUniqueReference = "UniqueReference";
        public string TextCompanyContactName = "ContactName";
        public string TextCompanyPhone = "ContactPhone";
        public string TextCompanyAddress = "Address'";
        public string TextCompanyEmail = "ContactEmail";

        /*Tab Services*/
        public string CompanyTabServices = "a[href = '#tabs-2'] > span.ui-icon.icon-services.icons_Cm";
        public string CompanyServices = "input.partSearch.ui-autocomplete-input";

        public string TextCompanyTabServices = "Services tab";
        public string TextCompanyServices = "company services";

        /*Tab Additional Fields*/
        public string CompanyTabAdditionalFields = "a[href = '#tabs-3'] > span.ui-icon.icon-additionalfields.icons_Cm";
        public string TextCompanyTabAdditionalFields = "AdditionalFields tab";

        public string CompanySubmit = "div.companies > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";
    }
}