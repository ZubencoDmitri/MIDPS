object Form1: TForm1
  Left = 192
  Top = 152
  Width = 338
  Height = 185
  Caption = 'Counter'
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
    Left = 84
    Top = 20
    Width = 158
    Height = 39
    Caption = 
      '                  Counter. '#13#10'Lucrare de laborator Nr.1 MIDPS.'#13#10' ' +
      '       Zubenco Dmitri , TI-145.'
  end
  object Button1: TButton
    Left = 56
    Top = 72
    Width = 75
    Height = 25
    Caption = 'Up'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 56
    Top = 104
    Width = 75
    Height = 25
    Caption = 'Down'
    TabOrder = 1
    OnClick = Button2Click
  end
  object Edit1: TEdit
    Left = 164
    Top = 72
    Width = 121
    Height = 21
    TabOrder = 2
    Text = '0'
  end
  object Button3: TButton
    Left = 212
    Top = 104
    Width = 75
    Height = 25
    Caption = 'Exit'
    TabOrder = 3
    OnClick = Button3Click
  end
end
