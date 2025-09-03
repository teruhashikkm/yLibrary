using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yLibrary.data.book
{
    public class Book
    {
        public Book()
        {
            ID = Guid.NewGuid().ToString();
            Name = "未知书名";
            Author = "未知作者";
            Publisher = "未知出版社";
            Holder = "无";
            BorrowTime = new DateTime(2025, 09, 03);
        }
        public Book(String id, String name, String author, String publisher, Boolean isBorrowed, String holder, DateTime borrowTime)
        {
            if((IsBorrowed == false && BorrowTime > new DateTime(1999, 12, 31))|| (IsBorrowed == true && BorrowTime == new DateTime(1999, 12, 31)))
            {
                throw new ArgumentException(nameof(BorrowTime), "借阅时间和是否借出匹配不上");
            }
            ID = id;
            Name = name;
            Author = author;
            Publisher = publisher;
            Holder = holder;
            BorrowTime = borrowTime;
            IsBorrowed = isBorrowed;
        }

        public String ID { get; set; }
        public String Name { get; set; }
        public String Author { get; set; }
        public String Publisher { get; set; }
        public Boolean IsBorrowed { get; set; }
        // 持有人
        public String Holder { get; set; }
        // 1999-12-31代表无效日期, 也就是没借出
        public DateTime BorrowTime { get; set; }

    }
}
