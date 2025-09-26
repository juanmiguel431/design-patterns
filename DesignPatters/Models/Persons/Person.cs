namespace DesignPatters.Models.Persons;

public class Person : ICloneable, IPrototype<Person>, IDeepCopyable<Person>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public string[] Nicknames { get; set; } = [];

    public ContactInfo? ContactInfo { get; set; }

    public Person()
    {
    }

    public Person(Person other)
    {
        FirstName = other.FirstName;
        MiddleName = other.MiddleName;
        LastName = other.LastName;
        Street = other.Street;
        City = other.City;
        State = other.State;
        ZipCode = other.ZipCode;
        Latitude = other.Latitude;
        Longitude = other.Longitude;
        Nicknames = (string[])other.Nicknames.Clone();
        ContactInfo = other.ContactInfo is null ? null : new ContactInfo(other.ContactInfo);
    }

    public virtual Person DeepCopy()
    {
        return new Person(this);
    }

    public Person(string firstName, string lastName, ContactInfo contactInfo) : this()
    {
        FirstName = firstName;
        LastName = lastName;
        ContactInfo = contactInfo;
    }

    public static PersonBuilder Builder() => new();
    public static PersonFunctionalBuilder FunctionalBuilder() => new();
    public static PersonFacetedBuilder PersonFacetedBuilder() => new();

    public override string ToString()
    {
        return
            $"{{\n" +
            $" {nameof(FirstName)}: {FirstName},\n" +
            $" {nameof(MiddleName)}: {MiddleName},\n" +
            $" {nameof(LastName)}: {LastName},\n" +
            $" {nameof(Street)}: {Street}\n" +
            $" {nameof(City)}: {City},\n" +
            $" {nameof(State)}: {State},\n" +
            $" {nameof(ZipCode)}: {ZipCode},\n" +
            $" {nameof(Latitude)}: {Latitude},\n" +
            $" {nameof(Longitude)}: {Longitude},\n" +
            $" {nameof(Nicknames)}: {string.Join(",", Nicknames)},\n" +
            $" {nameof(ContactInfo.Email)}: {ContactInfo?.Email},\n" +
            $" {nameof(ContactInfo.Phone)}: {ContactInfo?.Phone},\n" +
            $" {nameof(ContactInfo.Facebook)}: {ContactInfo?.Facebook}\n" +
            $"}}\n";
    }

    public object Clone()
    {
        var contactInfo = ContactInfo != null ? (ContactInfo)ContactInfo.Clone() : new ContactInfo();
        return new Person(FirstName, LastName, contactInfo);
    }

    public void CopyTo(Person target)
    {
        target.FirstName = FirstName;
        target.MiddleName = MiddleName;
        target.LastName = LastName;
        target.Street = Street;
        target.City = City;
        target.State = State;
        target.ZipCode = ZipCode;
        target.Latitude = Latitude;
        target.Longitude = Longitude;
        target.Nicknames = (string[])Nicknames.Clone();
        target.ContactInfo = ContactInfo is null ? null : ContactInfo.DeepClone();
    }
}