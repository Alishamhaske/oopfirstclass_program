using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class book
    {
        private int bk_id, b_price;
        private string bk_name, b_author_name;

        public void book_accpect(int b_id, int b_pr, string b_name, string b_author)
        {
            bk_id=b_id;
            b_price = b_pr;
            bk_name = b_name;
            b_author_name = b_author;

        }

        public string printbook()
        {
            return$"book id: {bk_id} book price:{b_price} book name:{bk_name}  book author:{b_author_name} ";
        }
    }
}
