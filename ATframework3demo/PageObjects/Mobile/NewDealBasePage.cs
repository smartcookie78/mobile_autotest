
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class NewDealBasePage
    {
        public CRMBasePage CreateDealButton()
        {

            // тап на поле для ввода названия сделки для отображения локатора этого поля для ввода названия сделки

            var NameFieldTap =  new MobileItem("//android.widget.TextView[@content-desc=\"deal_0_details_editor_TITLE_NAME\"]",
                "Тап на поле ввода названия сделки");
            NameFieldTap.Click();

            // ввод имени сделки

            var NameField = new MobileItem("//android.widget.EditText[@text=\"Deal #\"]",
                "Поле ввода названия сделки");
            NameField.SendKeys("DealName");

            // нажатие на кнопку "создать" в правом верхнем углу

            var CreateBtn = new MobileItem("//android.widget.TextView[@text=\"Create\"]",
                "Поле ввода названия сделки");
            CreateBtn.Click();

            return new CRMBasePage();
            
        }
    }
}
