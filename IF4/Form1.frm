VERSION 5.00
Object = "{C1951223-46B9-11CF-94E5-0000C0571740}#1.0#0"; "ngauge32.ocx"
Begin VB.Form Form1 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "NED Gauge Control Test Application"
   ClientHeight    =   4350
   ClientLeft      =   1140
   ClientTop       =   1515
   ClientWidth     =   6690
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   4350
   ScaleWidth      =   6690
   ShowInTaskbar   =   0   'False
   Begin VB.HScrollBar HScroll4 
      Height          =   255
      Left            =   4560
      Max             =   10
      TabIndex        =   21
      Top             =   3840
      Value           =   2
      Width           =   1935
   End
   Begin VB.Frame Frame3 
      Caption         =   "Outer Bevel"
      Height          =   1455
      Left            =   3600
      TabIndex        =   16
      Top             =   1800
      Width           =   1215
      Begin VB.OptionButton Option10 
         Caption         =   "Solid"
         Height          =   195
         Left            =   120
         TabIndex        =   19
         Top             =   1080
         Width           =   975
      End
      Begin VB.OptionButton Option9 
         Caption         =   "Raised"
         Height          =   195
         Left            =   120
         TabIndex        =   18
         Top             =   720
         Value           =   -1  'True
         Width           =   975
      End
      Begin VB.OptionButton Option8 
         Caption         =   "Inset"
         Height          =   195
         Left            =   120
         TabIndex        =   17
         Top             =   360
         Width           =   975
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Orientation"
      Height          =   1455
      Left            =   5040
      TabIndex        =   11
      Top             =   120
      Width           =   1335
      Begin VB.OptionButton Option7 
         Caption         =   "Top"
         Height          =   195
         Left            =   120
         TabIndex        =   15
         Top             =   1080
         Value           =   -1  'True
         Width           =   1095
      End
      Begin VB.OptionButton Option6 
         Caption         =   "Right"
         Height          =   195
         Left            =   120
         TabIndex        =   14
         Top             =   840
         Width           =   1095
      End
      Begin VB.OptionButton Option5 
         Caption         =   "Left"
         Height          =   195
         Left            =   120
         TabIndex        =   13
         Top             =   600
         Width           =   975
      End
      Begin VB.OptionButton Option4 
         Caption         =   "Bottom"
         Height          =   195
         Left            =   120
         TabIndex        =   12
         Top             =   360
         Width           =   1095
      End
   End
   Begin VB.HScrollBar HScroll3 
      Height          =   255
      Left            =   2400
      Max             =   10
      TabIndex        =   10
      Top             =   3840
      Value           =   2
      Width           =   1935
   End
   Begin VB.Frame Frame1 
      Caption         =   "Inner Bevel"
      Height          =   1455
      Left            =   3600
      TabIndex        =   5
      Top             =   120
      Width           =   1215
      Begin VB.OptionButton Option3 
         Caption         =   "Solid"
         Height          =   195
         Left            =   120
         TabIndex        =   8
         Top             =   1080
         Width           =   855
      End
      Begin VB.OptionButton Option2 
         Caption         =   "Raised"
         Height          =   195
         Left            =   120
         TabIndex        =   7
         Top             =   720
         Width           =   975
      End
      Begin VB.OptionButton Option1 
         Caption         =   "Inset"
         Height          =   195
         Left            =   120
         TabIndex        =   6
         Top             =   360
         Value           =   -1  'True
         Width           =   975
      End
   End
   Begin VB.HScrollBar HScroll2 
      Height          =   255
      LargeChange     =   3
      Left            =   240
      Max             =   30
      TabIndex        =   4
      Top             =   3840
      Value           =   3
      Width           =   1935
   End
   Begin VB.HScrollBar HScroll1 
      Height          =   255
      LargeChange     =   10
      Left            =   240
      Max             =   100
      TabIndex        =   1
      Top             =   3120
      Value           =   50
      Width           =   3015
   End
   Begin NedgaugeLib.Nedgauge Nedgauge1 
      Height          =   2655
      Left            =   480
      TabIndex        =   0
      Top             =   120
      Width           =   2655
      _Version        =   65536
      _ExtentX        =   4683
      _ExtentY        =   4683
      _StockProps     =   1
      NeedleColor     =   16711680
      BorderColor     =   0
      Min             =   0
      Max             =   100
      Pos             =   50
      OuterBevel      =   1
      InnerBevel      =   0
      OuterBevelWidth =   2
      InnerBevelWidth =   2
      BorderWidth     =   3
      ShadowColor     =   8421504
      HiliteColor     =   16777215
      HighAlarmColor  =   255
      LowAlarmColor   =   65280
      HighAlarm       =   90
      LowAlarm        =   10
      Orientation     =   3
      FaceColor       =   12632256
      NormalColor     =   12648447
   End
   Begin VB.Label Label4 
      Caption         =   "Outer Bevel Width"
      Height          =   255
      Left            =   4560
      TabIndex        =   20
      Top             =   3600
      Width           =   1455
   End
   Begin VB.Label Label3 
      Caption         =   "Inner Bevel Width"
      Height          =   255
      Left            =   2400
      TabIndex        =   9
      Top             =   3600
      Width           =   1575
   End
   Begin VB.Label Label2 
      Caption         =   "Border Width"
      Height          =   255
      Left            =   240
      TabIndex        =   3
      Top             =   3600
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Gauge Position"
      Height          =   255
      Left            =   240
      TabIndex        =   2
      Top             =   2880
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub HScroll1_Change()
Nedgauge1.Pos = HScroll1.Value
End Sub

Private Sub HScroll2_Change()
    Nedgauge1.BorderWidth = HScroll2.Value
End Sub


Private Sub HScroll3_Change()
    Nedgauge1.InnerBevelWidth = HScroll3.Value
End Sub

Private Sub HScroll4_Change()
    Nedgauge1.OuterBevelWidth = HScroll4.Value
End Sub

Private Sub Nedgauge1_Alarm(Alarm As Integer)
    If Alarm = 1 Then
        MsgBox ("Gauge 1 Low Alarm!")
    Else
        MsgBox ("Gauge 1 High Alarm!")
    End If
    
End Sub


Private Sub Option1_Click()
    Nedgauge1.InnerBevel = 0
End Sub


Private Sub Option10_Click()
    Nedgauge1.OuterBevel = 2
End Sub

Private Sub Option2_Click()
    Nedgauge1.InnerBevel = 1
End Sub


Private Sub Option3_Click()
    Nedgauge1.InnerBevel = 2
End Sub


Private Sub Option4_Click()
Nedgauge1.Orientation = 0
End Sub


Private Sub Option5_Click()
Nedgauge1.Orientation = 1
End Sub


Private Sub Option6_Click()
    Nedgauge1.Orientation = 2
End Sub


Private Sub Option7_Click()
    Nedgauge1.Orientation = 3
End Sub


Private Sub Option8_Click()
    Nedgauge1.OuterBevel = 0
End Sub


Private Sub Option9_Click()
    Nedgauge1.OuterBevel = 1
End Sub


