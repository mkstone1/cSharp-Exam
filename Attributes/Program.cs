using System.ComponentModel.DataAnnotations;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method1();



            Person p1 = new Person() { Name = "John", Age = 25 };
            Person p2 = new Person() { Name = "Mark", Age = 130 };
            Person p3 = new Person() { Age = 30 };

            var res = p1.Validate();
            var res2 = p2.Validate();

            Console.WriteLine(res);
            Console.WriteLine(res2);

            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(
                p1,
                new ValidationContext(p1),
                results,
                true
            );

            bool isAlsoValid = Validator.TryValidateObject(
                p2,
                new ValidationContext(p2),
                results,
                true
            );

            foreach (var validationResult in results)
            {
                Console.WriteLine(validationResult.ErrorMessage);
            }
        }

        //Attribute example. inhearths from System.Attribute
        [Obsolete("use method 2 plz")]
        public static void Method1() { }
    }

    [CustomAttribute("Description")]
    public class Person
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Range(0, 120)]
        public int Age { get; set; }

        public bool Validate()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);

            return Validator.TryValidateObject(this, context, results, true);
        }
    }

    public class CustomAttribute : Attribute
    {
        public string Description { get; set; }

        public CustomAttribute(string description)
        {
            Description = description;
        }
    }
}
