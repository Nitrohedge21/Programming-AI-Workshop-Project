using UnityEngine;

public abstract class State<T>
{
    public State() { }

    public abstract void Execute(T parentClass);
}
