using UnityEngine.InputSystem;
using UnityEngine;

public class Roller : MonoBehaviour
{
    public GameObject mger;
    private manager recebe;

    void Start()
    {
        mger = GameObject.Find("GameManeger");
        recebe = mger.GetComponent<manager>();
    }
    void Update()
    {
        float mod = recebe.velo;
        float trueVelocidade = -(mod * 25);
        transform.position += new Vector3(0, 0, trueVelocidade ) * Time.deltaTime;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }


}
