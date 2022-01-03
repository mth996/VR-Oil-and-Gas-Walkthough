using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillComponents : MonoBehaviour
{
    [Header("Ui Panel")]
    public GameObject StartPannel;
    public GameObject StartButton;
    public GameObject UiPanel;
    public GameObject BlowoutPreventerButton;

    [Header("Blowout Preventer Panel")]
    public GameObject BlowoutPreventerPanel;
    public GameObject BlowoutpreventernextButton;

    [Header("Quiz Panel")]
    public GameObject QuizPanel;
    
    [Header("Derrick Ui Panels")]
    public GameObject DerrickUiPanel;
    public GameObject IronRoughnecksButton;
    public GameObject TopdriveButton;
    public GameObject TurntableButton;
    public GameObject DerrickButton;
    public GameObject DrillstringButton;
    public GameObject DrillcollarButton;
    public GameObject DrawworksButton;
    public GameObject DerrickUiNextButton;

    [Header("Drill Collar Panel")]
    public GameObject DrillCollarPanel;
    public GameObject DrillCollarbackButton;

    [Header("IronRoughnecksPanel")]
    public GameObject IronRoughnecksPanel;
    public GameObject IronRoughnecksbackButton;

    [Header("DrawworksPanel")]
    public GameObject DrawworksPanel;
    public GameObject DrawworksbackButton;

    [Header("TopdrivePanel")]
    public GameObject TopdrivePanel;
    public GameObject TopdrivebackButton;

    [Header("Turntable Panel")]
    public GameObject TurntablePanel;
    public GameObject TurntablebackButton;

    [Header("Drill String Panel")]
    public GameObject DrillstringPanel;
    public GameObject DrillstringbackButton;


    [Header("Derrick Panel")]
    public GameObject DerrickPanel;
    public GameObject DerrickbackButton;

    [Header("Ui Pannel 2")]
    public GameObject UiPanel2;
    public GameObject MudpumpButton;
    public GameObject ShaleShakersButton;
    public GameObject Ui2PanelNextbutton;

    [Header("Mud Pump Panel")]
    public GameObject MudpumpPanel;
    public GameObject MudpumpbackButton;
    

    [Header("Shale shakers Panel")]
    public GameObject ShaleShakersPanel;
    public GameObject ShaleshakersbackButton;
  
    
    public void BlowoutPreventeron()
    {
        BlowoutPreventerPanel.SetActive(true);
        UiPanel.SetActive(false);
    }
    
    public void Starton()
    {
        BlowoutPreventerPanel.SetActive(true);
    }

    public void BlowoutPreventeroff()
    {
        BlowoutPreventerPanel.SetActive(false);
        UiPanel2.SetActive(true);
    }

    public void DrillCollaron()
    {
        DrillCollarPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
    }

    public void DrillCollaroff()
    {
        DrillCollarPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
    }

    public void DrillStringon()
    {
        DrillstringPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
    }

    public void DrillStringoff()
    {
        DrillstringPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
    }

    public void DrawWorkson()
    {
        DrawworksPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
    }

    public void DrawWorksoff()
    {
        DrawworksPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
    }

    public void Derrickon()
    {
        DerrickPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
    }

    public void Derrickoff()
    {
        DerrickPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
    }

    public void IronRoughneckson()
    {
        IronRoughnecksPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
    }

    public void IronRoughnecksoff()
    {
        IronRoughnecksPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
    }

    public void TopDriveon()
    {
        TopdrivePanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
    }

    public void TopDriveoff()
    {
        TopdrivePanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
    }

    public void Turntableon()
    {
        TurntablePanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
    }

    public void Turntableoff()
    {
        TurntablePanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
    }

    public void Ui2on()
    {
        UiPanel2.SetActive(true);
        MudpumpPanel.SetActive(false);
        ShaleShakersPanel.SetActive(false);
    }

    public void Mudpumpon()
    {
        UiPanel2.SetActive(false);
        MudpumpPanel.SetActive(true);
        ShaleShakersPanel.SetActive(false);
    }

    public void Shaleshakerson()
    {
        UiPanel2.SetActive(false);
        MudpumpPanel.SetActive(false);
        ShaleShakersPanel.SetActive(true);
    }

    public void DerrickNext()
    {
        QuizPanel.SetActive(true);
    }

    public void Ui2Next()
    {
        DerrickPanel.SetActive(true);
    }
  
    public void OnStartButtonClicked()
    {
        Starton();
    }

    public void OnBlowoutpreventerButtonClicked()
    {
        BlowoutPreventeron();
    }

    public void OnBlowoutpreventernextButtonClicked()
    {
        BlowoutPreventeroff();
    }

    public void OnDrillcollarButtonClicked()
    {
        DrillCollaron();
    }

    public void OnDrillcollarbackButtonClicked()
    {
        DrillCollaroff();
    }

    public void OnDrillstringButtonClicked()
    {
        DrillStringon();
    }

    public void OnDrillstringbackButtonClicked()
    {
        DrillStringoff();
    }

    public void OnDrawworksButtonClicked()
    {
        DrawWorkson();
    }

    public void OnDrawworksbackButtonClicked()
    {
        DrawWorksoff();
    }

    public void OnDerrickButtonClicked()
    {
        Derrickon();
    }

    public void OnDerrickbackButtonClicked()
    {
        Derrickoff();
    }

    public void OnIronRoughnecksButtonClicked()
    {
        IronRoughneckson();
    }

    public void OnIronRoughnecksbackButtonClicked()
    {
        IronRoughnecksoff();
    }

    public void OnTopdriveButtonClicked()
    {
        TopDriveon();
    }

    public void OnTopdrivebackButtonClicked()
    {
        TopDriveoff();
    }

    public void OnTurntableButtonClicked()
    {
        Turntableon();
    }

    public void OnTurntablebackButtonClicked()
    {
        Turntableoff();
    }

    public void OnMudpumpButtonClicked()
    {
        Mudpumpon();
    }

    public void OnMudpumpbackButtonClicked()
    {
        Ui2on();
    }
    public void OnShaleShakersButtonClicked()
    {
        Shaleshakerson();
    }

    public void OnShaleshakersbackButtonClicked()
    {
        Ui2on();
    }
    

    public void OnUi2NextButtonClicked()
    {
        Ui2Next();
        
    }

    public void OnDerrickUiNextButtonClicked()
    {
        DerrickNext();
    }

}


