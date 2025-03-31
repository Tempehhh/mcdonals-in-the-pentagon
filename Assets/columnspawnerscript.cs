using UnityEngine;

public class columnspawnerscript : MonoBehaviour
{
    public GameObject column;
    public float tickrate = 2;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawncolumn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < tickrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawncolumn();
            timer = 0;
        }
    }

    void spawncolumn()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(column, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
