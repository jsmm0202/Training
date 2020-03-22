using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Jess";
            string upper = MakeUppercase(name);

            Assert.Equal("Jess", name);
            Assert.Equal("JESS", upper);
        }

        private string MakeUppercase(string name)
        {
            return name.ToUpper();
        }

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            int x = GetInt();
            SetInt(x);
            
            Assert.Equal(3, x);
        }

        private void SetInt(int x)
        {
           x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            Book book1 = GetBook("Book 1");

            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            Book book1 = GetBook("Book 1");

            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            Book book1 = GetBook("Book 1");

            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            Book book1 = GetBook("Book 1");
            Book book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TwVarsCanReferenceSameObject()
        {
            Book book1 = GetBook("Book 1");
            Book book2 = book1;

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 1", book2.Name);
            Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1,book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
