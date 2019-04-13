using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class SkillsPage
    {
        public string SkillModule;

        //List Content   
        public string InputSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.skills #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string ButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.skills #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string ButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.skills #content > div.center.header.row > div > div.btnSearch #commonNewItem";

        public string SkillTitleItemView = "//div[@class='skills']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //XPath

        public string SkillIconRemoved = "//div[@class='skills']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";//XPath
        public string TextSkillIconRemoved = "Delete skill icon";

        //Detail Content Tab Skills
        public string SkillTabSkills = "//div[@class='skills']/div[@id='rightsidebar']/div[@class='content']/div[@class='row top']/div/ul/li/a[@href='#tabs-1']";//XPath
        public string SkillInputSkillName = ".container-app .container-module .admin .content.col.module .skills .details .tabContent.svGeneral input[name='Name']";
        public string SkillTextareaSkillDescription = ".container-app .container-module .admin .content.col.module .skills .details .tabContent.svGeneral textarea[name='Description']";

        //public string SkillState = "//div[@class='skills']/div[@id='rightsidebar']/div[@class='content']/div[@class='row top']/div/[@id='tabs-1']/div/form/div[4]/div[1]/div[2]/label/div[1]";
        public string SkillStatb = "//div[@class='skills']/div[@id='rightsidebar']/div[@class='content']/div[@class='row top']/div[@id='tabs-1']/div/form/div[@class='row bottom']/div/div[@class='onoffswitch']/label/div[@class='onoffswitch-inner']";
        public string SkillState = "//div[@id='tabs-1']/div/form/div[3]/div/div[2]/label/div[1]";

        public string SkillButtonSubmit = "div.skills > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";
        public string SkillButtonCancel = "div.skills > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";

        //Text
        public string TextSkillTitleItemView = "Skill item view";
        public string TextInputSearch = "Search field";
        public string TextButtonSearch = "Search button";
        public string TextButtonNew = "new button";

        public string TextSkillTabSkills = "Skills tab";
        public string TextSkillInputSkillName = "Name field";
        public string TextSkillTextareaSkillDescription = "Field description";

        public string TextSkillState = "Status switch";

        public string TextSkillButtonSubmit = "Submit button";
        public string TextSkillButtonCancel = "Cancel button";
    }
}
