// version 0.1
// goal: Generic text for when Nacho acts on an item.

enum Verb { Light, Photograph, Record, Pay};
enum Item { Beach, Cat, Grocer, BluesBand };

type Action = tuple (Verb, Item);

string Quip(Action action) {
    switch action
    {
        case ( Light, Cat):
            "I think I'll call you... Mr. Whiskers. I feel less lonely already.";
            break;
        default:
            "Sigh... I don't know why I thought that " + Gerund(action.verb) + " a " + action.item + " would help me feel better...";
    }
}

string function Gerund(Verb verb) {
    return verb.toString() + "ing";
}

