using UnityEngine;


public class Pet : MonoBehaviour
{

    private State<Pet> petState;

    public string p_name;
    public string p_species;

    private void Start()
    {
        petState = new PetIdle();
    }

    public void Update() { UpdateState(); }

    // Use this method to change states, so the old state is correctly disposed of
    public void ChangeState(State<Pet> newState) { petState = newState; }

    private void UpdateState()
    {
        //petState.Execute(this);

        petState?.Execute(this);
    }
}

