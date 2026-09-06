public abstract class Person
{
    private int personId;
    private string name;
    private int age;

    public int PersonId
    {
        get { return personId; }
        set { personId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Person(int personId, string name, int age)
    {
        this.personId = personId;
        this.name = name;
        this.age = age;
    }

    public abstract string GetRoleInfo();

    public override string ToString()
    {
        return $"ID: {PersonId}\n" +
               $"Name: {Name}\n" +
               $"Age: {Age}";
    }
}