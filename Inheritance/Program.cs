namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var birds = new Bird();
            birds.birdHaveBeaks = true;
            birds.Legss = 2;
            birds.HaveTeeth = false;
            birds.birdsHaveFeathers = true;



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var reptile = new Reptile()
            {
                Legs = 4,
                coldBlooded = true,
                Scales = true,
                areVertebrates = true,
            };
        }
    }
}
