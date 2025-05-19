using UnityEngine;
public class TesteSoma : MonoBehaviour
{
    private int A;
    private int B;
    private int C;
    
    int Soma(int a, int b)
    {
        return a + b;
    }
    
    int Soma2(int a, int b)
    {
        int c = a + b;
        return c;
    }

    void MairQue(int a, int b)
    {
        if (a > b)
        {
            Debug.Log("Avarievel A armazena: " 
                      + a + " que é maior que "+ b+".");   
        }
        else if (a < b)
        {
            Debug.Log("Avarievel A armazena: " 
                      + a + " que é menor que "+ b+".");  
        }
        else
        {
            Debug.Log("Avarievel A armazena: " 
                      + a + " que é igual que "+ b+".");  
        }
 
    }

    void Start()
    {
        A = 23;
        B = 12; 
        C = A + B;
        //Debug.Log(C);
        
        //Debug.Log(Soma(13,67));
        //Debug.Log(Soma(A,B));
        //Debug.Log(Soma(89,C));
        
        /*
        Debug.Log(Soma2(13,67));
        Debug.Log(Soma2(A,B));
        Debug.Log(Soma2(89,C));
        */

        /*
        if (A > B)
        {
            Debug.Log("Avarievel A armazena: "
                      + A + " que é maior que "+ B+".");
        }
        else
        {
            Debug.Log("Avarievel A armazena: "
                      + A + " que é menor que "+ B+".");
        }
        */

        MairQue(A,B);
        MairQue(23,3);
        MairQue(1,3);
        MairQue(1,1);


    }
    void Update()
    {
        
    }
}