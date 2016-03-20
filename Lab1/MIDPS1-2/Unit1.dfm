object Form1: TForm1
  Left = 192
  Top = 152
  Width = 319
  Height = 234
  Caption = 'Timer'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 64
    Top = 8
    Width = 165
    Height = 39
    Caption = 
      '                    Timer'#13#10'Lucrarea de Laborator Nr.1 MIDPS'#13#10'   ' +
      '      Zubenco Dmitri, TI-145'
  end
  object Button1: TButton
    Left = 196
    Top = 144
    Width = 75
    Height = 25
    Caption = 'Exit'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Edit1: TEdit
    Left = 152
    Top = 84
    Width = 121
    Height = 21
    TabOrder = 1
    Text = '00:00:00'
  end
  object Button2: TButton
    Left = 40
    Top = 84
    Width = 75
    Height = 25
    Caption = 'Start'
    TabOrder = 2
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 40
    Top = 112
    Width = 75
    Height = 25
    Caption = 'Stop'
    TabOrder = 3
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 40
    Top = 144
    Width = 75
    Height = 25
    Caption = 'Reset'
    TabOrder = 4
    OnClick = Button4Click
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 276
    Top = 168
  end
end
