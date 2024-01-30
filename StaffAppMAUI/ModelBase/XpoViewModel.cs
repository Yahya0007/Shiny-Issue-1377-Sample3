using DevExpress.Xpo;
using MvvmHelpers;
//using StaffApp.Services;
// using Xamarin.Forms;

namespace StaffApp.ViewModels {
    public class XpoViewModel : BaseViewModel {

        //UnitOfWork unitOfWork;

        //protected UnitOfWork UnitOfWork {
        //    get {
        //        if(unitOfWork == null) {
        //            unitOfWork = DataService.CreateUnitOfWork();
        //        }
        //        return unitOfWork;
        //    }
        //}

        public XpoViewModel() 
        {
            //NavigationPage.SetTitleIcon(this, "image.png");

            if (DataService.IsApplyforWork)
                return;

            if (!DataService.IsAuthenticated()) {
                App.ResetMainPage();
            }
        }

    }
}
