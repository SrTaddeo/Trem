using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    [SerializeField] Text Press;
    [SerializeField] Text Temp;
    [SerializeField] Text Velo;
    [SerializeField] Text Ener;
    public float velo;
    public float press;
    public float temp;
    public float ener;
    public float timer;

    public void AddCarvao()
    {
        ener = ener + 10;
    }
    public void SoltarCarvas()
    {
        while (true) { ener--; }

    }
    public void Freios()
    {

        velo = (velo * 10) - timer;

    }

    public void LiberPress()
    {

       press = (press - 10)  * timer;

    }

    public void Recursos()
    {
        timer = Time.deltaTime;

        if (ener > 300 ) { ener = 300; }

        if (ener > 0)
        {
            ener -= 1f * timer;
            if (ener < 30) temp += 0.5f * timer;
            else if (ener < 100) temp += 0.8f * timer;
            else if (ener < 300) temp += 1.2f * timer;
        }

        if (temp > 0)
        {

            if (ener <= 0) temp -= temp * 0.1f * timer;
            press += ((0.1f * temp) - (0.07f*press))* timer;

        }

        if (press > 5) //COLOCAR OS THRESHOLDS
        {
            velo += (0.3f+(velo*0.01f)+(press/200)) * timer;
            press -= (1f * ((velo / 10) / (temp))) * timer;
        }

            
        

        if ((press <= 10) && (temp <= 1))
        {
            velo--;
            if (velo < 0) velo = 0;
        }
    }

    public void EscreveRecursos()
    {

        Ener.text = ener.ToString("0");
        Velo.text = velo.ToString("0");
        Press.text = press.ToString("0");
        Temp.text = temp.ToString("0");
    }

    private void Start()
    {

    }

    private void Update()
    {
        Recursos();
        EscreveRecursos();
    }
}



