using System;

class CurrencyExchange
{
    public double inr, usd, ero, BTS;
    public delegate void ConvertCurrencyfromINR(double inr);
    public delegate void ConvertCurrencyfromUSD(double usd);
    public delegate void ConvertCurrencyfromEURO(double ero);
    public delegate void ConvertCurrencyfromBTS(double BTS);

    static void SelectCurrency()
    {

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\n\n ********** WELCOME TO GLOBAL CURRENCY EXCHANGE ************");

        Console.WriteLine(@"
  ______________________________
 |                              |
 |   1. INR	    3. BITCOIN     	   
 |                              |
 |   2. USD	    4. EURO         
 |______________________________|   
");
    }

    /***************** METHODS FOR INR TO OTHER CURRENCY --SUMMARY START ***************************/

    // Method for INR ₹ to US $ 

    public void INR2Dollar(double inr)
    {
        Console.WriteLine("\n Entered INR in USD is {0} :", usd = inr / 73.19);
    }

    // Method for INR to EURO 

    public void INR2Euro(double inr)
    {
        Console.WriteLine("\n Entered INR in EURO is {0} :", ero = inr / 88.57);
    }


    // Method for INR to BITCOIN

    public void INR2Bitcoin(double inr)
    {
        Console.WriteLine("\n Entered INR in BITCOIN is {0} :", BTS = inr / 2681035.0);
    }


    /************ INR TO OTHER CURRENCY  SUMMARY CLOSE ********/


    /***************** METHODS FOR USD TO OTHER CURRENCY --SUMMARY START ***************************/

    // Method for  USD $ to INR ₹ 

    public void Dollar2INR(double usd)
    {
        Console.WriteLine("\n Entered DOLLAR in USD is {0} :", inr = usd * 73.19);
    }

    // Method for USD to Euro

    public void Dollar2Euro(double usd)
    {
        Console.WriteLine("\n Entered DOLLAR in EURO is {0} :", ero = usd * 0.83);
    }


    // Method for USD to BITCOIN

    public void Dollar2Bitcoin(double usd)
    {
        Console.WriteLine("\n Entered DOLLAR in BITCOIN is {0} :", BTS = usd * 0.000027);
    }


    /************ USD TO OTHER CURRENCY  SUMMARY CLOSE ********/
    /***************** METHODS FOR BITCOIN TO OTHER CURRENCY --SUMMARY START ***************************/

    // Method for BITCOIN ₹ to US $ 

    public void Bitcoin2USD(double BTS)
    {
        Console.WriteLine("\n Entered BTS in USD is {0} :", usd = BTS * 37308.10);
    }

    // Method for BITCOIN to EURO 

    public void Bitcoin2Euro(double BTS)
    {
        Console.WriteLine("\n Entered BTS in EURO is {0} :", ero = BTS * 30769.30);
    }


    // Method for BITCOIN to INR

    public void Bitcoin2Inr(double BTS)
    {
        Console.WriteLine("\n Entered BTS in INR is {0} :", inr = BTS * 2730260.85);
    }


    /************ BITCOIN TO OTHER CURRENCY  SUMMARY CLOSE ********/

    /***************** METHODS FOR EURO TO OTHER CURRENCY --SUMMARY START ***************************/
    // METHOD FOR EURO TO USD

    public void Euro2Usd(double ero)
    {
        Console.WriteLine("\n Entered BTS in USD is {0} :", usd = ero * 1.21);
    }

    // Method for EURO to INR

    public void Euro2Inr(double ero)
    {
        Console.WriteLine("\n Entered BTS in EURO is {0} :", inr = ero * 88.68);
    }

    // Method for EURO to BTS

    public void Euro2Bitcoin(double ero)
    {
        Console.WriteLine("\n Entered BTS in BITCOIN is {0} :", BTS = ero * 0.000033);
    }


    /************ EURO TO OTHER CURRENCY  SUMMARY CLOSE ********/

    static void Main()
    {

        CurrencyExchange CE = new CurrencyExchange();
        /*********** objects for INR starts here ***************/
        ConvertCurrencyfromINR ccfi = new ConvertCurrencyfromINR(CE.INR2Dollar);
        ConvertCurrencyfromINR ccfi2 = new ConvertCurrencyfromINR(CE.INR2Euro);
        ConvertCurrencyfromINR ccfi3 = new ConvertCurrencyfromINR(CE.INR2Bitcoin);

        /************** objects for INR Ends here***************/

        /*********** objects for USD starts here ***************/
        ConvertCurrencyfromUSD ccfu = new ConvertCurrencyfromUSD(CE.Dollar2INR);
        ConvertCurrencyfromUSD ccfu2 = new ConvertCurrencyfromUSD(CE.Dollar2Euro);
        ConvertCurrencyfromUSD ccfu3 = new ConvertCurrencyfromUSD(CE.Dollar2Bitcoin);

        /************** objects for USD Ends here***************/

        /*********** objects for BTS starts here ***************/
        ConvertCurrencyfromBTS ccfb = new ConvertCurrencyfromBTS(CE.Bitcoin2USD);
        ConvertCurrencyfromBTS ccfb2 = new ConvertCurrencyfromBTS(CE.Bitcoin2Euro);
        ConvertCurrencyfromBTS ccfb3 = new ConvertCurrencyfromBTS(CE.Bitcoin2Inr);

        /************** objects for BTS Ends here***************/

        /*********** objects for EURO starts here ***************/
        ConvertCurrencyfromEURO ccfe = new ConvertCurrencyfromEURO(CE.Euro2Usd);
        ConvertCurrencyfromEURO ccfe2 = new ConvertCurrencyfromEURO(CE.Euro2Inr);
        ConvertCurrencyfromEURO ccfe3 = new ConvertCurrencyfromEURO(CE.Euro2Bitcoin);

        /************** objects for EURO Ends here***************/


        SelectCurrency();
        Console.Write("Enter Currency no.1 to be exchanged : ");
        double curr1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Currency no.2 to be exchanged : ");
        double curr2 = Convert.ToDouble(Console.ReadLine());

        if (curr1 == 1 && curr2 == 2) // INR to USD
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfi(amt);
        }
        else
            if (curr1 == 1 && curr2 == 3) // Inr to Bitcoin
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfi3(amt);
        }
        else
                if (curr1 == 1 && curr2 == 4) // Inr to EURO
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfi2(amt);

        }
        else
            if (curr1 == 2 && curr2 == 1) // USD to INR
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfu(amt);
        }
        else
                if (curr1 == 2 && curr2 == 3) // USD to BITCOIN
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfu3(amt);
        }
        else
                    if (curr1 == 2 && curr2 == 4) // USD to EURO
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfu2(amt);
        }

        else
                        if (curr1 == 3 && curr2 == 1) // BTS to INR
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfb3(amt);
        }
        else
                            if (curr1 == 3 && curr2 == 2) // BTS to USD
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfb(amt);
        }
        else
                                if (curr1 == 3 && curr2 == 4) // BTS to EURO
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfb2(amt);
        }
        else
                                    if (curr1 == 4 && curr2 == 1) //  EURO to INR
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfe2(amt);
        }
        else
                                        if (curr1 == 4 && curr2 == 2) //  EURO to USD
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfe(amt);
        }
        else
                                            if (curr1 == 4 && curr2 == 3) //  EURO to BTS
        {
            Console.Write("Enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            ccfe3(amt);
        }
    }
}