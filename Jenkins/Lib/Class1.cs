﻿namespace Lib
{
    public class Saudacao
    {
        public static string Cumprimentar(String value, DateTime dt)
        {
            String result = "";
            
            if(dt.Hour<=12)
            {
                result = "Bom dia " + value;
            }
            else if(dt.Hour <= 20)
            {
                result = "Boa tarde " + value;
            }
            else
            {
                result = "Boa noite " + value;
            }

            return result;
        }

    }
}