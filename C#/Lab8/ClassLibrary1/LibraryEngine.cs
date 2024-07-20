using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList
        , Func< Book, String > fPtr) // A) BDelegate < Book, String> fPtr

        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
