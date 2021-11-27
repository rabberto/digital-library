using System;

namespace Api.Domain.Models
{
    public class BookModel : BaseModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private Guid _authorId;
        public Guid AuthorId
        {
            get { return _authorId; }
            set { _authorId = value; }
        }
    }
}