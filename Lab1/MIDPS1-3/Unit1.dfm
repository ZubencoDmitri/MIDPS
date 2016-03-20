object Form1: TForm1
  Left = 192
  Top = 153
  Width = 546
  Height = 315
  Caption = 'Grafic'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object PaintBox1: TPaintBox
    Left = 196
    Top = 52
    Width = 305
    Height = 217
    OnPaint = PaintBox1Paint
  end
  object Label1: TLabel
    Left = 132
    Top = 16
    Width = 277
    Height = 13
    Caption = 'Grafic. Lucrarea de Laborator Nr.1. Zubenco Dmitri, TI-145'
  end
  object Button1: TButton
    Left = 24
    Top = 192
    Width = 75
    Height = 25
    Caption = 'Exit'
    TabOrder = 0
    OnClick = Button1Click
  end
  object start: TButton
    Left = 24
    Top = 56
    Width = 75
    Height = 25
    Caption = 'Start'
    TabOrder = 1
    OnClick = startClick
  end
  object stop: TButton
    Left = 24
    Top = 96
    Width = 75
    Height = 25
    Caption = 'Stop'
    TabOrder = 2
    OnClick = stopClick
  end
  object Panel1: TPanel
    Left = 132
    Top = 56
    Width = 29
    Height = 209
    Color = clMenuHighlight
    TabOrder = 3
  end
  object Panel2: TPanel
    Left = 132
    Top = 56
    Width = 29
    Height = 209
    Color = clBackground
    TabOrder = 4
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 484
    Top = 12
  end
end
