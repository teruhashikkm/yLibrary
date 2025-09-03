using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using yLibrary.data.book;

namespace yLibrary.windows.functionWindow.borrowPage.borrowBook
{
    public class BorrowBook: INotifyPropertyChanged
    {
        public BorrowBook(Book book)
        {
            InternBook = book;
            IsSelected = false;
        }
        public BorrowBook(Book book, Boolean isSelected)
        {
            InternBook = book;
            IsSelected = isSelected;
        }
        public Book InternBook { get; set; }
        private Boolean _isSelected;
        public Boolean IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
