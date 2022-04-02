using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Android;

public class LoginSystem : MonoBehaviour
{
    public string kullanıcıAdı;
    public string sifre;
    public string HackerName;
    string HackNote1;

    public GameObject InputFieldUsername;
    public GameObject InputFieldPassword;
    //public GameObject InputFieldHackerNote1;
    public Text GirisText;
    public Text HackerNameText;
    public string[] Deneme;

    public Text nameHackerText;
    public Text HackerBirthdayText;
    public Text HackerJobText;
    public Text HackerRoleText;

    public GameObject LoginPanel;
    public GameObject welcomePanel;
    public GameObject HackerProfilePanel;
    public GameObject ProgramInfoPanel;
    public GameObject HackerNotesPanel;
    //public GameObject SelectNotesPanel;
    public GameObject LogoutSurePanel;

    public bool HackerProfilePanelBool = false;
    public bool WelcomPanelBool = false;
    public bool SplitControlBool = false;
    public bool ProgramInfoBool =false;
    public bool HackerNotesPanelBool = false;



    [Header("HackerNotes Text's")]
    public string Note1;
    public Text Note1Header;
    public string Note2;
    public Text Note2Header;
    public string Note3;
    public Text Note3Header;
    public string Note4;
    public Text Note4Header;
    public string Note5;
    public Text Note5Header;
    public string Note6;
    public Text Note6Header;
    public string Note7;
    public Text Note7Header;
    public string Note8;
    public Text Note8Header;
    public string Note9;
    public Text Note9Header;
    public string Note10;
    public Text Note10Header;

    [Header("Notes Panels")]
    public GameObject SelectNotesPanel;
    public GameObject Note1Panel;
    public GameObject Note2Panel;
    public GameObject Note3Panel;
    public GameObject Note4Panel;
    public GameObject Note5Panel;
    public GameObject Note6Panel;
    public GameObject Note7Panel;
    public GameObject Note8Panel;
    public GameObject Note9Panel;
    public GameObject Note10Panel;

    [Header("HackerNotes InputField's")]
    public GameObject InputFieldHackerNote1;
    public GameObject InputFieldHackerNote2;
    public GameObject InputFieldHackerNote3;
    public GameObject InputFieldHackerNote4;
    public GameObject InputFieldHackerNote5;
    public GameObject InputFieldHackerNote6;
    public GameObject InputFieldHackerNote7;
    public GameObject InputFieldHackerNote8;
    public GameObject InputFieldHackerNote9;
    public GameObject InputFieldHackerNote10;

    bool izinBool = true;

