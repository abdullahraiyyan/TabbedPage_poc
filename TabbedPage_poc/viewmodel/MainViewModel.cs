using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPage_poc.view;

namespace TabbedPage_poc.viewmodel
{
    public class MainViewModel : ObservableObject
    {
        private TabViewModel _currentTabVm;

        public MainViewModel()
        {

            this.TabVms = new ObservableCollection<TabViewModel>();
            this.TabVms.Add(new TabViewModel() { Title = "Leave", CarouselItem = new NewPage1() });
            this.TabVms.Add(new TabViewModel() { Title = "Attendance", CarouselItem = new NewPage2() }); ;
            this.TabVms.Add(new TabViewModel() { Title = "Reimbursement", CarouselItem = new NewPage3() });
            this.TabVms.Add(new TabViewModel() { Title = "Over Time", CarouselItem = new NewPage4() });
            this.TabVms.Add(new TabViewModel() { Title = "Off Time", CarouselItem = new NewPage5() });
          

            this.CurrentTabVm = this.TabVms.FirstOrDefault();
        }


        public ObservableCollection<TabViewModel> TabVms { get; set; }

        public TabViewModel CurrentTabVm
        {
            get => _currentTabVm;
            set
            {
                _currentTabVm = value;
                onpropertychnaged(nameof(CurrentTabVm));
              // Set(ref _currentTabVm, value);
              
              //  SetSelection();
            }
        }

        private void SetSelection()
        {
            // this.TabVms.ForEach(vm => vm.IsSelected = false);
            foreach (var vm in TabVms)
            {
                vm.IsSelected = false;
                CurrentTabVm.IsSelected = true;
            }

            
        }
    }
}
