using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Charinfo : MonoBehaviour
{
    public Text Changingtext;
    public void ChangeText(int charint)
    {
        switch (charint) {
            case 1:
                Changingtext.text = "Ladys from Tinder, heyits_borna is my snapchat ID, but I also go by ShadowExcel. Feel free to add me if u r a Big Titty Goth Chick  \r\n Age:19 \r\n  \r\n Hip:20cm \r\n Butt:30cm \r\n ";
                break;
            case 2:
                Changingtext.text = "AYY its Pavel, add me on league if you are a big titty E-girl. My name is Papa Pape, and I will carry your fat ass like this box of chidos \r\n Age:19 \r\n Breast:61cm \r\n Hip:21cm \r\n Butt:31cm \r\n ";
                break;
            case 3:
                Changingtext.text = "Hi Im Petr and I have a girl friend \r\n \r\n \r\n \r\n \r\n Age:19 \r\n  Hip:80cm \r\n Butt:80cm \r\n";
                break;
            case 4:
                Changingtext.text = "Hi Im Niclas  I am still going to slide tackle GIBBZ with the help of my wing man Alex Chen\r\n \r\n Age:19 \r\n \r\n Hip:8cm \r\n Butt:8cm \r\n ";
                break;
            case 5:
                Changingtext.text = "Hello Everyone My name is Ivor, and you guys are welcome to my communist minecraft server, the only rule is please dont build Aushwiz  Age:19 \r\n \r\n Hip:65cm \r\n Butt:10cm \r\n ";
                break;
        }
      
    }
    public void ChangeBossText(int charint)
    {
        switch (charint)
        {
            case 1: Changingtext.color = new Color(1, 1, 1, 1);
                Changingtext.text = "Stephen Graham, Benglish teacher who can not be exposed to loud noises   ";
                break;
            case 2: Changingtext.color = new Color(1, 1, 1, 1);
                Changingtext.text = "Mr. Wilson comes from Austrilia a place on the opposite side of the globe";
                break;
            case 3: Changingtext.color = new Color(1,1, 1, 1);
                Changingtext.text = "Sarah Hawkins the name given to the fish whom came from the Uninted kingdem and got washed to she shoreds of the medetaranian sea and up to the sinks of the bio lab of Aisz. She desguises herself as a human but she still has some fish like behaviors, for example she swims in the middle of peoplpe when she is in a hallway and says excuse me, she carrys a fish bowl when she was pregenated by tomislav AKA aquaman which further proves she is indeed a fish";
                break;
            case 4:
                Changingtext.color = new Color(0, 0, 0, 1);
                Changingtext.text = "After realizing that add a france falg to her fb profile picture would not bring back the people killed by the terriors in the paris attack, ms sprilian has had enough, she yelled fuck paris imma become a jedi and awakened the force within her how she is a protector of the galaxy, however wherether she will be able to stop the dark side remains unclear...";
                break;
            case 5:
                Changingtext.color = new Color(1, 1, 1, 1);
                Changingtext.text = "Snooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooopy";
                break;
        }

    }
}
