using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRemoto
{
    internal class Program
    {
        bool power = false;
        int canal = 1;
        int volume = 99;

        static void Main(string[] args)
        {
            Program p = new Program(); //instancia de um objeto

            //tela menu
            while (true)
            {
                string opcoes = Console.ReadLine();
                if (opcoes.ToUpper() == "P")
                {
                    p.ligaDesliga();
                }
                if (opcoes.ToUpper().Equals("Q") || opcoes.ToUpper().Equals("A"))
                {
                    p.mudaCanal(opcoes);
                }
                if (opcoes.ToUpper().Equals("W") || opcoes.ToUpper().Equals("S"))
                {
                    p.mudaVolume(opcoes);
                }
            }
            Console.ReadKey();
        }
        public void ligaDesliga()
        {
            if (power) //se tv ligada
            {
                power = false; //desligar tv
                Console.WriteLine("Desligou a TV");
            }
            else
            {
                power = true; //ligar tv
                Console.WriteLine("Ligou a TV");
            }
                
        }

        public void mudaCanal(string opcoes)
        {
            if (power)
            {

                if (opcoes.ToUpper().Equals("Q"))//se seta pra cima
                    if (canal + 1 > 100)
                        canal = 1;
                    else
                        canal++; //subo um canal
                if (opcoes.ToUpper().Equals("A")) //se seta pra baixo
                    if (canal - 1 == 0)
                        canal = 100;
                    else
                        canal--; //desco um canal

                Console.WriteLine("Mudou canal: " + canal);
            }
            else
                Console.WriteLine("A TV esta Shutdown my friend");

        }

        public void mudaVolume(string opcoes)
        {
            if (power)
            {
                if (opcoes.ToUpper().Equals("W")) //se +
                    if (volume + 1 > 100)
                        volume = 100;
                    else
                        volume++;
                if (opcoes.ToUpper().Equals("S")) //se -
                {
                    if(volume > 0)
                        volume--;
                }
                    
                Console.WriteLine("Mudou Volume: " + volume);
            }
            else
                Console.WriteLine("A TV esta Shutdown my friend");
        }

    }
}
