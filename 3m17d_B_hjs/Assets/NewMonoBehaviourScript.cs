using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 5;
        float b;
        string c;
        bool d;

        PlusMinus(10, 10, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Plus(int left, int rigth)
    {
        return left + rigth;
    }

    int Minus(int left, int rigth)
    {
        return left - rigth;
    }

    int Multiply(int left, int rigth)
    {
        return left * rigth;
    }

    int Divide(int left, int rigth)
    {
        return left / rigth;
    }

    int PlusMinus(int left, int rigth, bool isplus)
    {
        if (isplus)
        {
            return left + rigth;
        }
        else
        {
            return left - rigth;
        }
    }
}

// public class Human
// {
//     public string name;
//     public float height;
//     public float kg;
//     public int age;
//     public int HP;
// 
//     void Walk()
//     {
//         Debug Log("걷기");
//     }
// 
//     void Eat()
//     {
//         Debug Log("먹기");
//     }
// 
//     void Sleep()
//     {
//         Debug Log("잠");
//     }
// 
//     void Introduce()
//     {
//         Debug Log("안녕 난" + name + "야");
//     }
// 
// 
// }
