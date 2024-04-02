using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    /// <summary>
    /// Главная панель приложения
    /// </summary>
    public class MobileMainPanel
    {
        public OpenThreeDotsMainPage OpenThreeDots()
        {
            var ThreeDotsBtn = new MobileItem("(//android.widget.ImageView[@resource-id=\"com.bitrix24.android:id/bb_bottom_bar_icon\"])[4]",
               "Кнопка 'Еще' справа снизу");
            ThreeDotsBtn.Click();

            return new OpenThreeDotsMainPage();
        }



        public MobileTasksListPage SelectTasks()
        {
            var tasksTab = new MobileItem("//android.widget.TextView[@resource-id=\"com.bitrix24.android:id/bb_bottom_bar_title\" and @text=\"Tasks\"]",
                "Таб 'Задачи'");
            tasksTab.Click();

            return new MobileTasksListPage();
        }
    }
}