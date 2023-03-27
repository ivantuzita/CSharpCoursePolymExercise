namespace CSharpCoursePolymExercise.Entities {
    internal class UsedProduct : Product {

        public DateTime ManufactureDate { get; set; }

        public override string priceTag() {
            return $"{base.Name} (used) $ {base.Price} (Manufacture date: {ManufactureDate})";
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {

            ManufactureDate = manufactureDate;
        }
    }
}
