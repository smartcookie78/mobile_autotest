
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class CRMBasePage
    {
        public PlusicBasePage PlusButton()
        {
            var PlusBtn = new MobileItem("//android.view.ViewGroup[@content-desc=\"KANBAN_STAGE_ADD_BTN\"]",
                "Кнопка '+' справа снизу");
            PlusBtn.Click();

            return new PlusicBasePage();
        }
    }
}
