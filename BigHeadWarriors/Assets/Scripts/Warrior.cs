public class Warrior
{
    public readonly string name;
    public readonly string type;
    public string localCaught;
    public int energy;
    public bool favorite;
    public int power;
    public string warriorId;

    public Warrior(string name, string type, string localCaught, int energy, bool favorite, int power, string warriorId) : this(name, type)
    {
        this.name = name;
        this.type = type;
        this.localCaught = localCaught;
        this.energy = energy;
        this.favorite = favorite;
        this.power = power;
        this.warriorId = warriorId;
    }

    public Warrior(string name, string type)
    {
        this.name = name;
        this.type = type;
    }



   

    public string LocalCaught
    {
        get
        {
            return localCaught;
        }

        set
        {
            localCaught = value;
        }
    }

    public int Energy
    {
        get
        {
            return energy;
        }

        set
        {
            energy = value;
        }
    }

    public bool Favorite
    {
        get
        {
            return favorite;
        }

        set
        {
            favorite = value;
        }
    }

    public int Power
    {
        get
        {
            return power;
        }

        set
        {
            power = value;
        }
    }

    public string WarriorId
    {
        get
        {
            return warriorId;
        }

        set
        {
            warriorId = value;
        }
    }
}
