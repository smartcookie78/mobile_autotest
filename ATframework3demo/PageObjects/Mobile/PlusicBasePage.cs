
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class PlusicBasePage
    {
        public NewDealBasePage DealButton()
        {
            var DealBtn = new MobileItem("//android.widget.TextView[@content-desc=\"CRM_ENTITY_TAB_DEAL_CONTEXT_MENU_2_title\"]",
                "Кнопка 'Сделка'");
            DealBtn.Click();

            return new NewDealBasePage();
        }
    }
}
