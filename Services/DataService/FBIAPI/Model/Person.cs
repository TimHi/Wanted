using System;
namespace Services.DataService.FBIAPI.Model
{
    public class Person
    {
        public Person(string lastName, string firstName, string imageURL, string descriptionText)
        {
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            ImageURL = imageURL ?? throw new ArgumentNullException(nameof(imageURL));
            DescriptionText = descriptionText ?? throw new ArgumentNullException(nameof(descriptionText));
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ImageURL { get; set; }
        public string DescriptionText { get; set; }
    }
}
