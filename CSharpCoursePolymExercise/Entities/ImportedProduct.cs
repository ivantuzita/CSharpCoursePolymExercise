namespace CSharpCoursePolymExercise.Entities {
    internal class ImportedProduct : Product {
        
        public double CustomsFee { get; set; }

        public override string priceTag() {
            return $"{base.Name} $ {totalPrice()} (Customs fee: $ {CustomsFee})";
        }

        public double totalPrice() {

            return base.Price + CustomsFee;

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {

            CustomsFee = customsFee;
        }


    }
}
