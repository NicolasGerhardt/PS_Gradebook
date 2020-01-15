using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Nic";
            var upper = MakeUpperCase(name);
            
            Assert.Equal("Nic", name);
            Assert.Equal("NIC", upper);
        }

        private string MakeUpperCase(string name)
        {
            return name.ToUpper();
        }

        [Fact]
        public void ValueTypesAlsoPassByValue() 
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {

            var book1 = GetBook("book1");
            var book2 = GetBook("book2");

            Assert.Equal("book1", book1.Name);
            Assert.Equal("book2", book2.Name);

        }
        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("book1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book1", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }


        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
