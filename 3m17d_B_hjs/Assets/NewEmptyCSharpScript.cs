using UnityEngine;

public class NewEmptyCSharpScript
{
    
    void Start()
    {
        Human man = new Human();
        man.name = "신구";
        man.height = 180f;
        man.age = 20;
        man.kg = 70f;


      
    }

}

public class Human
{
    public string name;
    public float height;
    public float kg;
    public int age;
    public int HP;

    void Walk()
    {
        Debug.Log("걷기");
    }

    void Eat()
    {
        Debug.Log("먹기");
    }

    void Sleep()
    {
        Debug.Log("잠");
    }

    void Introduce()
    {
        Debug.Log("안녕 난" + name + "야"); 
    }

    
}