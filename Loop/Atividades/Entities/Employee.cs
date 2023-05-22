using System.Reflection.Metadata.Ecma335;

namespace Loop.Atividades.Entities;

public class Employee
{
    public  Sex Sex { get; private set; }
    public byte Age { get; private set; }
    public bool IsExperient { get; private set; }

    public Scholarity Scholarity { get; private set; }
    

    public Employee(Sex sex, byte age, bool isExperient, Scholarity scholarity)
    {
        Sex = sex;
        Age = age;
        IsExperient = isExperient;
        Scholarity = scholarity;
    }

    public override string ToString()
    {
        return $"Sex: {Sex}, age: {Age}, is experient: {IsExperient}, scholarity: {Scholarity}";
    }
}

public enum Sex
{
    Masc = 1,
    Fem
}

public enum Scholarity
{
    EnsinoFundamental = 1,
    EnsinoMedio,
    EnsinoSuperior,
    PosGraduacao
    
}
