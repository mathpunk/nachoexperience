using System;
using System.Collections;
using System.Collections.Generic;

public class Reactions
{
    public enum Verb { Light, Photograph, Record, Pay };
    public enum Action { Light, Cat, Beach, Photograph, Grocer, Pay, BluesBand, Record };
    public enum Item {
        // Wanted items
        Beach,
        Cat,
        Grocer,
        BluesBand,
        // Unwanted items
        Squirrel,
        Rat,
        TacoVendor,
        ChineseRestaurant,
        MusicShop,
        Band,
        NavyPier,
        FerrisWheel
    };


    public string GetQuip(Action action, Verb verb, Item item)
    {
        switch (action)
        {
            case Action.Light:
            case Action.Cat:
                return "I'll call you Mr. Whiskers. I feel less lonely already.";

            case Action.Light:
            case Action.Rat:
                return "Aaaaaaaaaaaaaaaaaaaaaahhhhh!!!!!";

            case Action.Light:
            case Action.Squirrel:
                return "Cute. But not a very good pet.";

            case Action.Photograph:
            case Action.Beach:
                return "The water reaches right up to the city… just like in Mar del Plata.";

            case Action.Pay:
            case Action.Grocer:
                return "Chicken, garlic, parsley, tomato, lemon... and cheese, of course. I can almost taste my mother’s milanesa already."

            case Action.Record:
            case Action.BluesBand:
                return "Mm, yes! I love it. The blues reminds me that you can be happy even when times are tough.";

            default:
                return "Sigh... I don't know why I thought that would help me feel less homesick."
        }
    }

    public string Gerund(Verb verb)
    {
        return verb.ToString() + "ing";
    }

}
