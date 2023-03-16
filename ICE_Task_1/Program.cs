using System;

namespace Desktop
{
    class App
    {
    public static void Main(string[] args)
    {
        
        NumScripts();
        numQuestions();
        calSubtotal();
        numLecturers();
        
        Console.WriteLine("Scripts: "+autoNumScripts);
        Console.WriteLine("Questions: "+autoNumQuestions);
        Console.WriteLine("Total: "+autoSubtotal);
        Console.WriteLine("Lecturers: "+autoLectures);

        calTime();
        
    }

    //*********************************************
    public static int autoNumScripts {get;set;} //Created an automatic property
    public static void NumScripts() //gets the number of scripts to be marked from user
    {
        try{
        int num = 0;
        while(num == 0)
        {
        Console.WriteLine("Please input number of scripts to be marked");
        
         num = Convert.ToInt32(Console.ReadLine());
         autoNumScripts = num; //sets number to the automatic property
        }
        }catch(System.FormatException ){NumScripts();};//Catching a possible format exception then looping it back.
    }

    public static int autoNumQuestions {get;set;}
    public static void numQuestions()
    {
        Console.WriteLine("Please input the number of questions in the test");
        int quest = Convert.ToInt32(Console.ReadLine());
        if (quest > 1 && quest <10)
        {
            autoNumQuestions = quest;
        } else{
            Console.WriteLine("The questions must be more than 1 and less then 10");
            numQuestions();
        }

    }
    public static int autoSubtotal{get;set;}
    public static void calSubtotal()
    {
        int count = 1;
        int total = 0;  
        while(count < autoNumQuestions+1)
        {
            Console.WriteLine(format:"Please enter the subtotal of Question {0}",count);
        int sub = Convert.ToInt32(Console.ReadLine());
        if(sub > 0)
        {
            total += sub;
            autoSubtotal = total;
            count++;
        }else{
            Console.WriteLine("Subtotal is less than 1");
            calSubtotal();
        }
        }

    }
    public static int autoLectures {get;set;}
    public static void numLecturers()
    {
        int x = 0;
            
            
                while (x == 0)
                {
                    Console.WriteLine("Please enter the number of lectures marking the scripts");
                    int lect = Convert.ToInt32(Console.ReadLine());
                    if(lect > 0)
                    {
                        autoLectures = lect;
                        x++;
                    }
                    else
                     {
                        Console.WriteLine("The number of lecturers should be more than 0");
                
                        
                     }
                }
                
               
            
    }

    public static void calTime()
    {
        int s = autoNumScripts;
       int q = autoNumQuestions;
       int l = autoLectures;
       int u = autoSubtotal;
        double var = 0;
    

     

       if(l > s)
    {
        double divideScript = l / s; //Divides the number of lecturers by number of scripts
	double roundScript = Math.Round(divideScript); //Rounds the result of the calculation above
	
	Console.WriteLine("This many lectures: "+l+" Will need to mark this many scripts: "+roundScript);
     var = roundScript;
    } else
    {
        if(l == s)
        {
        Console.WriteLine("This many lectures: "+l+ " Will each have to mark this many scripts: "+ 1);
        var = 1;
        }else
        {

        if( s > l)
            {
	        double divideLect = s / l; //Divides the number of scripts by the number of lecturers
	        double roundLect = Math.Round(divideLect); //Rounds the result of the calculation above 
	        Console.WriteLine("This many lectures: "+l+ " Will each have to mark this many scripts: "+ roundLect);
            var = roundLect;

            }       
        }
    }
        //--------------------------------------------------------------------------------
        double totalQuestions = var * u;
        double seconds = totalQuestions * 2;
        TimeSpan t = TimeSpan.FromSeconds(seconds);


        if(t.Seconds > 30 & t.Seconds < 60)
        {
            
            if(t.Minutes == 60)
            {
                Console.WriteLine("Hours: "+ (t.Hours+1) + " Mins: " + 0);
            }else
            {
                Console.WriteLine("Hours: "+ t.Hours + " Mins: " + (t.Minutes+1));
            }
        }else
        {
                Console.WriteLine("Hours: "+ t.Hours + " Mins: " + t.Minutes);
        }
            
        

            
    
        
        
        

    }
    
    }
    
}