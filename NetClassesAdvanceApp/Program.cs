using NetUserClassLib;
using System.Runtime.CompilerServices;

User user = new User();

user.Age = 10;

//UserInfo userInfo = new UserInfo();

//UserInfo.Count = 10;

var builder = House.GetBuilder(5);

House house1 = new(5);
House house2 = new(15);

/*

private - доступен внутри самого класса
private protected - доступен в классе 
                    и в наследных классах внутри этой сбоки
(c# 11) file - доступен внутри файла
protected - доступен в классе и дочерних классах
            в том числе в других сборках
internal - доступен везде (public) внутри сборки,
            и недоступен (private) в других сборках
protected internal - доступен везде внутри сборки
                    и только в дочерних в других сборках
public - доступен везде, в том числе и дургих сборках

*/


class Example
{
    public int Sum(int a, int b) { return a + b; }
    public float Sum(float a, float b) { return a + b; }
    public int Sum(int a, int b, int c) { return a + b + c; }
}

class House
{
    const int N = 10;
    public readonly int M;
    static House()
    {

    }
    public House(int m)
    {
        M = m;
    }
    public bool Wall { set; get; }
    public bool Garage { set; get; }
    public bool Garden { set; get; }
    public bool Pool { set; get; }
    public static HouseBuilder GetBuilder(int m)
    {
        return new HouseBuilder(new House(m));
    }

    public HouseBuilder GetBuilder(bool f = true)
    {
        return new HouseBuilder(this);
    }
}

class HouseBuilder
{
    House house;
    public HouseBuilder(House house)
    {
        this.house = house;
    }
    HouseBuilder SetWall()
    {
        house.Wall = true;
        return this;
    }

    HouseBuilder SetGarage()
    {
        house.Garage = true;
        return this;
    }

    HouseBuilder SetGarden()
    {
        house.Garden = true;
        return this;
    }

    HouseBuilder SetPool()
    {
        house.Pool = true;
        return this;
    }

    House Build()
    {
        return house;
    }
}

readonly struct Person { readonly string Name; readonly int Age; }
record struct PersonR(string Name, int Age);