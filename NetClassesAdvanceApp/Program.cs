using NetUserClassLib;

User user = new User();

user.Age = 10;

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
