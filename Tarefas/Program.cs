using System;

namespace Tarefas{

    class Lampada{
        bool ligada;
        public Lampada(bool _ligada){
            this.ligada = _ligada;
        }

        public void ligar(){
            this.ligada = true;
        }

        public void desligar(){
            this.ligada = false;
        }

        public void imprimir(){
            if(this.ligada){
                Console.WriteLine("A lampada está ligada");
            }else{
                Console.WriteLine("A lampada está desligada");
            }
        }


        static void Main(string[] args)
        {
            Lampada lamp = new Lampada(true);
            lamp.imprimir();
            lamp.desligar();
            lamp.imprimir();
        }
    }



}
