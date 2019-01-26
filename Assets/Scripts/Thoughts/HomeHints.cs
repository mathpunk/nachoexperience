// version 0.1
// Goal: Quips about the initial, unfilled, sad & lonely state of Nacho's place.

// General
using System.Collections.Generic;
public class HomeHints  
{
    public string[] Empty = { "Kind of empty in this room.", "Not much to look at.", "It's a nice room but, it doesn't really feel like it's *mine*." };
    public string[] Lonely = { "No one here but me.", "Kind of lonely in this room.", "Sigh..." };

    // By room
    public string[] LivingRoomHints = { "It would be nice to have someone to talk to. Even a *pet* would make me feel less alone." };

    public string[] BedroomHints = { "The neighborhood is fine but, the *view* is pretty dull." };

    public string[] KitchenHints = { "I've been living on takeout. I could really use a *home-cooked meal*." };

    public string[] StudioHints = { "Work, work, work. Sigh. I should really put on some *music* that's just for me..." };
}
