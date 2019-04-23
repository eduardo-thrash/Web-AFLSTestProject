namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ModelsPage
    {
        public string ModelModule = "Model";
        public string ModelButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.models #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string ModelSubmit = "div.models > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string ModelFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.models #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextModelFieldSearch = "Field Search";

        public string ModelButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.models #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextModelButtonSearch = "Button Search";

        public string ModelView = "//div[@class='models']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextModelView = "Models element view";

        public string ModelIconRemoved = "//div[@class='models']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextModelIconRemoved = "Delete model icon";

        public string ModelName = ".container-app .container-module .admin .content.col.module .models .details .tabContent.modelsGeneral input[name='Name']";
        public string TextModelName = "Name";

        public string ModelDescription = ".container-app .container-module .admin .content.col.module .models .details .tabContent.modelsGeneral textarea[name='Description']";
        public string TextModelDescription = "Description";

        public string ModelSurvey = "//div[@id='Survey']/div/a[@class='dd-selected']";
        public string TextModelSurvey = "Survey selector";
    }
}