using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace recyclingApp.ViewModel
{
    public class AddViewModel : BaseViewModel
    {
        public AddViewModel()
        {
            MenuList = GetMenu();
        }

        public List<Pick> MenuList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopModalAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "Metals", Image = "IMG05.png", Description = "Add details about recycling metals.", Price = "0.00" },
                new Pick { Title = "Plastics", Image = "IMG04.png", Description = "add details about recycling plastics.", Price = "0.00" },
                new Pick { Title = "Botttles", Image = "IMG01.png", Description = "Add details about recycling bottles.", Price = "0.00" }
            };
        }
    }
}