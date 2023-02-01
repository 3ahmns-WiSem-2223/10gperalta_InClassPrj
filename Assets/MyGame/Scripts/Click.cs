using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{

    public TextMeshProUGUI countingText;
    public int counter = 0;

    private float positionX;
    private float positionY;
    private Vector2 position;


    void RandomPosition()
    {
        positionX = Random.Range(-10, 10);
        positionY = Random.Range(3, -4);
        position = new Vector2(positionX, positionY);
        transform.position = position;
    }

    private void OnMouseDown()
    {
        RandomPosition();
        Vector2 newPos = Camera.main.ScreenToWorldPoint(new Vector2(positionX, positionY)); 
        counter++;
    }

    void Update()
    {
        countingText.text = counter.ToString();
       
    }





}
