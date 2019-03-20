using System;
using Gtk;

namespace asd
{
    class Program
    {
        public static void Main(string[] args)
        {
            Application.Init();

            Window myWindow = new Window("az en tablam");
            myWindow.Resize(500,500);
            

            VBox myBox = new VBox();
            myWindow.Add(myBox);
            
            Table myTable = new Table(6,4,true);  //eloszor az oszlopot adom meg, utana a sort.
            myBox.Add(myTable);

            Button exit = new Button("Kilepes");
            exit.Released+=delegate{Application.Quit();}; //kilep a programbol

            Button btn1 = new Button("1");
            Button btn2 = new Button("2");
            Button btn3 = new Button("3");
            Button btn4 = new Button("4");
            Button btn5 = new Button("5");
            Button btn6 = new Button("6");
            Button btn7 = new Button("7");
            Button btn8 = new Button("8");
            Button btn9 = new Button("9");
            Button btn0 = new Button("0");

            Button btn11 = new Button("+");
            Button btn12 = new Button("-");
            Button btn13 = new Button("*");
            Button btn14 = new Button("/");
            Button btn15 = new Button("=");


            myTable.Attach (btn1,0,1,4,5); //mettol meddig, azaz 0.tol 1. oszlopig, es 4-5. sorban.
            myTable.Attach(btn2,1,2,4,5);
            myTable.Attach(btn3,2,3,4,5);

            myTable.Attach(btn4,0,1,3,4);
            myTable.Attach (btn5,1,2,3,4); 
            myTable.Attach(btn6,2,3,3,4);

            myTable.Attach(btn7,0,1,2,3);
            myTable.Attach(btn8,1,2,2,3);
            myTable.Attach (btn9,2,3,2,3); 

            myTable.Attach(btn0,0,2,5,6);
            myTable.Attach(btn15,2,4,5,6);


            myTable.Attach(btn14,3,4,1,2);
            myTable.Attach(btn13,3,4,2,3);
            myTable.Attach (btn12,3,4,3,4); 
            myTable.Attach(btn11,3,4,4,5);

            myTable.Attach (exit,0,3,1,2);


            myWindow.ShowAll();
            Application.Run();



            
        }
    }
}
