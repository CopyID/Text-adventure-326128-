using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class's'
public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        Start,
        Remenu,
        Intro,
        Trainstop,
        Wait1,
        Wait2,
        Wait3,
        Boringdeath,
        TrainOperator1,
        TrainOperator2,
        Inspect,
        Run1,
        Ghost,
        Q1A1,
        Q1A2,
        Q1A3,
        Q2,
        Q2A1,
        Q2A2,
        Q3,
        Q3A1,
        Q3A2,
        Possesed,
        Leave,
        Password,
        PassCorrect,
        PassWrong
    }

    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        Terminal.WriteLine("Hello Again World!");
        ShowMainMenu();
    }

    //Main menu
    void ShowMainMenu ()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello and welcome to the C.U. Labs     brain testing experience.");
        Terminal.WriteLine("Here we will test your brain with a    simple text based game.");
        Terminal.WriteLine("We wish you good luck!");
        Terminal.WriteLine("Game selected: Train Ride.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[start]");
        Terminal.WriteLine(" ");
    }

    void OnUserInput(string input)
    {
        if (currentState == States.Start)
        {
            if (input == "start")
            {
                StartIntro();
            }
            else if (input == "Eye C.U.")
            {
                Terminal.WriteLine("Sorry, the C.U. Myth Arcade is not     available in this game.");
            }
            else
            {
                Terminal.WriteLine("You need to type 'start' to start.");
            }
        }
        else if (currentState == States.Remenu)
        {
            if (input == "start")
            {
                StartIntro();
            }
            else if (input == "Eye C.U.")
            {
                Terminal.WriteLine("Sorry, the C.U. Myth Arcade is not     available in this game.");
            }
            else
            {
                Terminal.WriteLine("You need to type 'start' to start.");
            }

        }
        else if (currentState == States.Intro)
        {
            if (input == "continue")
            {
                StandStill();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Trainstop)
        {
            if (input == "yes")
            {
                CheckOperatorA();
            }
            if (input == "no")
            {
                PlayerWait1();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Wait1)
        {
            if (input == "continue")
            {
                CheckOperatorB();
            }
            if (input == "no")
            {
                PlayerWait2();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Wait2)
        {
            if (input == "continue")
            {
                CheckOperatorB();
            }
            if (input == "yes")
            {
                PlayerWait3();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }
        }
        else if (currentState == States.Wait3)
        {
            if (input == "continue")
            {
                CheckOperatorB();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }
            if (input == "yes")
            {
                Playerdeathbored();
            }
        }
        else if (currentState == States.Boringdeath)
        {
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }
        }
        else if (currentState == States.TrainOperator1)
        {
            if (input == "inspect")
            {
                Inspect();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }
            if (input == "run")
            {
                PlayerRun1();
            }
        }
        else if (currentState == States.TrainOperator2)
        {
            if (input == "inspect")
            {
                Inspect();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }
            if (input == "run")
            {
                PlayerRun1();
            }
        }
        else if (currentState == States.Inspect)
        {
            if (input == "continue")
            {
                ghosty();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Run1)
        {
            if (input == "continue")
            {
                ghosty();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Ghost)
        {
            if (input == "1")
            {
                Q1A1();
            }
            if (input == "2")
            {
                Q1A2();
            }
            if (input == "3")
            {
                Q1A3();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q1A1)
        {
            if (input == "continue")
            {
                Q2();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q1A2)
        {
            if (input == "continue")
            {
                Q2();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q1A3)
        {
            if (input == "continue")
            {
                Q3();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q2)
        {
            if (input == "continue")
            {
                NoSmack1();
            }
            if (input == "smack")
            {
                Smack1();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q2A1)
        {
            if (input == "leave")
            {
                Leave();
            }
            if (input == "password")
            {
                Password();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q2A2)
        {
            if (input == "continue")
            {
                Smack2();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q3)
        {
            if (input == "continue")
            {
                NoSmack2();
            }
            if (input == "smack")
            {
                Smack2();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q2A1)
        {
            if (input == "leave")
            {
                Exit();
            }
            if (input == "password")
            {
                Password();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q2A2)
        {
            if (input == "continue")
            {
                NoSmack2();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q3A1)
        {
            if (input == "leave")
            {
                Exit();
            }
            if (input == "stay")
            {
                Possesed();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Q3A2)
        {
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }

        }
        else if (currentState == States.Password)
        {
            if (input == "ghost town")
            {
                PassCorrect();
            }
            if (input == "restart")
            {
                StartIntro();
            }
            if (input == "menu")
            {
                ReMenu();
            }
            else
            {
                PassWrong();
            }

        }
        
    }

    
    void ReMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello and welcome to the C.U. Labs     brain testing experience.");
        Terminal.WriteLine("Here we will test your brain with a    simple text based game.");
        Terminal.WriteLine("We wish you good luck!");
        Terminal.WriteLine("Game selected: Train Ride.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[start]");
        Terminal.WriteLine(" ");
        currentState = States.remenu;
    }
    
    
    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Its a normal day, you are on the train to go to your vacation destination.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue]");
        Terminal.WriteLine(" ");
        currentState = States.intro;
    }

    void StandStill()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Out of nowhere, the train stops. Check on the train operator?");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[yes/no]");
        Terminal.WriteLine(" ");
        currentState = States.trainstop;
    }
    
    void PlayerWait1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("After waiting for an hour and nothing  happening, you decide its probably a    good idea to check on the train operator anyway.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue/no]");
        Terminal.WriteLine(" ");
        currentState = States.wait1;
    }
    
    void PlayerWait2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Are you sure? if you keep waiting      nothing happens?");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue/yes]");
        Terminal.WriteLine(" ");
        currentState = States.wait2;
    }
    
    void PlayerWait3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Are you 100% sure you are just going   to do nothing?!?!");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue/yes]");
        Terminal.WriteLine(" ");
        currentState = States.wait3;
    }
    
    void Playerdeathbored()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hours pass while you wait. After a     while, you die of because of lack of    action");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("{Ending: Bored to death}");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[menu/restart]");
        Terminal.WriteLine(" ");
        currentState = States.boringdeath;
    }
    void CheckOperatorA()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You find the operator dead at his seat.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[inspect/run]");
        Terminal.WriteLine(" ");
        currentState = States.TrainOperator1;
    }
    
    void CheckOperatorB()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You find the operator dead at his seat.");
        Terminal.WriteLine("He smells.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[inspect/run]");
        Terminal.WriteLine(" ");
        currentState = States.TrainOperator2;
    }
    
    void Inspect()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You inspect the operator's body. You   find a peace of paper, it says");
        Terminal.WriteLine("'Pass =  ghost town'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue]");
        Terminal.WriteLine(" ");
        currentState = States.Inspect;
    }
    
    void PlayerRun1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("While running, you smack into the door.It seems like the door has been locked  behind you.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue]");
        Terminal.WriteLine(" ");
        currentState = States.Run1;
    }
    
    void ghosty()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Out of nowhere, a ghost appears.");
        Terminal.WriteLine("{ghost}: 'Hello there...'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[1] Hello mr. ghost.");
        Terminal.WriteLine("[2] What is going on?!");
        Terminal.WriteLine("[3] I knew I shouldn't have eaten that     spaghetti.");
        Terminal.WriteLine(" ");
        currentState = States.Ghost;
    }
    
    void Q1A1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}: 'I am the ghost of this                 railway. You have come here             without permission.'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue]");
        Terminal.WriteLine(" ");
        currentState = States.Q1A1;
    }
    
    void Q1A2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}: 'You have entered my railway            without permission.'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue]");
        Terminal.WriteLine(" ");
        currentState = States.Q1A2;
    }
    
    void Q1A3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("The ghost grabs a glove and smacks you.");
        Terminal.WriteLine("{ghost}: 'This has nothing to do with            your spaghetti!'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue]");
        Terminal.WriteLine(" ");
        currentState = States.Q1A3;
    }
    
    void Q2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'Leave my railway at once!'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue/smack]");
        Terminal.WriteLine(" ");
        currentState = States.Q2;
    }
    
    void Q3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'Alright, where ware we.'");
        Terminal.WriteLine("{ghost}:'oh yea. Leave my railway at            once!'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue/smack]");
        Terminal.WriteLine(" ");
        currentState = States.Q3;
    }
    
    void NoSmack1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'Well, I guess you havn't               been TO bothering. I will give          you a chance to stay, IF you            know the secret password.'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[password/leave]");
        Terminal.WriteLine(" ");
        currentState = States.Q2A1;
    }
    
    void Smack1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'You know you can't hit a               ghost, right?'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[continue]");
        Terminal.WriteLine(" ");
        currentState = States.Q2A2;
    }
    
    void NoSmack2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'You have been bothering me             quite a bit, LEAVE!'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[leave/stay]");
        Terminal.WriteLine(" ");
        currentState = States.Q3A1;
    }
    
    void Smack2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'This isn't worth it...'");
        Terminal.WriteLine("The ghost smacks you in the face. He   does with so much force, that you die.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("{Ending: A smack to the face}");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[menu/restart]");
        Terminal.WriteLine(" ");
        currentState = States.Q3A2;
    }
    
    void PassWrong()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'That is wrong! As a consequence for getting the password wrong, I'll posses your body, lucky you.'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("{Ending: A smack to the face}");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[menu/restart]");
        Terminal.WriteLine(" ");
        currentState = States.PassWrong;
    }
    
    void Password()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'Alright, what is the password''");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("|Insert Password|");
        Terminal.WriteLine(" ");
        currentState = States.Password;
    }
    
    void PassCorrect()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'Correct! Alright, I'll let you stay for a while. And I guess we could have a conversation. It can be quite lonely haunting a railway.''");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("{Ending: A smack to the face}");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[menu/restart]");
        Terminal.WriteLine(" ");
        currentState = States.PassCorrect;
    }
    
    void Possesed()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'That is wrong! As a consequence for getting the password wrong, I'll posses your body, lucky you.'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("{Ending: A smack to the face}");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[menu/restart]");
        Terminal.WriteLine(" ");
        currentState = States.Q3A2;
    }
    
    void Exit()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You deside to leave the ghost alone and leave the train. You walk for hours to get back to a station.");
        Terminal.WriteLine("Then you remember you left all your stuff in the train, so you have nothing with you.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("{Ending: 'Escaped'}");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[menu/restart]");
        Terminal.WriteLine(" ");
        currentState = States.Q3A2;
    }
    
    void Leave()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("{ghost}:'This isn't worth it...'");
        Terminal.WriteLine("The ghost smacks you in the face. He   does with so much force, that you die.'");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("{Ending: A smack to the face}");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("[menu/restart]");
        Terminal.WriteLine(" ");
        currentState = States.Q3A2;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
