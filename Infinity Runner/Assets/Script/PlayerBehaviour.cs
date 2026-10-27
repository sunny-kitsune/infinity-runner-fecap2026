using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //SerializeField me ajuda a manipuloar o valor da variável na unity
    [SerializeField] private float moveSpeed;
    private float moveX;
    private float moveY;

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        moveY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(moveX, moveY, 0);
    }
}