    void Start()
    {
       
        LoginPanel.SetActive(true);
        welcomePanel.SetActive(false);
        LogoutSurePanel.SetActive(false);
        HackerNotesPanel.SetActive(false);
        SelectNotesPanel.SetActive(false);
        HackNote1 = " ";

        GirisText.text = "            &               &                      &               &                &           &          ";
        //GirisTextFilter.text = "Emirhan Soylu&İstanbul&Türkiye&Founder/CEO";
        //Deneme = GirisTextFilter.text.Split(new char[] {'&'});
    }

    
    void Update()
    {
        if(izinBool)
        {
            //----------------------------------------------------------Permissions---------------------------------------------------------------

            AndroidRuntimePermissions.Permission[] izinler = AndroidRuntimePermissions.RequestPermissions("android.permission.WRITE_EXTERNAL_STORAGE", "android.permission.CAMERA");
            if (izinler[0] == AndroidRuntimePermissions.Permission.Granted && izinler[1] == AndroidRuntimePermissions.Permission.Granted)
            {
                Debug.Log("Tüm izinlere sahibiz!");
                izinBool = false;
            }
            else
            {
                Debug.Log("Bazı izinlere sahip değiliz...");
            }
            //------------------------------------------------------------------------------------------------------------------------------------
        }


        kullanıcıAdı = InputFieldUsername.GetComponent<Text>().text;
        sifre = InputFieldPassword.GetComponent<Text>().text;


        Deneme = GirisText.text.Split(new char[] { '&' });

        if(SplitControlBool)
        {
            
        }

        if (Deneme[0] == "Database Connected Succesfully ---> Login SUCCESS!!" && !WelcomPanelBool)
        {
            LoginPanel.SetActive(false);
            welcomePanel.SetActive(true);
            WelcomPanelBool = true;
        }

        if(WelcomPanelBool)
        {
            HackerNameText.text = kullanıcıAdı;
           
        }
        //----------------------------------------------------HACKER PROFILE---------------------------------------------------------------------
        if (HackerProfilePanelBool)
        {
            nameHackerText.text = Deneme[4];
            if(nameHackerText.text == " ")
            {
                nameHackerText.text = "Unknown!";
            }
            HackerBirthdayText.text = Deneme[5];
            if (HackerBirthdayText.text == " ")
            {
                HackerBirthdayText.text = "Unknown!";
            }
            HackerJobText.text = Deneme[6];
            if (HackerJobText.text == " ")
            {
                HackerJobText.text = "Unknown!";
            }
            HackerRoleText.text = Deneme[7];
            if (HackerRoleText.text == " ")
            {
                HackerRoleText.text = "Unknown!";
            }

        }
        //----------------------------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------Hacker Notes-----------------------------------------------------------
        if(HackerNotesPanelBool)
        {
            Note1 = Deneme[8];
            Note2 = Deneme[9];
            Note3 = Deneme[10];
            Note4 = Deneme[11];
            Note5 = Deneme[12];
            Note6 = Deneme[13];
            Note7 = Deneme[14];
            Note8 = Deneme[15];
            Note9 = Deneme[16];
            Note10 = Deneme[17];

            if (Note1 == " ")
            {
                Note1Header.text = "-NULL NOTE-";
            }
            else
            {
                Note1Header.text = Note1.Substring(0, 15) + "...";
            }


            if (Note2 == " ")
            {
                Note2Header.text = "-NULL NOTE-";
            }
            else
            {
                Note2Header.text = Note2.Substring(0, 15) + "...";
            }


            if (Note3 == " ")
            {
                Note3Header.text = "-NULL NOTE-";
            }
            else
            {
                Note3Header.text = Note3.Substring(0, 15) + "...";
            }


            if (Note4 == " ")
            {
                Note4Header.text = "-NULL NOTE-";
            }
            else
            {
                Note4Header.text = Note4.Substring(0, 15) + "...";
            }


            if (Note5 == " ")
            {
                Note5Header.text = "-NULL NOTE-";
            }
            else
            {
                Note5Header.text = Note5.Substring(0, 15) + "...";
            }


            if (Note6 == " ")
            {
                Note6Header.text = "-NULL NOTE-";
            }
            else
            {
                Note6Header.text = Note6.Substring(0, 15) + "...";
            }

            if (Note7 == " ")
            {
                Note7Header.text = "-NULL NOTE-";
            }
            else
            {
                Note7Header.text = Note7.Substring(0, 15) + "...";
            }


            if (Note8 == " ")
            {
                Note8Header.text = "-NULL NOTE-";
            }
            else
            {
                Note8Header.text = Note8.Substring(0, 10) + "...";
            }


            if (Note9 == " ")
            {
                Note9Header.text = "-NULL NOTE-";
            }
            else
            {
                Note9Header.text = Note9.Substring(0, 15) + "...";
            }


            if (Note10 == "")
            {
                Note10Header.text = "-NULL NOTE-";
            }
            else
            {
                Note10Header.text = Note10.Substring(0, 15) + "...";
            }

        }

        //------------------------------------------------------------------------------------------------------------------------------------

    }
    IEnumerator LoginS(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginuser", username);
        form.AddField("loginpass", password);



        using (UnityWebRequest www = UnityWebRequest.Post("http://login.yigittaekwondo.com/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                GirisText.text = www.downloadHandler.text;
                //Text Animasyonu kodlarını yaz!
            }

        }

    }


    IEnumerator NoteS(string username, string password, string hackersnote1)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginuser", username);
        form.AddField("loginpass", password);
        form.AddField("hnote1", hackersnote1);


