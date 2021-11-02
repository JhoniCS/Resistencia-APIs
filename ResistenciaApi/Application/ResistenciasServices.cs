using System;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;


namespace ResistenciaApi.Application
{
    public class ResistenciasServices
{
        public string Calcular(Resistencias res)
        {
           
            var color1 = res.Color1.ToLower();
            var color2 = res.Color2.ToLower();
            var color3 = res.Color3.ToLower();
            var color4 = res.Color4.ToLower();


            int val1;
            int val2;
            int val3;
            int val4;

            switch (color1)
            {
                case "Negro": val1 = 0; break;
                case "Marrón": val1 = 10; break;
                case "Rojo": val1 = 20; break;
                case "Naranja": val1 = 30; break;
                case "Amarillo": val1 = 40; break;
                case "Verde": val1 = 50; break;
                case "Azul": val1 = 60; break;
                case "Violeta": val1 = 70; break;
                case "Gris": val1 = 80; break;
                case "Blanco": val1 = 90; break;
                case null: return ("No se recibio el PRIMER color");
                default: return ("PRIMER color invalido");

            }

            switch (color2)
            {
                case "negro": val2 = 0; break;
                case "cafe": val2 = 1; break;
                case "rojo": val2 = 2; break;
                case "naranja": val2 = 3; break;
                case "amarillo": val2 = 4; break;
                case "verde": val2 = 5; break;
                case "azul": val2 = 6; break;
                case "violeta": val2 = 7; break;
                case "gris": val2 = 8; break;
                case "blanco": val2 = 9; break;
                case null: return ("No se recibio el SEGUNDO color");
                default: return ("SEGUNDO color invalido");

            }
             
             if(val1 ==0&&val2==0)
             {
                 return("Error, intenta cambiar el primer o segundo color");
             }

            switch (color3)
            {
                case "Negro": val3 = 1; break;
                case "Marrón": val3 = 10; break;
                case "Rojo": val3 = 100; break;
                case "Naranja": val3 = 1000; break;
                case "Amarillo": val3 = 10000; break;
                case "Verde": val3 = 100000; break;
                case "Azul": val3 = 1000000; break;
                case null: return ("No se recibio el TERCER color");
                default: return ("Color invalido");

            }

            switch (color4)
            {
                case "Dorado": val4 = 5; break;
                case "Plata": val4 = 10; break;
                case null: return ("No se recibio el primer color");
                default: return ("Solo se acepta  DORADO y PLATA");

            }

            double resistencia = (val1+val2)*val3;
            double tolerancia = (val4*resistencia)/100;
            double resistenciamax = resistencia + tolerancia;
            double resistenciamin = resistencia - tolerancia;

            return ($"La resistencia es: {resistencia} Ω. La tolerancia de : {tolerancia} %. el máximo es : {resistenciamax} Ω y el Minimo es: {resistenciamin} Ω ");
        }
    }
}
