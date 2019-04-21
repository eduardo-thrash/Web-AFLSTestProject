namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ChronometersPage
    {
        public string ChronometerModule = "Chronometer";
        public string ChronometerButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.chronometers #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string ChronometerSubmit = "div.chronometers > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string TabChronometerdetail = "a[href = '#tabs-1'] > span.ui-icon.icon-stopwatches.icons_St";
        public string TextTabChronometerdetail = "Chronometer detail tab";

        public string ChronometerInputSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.chronometers #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextChronometerInputSearch = "Field Search";

        public string ChronometerButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.chronometers #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextChronometerButtonSearch = "Button Search";

        public string ChronometerItemView = "//div[@class='chronometers']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextChronometerItemView = "chronometer element view";

        public string ChronometerName = ".container-app .container-module .admin .content.col.module .chronometers .details .tabContent.general input[name='Name']";//CssSelector
        public string TextChronometerName = "name";

        public string ChronometerDescription = ".container-app .container-module .admin .content.col.module .chronometers .details .tabContent.general textarea[name='Description']";//CssSelector
        public string TextChronometerDescription = "Description";

        public string ChronometerIconRemoved = "//div[@class='chronometers']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='Button1']";
        public string TextChronometerIconRemoved = "Delete chronometer icon";

        public string ChronometerViewNoFound = "//div[@class='mCSB_container mCS_y_hidden mCS_no_scrollbar_y']/div/div";
    }
}