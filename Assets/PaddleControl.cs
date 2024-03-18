using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float batasAtas;
    public float batasBawah;
    public float batasKanan;
    public float batasKiri;
    public float kecepatan;
    public string inputVertikal;
    public string inputHorizontal;

    // Update is called once per frame
    void Update()
    {
        float gerakVertikal = Input.GetAxis(inputVertikal) * kecepatan * Time.deltaTime;
        float gerakHorizontal = Input.GetAxis(inputHorizontal) * kecepatan * Time.deltaTime;

        //Gerak
        Vector3 nextPosition = transform.position + new Vector3(gerakHorizontal, gerakVertikal, 0);

        //BATAS
        nextPosition.x = Mathf.Clamp(nextPosition.x, batasKiri, batasKanan);
        nextPosition.y = Mathf.Clamp(nextPosition.y, batasBawah, batasAtas);

        transform.position = nextPosition;
    }
}
