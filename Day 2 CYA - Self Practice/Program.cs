//Other story which was originally going to be attempted too many variations to be small project. Will attempt later

/*Console.WriteLine("Welcome to dear reader to: \"Don’t Go in the Attic! - A (Slightly) Creepy Choose-Your-Own Adventure\" story. \n\nAll credit for contents of story goes to publisher " +
    "of this link below:\nhttps://www.glenridge.org/cms/lib/NJ01001358/Centricity/Domain/384/RAS%20School%20Visit.pdf");
*/
Console.WriteLine("What is your name?");
string n = Console.ReadLine();

Console.WriteLine($"\nWelcome {n}, my dear reader. You are about to experience a wonderours tale. Prepare yourself for: Gentle Bull Co's - CYA AI generated story. \nAll credit for contents of story goes to publisher " +
    "of this link below:\nhttps://gentlebullco.medium.com/turn-chatgpt-into-an-open-ended-choose-your-own-adventure-game-and-role-play-any-story-you-want-ad4572cb9077\n\n" +
    "There will be paths that go no where on here. ChatGPT is down and this is a small unfinished story piece I found online. But it shows proof of concept.\n" +
    "Please engage fullscreen for optimal reading experience.");

Console.WriteLine("\nThis is will be a Choose Your Own Adventure style story. \n\nYou will be given the story in chunks. At the end of the chunk, you'll make a decision to shape the " +
    "story and \nthat's really it. Before we continue, I need to lay down how you make a choice.\nAt each selection point, you will be asked to make a selection. \n\n" +
    "Respond with the corresponding option number as an interger .\n\n" +
    "Do you understand?\n" +
    "      Option 1: Yes.\n" +
    "      Option 2: No.");
bool inst = true;
bool start = true;
do
{
    int understandInstructions = int.Parse(Console.ReadLine());
    if (understandInstructions == 1)
    {
        inst = false;
        Console.WriteLine("Fantastic, let's begin.\n\n____________________________________________________________________________________________");
        start = false;
        break;
    }
    else if (understandInstructions == 2)
    {
        Console.WriteLine("Read it over and try again.");
    }
    else
    {
        Console.WriteLine("Invalid response. Try again.");
    }
}
while (true);

//Starting line from other story which can be found at link above. Too big for current level. Will tackle later.
/*Console.WriteLine("It’s a gloomy Monday morning in late autumn. The school looks dark and ominous. Before you can even get to your locker,\n" +
    "the principal calls you into his office. " +

    "\n\n\"I know it’s you who’s been stealing all the oatmeal raisin cookies from the lunchroom,\" Dr. Donovan says with \n" +
    "a stern expression. \n\n" +

    "\"What?\" you ask in surprise. \"I don’t even like oatmeal--\"\n\n" +

    "Dr.Donovan waves your words away. \"I’m willing to let your petty thievery slide if you do me a favor. There’s a \n" +
    "rumor going around that the school is haunted, and now some of the teachers are too scared to come to work." +
    "\nI need you to check it out.\"\n\n" +

    "\"Um...okay,\" you say. Even though you weren’t the one who stole the cookies, it doesn’t sound like Dr. Donovan \n" +
    "is going to believe you.\n\n" +

    "\"Good decision,\" says Dr. Donovan. \"Talk to Mrs. Odell or Mr. Aumack first. You’re free to explore the entire school,\n" +
    "but DON’T GO IN THE ATTIC! From what I’ve heard, there’s a really scary ghost up there. " +
    "\nIt’s WAY too dangerous for a child.\" \n\n" +

    "\"When should I start?\" you ask.\n\n" +

    "Dr.Donovan checks his watch.\n\n" +

    "\"Right now,\" he says. \n\n______________________________\n" +

    "Choose your selection:\n" +
    "Option 1: Go see Mrs. Odell.\n" +

    "OR\n" +

    "Option 2: Go see Mr. Aumack.\n______________________________");
*/
Console.WriteLine("Quick Backstory\n" +
    "You are a new crew member on the USS Buttknuckle. The USS Buttknuckle is a cargo ship en route to a mining colony in an asteroid belt. " +
    "The Unified Galactic Government (UGG) is engaged in a war with space pirates, \nwho call themselves “The Unheard”. The pirates are vicious and will stop at nothing to " +
    "get what they want.\n\n");

Console.WriteLine("Our Character's Background\n" +
    "The leaders of the ship are Cal and Gus, two space entrepreneurs with a secret criminal past. Cal is witty and sarcastic, but strong willed and clever. Gus " +
    "is serious, but funny, and a good person. \nThe shipboard AI of the USS Buttknuckle is named Susana, and she is very sarcastic, but follows orders.");

Console.WriteLine("______________________________________________________________________________________________________________________________________________");
Console.WriteLine("\n\nYou wake up in your small bunk on the USS Buttknuckle. You’re still getting used to the constant hum of the engines and the low gravity. " +
    "You swing your legs over the side of your bed and stand up, \nfeeling a little dizzy. You look around your cramped quarters, taking in the few personal " +
    "items you’ve managed to bring with you on this long journey.\n\n" +
    "What do you do?\n");
Console.WriteLine("" +
    "      Option 1: Get dressed and head to the galley for breakfast.\n\n" +
    "      Option 2: Stay in your room and try to catch up on some sleep.\n\n" +
    "      Option 3: Head to the bridge to see what’s going on.");

