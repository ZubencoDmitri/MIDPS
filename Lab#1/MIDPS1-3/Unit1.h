//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TPaintBox *PaintBox1;
        TButton *Button1;
        TTimer *Timer1;
        TButton *start;
        TButton *stop;
        TPanel *Panel1;
        TPanel *Panel2;
        TLabel *Label1;
        void __fastcall PaintBox1Paint(TObject *Sender);
        void __fastcall Button1Click(TObject *Sender);
        void __fastcall stopClick(TObject *Sender);
        void __fastcall startClick(TObject *Sender);
        void __fastcall Timer1Timer(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
