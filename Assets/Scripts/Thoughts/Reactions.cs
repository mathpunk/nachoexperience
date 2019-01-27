using System;
using System.Collections;
using System.Collections.Generic;

public class Reactions : MonoBehavior
{
    public enum Verb
    {
        Light,
        Photograph,
        Record,
        Pay
    };

    public enum Item
    {
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

    private Dictionary<Verb, string> CatQuips;
    private Dictionary<Verb, string> BeachQuips;
    private Dictionary<Verb, string> GrocerQuips;
    private Dictionary<Verb, string> BluesBandQuips;

    public string GeneralFailure()
    {
        return "Sigh... I don't know why I thought that would help me feel less homesick.";
    }

    public Start()
    {
        CatQuips.Add(Light, "You look just like my old cat, Mr Whiskers!");
        CatQuips.Add(Photograph, "I guess I'm a guy who takes cat photos now. Huh.");
        CatQuips.Add(Record, "C'mon kitty... Meow or purr or something... Dang.");
        CatQuips.Add(Pay, "You're trying to buy something from a cat, Nacho. Wow. I better go home and rest.");

        BeachQuips.Add(Photograph, "A great view. The water reaches right up to the city... just like in Mar del Plata.");

        GrocerQuips.Add(Pay, "Chicken, garlic, parsley, tomato, lemon... and cheese, of course. I can almost taste my mother’s milanesa already.");

        BluesBandQuips.Add( Record, "Yes! I love it! The blues reminds me that you can be happy even when times are tough.");
    }

    private string GetQuipOrDefault(Dictionary<Verb, string> quips, Verb verb)
    {
        return quips.ContainsKey(verb) ? quips[verb] : GeneralFailure();
    }

    public string GetQuip(Verb verb, Item item)
    {

        switch (item)
        {
            case Item.Cat:
                return GetQuipOrDefault(CatQuips, verb);

            case Item.Beach:
                return GetQuipOrDefault(BeachQuips, verb);

            case Item.Grocer:
                return GetQuipOrDefault(GrocerQuips, verb);

            case Item.BluesBand:
                return GetQuipOrDefault(BluesBandQuips, verb);

            default:
                return GeneralFailure();
        }
    }

    public string Gerund(Verb verb)
    {
        return verb.ToString() + "ing";
    }

}