bool start2 = true;
do
{
    //Console.WriteLine("________________________________");

    int path1 = int.Parse(Console.ReadLine());
    if (path1 == 1)
    {
        Console.WriteLine("Sure would be nice if they gave us some story here, huh? Select a different option path so you can hear the story.\n");
        start = false;
    }
    else if (path1 == 2)
    {
        Console.WriteLine("Sure would be nice if they gave us some story here, huh? Select a different option path so you can hear the story.");
        start = false;
    }
    else if (path1 == 3)
    {
        Console.WriteLine("\nHead to the Bridge to See What’s Going On.");
        start = false;
        break;
        start2 = false;
    }
    else
    {
        Console.WriteLine("Invalid option selection. Please try again.");
        start = false;
    }
}
while (start = true);

Console.WriteLine("______________________________________________________________________________________________________________________________________________\n");
Console.WriteLine("" +
    "You head to the bridge, trying to avoid bumping into any other crew members in the narrow corridors. When you arrive, you see Cal and Gus standing at the main console, " +
    "going over some data. \nSusana, the shipboard AI, is standing nearby, her holographic projection flickering slightly. She looks up as you enter and gives you a sarcastic " +
    "smile.\n\n" +
    "" +
    "“Well, well, if it isn’t the new kid,” she says. “Ready to take on the universe?”\n\n" +
    "What do you do?\n");
Console.WriteLine("" +
    "      Option 1: Ask Cal and Gus what’s going on.\n\n" +
    "      Option 2:  Ignore Susana and head to the galley for breakfast.\n\n" +
    "      Option 3: Try to strike up a conversation with Susana.");

bool start3 = true;
do
{
    //Console.WriteLine("________________________________");

    int path2 = int.Parse(Console.ReadLine());
    if (path2 == 1)
    {
        Console.WriteLine("I thought it sounded good too, but no dice. Select a different option path so you can hear the story.\n");
        start2 = false;
    }
    else if (path2 == 2)
    {
        Console.WriteLine($"How unfortunate {n}, who knows where this could've gone. Select a different option path so you can hear the story.\n");
        start2 = false;
    }
    else if (path2 == 3)
    {
        Console.WriteLine("\nTry to Strike Up A Conversation with Susana.");
        start2 = false;
        break;
        start3 = false;
    }
    else
    {
        Console.WriteLine("Invalid option selection. Please try again.");
        start2 = false;
    }

}
while (start2 = true);

Console.WriteLine("______________________________________________________________________________________________________________________________________________\n");
Console.WriteLine("" +
    "You approach Susana and ask her what’s going on. She looks at you for a moment, then gives you a sly smile. “I’m not supposed to say anything,” he says, “but Cal and " +
    "Gus are worried about a possible pirate attack. \nWe’re in the middle of an asteroid belt, and the pirates like to hide out here and attack ships passing through. " +
    "Cal and Gus are trying to figure out a plan to protect the ship.”\n\n" +

    "What do you do?\n");
Console.WriteLine("" +
    "      Option 1: Ask Cal and Gus if they need any help.\n\n" +
    "      Option 2: Head to the galley to grab some breakfast and wait for further instructions.\n\n" +
    "      Option 3: Ask Susana if she knows any way to contact the pirates and try to negotiate a peaceful solution.");

bool start4 = true;
do
{
    int path3 = int.Parse(Console.ReadLine());
    if (path3 == 1)
    {
        Console.WriteLine("\nAsk Cal and Gus if They Need Any Help.");
        start3 = false;
        break;
        start4 = false;
    }
    else if (path3 == 2)
    {
        Console.WriteLine($"Do your dreams go nowhere also {n}? Select a different option path so you can hear the story.\n");
        start3 = false;
    }
    else if (path3 == 3)
    {
        Console.WriteLine("Guess what? Select a different option path so you can hear the story.\n");
        start3 = false;
    }
    else
    {
        Console.WriteLine("Invalid option selection. Please try again.");
        start3 = false;
    }

}
while (start3 = true);

Console.WriteLine("______________________________________________________________________________________________________________________________________________\n");
Console.WriteLine("" +
    "You walk over to Cal and Gus and ask them if they need any help. Cal looks up from the console and gives you a wry smile. \n“Thanks for offering, kid,” he says, " +
    "“but I think we’ve got it covered. We’ve got a few tricks up our sleeves to deal with these pirates. \nJust stay out of trouble and follow orders, and we’ll be fine.” " +
    "Gus nods in agreement.”\n\n" +

    "What do you do?\n");
Console.WriteLine("" +
    "      Option 1: Ask Cal and Gus if they have any advice for dealing with pirates.\n\n" +
    "      Option 2: Head to the galley to grab some breakfast.\n\n" +
    "      Option 3: Head back to your quarters to wait for further instructions.");

bool start5 = true;
//do
//{
//    int switch1 = int.Parse(Console.ReadLine());
//    switch (switch1)
//    {
//        case 1:
//            Console.WriteLine("\nAsk Cal and Gus if They Have Any Advice for Dealing with Pirates.");
//            start4 = false;
//            break;
//            start5 = true;
//        case 2:
//            Console.WriteLine($"Sure would be nice if they gave us some story here, huh {n}? Select a different option path so you can hear the story.\n");
//            start4 = false;
//            break;
//        case 3:
//            Console.WriteLine("I thought it sounded good too, but no dice. Select a different option path so you can hear the story.\n");
//            start4 = false;
//            break;
//        default:
//            Console.WriteLine("Invalid option selection. Please try again.");
//            start4 = false;
//            break;
//    }
//}
//while (start4 =true);