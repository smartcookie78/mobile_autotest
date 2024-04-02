using atFrameWork2.BaseFramework;
using ATframework3demo.PageObjects.Mobile;

namespace ATframework3demo.TestCases.Deals
{
    public class Case_Mobile_Deals : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(
                new TestCase("Создание сделки", mobileHomePage => CreateDeal(mobileHomePage)));
            return caseCollection;
        }

        void CreateDeal(MobileHomePage homePage) 
        {
  
            homePage
                .TabsPanel
                // нажать ЕЩЕ (значок "три точки" справа снизу)
                .OpenThreeDots()
                // открыть CRM 
                .OpenCRM()
                // нажать на кнопку "плюсика" справа внизу
                .PlusButton()
                // во всплывающем фрейме выбрать "Сделка"
                .DealButton()
                // создать пустую сделку без данных
                .CreateDealButton();

        }
    }
}
