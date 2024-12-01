using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSkript : MonoBehaviour
{
    //Зодровье НПС
    public int health = 5;

    //Уровань НПС
    public int level = 1;

    //Скорость НПС
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        //+здоровье НПС
        health += level;
        //Вывод в консоль зводоровье НПС
        print("Здоровье НПС: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
