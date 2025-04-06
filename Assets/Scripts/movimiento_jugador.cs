using UnityEngine;

public class Movimiento_jugador : MonoBehaviour
{
    public float speed = 5f; //Velocidad del jugador 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Input Axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Crear el vector de movimiento
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        
        // Mover el objeto
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
