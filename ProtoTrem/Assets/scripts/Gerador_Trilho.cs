using UnityEngine;

public class Gerador_Trilho : MonoBehaviour
{
    GameObject PrxTrilho;
    public GameObject SgmtTrilho;
    public GameObject FimTrilho;
    [SerializeField] int distanciaFinal;
    int distanciaAtual;
    
    private void OnTriggerEnter(Collider other)
    {
        distanciaAtual += 1;
        PrxTrilho = SgmtTrilho;

        /*
         if(distanciaAtual == distanciaFinal) PrxTrilho = FimTrilho
        else PrxTrilho = SgmtTrilho;
        */

        if (other.gameObject.CompareTag("trigger"))
        { 
            Instantiate(PrxTrilho, new Vector3(0,0, 1873), Quaternion.identity);
        }
    }

}
