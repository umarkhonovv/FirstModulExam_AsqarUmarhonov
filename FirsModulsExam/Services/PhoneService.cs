using FirsModulsExam.Models;

namespace FirsModulsExam.Services;

public class PhoneService
{

    private List<Phone> phones;

    public PhoneService()
    {
        phones = new List<Phone>();
    }

    public Phone Add(Phone phone)
    {
        phone.Id = new Guid();
        phones.Add(phone);

        return phone;
    }

    public Phone GetById(Guid id)
    {
        foreach (var phone in phones)
        {
            if (phone.Id == id)
            {
                return phone;
            }
        }

        return null;
    }

    public bool Delete(Guid id)
    {
        var exists = GetById(id);
        if (exists is null)
        {
            return false;
        }

        phones.Remove(exists);

        return true;
    }

    public bool Update(Phone updatedPhone)
    {
        var exists = GetById(updatedPhone.Id);
        if (exists is null)
        {
            return false;
        }

        var index = phones.IndexOf(exists);
        phones[index] = updatedPhone;

        return true;
    }

    public List<Phone> GetAll()
    {
        return phones;
    }


}
