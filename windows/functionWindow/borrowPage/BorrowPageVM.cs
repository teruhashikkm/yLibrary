using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using yLibrary.common.commands;
using yLibrary.data.book;
using yLibrary.windows.functionWindow.borrowPage.borrowBook;

namespace yLibrary.windows.functionWindow.borrowPage
{
    public class BorrowPageVM: INotifyPropertyChanged
    {
        public BorrowPageVM()
        {
            // 添加示例数据
            var books = new List<Book>
            {
                new Book("1", "C#高级编程", "John Doe", "清华出版社", false, "", new DateTime(1999,12,31)),
                new Book("2", ".NET设计模式", "Jane Smith", "机械工业", true, "张三", DateTime.Now)
            };

            foreach (var book in books)
            {
                BorrowBooks.Add(new BorrowBook(book));
            }

            BorrowCommand = new RelayCommand(ExecuteBorrowCommand);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private ObservableCollection<BorrowBook> _books = new ObservableCollection<BorrowBook>();
        public ObservableCollection<BorrowBook> BorrowBooks
        {
            get => _books;
            set
            {
                _books = value;
                OnPropertyChanged();
            }
        }

        public ICommand BorrowCommand { get; }

        private void ExecuteBorrowCommand(object parameter)
        {
            // 获取所有选中的书籍（IsSelected为true）
            var selectedBooks = BorrowBooks.Where(b => b.IsSelected).ToList();

            if (selectedBooks.Any())
            {
                string message = $"您已借阅以下书籍:\n{string.Join("\n", selectedBooks.Select(b => b.InternBook.Name))}";
                MessageBox.Show(message);

                // 实际借阅逻辑：更新书籍状态
                foreach (var borrowBook in selectedBooks)
                {
                    borrowBook.InternBook.IsBorrowed = true;
                    borrowBook.InternBook.Holder = "当前借阅者"; // 替换为实际借阅者
                    borrowBook.InternBook.BorrowTime = DateTime.Now;
                }
            }
            else
            {
                MessageBox.Show("请至少选择一本书籍");
            }
        }
    }
}
