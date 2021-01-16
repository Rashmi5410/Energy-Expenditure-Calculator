using System;
using static System.Console;

namespace Bme121
{
    static class Program
    {
        static void Main( )
        {
            //asks user for information 
            WriteLine( "What is your name?" );
            string name= ReadLine( );
            WriteLine( "How old are you?" );
            double age=double.Parse( ReadLine( ) );//parse 
            WriteLine( "What is your height?" );
            double height=double.Parse( ReadLine( ));
            WriteLine( "How much do you weigh?" );
            double weight=double.Parse( ReadLine( ));
            WriteLine( "Please specify your sex: ");
            string sex= ReadLine( );
            double restingEnergyExpenditure;//declares variable for overall equation 
            
            
            if (sex=="female")
            {
                restingEnergyExpenditure= (10* weight) + (6.25* height) - (5*age) - 161;
            }
            else//male
            {
                restingEnergyExpenditure= (10* weight) + (6.25* height) - (5*age) +5; 
            }
            
                WriteLine("Name:" + name);
                WriteLine("Age(years):" + age);
                WriteLine("Height(cm):" + height);
                WriteLine("Weight(kg):" + weight);
                WriteLine("Sex:" + sex);
                WriteLine("Resting Energy Expenditure(cal/day):" + restingEnergyExpenditure);
             
            
            
            
            
        }
    }
}
