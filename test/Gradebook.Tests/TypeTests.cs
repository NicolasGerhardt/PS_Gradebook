using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            // arrange section
            var book1 = GetBook("book1");
            var book2 = GetBook("book2");


            // act section

            

            // assert section 
            Assert.Equal("book1", book1.Name);
            Assert.Equal("book2", book2.Name);


        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