        using (UnityWebRequest www = UnityWebRequest.Post("http://login.yigittaekwondo.com/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                GirisText.text = www.downloadHandler.text;
                //Text Animasyonu kodlarını yaz!
            }
        
        }

    }


    public void LoginButton()
    {
        StartCoroutine(LoginS(kullanıcıAdı, sifre));
        SplitControlBool = true;
        
    }

    public void LogoutButton()
    {
        LogoutSurePanel.SetActive(true);
    }

    public void LogoutSureYesButton()
    {
        welcomePanel.SetActive(false);
        LoginPanel.SetActive(true);
        LogoutSurePanel.SetActive(false);
        //WelcomPanelBool = false;
    }

    public void LogoutSureNoButton()
    {
        LogoutSurePanel.SetActive(false);
    }

    public void HackerProfileButton()
    {
        HackerProfilePanel.SetActive(true);
        welcomePanel.SetActive(false);

        WelcomPanelBool = false;
        HackerProfilePanelBool = true;
        HackerNameText.text = HackerName;
    }

    public void HackerProfileBackButton()
    {
        HackerProfilePanel.SetActive(false);
        welcomePanel.SetActive(true);
        WelcomPanelBool = true;
        HackerProfilePanelBool = false;
    }

    public void ProgramInfoButton()
    {
        welcomePanel.SetActive(false);
        ProgramInfoPanel.SetActive(true);

        WelcomPanelBool = false;
        ProgramInfoBool = true;
    }

    public void ProgramInfoBackButton()
    {
        welcomePanel.SetActive(true);
        ProgramInfoPanel.SetActive(false);

        WelcomPanelBool = true;
        ProgramInfoBool = false;
    }

    public void HackerNotesButton()
    {
        welcomePanel.SetActive(false);
        HackerNotesPanel.SetActive(true);

        HackerNotesPanelBool = true;
    }

    public void HackerNotesBackButton()
    {
        welcomePanel.SetActive(true);
        HackerNotesPanel.SetActive(false);

        HackerNotesPanelBool = false;
    }

    public void SelectNoteButton()
    {
        SelectNotesPanel.SetActive(true);
    }

    public void SaveNoteButton()
    {
        HackNote1 = InputFieldHackerNote1.GetComponent<Text>().text;
        StartCoroutine(NoteS(kullanıcıAdı, sifre, HackNote1));
    }

    //-------------------------------------------------Note Select - Back Buttons------------------------------------------------------------------
    public void SelectNote1Button()
    {
        SelectNotesPanel.SetActive(false);
        Note1Panel.SetActive(true);
    }

    public void Note1Back()
    {
        Note1Panel.SetActive(false);
    }
    public void SelectNote2Button()
    {
        SelectNotesPanel.SetActive(false);
        Note2Panel.SetActive(true);
    }

    public void Note2Back()
    {
        Note2Panel.SetActive(false);
    }

    public void SelectNote3Button()
    {
        SelectNotesPanel.SetActive(false);
        Note3Panel.SetActive(true);
    }

    public void Note3Back()
    {
        Note3Panel.SetActive(false);
    }

    public void SelectNote4Button()
    {
        SelectNotesPanel.SetActive(false);
        Note4Panel.SetActive(true);
    }

    public void Note4Back()
    {
        Note4Panel.SetActive(false);
    }

    public void SelectNote5Button()
    {
        SelectNotesPanel.SetActive(false);
        Note5Panel.SetActive(true);
    }

    public void Note5Back()
    {
        Note5Panel.SetActive(false);
    }

    public void SelectNote6Button()
    {
        SelectNotesPanel.SetActive(false);
        Note6Panel.SetActive(true);
    }

    public void Note6Back()
    {
        Note6Panel.SetActive(false);
    }

    public void SelectNote7Button()
    {
        SelectNotesPanel.SetActive(false);
        Note7Panel.SetActive(true);
    }

    public void Note7Back()
    {
        Note7Panel.SetActive(false);
    }

    public void SelectNote8Button()
    {
        SelectNotesPanel.SetActive(false);
        Note8Panel.SetActive(true);
    }

    public void Note8Back()
    {
        Note8Panel.SetActive(false);
    }

    public void SelectNote9Button()
    {
        SelectNotesPanel.SetActive(false);
        Note9Panel.SetActive(true);
    }

    public void Note9Back()
    {
        Note9Panel.SetActive(false);
    }

    public void SelectNote10Button()
    {
        SelectNotesPanel.SetActive(false);
        Note10Panel.SetActive(true);
    }

    public void Note10Back()
    {
        Note10Panel.SetActive(false);
    }
    //-------------------------------------------------------------------------------------------------------------------------------------
}

