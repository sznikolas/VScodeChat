using System;
using Gtk;

namespace asd
{        class Program
    {
        
 
      
        public static void Main(string[] args)
        {
            Application.Init();

            Window myWindow = new Window("Szamologep");
            myWindow.Resize(500,500);
            

            VBox myBox = new VBox();
            myWindow.Add(myBox);
            
            Table myTable = new Table(7,4,true);  //eloszor az oszlopot adom meg, utana a sort.
            myBox.Add(myTable);

            Button exit = new Button("Kilepes");
            exit.Released+=delegate{Application.Quit();}; //kilep a programbol

            Label text1 = new Label();
            //myTable.Add(text1);
            Label text2 = new Label();
            Label text3 = new Label();
            Label text4 = new Label();
            Label text5 = new Label();
            //text4.Text="=";

            int a =0;
            int b =0;
            int c =0;
            int d = 0;

            Button btn0 = new Button("0");
            btn0.Clicked += nulla;

            Button btn1 = new Button("1");
            //btn1.Released+=delegate{text1.Buffer.Text="1";};
            btn1.Clicked += egyes;   
           
            Button btn2 = new Button("2");
             btn2.Clicked += kettes;
            Button btn3 = new Button("3");
             btn3.Clicked += harmas;
            Button btn4 = new Button("4");
             btn4.Clicked += negyes;
            Button btn5 = new Button("5");
             btn5.Clicked += otos;
            Button btn6 = new Button("6");
             btn6.Clicked += hatos;
            Button btn7 = new Button("7");
             btn7.Clicked += hetes;
            Button btn8 = new Button("8");
             btn8.Clicked += nyolcas;
            Button btn9 = new Button("9");
             btn9.Clicked += kilences;
            

            Button btn11 = new Button("+");
            btn11.Clicked += osszeadas;
            //btn1.Clicked += ; 
            
           
            Button btn12 = new Button("-");
            btn12.Clicked += kivonas;
            Button btn13 = new Button("*");
            btn13.Clicked += szorzas;
            Button btn14 = new Button("/");
            btn14.Clicked += osztas;
            Button btn15 = new Button("=");
            btn15.Clicked += egyenlo;
            Button torlesx = new Button("C");
            torlesx.Clicked += torles;


            myTable.Attach (btn1,0,1,5,6); //mettol meddig, azaz 0.tol 1. oszlopig, es 4-5. sorban.
            myTable.Attach(btn2,1,2,5,6);
            myTable.Attach(btn3,2,3,5,6);

            myTable.Attach(btn4,0,1,4,5);
            myTable.Attach (btn5,1,2,4,5); 
            myTable.Attach(btn6,2,3,4,5);

            myTable.Attach(btn7,0,1,3,4);
            myTable.Attach(btn8,1,2,3,4);
            myTable.Attach (btn9,2,3,3,4); 

            myTable.Attach(btn0,0,2,6,7);
            myTable.Attach(btn15,2,4,6,7);


            myTable.Attach(btn14,3,4,2,3);
            myTable.Attach(btn13,3,4,3,4);
            myTable.Attach (btn12,3,4,4,5); 
            myTable.Attach(btn11,3,4,5,6);

            myTable.Attach (exit,1,3,2,3);
            myTable.Attach(torlesx,0,1,2,3);
            myTable.Attach (text1,0,1,0,1);
            myTable.Attach (text2,1,2,0,1);
            myTable.Attach (text3,2,3,0,1);
            myTable.Attach (text4,0,1,1,2);
            myTable.Attach (text5,1,4,1,2);


            myWindow.ShowAll();
            Application.Run();

             void nulla (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"0";
            }

             void egyes (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"1";
            }

             void kettes (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"2";
            }

             void harmas (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"3";
            }

             void negyes (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"4";
            }


             void otos (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"5";
            }

             void hatos (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"6";
            }

             void hetes (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"7";
            }

             void nyolcas (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"8";
            }


             void kilences (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"9";
            }

             void osszeadas (object sender, System.EventArgs  e)
            {
                //text1.Text = text1.Text +"+";
                
                 a =  Convert.ToInt32(text1.Text) ;
                
                text3.Text = text1.Text;
                text2.Text="+";
                text1.Text ="";
               
                
          
            }

            void kivonas (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"-";
            }

            void egyenlo (object sender, System.EventArgs  e)
            {
                 b = Convert.ToInt32(text1.Text); 
                 c = a + b;
                text1.Text = b.ToString();
                text4.Text = "=";
                text5.Text =  c.ToString();
            }

            void szorzas (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"x";
            }

            void osztas (object sender, System.EventArgs  e)
            {
                text1.Text = text1.Text +"/";
            }

            void torles (object sender, System.EventArgs  e)
            {
                text1.Text = "";
                text2.Text = "";
                text3.Text = "";
                text4.Text = "";
                text5.Text = "";
            }


        }
    }
}
