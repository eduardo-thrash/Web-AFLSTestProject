namespace AFLSUIProjectTest.UIMap.ConfigurationElementsConfiguration
{
    public class CalendarsPage
    {
        public string CalendarModule = "Calendars";
        public string CalendarButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.calendars #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string CalendarSubmit = "div.calendars > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string CalendarFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.calendars #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextCalendarFieldSearch = "Field Search";

        public string CalendarButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.calendars #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextCalendarButtonSearch = "Button Search";

        public string CalendarView = "//div[@class='calendars']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextCalendarView = "calendar element view";

        public string CalendarTabCalendarInformation = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Calendars";
        public string TextCalendarTabCalendarInformation = "Calendar Information";

        public string CalendarName = ".container-app .container-module .admin .content.col.module .calendars .details .tabContent.svGeneral input[name='Name']";
        public string TextCalendarName = "name";

        public string CalendarDescription = ".container-app .container-module .admin .content.col.module .calendars .details .tabContent.svGeneral textarea[name='Description']";
        public string TextCalendarDescription = "Description";

        public string CalendarTabWorkingHours = "a[href = '#tabs-2'] > span.ui-icon.icon-workingHours.icons_Calendars";
        public string TextCalendarTabWorkingHours = "working Hours";

        public string CalendarAvailabiltty = "#calendar > div > div > table > tbody > tr > td > div > div > div.fc-slats > table > tbody > tr:nth-child(8) > td:nth-child(2)";
        public string TextCalendarAvailabiltty = "Availability block";

        public string CalendarTabNonWorkingDays = "a[href = '#tabs-3'] > span.ui-icon.icon-nonWorkingDays.icons_Calendars";
        public string TextCalendarTabNonWorkingDays = "Non Working Days";

        public string CalendarFieldHoliday = "#Day";
        public string TextCalendarFieldHoliday = "Date field of day";

        public string CalendarHoliday = "body > div:nth-child(18) > div.xdsoft_datepicker.active > div.xdsoft_calendar > table > tbody > tr:nth-child(4) > td.xdsoft_date.xdsoft_day_of_week4.xdsoft_date.xdsoft_weekend > div";
        public string TextCalendarHoliday = "Date of day";

        public string CalendarAddDay = "#addDay";
        public string TextCalendarAddDay = "Add button";

        public string CalendarLoadHolidays = "//div[@class='calendars']//div[@id='tabs-3']//label[@for='loadHolidays']/span";
        public string TextCalendarLoadHolidays = "Check Non Working Days";

        public string ItemViewCalendar = "//div[@class='calendars']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";//XPath

        public string CalendarIconRemoved = "//div[@class='calendars']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextCalendarIconRemoved = "Delete calendar icon";

        public string CalendarSunday = "//div[@class='calendars']//div[@id='tabs-2']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[@class='fc-content-skeleton']/table/tbody/tr/td[2]";
        public string CalendarMonday = "//div[@class='calendars']//div[@id='tabs-2']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[@class='fc-content-skeleton']/table/tbody/tr/td[3]";
        public string CalendarTuesday = "//div[@class='calendars']//div[@id='tabs-2']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[@class='fc-content-skeleton']/table/tbody/tr/td[4]";
        public string CalendarWednesday = "//div[@class='calendars']//div[@id='tabs-2']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[@class='fc-content-skeleton']/table/tbody/tr/td[5]";
        public string CalendarThursday = "//div[@class='calendars']//div[@id='tabs-2']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[@class='fc-content-skeleton']/table/tbody/tr/td[6]";
        public string CalendarFriday = "//div[@class='calendars']//div[@id='tabs-2']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[@class='fc-content-skeleton']/table/tbody/tr/td[7]";
        public string CalendarSaturday = "//div[@class='calendars']//div[@id='tabs-2']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[@class='fc-content-skeleton']/table/tbody/tr/td[8]";

        public string CalendarControl = "/html/body/div[15]/div[1]/div[2]/table/tbody/tr/td[not(contains(@class,'disabled'))]";
    }
}