namespace DesignPatters.Models.Persons;

public class ContactInfo: ICloneable, IPrototype<ContactInfo>
{
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Facebook { get; set; }
    
    public ContactInfo()
    {
    }
    
    public ContactInfo(ContactInfo other)
    {
        Email = other.Email;
        Phone = other.Phone;
        Facebook = other.Facebook;
    }
    
    public ContactInfo DeepCopy()
    {
        return new ContactInfo(this);
    }

    public ContactInfo(string email, string phone, string facebook)
    {
        Email = email;
        Phone = phone;
        Facebook = facebook;
    }
    
    public object Clone()
    {
        return new ContactInfo(Email, Phone, Facebook);
    }
}