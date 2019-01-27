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
        NavyPier
    };

    // Quips for quest items
    private Dictionary<Verb, string> CatQuips;
    private Dictionary<Verb, string> BeachQuips;
    private Dictionary<Verb, string> GrocerQuips;
    private Dictionary<Verb, string> BluesBandQuips;

    // Quips for distractors
    private Dictionary<Verb, string> RatQuips;
    private Dictionary<Verb, string> SquirrelQuips;
    private Dictionary<Verb, string> NavyPierQuips;
    private Dictionary<Verb, string> TacoVendorQuips;
    private Dictionary<Verb, string> ChineseRestaurantQuips;
    private Dictionary<Verb, string> MusicShopQuips;
    private Dictionary<Verb, string> BandQuips;

    public string GeneralFailure()
    {
        return "Sigh... I don't know why I thought that would help me feel less homesick.";
    }

    public void Start()
    {
        // Success Messages
        CatQuips.Add(Verb.Light, "You look just like my old cat, Mr Whiskers!");
        BeachQuips.Add(Verb.Photograph, "A great view. The water reaches right up to the city... just like in Mar del Plata.");
        GrocerQuips.Add(Verb.Pay, "Chicken, garlic, parsley, tomato, lemon... and cheese, of course. I can almost taste my mother’s milanesa already.");
        BluesBandQuips.Add(Verb.Record, "It's so good! This kind of music makes me think of my brother --- we loved watching The Blues Brothers.");

        // Right Item, Wrong Action
        CatQuips.Add(Verb.Photograph, "I guess I'm a guy who takes cat photos now. Huh.");
        CatQuips.Add(Verb.Record, "C'mon kitty... Meow or purr or something... Dang.");
        CatQuips.Add(Verb.Pay, "You're trying to buy something from a cat, Nacho. Wow. I better go home and rest.");
        BeachQuips.Add(Verb.Record, "The beach is deserted in winter. Just the sound of the wind.");
        BluesBandQuips.Add(Verb.Photograph, "They sound great, but --- they don't look like much.");

        // Distractors. An opportunity for more hints
        RatQuips.Add(Verb.Light, "AH! AHHH!! AHHHHHHHHHHHH!!!!!!");
        SquirrelQuips.Add(Verb.Light, "Cute. But it wouldn't make a very good *pet*.");
        NavyPierQuips.Add(Verb.Photograph, "The Ferris wheel is cool and all but, this view mostly reminds me that I'm not on a Mar del Plata *beach*. Sigh...");
        MusicShopQuips.Add(Verb.Record, "You're not allowed to play the instruments here. It just sounds like any old store.");
        BandQuips.Add(Verb.Record, "They're pretty good. But I don't feel connected to this kind of music. Oh well...");
        TacoVendorQuips.Add(Verb.Pay, "These tacos are pretty good. But they remind me how long it's been since I had choripan. Ooh, or *home-cooked milanesa*...");
        ChineseRestaurantQuips.Add(Verb.Pay, "This is pretty tasty. But I miss my mother's *home-cooked milanesa*...");
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
            // Quest Items
            case Item.Cat:
                return GetQuipOrDefault(CatQuips, verb);

            case Item.Beach:
                return GetQuipOrDefault(BeachQuips, verb);

            case Item.Grocer:
                return GetQuipOrDefault(GrocerQuips, verb);

            case Item.BluesBand:
                return GetQuipOrDefault(BluesBandQuips, verb);

            // Distractor Items
            case Item.Rat:
                return GetQuipOrDefault(RatQuips, verb);

            case Item.Squirrel:
                return GetQuipOrDefault(SquirrelQuips, verb);

            case Item.NavyPier:
                return GetQuipOrDefault(NavyPierQuips, verb);

            case Item.MusicShop:
                return GetQuipOrDefault(MusicShopQuips, verb);

            case Item.Band:
                return GetQuipOrDefault(BandQuips, verb);

            case Item.TacoVendor:
                return GetQuipOrDefault(TacoVendorQuips, verb);

            case Item.ChineseRestaurant:
                return GetQuipOrDefault(ChineseRestaurantQuips, verb);

            default:
                return GeneralFailure();
        }
    }

    public string Gerund(Verb verb)
    {
        return verb.ToString() + "ing";
    }

}
