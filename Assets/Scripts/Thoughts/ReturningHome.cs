using System;
using System.Collections;
using System.Collections.Generic;
// version 0.1
// goal: Generic text for when Nacho acts on an item.

public class ReturningHome
{
    public enum Verb { Light, Photograph, Record, Pay };
    public enum Item { Beach, Cat, Grocer, BluesBand };
    public enum Action { Light, Cat };

    public string GetQuip(Action action, Verb verb, Item item)
    {
        switch (action)
        {
            case Action.Light:
            case Action.Cat:
                return "I think I'll call you... Mr. Whiskers. I feel less lonely already.";
            default:
                return "Sigh... I don't know why I thought that " + Gerund(verb) + " a " + item + " would help me feel better...";
        }
    }

    public string Gerund(Verb verb)
    {
        return verb.ToString() + "ing";
    }

}
