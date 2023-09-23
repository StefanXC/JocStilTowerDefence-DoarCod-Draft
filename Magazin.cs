using UnityEngine;

public class Magazin : MonoBehaviour
{
    public MatritaTureta turetaStandard;
    public MatritaTureta altaTureta;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectTuretaStandard()
    {
        Debug.Log("Ai cumparat tureta standard");
        buildManager.SelectTuretaToBuild(turetaStandard);
    }

    public void SelectCumparaTureta()
    {
        Debug.Log("Ai cumparat tureta ");
        buildManager.SelectTuretaToBuild(altaTureta);
    }
}
