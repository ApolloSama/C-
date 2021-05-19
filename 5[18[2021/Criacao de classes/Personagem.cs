namespace Criacao_de_classes
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public int hp;


        public int Atacar(){
            int dano = 5;

            return dano;
        }

        public int Defender(){
            int defesa = 3;

            return defesa;
        }
    }
}