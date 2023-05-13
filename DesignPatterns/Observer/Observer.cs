﻿namespace Observer;

public abstract class Observer
{
    protected Subject Subject;

    public abstract void Notify(object arg);
}
