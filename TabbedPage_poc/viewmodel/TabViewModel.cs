using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedPage_poc.viewmodel
{
    public class TabViewModel : ObservableObject
    {
        public View CarouselItem { get; set; }
        private bool _isSelected;
        public bool IsSelected { get => _isSelected; set => Set(ref _isSelected, value); }
        private string _title;
        //    private string _content;
        //    private bool _isSelected;



        public string Title { get => _title; set => Set(ref _title, value); }




        //    public string Content { get => _content; set => Set(ref _content, value); }

        //    public bool IsSelected { get => _isSelected; set =>Set(ref _isSelected, value); }
        //}
    }
}
