using System;

public class Dog
{
    public string Name { get; set; }
    public string Sex { get; set; }
    public Dog Mother { get; set; }
    public Dog Father { get; set; }

    public Dog(string name, string sex)
    {
        Name = name;
        Sex = sex;
    }

    public string FathersName()
    {
        return Father == null ? "Unknown" : Father.Name;
    }

    public bool HasSameMotherAs(Dog otherDog)
    {
        if (Mother == null || otherDog.Mother == null)
        {
            return false;
        }
        else if (Mother.Name == otherDog.Mother.Name)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}