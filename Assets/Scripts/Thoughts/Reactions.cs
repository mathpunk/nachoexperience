using System;
using System.Collections;
using System.Collections.Generic;

public class Reactions
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
                return "I'll call you Mr. Whiskers. I feel less lonely already.";

            case Action.Beach:
            case Action.Photograph:
                return "The water reaches right up to the city… just like in Mar del Plata.";

            case Action.Grocer:
            case Action.Pay:
                return "Chicken, garlic, parsley, tomato, lemon... and cheese, of course. I can almost taste my mother’s milanesa already."

            case Action.BluesBand:
            case Action.Record:
                return "Mm, yes! The blues reminds me that you can be happy even when times are tough.";

            default:
                // return "Sigh... I don't know why I thought that " + Gerund(verb) + " a " + item + " would help me feel better...";
                return "Sigh... I don't know why I thought that would help me feel less homesick."
        }
    }

    public string Gerund(Verb verb)
    {
        return verb.ToString() + "ing";
    }

}
