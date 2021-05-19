namespace Exercício_celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string dimensoes;
        public bool ligado = false;

        public bool Ligar(){
            ligado = true;
            return ligado;
        }

        public bool Desligar(){
            ligado = false;
            return ligado;
        }
    }
}