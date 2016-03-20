//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
#include <stdio.h>

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"


int width;
int height;
int x;
int y;

TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
        stop->Enabled = false;
        //srand(time(NULL));
}
//---------------------------------------------------------------------------

void __fastcall TForm1::PaintBox1Paint(TObject *Sender)
{
        PaintBox1->Canvas->Pen->Color = clBlack;
        PaintBox1->Canvas->Brush->Color = clBlack;
        PaintBox1->Canvas->Brush->Style = bsCross;
        PaintBox1->Canvas->Rectangle(0, 0, PaintBox1->Width, PaintBox1->Height);

}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
Close();
}
//---------------------------------------------------------------------------
void DrawLine()
{
        y = (height / 2.0) + (rand() % 41 - 20);
        Form1->PaintBox1->Canvas->LineTo(++x, y);
        Form1->Panel2->Height = y;
}
void __fastcall TForm1::stopClick(TObject *Sender)
{
        Timer1->Enabled = false;
        start->Enabled = true;
        stop->Enabled = false;

}
//---------------------------------------------------------------------------
void __fastcall TForm1::startClick(TObject *Sender)
{
        PaintBox1->Repaint();
        PaintBox1->Canvas->Pen->Color = clRed;
        width = Form1->PaintBox1->Width;
        height = Form1->PaintBox1->Height;
        x = 0;
        PaintBox1->Canvas->MoveTo(0, height / 2.0);
        stop->Enabled = true;
        start->Enabled = false;
        Timer1->Enabled = true;

}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
  if(x == width)
                stopClick(Sender);
        else DrawLine();

}
//---------------------------------------------------------------------------
