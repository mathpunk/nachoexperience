using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactions : MonoBehaviour
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
    private Dictionary<Item, Dictionary<Verb, string>> CatReactions;

    private Dictionary<Verb, string> CatQuips;
    private Dictionary<Verb, string> BeachQuips;
    private Dictionary<Verb, string> GrocerQuips;
    private Dictionary<Verb, string> BluesBandQuips;

    public string GeneralFailure()
    {
        return "Sigh... I don't know why I thought that would help me feel less homesick.";
    }

    public void Start()
    {
        CatQuips.Add(Verb.Light, "You look just like my old cat, Mr Whiskers!");
        CatQuips.Add(Verb.Photograph, "I guess I'm a guy who takes cat photos now. Huh.");
        CatQuips.Add(Verb.Record, "C'mon kitty... Meow or purr or something... Dang.");
        CatQuips.Add(Verb.Pay, "You're trying to buy something from a cat, Nacho. Wow. I better go home and rest.");

        BeachQuips.Add(Verb.Photograph, "A great view. The water reaches right up to the city... just like in Mar del Plata.");

        GrocerQuips.Add(Verb.Pay, "Chicken, garlic, parsley, tomato, lemon... and cheese, of course. I can almost taste my mother’s milanesa already.");

        BluesBandQuips.Add(Verb.Record, "Yes! I love it! The blues reminds me that you can be happy even when times are tough.");
    }

    private string GetQuipOrDefault(Dictionary<Verb, string> quips, Verb verb)
    {
        string quip = "";
        return (quips.TryGetValue(verb, out quip)) ? quip : GeneralFailure();
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
