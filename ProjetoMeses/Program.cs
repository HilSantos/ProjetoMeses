﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMeses
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Mês, numero;
            string Semestre;

            Console.WriteLine("Informe um numero de 1 a 12: ");
            Mês = Convert.ToInt32(Console.ReadLine());

            switch (Mês)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;

                default:
                    Console.WriteLine("Valor Incorreto!");
                    break;
            }
            //verificar os numeros referentes aos meses e se é do 1º Semestre ou do 2º Semestre

            if (Mês <= 6)
            {
                Console.WriteLine("Primeiro Semestre");
                Mês = Convert.ToInt32(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Segundo Semestre");
                Mês = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
